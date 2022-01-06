namespace DbFirstEntity
{
    partial class Form1
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
            this.dgvTablolar = new System.Windows.Forms.DataGridView();
            this.groupBoxTablolar = new System.Windows.Forms.GroupBox();
            this.btnOgrenciListesi = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.groupBoxOgrenci = new System.Windows.Forms.GroupBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDersListesi = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBoxNotlar = new System.Windows.Forms.GroupBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.btnNotListesi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnJoinIleGetir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDers = new System.Windows.Forms.GroupBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPurosedur = new System.Windows.Forms.Button();
            this.radioAd_A_Z = new System.Windows.Forms.RadioButton();
            this.radioAd_Z_A = new System.Windows.Forms.RadioButton();
            this.radioIlk3 = new System.Windows.Forms.RadioButton();
            this.radioIcindeAOlan = new System.Windows.Forms.RadioButton();
            this.radioDegerVarMi = new System.Windows.Forms.RadioButton();
            this.radioOgrenciSayisi = new System.Windows.Forms.RadioButton();
            this.radioGetToID = new System.Windows.Forms.RadioButton();
            this.radioSinav1ToplamPuan = new System.Windows.Forms.RadioButton();
            this.radio1SınavOrt = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.radioOrtUstu = new System.Windows.Forms.RadioButton();
            this.radio1EnYuksek = new System.Windows.Forms.RadioButton();
            this.radio1EnDusuk = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablolar)).BeginInit();
            this.groupBoxTablolar.SuspendLayout();
            this.groupBoxOgrenci.SuspendLayout();
            this.groupBoxNotlar.SuspendLayout();
            this.groupBoxDers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTablolar
            // 
            this.dgvTablolar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablolar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablolar.Location = new System.Drawing.Point(3, 17);
            this.dgvTablolar.Name = "dgvTablolar";
            this.dgvTablolar.Size = new System.Drawing.Size(812, 242);
            this.dgvTablolar.TabIndex = 0;
            // 
            // groupBoxTablolar
            // 
            this.groupBoxTablolar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTablolar.Controls.Add(this.dgvTablolar);
            this.groupBoxTablolar.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTablolar.Name = "groupBoxTablolar";
            this.groupBoxTablolar.Size = new System.Drawing.Size(818, 262);
            this.groupBoxTablolar.TabIndex = 1;
            this.groupBoxTablolar.TabStop = false;
            this.groupBoxTablolar.Text = "Tablolar : ";
            // 
            // btnOgrenciListesi
            // 
            this.btnOgrenciListesi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOgrenciListesi.Location = new System.Drawing.Point(178, 18);
            this.btnOgrenciListesi.Name = "btnOgrenciListesi";
            this.btnOgrenciListesi.Size = new System.Drawing.Size(110, 26);
            this.btnOgrenciListesi.TabIndex = 2;
            this.btnOgrenciListesi.Text = "Öğrenci Listele";
            this.btnOgrenciListesi.UseVisualStyleBackColor = true;
            this.btnOgrenciListesi.Click += new System.EventHandler(this.btnOgrenciListesi_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(178, 79);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(110, 26);
            this.btnOgrenciEkle.TabIndex = 2;
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSil.Location = new System.Drawing.Point(178, 110);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 26);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuncelle.Location = new System.Drawing.Point(178, 48);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 26);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBul.Location = new System.Drawing.Point(178, 140);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(110, 26);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID :";
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Location = new System.Drawing.Point(80, 20);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(93, 21);
            this.txtOgrenciID.TabIndex = 4;
            // 
            // groupBoxOgrenci
            // 
            this.groupBoxOgrenci.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBoxOgrenci.Controls.Add(this.txtFoto);
            this.groupBoxOgrenci.Controls.Add(this.label6);
            this.groupBoxOgrenci.Controls.Add(this.txtSoyad);
            this.groupBoxOgrenci.Controls.Add(this.btnBul);
            this.groupBoxOgrenci.Controls.Add(this.btnSil);
            this.groupBoxOgrenci.Controls.Add(this.label5);
            this.groupBoxOgrenci.Controls.Add(this.btnOgrenciEkle);
            this.groupBoxOgrenci.Controls.Add(this.btnGuncelle);
            this.groupBoxOgrenci.Controls.Add(this.txtAd);
            this.groupBoxOgrenci.Controls.Add(this.label4);
            this.groupBoxOgrenci.Controls.Add(this.btnOgrenciListesi);
            this.groupBoxOgrenci.Controls.Add(this.txtOgrenciID);
            this.groupBoxOgrenci.Controls.Add(this.label1);
            this.groupBoxOgrenci.Location = new System.Drawing.Point(-1, 273);
            this.groupBoxOgrenci.Name = "groupBoxOgrenci";
            this.groupBoxOgrenci.Size = new System.Drawing.Size(304, 178);
            this.groupBoxOgrenci.TabIndex = 5;
            this.groupBoxOgrenci.TabStop = false;
            this.groupBoxOgrenci.Text = "Öğrenci";
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(80, 117);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(93, 21);
            this.txtFoto.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "FOTOĞRAF :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(80, 84);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(93, 21);
            this.txtSoyad.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "SOYAD :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(80, 52);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(93, 21);
            this.txtAd.TabIndex = 4;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AD :";
            // 
            // btnDersListesi
            // 
            this.btnDersListesi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDersListesi.Location = new System.Drawing.Point(36, 86);
            this.btnDersListesi.Name = "btnDersListesi";
            this.btnDersListesi.Size = new System.Drawing.Size(108, 21);
            this.btnDersListesi.TabIndex = 2;
            this.btnDersListesi.Text = "Ders Listesi";
            this.btnDersListesi.UseVisualStyleBackColor = true;
            this.btnDersListesi.Click += new System.EventHandler(this.btnDersListesi_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHesapla.Location = new System.Drawing.Point(168, 117);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(130, 26);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // groupBoxNotlar
            // 
            this.groupBoxNotlar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBoxNotlar.Controls.Add(this.txtDurum);
            this.groupBoxNotlar.Controls.Add(this.btnNotListesi);
            this.groupBoxNotlar.Controls.Add(this.label10);
            this.groupBoxNotlar.Controls.Add(this.txtOrtalama);
            this.groupBoxNotlar.Controls.Add(this.label9);
            this.groupBoxNotlar.Controls.Add(this.txtSinav2);
            this.groupBoxNotlar.Controls.Add(this.txtSinav3);
            this.groupBoxNotlar.Controls.Add(this.label7);
            this.groupBoxNotlar.Controls.Add(this.btnJoinIleGetir);
            this.groupBoxNotlar.Controls.Add(this.btnHesapla);
            this.groupBoxNotlar.Controls.Add(this.label8);
            this.groupBoxNotlar.Controls.Add(this.txtSinav1);
            this.groupBoxNotlar.Controls.Add(this.label2);
            this.groupBoxNotlar.Location = new System.Drawing.Point(309, 273);
            this.groupBoxNotlar.Name = "groupBoxNotlar";
            this.groupBoxNotlar.Size = new System.Drawing.Size(317, 178);
            this.groupBoxNotlar.TabIndex = 5;
            this.groupBoxNotlar.TabStop = false;
            this.groupBoxNotlar.Text = "Notlar";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(74, 140);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(88, 21);
            this.txtDurum.TabIndex = 4;
            // 
            // btnNotListesi
            // 
            this.btnNotListesi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNotListesi.Location = new System.Drawing.Point(168, 53);
            this.btnNotListesi.Name = "btnNotListesi";
            this.btnNotListesi.Size = new System.Drawing.Size(130, 26);
            this.btnNotListesi.TabIndex = 2;
            this.btnNotListesi.Text = "Not Listesi";
            this.btnNotListesi.UseVisualStyleBackColor = true;
            this.btnNotListesi.Click += new System.EventHandler(this.btnNotListesi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "DURUM :";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(74, 112);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(88, 21);
            this.txtOrtalama.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "ORTALAMA :";
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(74, 57);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(88, 21);
            this.txtSinav2.TabIndex = 4;
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(74, 84);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(88, 21);
            this.txtSinav3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "SINAV 2 :";
            // 
            // btnJoinIleGetir
            // 
            this.btnJoinIleGetir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnJoinIleGetir.Location = new System.Drawing.Point(168, 85);
            this.btnJoinIleGetir.Name = "btnJoinIleGetir";
            this.btnJoinIleGetir.Size = new System.Drawing.Size(130, 26);
            this.btnJoinIleGetir.TabIndex = 2;
            this.btnJoinIleGetir.Text = "Join İle Getir";
            this.btnJoinIleGetir.UseVisualStyleBackColor = true;
            this.btnJoinIleGetir.Click += new System.EventHandler(this.btnJoinIleGetir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "SINAV 3 :";
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(74, 29);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(88, 21);
            this.txtSinav1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SINAV 1 :";
            // 
            // groupBoxDers
            // 
            this.groupBoxDers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBoxDers.Controls.Add(this.txtDersAd);
            this.groupBoxDers.Controls.Add(this.label11);
            this.groupBoxDers.Controls.Add(this.txtDersID);
            this.groupBoxDers.Controls.Add(this.label3);
            this.groupBoxDers.Controls.Add(this.btnDersListesi);
            this.groupBoxDers.Location = new System.Drawing.Point(632, 273);
            this.groupBoxDers.Name = "groupBoxDers";
            this.groupBoxDers.Size = new System.Drawing.Size(165, 123);
            this.groupBoxDers.TabIndex = 5;
            this.groupBoxDers.TabStop = false;
            this.groupBoxDers.Text = "Ders";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(48, 58);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(88, 21);
            this.txtDersAd.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "AD :";
            // 
            // txtDersID
            // 
            this.txtDersID.Location = new System.Drawing.Point(48, 29);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(88, 21);
            this.txtDersID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // btnPurosedur
            // 
            this.btnPurosedur.Location = new System.Drawing.Point(632, 412);
            this.btnPurosedur.Name = "btnPurosedur";
            this.btnPurosedur.Size = new System.Drawing.Size(84, 39);
            this.btnPurosedur.TabIndex = 6;
            this.btnPurosedur.Text = "Prosedür";
            this.btnPurosedur.UseVisualStyleBackColor = true;
            this.btnPurosedur.Click += new System.EventHandler(this.btnPurosedur_Click);
            // 
            // radioAd_A_Z
            // 
            this.radioAd_A_Z.AutoSize = true;
            this.radioAd_A_Z.Location = new System.Drawing.Point(834, 20);
            this.radioAd_A_Z.Name = "radioAd_A_Z";
            this.radioAd_A_Z.Size = new System.Drawing.Size(147, 17);
            this.radioAd_A_Z.TabIndex = 7;
            this.radioAd_A_Z.Text = "Ada Göre Sırala(A-Z)";
            this.radioAd_A_Z.UseVisualStyleBackColor = true;
            // 
            // radioAd_Z_A
            // 
            this.radioAd_Z_A.AutoSize = true;
            this.radioAd_Z_A.Location = new System.Drawing.Point(834, 50);
            this.radioAd_Z_A.Name = "radioAd_Z_A";
            this.radioAd_Z_A.Size = new System.Drawing.Size(147, 17);
            this.radioAd_Z_A.TabIndex = 7;
            this.radioAd_Z_A.Text = "Ada Göre Sırala(Z-A)";
            this.radioAd_Z_A.UseVisualStyleBackColor = true;
            // 
            // radioIlk3
            // 
            this.radioIlk3.AutoSize = true;
            this.radioIlk3.Location = new System.Drawing.Point(834, 80);
            this.radioIlk3.Name = "radioIlk3";
            this.radioIlk3.Size = new System.Drawing.Size(84, 17);
            this.radioIlk3.TabIndex = 7;
            this.radioIlk3.Text = "İlk 3 Kayıt";
            this.radioIlk3.UseVisualStyleBackColor = true;
            // 
            // radioIcindeAOlan
            // 
            this.radioIcindeAOlan.AutoSize = true;
            this.radioIcindeAOlan.Location = new System.Drawing.Point(834, 110);
            this.radioIcindeAOlan.Name = "radioIcindeAOlan";
            this.radioIcindeAOlan.Size = new System.Drawing.Size(136, 17);
            this.radioIcindeAOlan.TabIndex = 7;
            this.radioIcindeAOlan.Text = "İçinde A Olan Adlar";
            this.radioIcindeAOlan.UseVisualStyleBackColor = true;
            // 
            // radioDegerVarMi
            // 
            this.radioDegerVarMi.AutoSize = true;
            this.radioDegerVarMi.Location = new System.Drawing.Point(834, 170);
            this.radioDegerVarMi.Name = "radioDegerVarMi";
            this.radioDegerVarMi.Size = new System.Drawing.Size(170, 17);
            this.radioDegerVarMi.TabIndex = 7;
            this.radioDegerVarMi.Text = "Kulüplerde Değer Var Mı?";
            this.radioDegerVarMi.UseVisualStyleBackColor = true;
            // 
            // radioOgrenciSayisi
            // 
            this.radioOgrenciSayisi.AutoSize = true;
            this.radioOgrenciSayisi.Location = new System.Drawing.Point(834, 200);
            this.radioOgrenciSayisi.Name = "radioOgrenciSayisi";
            this.radioOgrenciSayisi.Size = new System.Drawing.Size(152, 17);
            this.radioOgrenciSayisi.TabIndex = 7;
            this.radioOgrenciSayisi.Text = "Toplam Öğrenci Sayısı";
            this.radioOgrenciSayisi.UseVisualStyleBackColor = true;
            // 
            // radioGetToID
            // 
            this.radioGetToID.AutoSize = true;
            this.radioGetToID.Location = new System.Drawing.Point(835, 140);
            this.radioGetToID.Name = "radioGetToID";
            this.radioGetToID.Size = new System.Drawing.Size(146, 17);
            this.radioGetToID.TabIndex = 7;
            this.radioGetToID.Text = "ID\' ye göre veri getir";
            this.radioGetToID.UseVisualStyleBackColor = true;
            // 
            // radioSinav1ToplamPuan
            // 
            this.radioSinav1ToplamPuan.AutoSize = true;
            this.radioSinav1ToplamPuan.Location = new System.Drawing.Point(835, 230);
            this.radioSinav1ToplamPuan.Name = "radioSinav1ToplamPuan";
            this.radioSinav1ToplamPuan.Size = new System.Drawing.Size(145, 17);
            this.radioSinav1ToplamPuan.TabIndex = 7;
            this.radioSinav1ToplamPuan.Text = "Sınav 1 Toplam Puan";
            this.radioSinav1ToplamPuan.UseVisualStyleBackColor = true;
            // 
            // radio1SınavOrt
            // 
            this.radio1SınavOrt.AutoSize = true;
            this.radio1SınavOrt.Location = new System.Drawing.Point(835, 260);
            this.radio1SınavOrt.Name = "radio1SınavOrt";
            this.radio1SınavOrt.Size = new System.Drawing.Size(160, 17);
            this.radio1SınavOrt.TabIndex = 7;
            this.radio1SınavOrt.Text = "Sınav 1 Ortalama Puanı";
            this.radio1SınavOrt.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Location = new System.Drawing.Point(835, 427);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(120, 38);
            this.btnLinqEntity.TabIndex = 8;
            this.btnLinqEntity.Text = "Seçiliye Göre Getir";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // radioOrtUstu
            // 
            this.radioOrtUstu.AutoSize = true;
            this.radioOrtUstu.Location = new System.Drawing.Point(834, 291);
            this.radioOrtUstu.Name = "radioOrtUstu";
            this.radioOrtUstu.Size = new System.Drawing.Size(161, 17);
            this.radioOrtUstu.TabIndex = 9;
            this.radioOrtUstu.Text = "1. Sınavı Ortalama Üstü";
            this.radioOrtUstu.UseVisualStyleBackColor = true;
            // 
            // radio1EnYuksek
            // 
            this.radio1EnYuksek.AutoSize = true;
            this.radio1EnYuksek.Location = new System.Drawing.Point(835, 321);
            this.radio1EnYuksek.Name = "radio1EnYuksek";
            this.radio1EnYuksek.Size = new System.Drawing.Size(131, 17);
            this.radio1EnYuksek.TabIndex = 10;
            this.radio1EnYuksek.Text = "1.Sınav En Yüksek";
            this.radio1EnYuksek.UseVisualStyleBackColor = true;
            // 
            // radio1EnDusuk
            // 
            this.radio1EnDusuk.AutoSize = true;
            this.radio1EnDusuk.Location = new System.Drawing.Point(835, 352);
            this.radio1EnDusuk.Name = "radio1EnDusuk";
            this.radio1EnDusuk.Size = new System.Drawing.Size(126, 17);
            this.radio1EnDusuk.TabIndex = 11;
            this.radio1EnDusuk.Text = "1.Sınav En Düşük";
            this.radio1EnDusuk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 477);
            this.Controls.Add(this.radio1EnDusuk);
            this.Controls.Add(this.radio1EnYuksek);
            this.Controls.Add(this.radioOrtUstu);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.radio1SınavOrt);
            this.Controls.Add(this.radioSinav1ToplamPuan);
            this.Controls.Add(this.radioGetToID);
            this.Controls.Add(this.radioOgrenciSayisi);
            this.Controls.Add(this.radioDegerVarMi);
            this.Controls.Add(this.radioIcindeAOlan);
            this.Controls.Add(this.radioIlk3);
            this.Controls.Add(this.radioAd_Z_A);
            this.Controls.Add(this.radioAd_A_Z);
            this.Controls.Add(this.btnPurosedur);
            this.Controls.Add(this.groupBoxDers);
            this.Controls.Add(this.groupBoxNotlar);
            this.Controls.Add(this.groupBoxOgrenci);
            this.Controls.Add(this.groupBoxTablolar);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablolar)).EndInit();
            this.groupBoxTablolar.ResumeLayout(false);
            this.groupBoxOgrenci.ResumeLayout(false);
            this.groupBoxOgrenci.PerformLayout();
            this.groupBoxNotlar.ResumeLayout(false);
            this.groupBoxNotlar.PerformLayout();
            this.groupBoxDers.ResumeLayout(false);
            this.groupBoxDers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablolar;
        private System.Windows.Forms.GroupBox groupBoxTablolar;
        private System.Windows.Forms.Button btnOgrenciListesi;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.GroupBox groupBoxOgrenci;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDersListesi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBoxNotlar;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDers;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnNotListesi;
        private System.Windows.Forms.Button btnJoinIleGetir;
        private System.Windows.Forms.Button btnPurosedur;
        private System.Windows.Forms.RadioButton radioAd_A_Z;
        private System.Windows.Forms.RadioButton radioAd_Z_A;
        private System.Windows.Forms.RadioButton radioIlk3;
        private System.Windows.Forms.RadioButton radioIcindeAOlan;
        private System.Windows.Forms.RadioButton radioDegerVarMi;
        private System.Windows.Forms.RadioButton radioOgrenciSayisi;
        private System.Windows.Forms.RadioButton radioGetToID;
        private System.Windows.Forms.RadioButton radioSinav1ToplamPuan;
        private System.Windows.Forms.RadioButton radio1SınavOrt;
        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.RadioButton radioOrtUstu;
        private System.Windows.Forms.RadioButton radio1EnYuksek;
        private System.Windows.Forms.RadioButton radio1EnDusuk;
    }
}

