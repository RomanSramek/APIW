namespace APIW
{
    partial class APIWEB
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APIWEB));
            this.btStart = new System.Windows.Forms.Button();
            this.tbProxyHostName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btUlozNastaveniProxy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProxyPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProxyUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProxyPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApiToken = new System.Windows.Forms.TextBox();
            this.tbOdkaz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNahodnyCasOD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNahodnyCasDO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCelkovyPocetOtevreni = new System.Windows.Forms.TextBox();
            this.chCOteviraniPodlePoctu = new System.Windows.Forms.CheckBox();
            this.chCOteviraniPodleCasu = new System.Windows.Forms.CheckBox();
            this.tbOteviraniPodleCasuDO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbOteviraniPodleCasuOD = new System.Windows.Forms.TextBox();
            this.btStop = new System.Windows.Forms.Button();
            this.TimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.tbOtevriMaximalne = new System.Windows.Forms.TextBox();
            this.lAktualniStav = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbCekaNaStart = new System.Windows.Forms.Label();
            this.lipAdresa = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lPocetStejnychIp = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btUloz = new System.Windows.Forms.Button();
            this.tbVlastniNazev = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lPocetOtevrenych = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lCelkovyObjDat = new System.Windows.Forms.Label();
            this.btOtevri = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.lFunkceProxy = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbZbyvajiciDataNaServeru = new System.Windows.Forms.Label();
            this.btObnovZbyvData = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.lbTestObjemuDat = new System.Windows.Forms.Label();
            this.btTestObjDat = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Lime;
            this.btStart.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btStart.Location = new System.Drawing.Point(636, 290);
            this.btStart.Margin = new System.Windows.Forms.Padding(5);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(143, 51);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbProxyHostName
            // 
            this.tbProxyHostName.Location = new System.Drawing.Point(112, 31);
            this.tbProxyHostName.Margin = new System.Windows.Forms.Padding(5);
            this.tbProxyHostName.Name = "tbProxyHostName";
            this.tbProxyHostName.Size = new System.Drawing.Size(102, 22);
            this.tbProxyHostName.TabIndex = 2;
            this.tbProxyHostName.Text = "geo.iproyal.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proxy hostname:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.Gainsboro;
            this.progressBar1.Location = new System.Drawing.Point(16, 437);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1451, 35);
            this.progressBar1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btUlozNastaveniProxy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbProxyPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbProxyUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbProxyPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbApiToken);
            this.groupBox1.Controls.Add(this.tbProxyHostName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1451, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nastavení připojení k proxy serveru";
            // 
            // btUlozNastaveniProxy
            // 
            this.btUlozNastaveniProxy.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btUlozNastaveniProxy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btUlozNastaveniProxy.Location = new System.Drawing.Point(1234, 57);
            this.btUlozNastaveniProxy.Margin = new System.Windows.Forms.Padding(5);
            this.btUlozNastaveniProxy.Name = "btUlozNastaveniProxy";
            this.btUlozNastaveniProxy.Size = new System.Drawing.Size(184, 22);
            this.btUlozNastaveniProxy.TabIndex = 61;
            this.btUlozNastaveniProxy.Text = "Ulož nastavení proxy serveru";
            this.btUlozNastaveniProxy.UseVisualStyleBackColor = true;
            this.btUlozNastaveniProxy.Click += new System.EventHandler(this.btUlozNastaveniProxy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nezapomeň při změně tvé reálné Ip adresy na White list IpRoyal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(915, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "API Token:";
            // 
            // tbProxyPassword
            // 
            this.tbProxyPassword.Location = new System.Drawing.Point(570, 31);
            this.tbProxyPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tbProxyPassword.Name = "tbProxyPassword";
            this.tbProxyPassword.Size = new System.Drawing.Size(193, 22);
            this.tbProxyPassword.TabIndex = 6;
            this.tbProxyPassword.Text = "4C9qRZtlzUTCU451_country-cz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(465, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Proxy password:";
            // 
            // tbProxyUserName
            // 
            this.tbProxyUserName.Location = new System.Drawing.Point(329, 31);
            this.tbProxyUserName.Margin = new System.Windows.Forms.Padding(5);
            this.tbProxyUserName.Name = "tbProxyUserName";
            this.tbProxyUserName.Size = new System.Drawing.Size(126, 22);
            this.tbProxyUserName.TabIndex = 4;
            this.tbProxyUserName.Text = "spidwICpDjOkIFdA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(224, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proxy username:";
            // 
            // tbProxyPort
            // 
            this.tbProxyPort.Location = new System.Drawing.Point(849, 31);
            this.tbProxyPort.Margin = new System.Windows.Forms.Padding(5);
            this.tbProxyPort.Name = "tbProxyPort";
            this.tbProxyPort.Size = new System.Drawing.Size(45, 22);
            this.tbProxyPort.TabIndex = 8;
            this.tbProxyPort.Text = "12321";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(773, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Proxy port:";
            // 
            // tbApiToken
            // 
            this.tbApiToken.Location = new System.Drawing.Point(989, 31);
            this.tbApiToken.Margin = new System.Windows.Forms.Padding(5);
            this.tbApiToken.Name = "tbApiToken";
            this.tbApiToken.Size = new System.Drawing.Size(429, 22);
            this.tbApiToken.TabIndex = 10;
            this.tbApiToken.Text = "5ecb3474eee82f55c7b2ba626686369d8e64da21fc378298f68446f78326";
            // 
            // tbOdkaz
            // 
            this.tbOdkaz.Location = new System.Drawing.Point(79, 121);
            this.tbOdkaz.Margin = new System.Windows.Forms.Padding(5);
            this.tbOdkaz.Name = "tbOdkaz";
            this.tbOdkaz.Size = new System.Drawing.Size(1355, 25);
            this.tbOdkaz.TabIndex = 12;
            this.tbOdkaz.Text = "https://zlinsky.denik.cz/tagy/frantisek-kugler-31197.html?strana=3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(26, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Odkaz:";
            // 
            // tbNahodnyCasOD
            // 
            this.tbNahodnyCasOD.Location = new System.Drawing.Point(243, 176);
            this.tbNahodnyCasOD.Margin = new System.Windows.Forms.Padding(5);
            this.tbNahodnyCasOD.Name = "tbNahodnyCasOD";
            this.tbNahodnyCasOD.Size = new System.Drawing.Size(41, 25);
            this.tbNahodnyCasOD.TabIndex = 13;
            this.tbNahodnyCasOD.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(172, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Náhodný čas otevírání odkazu v sek:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(206, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "OD-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(294, 182);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "DO-";
            // 
            // tbNahodnyCasDO
            // 
            this.tbNahodnyCasDO.Location = new System.Drawing.Point(331, 176);
            this.tbNahodnyCasDO.Margin = new System.Windows.Forms.Padding(5);
            this.tbNahodnyCasDO.Name = "tbNahodnyCasDO";
            this.tbNahodnyCasDO.Size = new System.Drawing.Size(41, 25);
            this.tbNahodnyCasDO.TabIndex = 17;
            this.tbNahodnyCasDO.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(391, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Celkový počet otevření:";
            // 
            // tbCelkovyPocetOtevreni
            // 
            this.tbCelkovyPocetOtevreni.Location = new System.Drawing.Point(533, 176);
            this.tbCelkovyPocetOtevreni.Margin = new System.Windows.Forms.Padding(5);
            this.tbCelkovyPocetOtevreni.Name = "tbCelkovyPocetOtevreni";
            this.tbCelkovyPocetOtevreni.Size = new System.Drawing.Size(47, 25);
            this.tbCelkovyPocetOtevreni.TabIndex = 19;
            this.tbCelkovyPocetOtevreni.Text = "2";
            // 
            // chCOteviraniPodlePoctu
            // 
            this.chCOteviraniPodlePoctu.AutoSize = true;
            this.chCOteviraniPodlePoctu.Checked = true;
            this.chCOteviraniPodlePoctu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chCOteviraniPodlePoctu.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chCOteviraniPodlePoctu.Location = new System.Drawing.Point(29, 181);
            this.chCOteviraniPodlePoctu.Name = "chCOteviraniPodlePoctu";
            this.chCOteviraniPodlePoctu.Size = new System.Drawing.Size(127, 20);
            this.chCOteviraniPodlePoctu.TabIndex = 20;
            this.chCOteviraniPodlePoctu.Text = "Otevírání podle počtu";
            this.chCOteviraniPodlePoctu.UseVisualStyleBackColor = true;
            this.chCOteviraniPodlePoctu.CheckedChanged += new System.EventHandler(this.chCOteviraniPodlePoctu_CheckedChanged);
            // 
            // chCOteviraniPodleCasu
            // 
            this.chCOteviraniPodleCasu.AutoSize = true;
            this.chCOteviraniPodleCasu.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chCOteviraniPodleCasu.Location = new System.Drawing.Point(29, 219);
            this.chCOteviraniPodleCasu.Name = "chCOteviraniPodleCasu";
            this.chCOteviraniPodleCasu.Size = new System.Drawing.Size(156, 20);
            this.chCOteviraniPodleCasu.TabIndex = 21;
            this.chCOteviraniPodleCasu.Text = "Otevírání dle času a datumu";
            this.chCOteviraniPodleCasu.UseVisualStyleBackColor = true;
            this.chCOteviraniPodleCasu.CheckedChanged += new System.EventHandler(this.chCOteviraniPodleCasu_CheckedChanged);
            // 
            // tbOteviraniPodleCasuDO
            // 
            this.tbOteviraniPodleCasuDO.Enabled = false;
            this.tbOteviraniPodleCasuDO.Location = new System.Drawing.Point(331, 217);
            this.tbOteviraniPodleCasuDO.Margin = new System.Windows.Forms.Padding(5);
            this.tbOteviraniPodleCasuDO.Name = "tbOteviraniPodleCasuDO";
            this.tbOteviraniPodleCasuDO.Size = new System.Drawing.Size(41, 25);
            this.tbOteviraniPodleCasuDO.TabIndex = 26;
            this.tbOteviraniPodleCasuDO.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(294, 223);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "DO-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(206, 223);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "OD-";
            // 
            // tbOteviraniPodleCasuOD
            // 
            this.tbOteviraniPodleCasuOD.Enabled = false;
            this.tbOteviraniPodleCasuOD.Location = new System.Drawing.Point(243, 217);
            this.tbOteviraniPodleCasuOD.Margin = new System.Windows.Forms.Padding(5);
            this.tbOteviraniPodleCasuOD.Name = "tbOteviraniPodleCasuOD";
            this.tbOteviraniPodleCasuOD.Size = new System.Drawing.Size(41, 25);
            this.tbOteviraniPodleCasuOD.TabIndex = 22;
            this.tbOteviraniPodleCasuOD.Text = "2";
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.Red;
            this.btStop.Enabled = false;
            this.btStop.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 14.25F, System.Drawing.FontStyle.Bold);
            this.btStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btStop.Location = new System.Drawing.Point(636, 359);
            this.btStop.Margin = new System.Windows.Forms.Padding(5);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(143, 54);
            this.btStop.TabIndex = 27;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // TimePicker1
            // 
            this.TimePicker1.AllowDrop = true;
            this.TimePicker1.Enabled = false;
            this.TimePicker1.Location = new System.Drawing.Point(744, 214);
            this.TimePicker1.Name = "TimePicker1";
            this.TimePicker1.Size = new System.Drawing.Size(85, 25);
            this.TimePicker1.TabIndex = 28;
            this.TimePicker1.Layout += new System.Windows.Forms.LayoutEventHandler(this.dateTimePicker1_Layout);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(533, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(477, 223);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Začit v:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(837, 220);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Skončit v:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(906, 213);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // TimePicker2
            // 
            this.TimePicker2.AllowDrop = true;
            this.TimePicker2.Enabled = false;
            this.TimePicker2.Location = new System.Drawing.Point(1112, 213);
            this.TimePicker2.Name = "TimePicker2";
            this.TimePicker2.Size = new System.Drawing.Size(85, 25);
            this.TimePicker2.TabIndex = 33;
            this.TimePicker2.Layout += new System.Windows.Forms.LayoutEventHandler(this.TimePicker2_Layout);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(1205, 217);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "Otevřít maximálně:";
            // 
            // tbOtevriMaximalne
            // 
            this.tbOtevriMaximalne.Enabled = false;
            this.tbOtevriMaximalne.Location = new System.Drawing.Point(1319, 211);
            this.tbOtevriMaximalne.Margin = new System.Windows.Forms.Padding(5);
            this.tbOtevriMaximalne.Name = "tbOtevriMaximalne";
            this.tbOtevriMaximalne.Size = new System.Drawing.Size(53, 25);
            this.tbOtevriMaximalne.TabIndex = 35;
            this.tbOtevriMaximalne.Text = "3";
            // 
            // lAktualniStav
            // 
            this.lAktualniStav.AutoSize = true;
            this.lAktualniStav.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lAktualniStav.Location = new System.Drawing.Point(26, 311);
            this.lAktualniStav.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lAktualniStav.Name = "lAktualniStav";
            this.lAktualniStav.Size = new System.Drawing.Size(79, 16);
            this.lAktualniStav.TabIndex = 36;
            this.lAktualniStav.Text = "Aktuální stav:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(26, 327);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "Poslední požitá ip adresa:";
            // 
            // lbCekaNaStart
            // 
            this.lbCekaNaStart.AutoSize = true;
            this.lbCekaNaStart.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCekaNaStart.Location = new System.Drawing.Point(230, 311);
            this.lbCekaNaStart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCekaNaStart.Name = "lbCekaNaStart";
            this.lbCekaNaStart.Size = new System.Drawing.Size(76, 16);
            this.lbCekaNaStart.TabIndex = 38;
            this.lbCekaNaStart.Text = "Čeká na start";
            // 
            // lipAdresa
            // 
            this.lipAdresa.AutoSize = true;
            this.lipAdresa.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lipAdresa.Location = new System.Drawing.Point(230, 327);
            this.lipAdresa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lipAdresa.Name = "lipAdresa";
            this.lipAdresa.Size = new System.Drawing.Size(88, 16);
            this.lipAdresa.TabIndex = 39;
            this.lipAdresa.Text = "188.246.111.233";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(26, 343);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 16);
            this.label20.TabIndex = 40;
            this.label20.Text = "Počet stejných Ip adres:";
            // 
            // lPocetStejnychIp
            // 
            this.lPocetStejnychIp.AutoSize = true;
            this.lPocetStejnychIp.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPocetStejnychIp.Location = new System.Drawing.Point(230, 343);
            this.lPocetStejnychIp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lPocetStejnychIp.Name = "lPocetStejnychIp";
            this.lPocetStejnychIp.Size = new System.Drawing.Size(13, 16);
            this.lPocetStejnychIp.TabIndex = 41;
            this.lPocetStejnychIp.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.Location = new System.Drawing.Point(26, 359);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(133, 16);
            this.label22.TabIndex = 42;
            this.label22.Text = "Aktuální počet otevření:";
            // 
            // btUloz
            // 
            this.btUloz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btUloz.Location = new System.Drawing.Point(1089, 381);
            this.btUloz.Margin = new System.Windows.Forms.Padding(5);
            this.btUloz.Name = "btUloz";
            this.btUloz.Size = new System.Drawing.Size(184, 35);
            this.btUloz.TabIndex = 43;
            this.btUloz.Text = "Ulož nastavení";
            this.btUloz.UseVisualStyleBackColor = true;
            this.btUloz.Click += new System.EventHandler(this.btUloz_Click);
            // 
            // tbVlastniNazev
            // 
            this.tbVlastniNazev.Location = new System.Drawing.Point(200, 265);
            this.tbVlastniNazev.Margin = new System.Windows.Forms.Padding(5);
            this.tbVlastniNazev.Name = "tbVlastniNazev";
            this.tbVlastniNazev.Size = new System.Drawing.Size(247, 25);
            this.tbVlastniNazev.TabIndex = 44;
            this.tbVlastniNazev.Text = "ZlinskýDeníkFKstr3";
            this.tbVlastniNazev.TextChanged += new System.EventHandler(this.tbVlastniNazev_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.Location = new System.Drawing.Point(25, 271);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(162, 16);
            this.label23.TabIndex = 45;
            this.label23.Text = "Vlastní název pro rozpoznání:";
            // 
            // lPocetOtevrenych
            // 
            this.lPocetOtevrenych.AutoSize = true;
            this.lPocetOtevrenych.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPocetOtevrenych.Location = new System.Drawing.Point(230, 359);
            this.lPocetOtevrenych.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lPocetOtevrenych.Name = "lPocetOtevrenych";
            this.lPocetOtevrenych.Size = new System.Drawing.Size(13, 16);
            this.lPocetOtevrenych.TabIndex = 46;
            this.lPocetOtevrenych.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label27.Location = new System.Drawing.Point(26, 391);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(108, 16);
            this.label27.TabIndex = 49;
            this.label27.Text = "Celkový objem dat:";
            // 
            // lCelkovyObjDat
            // 
            this.lCelkovyObjDat.AutoSize = true;
            this.lCelkovyObjDat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCelkovyObjDat.Location = new System.Drawing.Point(230, 391);
            this.lCelkovyObjDat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lCelkovyObjDat.Name = "lCelkovyObjDat";
            this.lCelkovyObjDat.Size = new System.Drawing.Size(13, 16);
            this.lCelkovyObjDat.TabIndex = 50;
            this.lCelkovyObjDat.Text = "0";
            // 
            // btOtevri
            // 
            this.btOtevri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btOtevri.Location = new System.Drawing.Point(1283, 381);
            this.btOtevri.Margin = new System.Windows.Forms.Padding(5);
            this.btOtevri.Name = "btOtevri";
            this.btOtevri.Size = new System.Drawing.Size(184, 35);
            this.btOtevri.TabIndex = 57;
            this.btOtevri.Text = "Otevři nastavení";
            this.btOtevri.UseVisualStyleBackColor = true;
            this.btOtevri.Click += new System.EventHandler(this.btOtevri_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label34.Location = new System.Drawing.Point(26, 407);
            this.label34.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(83, 16);
            this.label34.TabIndex = 59;
            this.label34.Text = "Funkce proxy:";
            // 
            // lFunkceProxy
            // 
            this.lFunkceProxy.AutoSize = true;
            this.lFunkceProxy.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFunkceProxy.Location = new System.Drawing.Point(230, 407);
            this.lFunkceProxy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lFunkceProxy.Name = "lFunkceProxy";
            this.lFunkceProxy.Size = new System.Drawing.Size(55, 16);
            this.lFunkceProxy.TabIndex = 60;
            this.lFunkceProxy.Text = "neaktivní";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label29.Location = new System.Drawing.Point(1118, 327);
            this.label29.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(142, 16);
            this.label29.TabIndex = 51;
            this.label29.Text = "Zbývající data na serveru:";
            // 
            // lbZbyvajiciDataNaServeru
            // 
            this.lbZbyvajiciDataNaServeru.AutoSize = true;
            this.lbZbyvajiciDataNaServeru.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZbyvajiciDataNaServeru.Location = new System.Drawing.Point(1267, 327);
            this.lbZbyvajiciDataNaServeru.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbZbyvajiciDataNaServeru.Name = "lbZbyvajiciDataNaServeru";
            this.lbZbyvajiciDataNaServeru.Size = new System.Drawing.Size(13, 16);
            this.lbZbyvajiciDataNaServeru.TabIndex = 52;
            this.lbZbyvajiciDataNaServeru.Text = "0";
            // 
            // btObnovZbyvData
            // 
            this.btObnovZbyvData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btObnovZbyvData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btObnovZbyvData.Location = new System.Drawing.Point(1030, 326);
            this.btObnovZbyvData.Margin = new System.Windows.Forms.Padding(5);
            this.btObnovZbyvData.Name = "btObnovZbyvData";
            this.btObnovZbyvData.Size = new System.Drawing.Size(78, 20);
            this.btObnovZbyvData.TabIndex = 53;
            this.btObnovZbyvData.Text = "Obnov";
            this.btObnovZbyvData.UseVisualStyleBackColor = true;
            this.btObnovZbyvData.Click += new System.EventHandler(this.btObnovZbyvData_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label32.Location = new System.Drawing.Point(1110, 265);
            this.label32.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(192, 16);
            this.label32.TabIndex = 54;
            this.label32.Text = "Test objemu dat jednoho připojení:";
            // 
            // lbTestObjemuDat
            // 
            this.lbTestObjemuDat.AutoSize = true;
            this.lbTestObjemuDat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTestObjemuDat.Location = new System.Drawing.Point(1312, 265);
            this.lbTestObjemuDat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTestObjemuDat.Name = "lbTestObjemuDat";
            this.lbTestObjemuDat.Size = new System.Drawing.Size(13, 16);
            this.lbTestObjemuDat.TabIndex = 55;
            this.lbTestObjemuDat.Text = "0";
            // 
            // btTestObjDat
            // 
            this.btTestObjDat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btTestObjDat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btTestObjDat.Location = new System.Drawing.Point(1028, 264);
            this.btTestObjDat.Margin = new System.Windows.Forms.Padding(5);
            this.btTestObjDat.Name = "btTestObjDat";
            this.btTestObjDat.Size = new System.Drawing.Size(78, 20);
            this.btTestObjDat.TabIndex = 56;
            this.btTestObjDat.Text = "Test";
            this.btTestObjDat.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label33.Location = new System.Drawing.Point(1110, 281);
            this.label33.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(339, 16);
            this.label33.TabIndex = 58;
            this.label33.Text = "Pro správný test musíš vyplnit odkaz který budeš chtít otevírat!";
            // 
            // APIWEB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1493, 489);
            this.Controls.Add(this.lFunkceProxy);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.btOtevri);
            this.Controls.Add(this.btTestObjDat);
            this.Controls.Add(this.lbTestObjemuDat);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btObnovZbyvData);
            this.Controls.Add(this.lbZbyvajiciDataNaServeru);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.lCelkovyObjDat);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lPocetOtevrenych);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tbVlastniNazev);
            this.Controls.Add(this.btUloz);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lPocetStejnychIp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lipAdresa);
            this.Controls.Add(this.lbCekaNaStart);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lAktualniStav);
            this.Controls.Add(this.tbOtevriMaximalne);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TimePicker2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TimePicker1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.tbOteviraniPodleCasuDO);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbOteviraniPodleCasuOD);
            this.Controls.Add(this.chCOteviraniPodleCasu);
            this.Controls.Add(this.chCOteviraniPodlePoctu);
            this.Controls.Add(this.tbCelkovyPocetOtevreni);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNahodnyCasDO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNahodnyCasOD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbOdkaz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btStart);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "APIWEB";
            this.Text = "APIWEB";
            this.Load += new System.EventHandler(this.APIWEB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbProxyHostName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbProxyUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProxyPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbApiToken;
        private System.Windows.Forms.TextBox tbProxyPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOdkaz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNahodnyCasOD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNahodnyCasDO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCelkovyPocetOtevreni;
        private System.Windows.Forms.CheckBox chCOteviraniPodlePoctu;
        private System.Windows.Forms.CheckBox chCOteviraniPodleCasu;
        private System.Windows.Forms.TextBox tbOteviraniPodleCasuDO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbOteviraniPodleCasuOD;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.DateTimePicker TimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker TimePicker2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbOtevriMaximalne;
        private System.Windows.Forms.Label lAktualniStav;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbCekaNaStart;
        private System.Windows.Forms.Label lipAdresa;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lPocetStejnychIp;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btUloz;
        private System.Windows.Forms.TextBox tbVlastniNazev;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lPocetOtevrenych;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lCelkovyObjDat;
        private System.Windows.Forms.Button btOtevri;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lFunkceProxy;
        private System.Windows.Forms.Button btUlozNastaveniProxy;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbZbyvajiciDataNaServeru;
        private System.Windows.Forms.Button btObnovZbyvData;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lbTestObjemuDat;
        private System.Windows.Forms.Button btTestObjDat;
        private System.Windows.Forms.Label label33;
    }
}

