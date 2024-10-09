using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;
using System.Net;


namespace APIW
{
    public partial class APIWEB : Form
    {

        private List<string> ipAdresses = new List<string>(); // Seznam IP adres
        private int otevreniCounter = 0; // Počítadlo pro sledování počtu otevření
        private int kolizeCounter = 0; // Počítadlo kolizí IP adres

        

        public APIWEB()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_Layout(object sender, LayoutEventArgs e)
        {
            // Nastavení DateTimePicker jako časového pickeru
            TimePicker1.Format = DateTimePickerFormat.Time;
            TimePicker1.ShowUpDown = true; // Zobrazí šipky pro volbu času
        }

        private void TimePicker2_Layout(object sender, LayoutEventArgs e)
        {
            // Nastavení DateTimePicker jako časového pickeru
            TimePicker2.Format = DateTimePickerFormat.Time;
            TimePicker2.ShowUpDown = true; // Zobrazí šipky pro volbu času
        }

        private void btUlozNastaveniProxy_Click(object sender, EventArgs e)
        {
            {
                // Uložit nastavení do Properties.Settings
                Properties.Settings.Default.ProxyHostName = tbProxyHostName.Text;
                Properties.Settings.Default.ProxyUserName = tbProxyUserName.Text;
                Properties.Settings.Default.ProxyPassword = tbProxyPassword.Text;
                Properties.Settings.Default.ProxyPort = tbProxyPort.Text;
                Properties.Settings.Default.ApiToken = tbApiToken.Text;

                // Uložit nastavení do trvalého úložiště
                Properties.Settings.Default.Save();

                // Zobrazit zprávu o úspěšném uložení
                MessageBox.Show("Nastavení proxy bylo úspěšně uloženo.", "Uloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void APIWEB_Load(object sender, EventArgs e)
        {
            // Načíst uložená nastavení a vyplnit textová pole
            tbProxyHostName.Text = Properties.Settings.Default.ProxyHostName;
            tbProxyUserName.Text = Properties.Settings.Default.ProxyUserName;
            tbProxyPassword.Text = Properties.Settings.Default.ProxyPassword;
            tbProxyPort.Text = Properties.Settings.Default.ProxyPort;
            tbApiToken.Text = Properties.Settings.Default.ApiToken;
        }

        private void btUloz_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
        private void SaveSettings()
        {
            // Otevřeme dialogové okno pro uložení souboru
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Definujeme filtry souborů (např. jen JSON soubory)
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Uložit nastavení";

                // Pokud uživatel zadá název v tbVlastniNazev, nastavíme ho jako defaultní název
                if (!string.IsNullOrWhiteSpace(tbVlastniNazev.Text))
                {
                    saveFileDialog.FileName = tbVlastniNazev.Text; // Nastavení defaultního názvu souboru
                }

                // Pokud uživatel vybere "OK" a zadá název souboru
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    // Zde uložíme data z TextBoxů do objektu
                    var settings = new
                    {
                        Odkaz = tbOdkaz.Text,
                        NahodnyCasOD = tbNahodnyCasOD.Text,
                        NahodnyCasDO = tbNahodnyCasDO.Text,
                        CelkovyPocetOtevreni = tbCelkovyPocetOtevreni.Text,
                        OteviraniPodleCasuOD = tbOteviraniPodleCasuOD.Text,
                        OteviraniPodleCasuDO = tbOteviraniPodleCasuDO.Text,
                        DateTimePicker1 = dateTimePicker1.Value,
                        TimePicker1 = TimePicker1.Value,
                        DateTimePicker2 = dateTimePicker2.Value,
                        TimePicker2 = TimePicker2.Value,
                        OtevriMaximalne = tbOtevriMaximalne.Text,
                        VlastniNazev = tbVlastniNazev.Text,
                        OteviraniPodlePoctu = chCOteviraniPodlePoctu.Checked,
                        OteviraniPodleCasu = chCOteviraniPodleCasu.Checked
                    };

                    // Serializujeme objekt do JSON
                    string json = JsonConvert.SerializeObject(settings, Formatting.Indented);

                    // Uložíme JSON do souboru
                    File.WriteAllText(fileName, json);

                    // Informujeme uživatele, že nastavení bylo uloženo
                    MessageBox.Show("Nastavení bylo úspěšně uloženo!", "Uloženo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btOtevri_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Otevřeme dialogové okno pro otevření souboru
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Definujeme filtry pro výběr souborů
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Načíst nastavení";

                // Pokud uživatel vybere soubor a klikne na OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    // Načteme obsah souboru do stringu
                    string json = File.ReadAllText(fileName);

                    // Deserializujeme JSON na objekt
                    var settings = JsonConvert.DeserializeObject<dynamic>(json);

                    // Nastavíme hodnoty v TextBoxech a dalších prvcích na základě načteného souboru
                    tbOdkaz.Text = settings.Odkaz;
                    tbNahodnyCasOD.Text = settings.NahodnyCasOD;
                    tbNahodnyCasDO.Text = settings.NahodnyCasDO;
                    tbCelkovyPocetOtevreni.Text = settings.CelkovyPocetOtevreni;
                    tbOteviraniPodleCasuOD.Text = settings.OteviraniPodleCasuOD;
                    tbOteviraniPodleCasuDO.Text = settings.OteviraniPodleCasuDO;
                    dateTimePicker1.Value = settings.DateTimePicker1;
                    TimePicker1.Value = settings.TimePicker1;
                    dateTimePicker2.Value = settings.DateTimePicker2;
                    TimePicker2.Value = settings.TimePicker2;
                    tbOtevriMaximalne.Text = settings.OtevriMaximalne;
                    tbVlastniNazev.Text = settings.VlastniNazev;

                    // Načteme hodnoty checkboxů
                    chCOteviraniPodlePoctu.Checked = settings.OteviraniPodlePoctu;
                    chCOteviraniPodleCasu.Checked = settings.OteviraniPodleCasu;

                    // Volitelně, podle stavu checkboxů aktivujeme/deaktivujeme další prvky
                    if (chCOteviraniPodlePoctu.Checked)
                    {
                        chCOteviraniPodlePoctu_CheckedChanged(null, null);
                    }
                    else if (chCOteviraniPodleCasu.Checked)
                    {
                        chCOteviraniPodleCasu_CheckedChanged(null, null);
                    }

                    // Informujeme uživatele, že nastavení bylo načteno
                    MessageBox.Show("Nastavení bylo úspěšně načteno!", "Načteno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void chCOteviraniPodlePoctu_CheckedChanged(object sender, EventArgs e)
        {
            if (chCOteviraniPodlePoctu.Checked)
            {
                // Povolí interakci pouze pro počty
                chCOteviraniPodleCasu.Checked = false;

                tbOteviraniPodleCasuOD.Enabled = false; // Zakáže interakci s TextBoxem
                tbOteviraniPodleCasuDO.Enabled = false;
                dateTimePicker1.Enabled = false;
                TimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                TimePicker2.Enabled = false;
                tbOtevriMaximalne.Enabled = false;

                tbNahodnyCasOD.Enabled = true; // Povolí interakci s TextBoxem
                tbNahodnyCasDO.Enabled = true;
                tbCelkovyPocetOtevreni.Enabled = true;
            }
        }

        private void chCOteviraniPodleCasu_CheckedChanged(object sender, EventArgs e)
        {
            if (chCOteviraniPodleCasu.Checked)
            {
                // Povolí interakci pouze pro čas
                chCOteviraniPodlePoctu.Checked = false;

                tbOteviraniPodleCasuOD.Enabled = true; // Povolí interakci s TextBoxem
                tbOteviraniPodleCasuDO.Enabled = true;
                dateTimePicker1.Enabled = true;
                TimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                TimePicker2.Enabled = true;
                tbOtevriMaximalne.Enabled = true;

                tbNahodnyCasOD.Enabled = false; // Zakáže interakci s TextBoxem
                tbNahodnyCasDO.Enabled = false;
                tbCelkovyPocetOtevreni.Enabled = false;
            }
        }

        private void tbVlastniNazev_TextChanged(object sender, EventArgs e)
        {
            // Původní název okna
            string originalTitle = "APIWEB";

            // Doplníme text z tbVlastniNazev k názvu okna
            this.Text = originalTitle + " - " + tbVlastniNazev.Text;
        }

        private async void btObnovZbyvData_Click(object sender, EventArgs e)
        {
            // Zde získáme zbývající data
            await GetRemainingDataAsync();
        }
        private async Task GetRemainingDataAsync()
        {
            try
            {
                // URL endpointu pro získání dat (vlož správnou URL dle IPRoyal API)
                string apiUrl = "https://resi-api.iproyal.com/v1";  // Fiktivní URL

                // Vytvoření HTTP klienta
                using (HttpClient client = new HttpClient())
                {
                    // Nastavení přihlašovacích údajů (API token nebo autentizace dle potřeby)
                    string apiToken = tbApiToken.Text;  // Získáme token z TextBoxu
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiToken}");

                    // Odeslání GET požadavku
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    // Načtení výsledků jako string
                    string responseData = await response.Content.ReadAsStringAsync();

                    // Zpracování odpovědi (zde musíme vědět, jaká data API vrací, předpokládejme JSON)
                    dynamic result = JsonConvert.DeserializeObject(responseData);

                    // Předpokládejme, že API vrátí klíč 'remaining_data' s počtem zbývajících dat
                    string remainingData = result.remaining_data;

                    // Zobrazení zbývajících dat v Labelu
                    lbZbyvajiciDataNaServeru.Text = $"Zbývající data: {remainingData} GB";
                }
            }
            catch (Exception ex)
            {
                // Zpracování chybového stavu
                MessageBox.Show($"Došlo k chybě při získávání dat: {ex.Message}");
            }
        }

        private async void btStart_Click(object sender, EventArgs e)
        {
            // Uložení aktuálních barev textu všech Label
            var labelColors = this.Controls.OfType<Label>()
                                           .ToDictionary(label => label, label => label.ForeColor);

            // Zablokování všech ovládacích prvků kromě btStop
            SetControlsEnabled(this, false);

            // Nastavení btStop na Enabled
            btStop.Enabled = true;

            if (chCOteviraniPodlePoctu.Checked)
            {
                // Spustit otevírání podle počtu
                await StartOteviraniPodlePoctu();
            }
            else if (chCOteviraniPodleCasu.Checked)
            {
                await StartOteviraniPodleCasu();
            }
            else
            {
                // Pokud ani jedno není zaškrtnuto, zobraz varování nebo proveď nějakou akci
                MessageBox.Show("Prosím vyberte, zda chcete otevírat podle počtu nebo podle času.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Obnovení barev textu pro všechny Label
            foreach (var labelColor in labelColors)
            {
                labelColor.Key.ForeColor = labelColor.Value; // Obnovení barvy
            }
        }
        // Rekurzivní metoda pro zablokování/odblokování ovládacích prvků
        private void SetControlsEnabled(Control parent, bool enabled)
        {
            foreach (Control control in parent.Controls)
            {
                // Pokud je ovládací prvek btStop, nastavíme Enabled na true
                if (control == btStop)
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = enabled;
                }

                // Pokud je ovládací prvek kontejner (např. GroupBox, Panel), procházejte jeho ovládací prvky
                if (control.HasChildren)
                {
                    SetControlsEnabled(control, enabled);
                }
            }
        }

        private async Task StartOteviraniPodlePoctu()
        {
            int celkovyPocetOtevreni;
            if (int.TryParse(tbCelkovyPocetOtevreni.Text, out celkovyPocetOtevreni))
            {
                // Nastavení se bude opakovat, dokud nedosáhne celkového počtu otevření
                while (otevreniCounter < celkovyPocetOtevreni)
                {
                    // Vygenerujeme náhodný čas v intervalu od NahodnyCasOD do NahodnyCasDO
                    Random rand = new Random();
                    int interval = rand.Next(int.Parse(tbNahodnyCasOD.Text), int.Parse(tbNahodnyCasDO.Text));

                    // Spustíme odpočet a zobrazíme zbývající čas do dalšího otevření
                    for (int i = interval; i >= 0; i--)
                    {
                        lbCekaNaStart.Text = $"Čekám {i} sekund před dalším otevřením...";

                        await Task.Delay(1000); // Čekáme jednu sekundu
                    }

                    // Otevření odkazu přes IPRoyal proxy
                    await OtevriOdkaz();

                    otevreniCounter++;
                }

                MessageBox.Show("Otevírání odkazů dokončeno.");
            }
            else
            {
                MessageBox.Show("Zadejte platný počet otevření.");
            }
        }


        private async Task OtevriOdkaz()
        {
            try
            {
                // Získání nové IP adresy
                await GetNewIpAddressAsync(tbApiToken.Text, tbProxyUserName.Text); // Přidáno: Požadavek na novou IP adresu

                // Vytvoření HTTP požadavku přes proxy
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(tbOdkaz.Text);
                WebProxy proxy = new WebProxy($"http://{tbProxyHostName.Text}:{tbProxyPort.Text}");
                proxy.Credentials = new NetworkCredential(tbProxyUserName.Text, tbProxyPassword.Text);
                request.Proxy = proxy;

                // Přidání hlavičky pro maskování jako skutečný uživatel
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36";

                // Přidání Authorization hlavičky s API tokenem
                request.Headers.Add("Authorization", $"Bearer {tbApiToken.Text}");

                // Odeslání požadavku a získání odpovědi
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

                // Získání IP adresy přidělené proxy
                string ipAdresa = await ZiskejIpAdresuZProxy(proxy);

                if (!string.IsNullOrEmpty(ipAdresa))
                {
                    lipAdresa.Text = $"{ipAdresa}";
                }
                else
                {
                    lipAdresa.Text = "IP adresa se nepodařila zjistit.";
                }

                // Kontrola, zda IP adresa již nebyla použita
                if (ipAdresses.Contains(ipAdresa))
                {
                    // Zvýšení počítadla kolizí
                    kolizeCounter++;
                    lPocetStejnychIp.Text = $"{kolizeCounter}";
                }
                else
                {
                    ipAdresses.Add(ipAdresa); // Přidáme IP do seznamu
                }

                // Kontrola funkce proxy
                await ZkontrolujFunkciProxy(ipAdresa);

                // Zavření odpovědi
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při otevírání odkazu: {ex.Message}");
            }
        }
        // Funkce pro získání IP adresy přes proxy
        private async Task<string> ZiskejIpAdresuZProxy(WebProxy proxy)
        {
            try
            {
                // Vytvoření požadavku na externí službu, která vrátí veřejnou IP adresu
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.ipify.org");
                request.Proxy = proxy; // Nastavíme proxy pro požadavek
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36";
                request.Headers.Add("Authorization", $"Bearer {tbApiToken.Text}"); // Přidání hlavičky s API tokenem
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    return await reader.ReadToEndAsync(); // Získáme IP adresu jako string
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při získávání IP adresy přes proxy: {ex.Message}");
                return null;
            }
        }

        private async Task ZkontrolujFunkciProxy(string ipAdresaZProxy)
        {
            try
            {
                // Získání vlastní IP adresy bez použití proxy
                HttpWebRequest realIpRequest = (HttpWebRequest)WebRequest.Create("https://api.ipify.org");
                realIpRequest.Method = "GET";

                string realIp;
                using (HttpWebResponse realIpResponse = (HttpWebResponse)await realIpRequest.GetResponseAsync())
                using (StreamReader reader = new StreamReader(realIpResponse.GetResponseStream()))
                {
                    realIp = await reader.ReadToEndAsync();
                }

                // Porovnání IP adres
                if (realIp == ipAdresaZProxy)
                {
                    lFunkceProxy.Text = "nefunkční"; // Proxy nefunguje
                }
                else
                {
                    lFunkceProxy.Text = "funkční"; // Proxy funguje
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při kontrole funkčnosti proxy: {ex.Message}");
            }
        }
        // Nová metoda pro získání nové IP adresy
        private async Task<string> GetNewIpAddressAsync(string apiToken, string username)
        {
            try
            {
                // URL endpointu pro získání nové IP adresy (přizpůsobte podle dokumentace IPRoyal)
                string url = "https://resi-api.iproyal.com/v1/residential-users/get-new-ip";

                // Vytvoření HTTP požadavku
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST"; // Změňte podle potřeby (GET nebo POST)
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", $"Bearer {apiToken}");

                // Vytvoření JSON payloadu, pokud je potřeba
                var requestBody = new
                {
                    username = username
                };
                string json = JsonConvert.SerializeObject(requestBody);

                // Odeslání těla požadavku
                using (var streamWriter = new StreamWriter(await request.GetRequestStreamAsync()))
                {
                    await streamWriter.WriteAsync(json);
                }

                // Získání odpovědi
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string responseText = await reader.ReadToEndAsync();

                    // Zde byste měli analyzovat responseText a získat novou IP adresu
                    // Například pokud API vrací JSON s IP adresou:
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseText);
                    return jsonResponse.new_ip; // Přizpůsobte podle struktury odpovědi
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba při získávání nové IP adresy: {ex.Message}");
                return null;
            }
        }


        // Metoda pro otevírání podle času
        private async Task StartOteviraniPodleCasu()
        {
            // Kombinujeme datum a čas
            DateTime startTime = dateTimePicker1.Value.Date + TimePicker1.Value.TimeOfDay; // Pouze datum z DateTimePicker a čas z TimePicker
            DateTime endTime = dateTimePicker2.Value.Date + TimePicker2.Value.TimeOfDay; // Pouze datum z DateTimePicker a čas z TimePicker

            // Kontrola, zda je startTime pozdější než endTime
            if (startTime > endTime)
            {
                MessageBox.Show("Chyba: Datum a čas zahájení nemohou být pozdější než datum a čas ukončení!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Ukončíme metodu, pokud je chyba
            }

            // Kontrola, zda je startTime již v minulosti
            if (startTime <= DateTime.Now)
            {
                // Pokud už čas přišel, zahájení otevírání
                await OteviraniOdkazuDoEndTime(endTime);
            }
            else
            {
                // Pokud čas ještě nenastal, odpočet do startu
                while (startTime > DateTime.Now)
                {
                    TimeSpan remainingTime = startTime - DateTime.Now;
                    
                    await Task.Delay(1000); // Zpoždění jedné sekundy
                }

                // Když čas nastane, začni otevírat odkazy
                await OteviraniOdkazuDoEndTime(endTime);
            }
        }

        private async Task OteviraniOdkazuDoEndTime(DateTime endTime)
        {
            int maximalneOtevreni;
            if (int.TryParse(tbOtevriMaximalne.Text, out maximalneOtevreni))
            {
                Random random = new Random();
                int pocetOtevreni = 0;

                while (DateTime.Now < endTime && pocetOtevreni < maximalneOtevreni)
                {
                    // Vygenerovat náhodný čas
                    int nahodnyInterval = random.Next(int.Parse(tbOteviraniPodleCasuOD.Text), int.Parse(tbOteviraniPodleCasuDO.Text));

                    // Odpočet do dalšího otevření
                    for (int j = nahodnyInterval; j >= 0; j--)
                    {
                        
                        await Task.Delay(1000); // Zpoždění jedné sekundy
                    }

                    // Otevři odkaz zde (přidej logiku pro otevření)
                    lPocetOtevrenych.Text = $"Počet otevření: {pocetOtevreni + 1}";

                    // Zobrazí IP adresu (přidej logiku pro získání IP adresy)
                    lipAdresa.Text = "Zde bude IP adresa";

                    pocetOtevreni++;
                }
            }
            else
            {
                MessageBox.Show("Chyba: Zadejte platný maximální počet otevření!");
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            // Nastavení btStop na false
            btStop.Enabled = false;

            // Odblokování ostatních ovládacích prvků
            SetControlsEnabled(this, true);
        }

        
    }
}
