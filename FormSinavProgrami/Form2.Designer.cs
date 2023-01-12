namespace FormSinavProgrami
{
    partial class FormAdSoyad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelGorselProgSinav = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelKalanSure = new System.Windows.Forms.Label();
            this.labelSayac = new System.Windows.Forms.Label();
            this.labelTCNo = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.textBoxTCNo = new System.Windows.Forms.TextBox();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.labelDogruSayi = new System.Windows.Forms.Label();
            this.labelDogruSayiSonuc = new System.Windows.Forms.Label();
            this.labelYanlisSayi = new System.Windows.Forms.Label();
            this.labelYanlisSayiSonuc = new System.Windows.Forms.Label();
            this.labelTCNoSonuc = new System.Windows.Forms.Label();
            this.labelTCNoSonuc2 = new System.Windows.Forms.Label();
            this.labelAdSoyadSonuc = new System.Windows.Forms.Label();
            this.labelAdSoyadSonuc2 = new System.Windows.Forms.Label();
            this.buttonTestBaslat = new System.Windows.Forms.Button();
            this.buttonTestBitir = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGorselProgSinav
            // 
            this.labelGorselProgSinav.AutoSize = true;
            this.labelGorselProgSinav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGorselProgSinav.ForeColor = System.Drawing.Color.Red;
            this.labelGorselProgSinav.Location = new System.Drawing.Point(192, 11);
            this.labelGorselProgSinav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGorselProgSinav.Name = "labelGorselProgSinav";
            this.labelGorselProgSinav.Size = new System.Drawing.Size(323, 25);
            this.labelGorselProgSinav.TabIndex = 0;
            this.labelGorselProgSinav.Text = "Açık Kaynak İşletim Sistemi Soruları";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelKalanSure
            // 
            this.labelKalanSure.AutoSize = true;
            this.labelKalanSure.Location = new System.Drawing.Point(17, 20);
            this.labelKalanSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKalanSure.Name = "labelKalanSure";
            this.labelKalanSure.Size = new System.Drawing.Size(82, 17);
            this.labelKalanSure.TabIndex = 1;
            this.labelKalanSure.Text = "Kalan Süre:";
            // 
            // labelSayac
            // 
            this.labelSayac.AutoSize = true;
            this.labelSayac.ForeColor = System.Drawing.Color.Black;
            this.labelSayac.Location = new System.Drawing.Point(108, 20);
            this.labelSayac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSayac.Name = "labelSayac";
            this.labelSayac.Size = new System.Drawing.Size(16, 17);
            this.labelSayac.TabIndex = 2;
            this.labelSayac.Text = "0";
            this.labelSayac.Click += new System.EventHandler(this.labelSayac_Click);
            // 
            // labelTCNo
            // 
            this.labelTCNo.AutoSize = true;
            this.labelTCNo.Location = new System.Drawing.Point(22, 50);
            this.labelTCNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTCNo.Name = "labelTCNo";
            this.labelTCNo.Size = new System.Drawing.Size(50, 17);
            this.labelTCNo.TabIndex = 3;
            this.labelTCNo.Text = "TC no:";
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(269, 50);
            this.labelAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(79, 17);
            this.labelAdSoyad.TabIndex = 4;
            this.labelAdSoyad.Text = "Adı Soyadı:";
            // 
            // textBoxTCNo
            // 
            this.textBoxTCNo.Location = new System.Drawing.Point(80, 47);
            this.textBoxTCNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTCNo.MaxLength = 11;
            this.textBoxTCNo.Name = "textBoxTCNo";
            this.textBoxTCNo.Size = new System.Drawing.Size(132, 22);
            this.textBoxTCNo.TabIndex = 5;
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(356, 47);
            this.textBoxAdSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(132, 22);
            this.textBoxAdSoyad.TabIndex = 6;
            // 
            // labelDogruSayi
            // 
            this.labelDogruSayi.AutoSize = true;
            this.labelDogruSayi.ForeColor = System.Drawing.Color.Green;
            this.labelDogruSayi.Location = new System.Drawing.Point(556, 20);
            this.labelDogruSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDogruSayi.Name = "labelDogruSayi";
            this.labelDogruSayi.Size = new System.Drawing.Size(92, 17);
            this.labelDogruSayi.TabIndex = 7;
            this.labelDogruSayi.Text = "Doğru Sayısı:";
            // 
            // labelDogruSayiSonuc
            // 
            this.labelDogruSayiSonuc.AutoSize = true;
            this.labelDogruSayiSonuc.Location = new System.Drawing.Point(645, 20);
            this.labelDogruSayiSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDogruSayiSonuc.Name = "labelDogruSayiSonuc";
            this.labelDogruSayiSonuc.Size = new System.Drawing.Size(16, 17);
            this.labelDogruSayiSonuc.TabIndex = 8;
            this.labelDogruSayiSonuc.Text = "0";
            // 
            // labelYanlisSayi
            // 
            this.labelYanlisSayi.AutoSize = true;
            this.labelYanlisSayi.ForeColor = System.Drawing.Color.Red;
            this.labelYanlisSayi.Location = new System.Drawing.Point(695, 20);
            this.labelYanlisSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYanlisSayi.Name = "labelYanlisSayi";
            this.labelYanlisSayi.Size = new System.Drawing.Size(91, 17);
            this.labelYanlisSayi.TabIndex = 9;
            this.labelYanlisSayi.Text = "Yanlış Sayısı:";
            // 
            // labelYanlisSayiSonuc
            // 
            this.labelYanlisSayiSonuc.AutoSize = true;
            this.labelYanlisSayiSonuc.Location = new System.Drawing.Point(783, 20);
            this.labelYanlisSayiSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYanlisSayiSonuc.Name = "labelYanlisSayiSonuc";
            this.labelYanlisSayiSonuc.Size = new System.Drawing.Size(16, 17);
            this.labelYanlisSayiSonuc.TabIndex = 10;
            this.labelYanlisSayiSonuc.Text = "0";
            // 
            // labelTCNoSonuc
            // 
            this.labelTCNoSonuc.AutoSize = true;
            this.labelTCNoSonuc.Location = new System.Drawing.Point(557, 55);
            this.labelTCNoSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTCNoSonuc.Name = "labelTCNoSonuc";
            this.labelTCNoSonuc.Size = new System.Drawing.Size(52, 17);
            this.labelTCNoSonuc.TabIndex = 11;
            this.labelTCNoSonuc.Text = "TC No:";
            // 
            // labelTCNoSonuc2
            // 
            this.labelTCNoSonuc2.AutoSize = true;
            this.labelTCNoSonuc2.Location = new System.Drawing.Point(607, 55);
            this.labelTCNoSonuc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTCNoSonuc2.Name = "labelTCNoSonuc2";
            this.labelTCNoSonuc2.Size = new System.Drawing.Size(0, 17);
            this.labelTCNoSonuc2.TabIndex = 12;
            // 
            // labelAdSoyadSonuc
            // 
            this.labelAdSoyadSonuc.AutoSize = true;
            this.labelAdSoyadSonuc.Location = new System.Drawing.Point(557, 80);
            this.labelAdSoyadSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdSoyadSonuc.Name = "labelAdSoyadSonuc";
            this.labelAdSoyadSonuc.Size = new System.Drawing.Size(79, 17);
            this.labelAdSoyadSonuc.TabIndex = 13;
            this.labelAdSoyadSonuc.Text = "Adı Soyadı:";
            // 
            // labelAdSoyadSonuc2
            // 
            this.labelAdSoyadSonuc2.AutoSize = true;
            this.labelAdSoyadSonuc2.Location = new System.Drawing.Point(636, 80);
            this.labelAdSoyadSonuc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdSoyadSonuc2.Name = "labelAdSoyadSonuc2";
            this.labelAdSoyadSonuc2.Size = new System.Drawing.Size(0, 17);
            this.labelAdSoyadSonuc2.TabIndex = 14;
            // 
            // buttonTestBaslat
            // 
            this.buttonTestBaslat.Location = new System.Drawing.Point(80, 80);
            this.buttonTestBaslat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTestBaslat.Name = "buttonTestBaslat";
            this.buttonTestBaslat.Size = new System.Drawing.Size(133, 28);
            this.buttonTestBaslat.TabIndex = 15;
            this.buttonTestBaslat.Text = "Testi Başlat";
            this.buttonTestBaslat.UseVisualStyleBackColor = true;
            this.buttonTestBaslat.Click += new System.EventHandler(this.buttonTestBaslat_Click);
            // 
            // buttonTestBitir
            // 
            this.buttonTestBitir.Location = new System.Drawing.Point(355, 80);
            this.buttonTestBitir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTestBitir.Name = "buttonTestBitir";
            this.buttonTestBitir.Size = new System.Drawing.Size(133, 28);
            this.buttonTestBitir.TabIndex = 16;
            this.buttonTestBitir.Text = "Testi Bitir";
            this.buttonTestBitir.UseVisualStyleBackColor = true;
            this.buttonTestBitir.Click += new System.EventHandler(this.buttonTestBitir_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 58);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 21);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kaptan";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 86);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 21);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "X Windows";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 114);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 21);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Minix";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 143);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(65, 21);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Panel";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(21, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(387, 172);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Location = new System.Drawing.Point(23, 305);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(387, 172);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Soru 2";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 58);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(75, 21);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Gnome";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(15, 143);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(57, 21);
            this.radioButton6.TabIndex = 20;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "KDE";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(15, 86);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(57, 21);
            this.radioButton7.TabIndex = 18;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Xfce";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(15, 114);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(91, 21);
            this.radioButton8.TabIndex = 19;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Open Box";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.radioButton9);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Controls.Add(this.radioButton11);
            this.groupBox3.Controls.Add(this.radioButton12);
            this.groupBox3.Location = new System.Drawing.Point(420, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(387, 172);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Soru 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MaximumSize = new System.Drawing.Size(373, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(322, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "Aşağıdakilerden hangi KDE temel bileşenlerinden değildir? ";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(15, 58);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(90, 21);
            this.radioButton9.TabIndex = 17;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Masaüstü";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(15, 143);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(128, 21);
            this.radioButton10.TabIndex = 20;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Masaüstü Dizini";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(15, 86);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(65, 21);
            this.radioButton11.TabIndex = 18;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Panel";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(15, 114);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(59, 21);
            this.radioButton12.TabIndex = 19;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Root";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.radioButton13);
            this.groupBox4.Controls.Add(this.radioButton14);
            this.groupBox4.Controls.Add(this.radioButton15);
            this.groupBox4.Controls.Add(this.radioButton16);
            this.groupBox4.Location = new System.Drawing.Point(420, 305);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(387, 172);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Soru 4";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(15, 58);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(70, 21);
            this.radioButton13.TabIndex = 17;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "/Home";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(15, 143);
            this.radioButton14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(55, 21);
            this.radioButton14.TabIndex = 20;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "/Usr";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(15, 86);
            this.radioButton15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(53, 21);
            this.radioButton15.TabIndex = 18;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "/Bin";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(15, 114);
            this.radioButton16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(33, 21);
            this.radioButton16.TabIndex = 19;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "/";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.MaximumSize = new System.Drawing.Size(373, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(367, 34);
            this.label4.TabIndex = 22;
            this.label4.Text = "Aşağıdakilerden hangisi Linux dosya sisteminde en üstte bulunan dizindir?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.MaximumSize = new System.Drawing.Size(373, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(347, 34);
            this.label7.TabIndex = 23;
            this.label7.Text = "Linux işletim sistemlerinde kullanılan grafik ara yüz alt yapısı hangisidir? ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(373, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(371, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pardus ile birlikte gelen masaüstü ortamı aşağıdakilerden hangisidir? ";
            // 
            // FormAdSoyad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 527);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTestBitir);
            this.Controls.Add(this.buttonTestBaslat);
            this.Controls.Add(this.labelAdSoyadSonuc2);
            this.Controls.Add(this.labelAdSoyadSonuc);
            this.Controls.Add(this.labelTCNoSonuc2);
            this.Controls.Add(this.labelTCNoSonuc);
            this.Controls.Add(this.labelYanlisSayiSonuc);
            this.Controls.Add(this.labelYanlisSayi);
            this.Controls.Add(this.labelDogruSayiSonuc);
            this.Controls.Add(this.labelDogruSayi);
            this.Controls.Add(this.textBoxAdSoyad);
            this.Controls.Add(this.textBoxTCNo);
            this.Controls.Add(this.labelAdSoyad);
            this.Controls.Add(this.labelTCNo);
            this.Controls.Add(this.labelSayac);
            this.Controls.Add(this.labelKalanSure);
            this.Controls.Add(this.labelGorselProgSinav);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdSoyad";
            this.Text = "Açık Kaynak İşletim Sistemi Sınavı";
            this.Load += new System.EventHandler(this.FormAdSoyad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGorselProgSinav;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelKalanSure;
        private System.Windows.Forms.Label labelSayac;
        private System.Windows.Forms.Label labelTCNo;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.TextBox textBoxTCNo;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label labelDogruSayi;
        private System.Windows.Forms.Label labelDogruSayiSonuc;
        private System.Windows.Forms.Label labelYanlisSayi;
        private System.Windows.Forms.Label labelYanlisSayiSonuc;
        private System.Windows.Forms.Label labelTCNoSonuc;
        private System.Windows.Forms.Label labelTCNoSonuc2;
        private System.Windows.Forms.Label labelAdSoyadSonuc;
        private System.Windows.Forms.Label labelAdSoyadSonuc2;
        private System.Windows.Forms.Button buttonTestBaslat;
        private System.Windows.Forms.Button buttonTestBitir;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}