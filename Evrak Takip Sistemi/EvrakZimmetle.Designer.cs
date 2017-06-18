using ETS.OzelKontrol;

namespace ETS
{
    partial class EvrakZimmetle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvrakZimmetle));
            this.txtEvrakKategorisi = new DevExpress.XtraEditors.LookUpEdit();
            this.lblEvrakZimmetKategori = new DevExpress.XtraEditors.LabelControl();
            this.btnEvrakiZimmetle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtZimmetTarihi = new DevExpress.XtraEditors.DateEdit();
            this.lblZimmetSiraNo = new DevExpress.XtraEditors.LabelControl();
            this.txtZimmetSiraNo = new DevExpress.XtraEditors.TextEdit();
            this.gcZimmetlenenEvrak = new DevExpress.XtraEditors.GroupControl();
            this.chkPrvDurum = new DevExpress.XtraEditors.CheckButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrvAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrvEvrakIslemSonTarihi = new DevExpress.XtraEditors.TextEdit();
            this.txtPrvGonderdigiMakam = new DevExpress.XtraEditors.TextEdit();
            this.txtPrvGuvenlikNoOncelikDerecesi = new DevExpress.XtraEditors.TextEdit();
            this.txtPrvGizlilikDerecesi = new DevExpress.XtraEditors.TextEdit();
            this.txtPrvEvrakTarihi = new DevExpress.XtraEditors.TextEdit();
            this.txtPrvEvrakKayitTarihi = new DevExpress.XtraEditors.TextEdit();
            this.txtPrvEvrakiCikaranMakam = new DevExpress.XtraEditors.TextEdit();
            this.txtPrvEvrakKayitNo = new DevExpress.XtraEditors.TextEdit();
            this.txtPrvDosyaNoKonusu = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblGuvenlikNoOncelikDerecesi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblGizlilikDerecesi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblGonderildigiMakam = new DevExpress.XtraEditors.LabelControl();
            this.lblDurum = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.lblEvrakSuresi = new DevExpress.XtraEditors.LabelControl();
            this.txtEvrakiTeslimAlan = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gradientPanel1 = new GradientPanel();
            this.txtEvrakTipi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakKategorisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimmetTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimmetTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimmetSiraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcZimmetlenenEvrak)).BeginInit();
            this.gcZimmetlenenEvrak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakIslemSonTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvGonderdigiMakam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvGuvenlikNoOncelikDerecesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvGizlilikDerecesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakKayitTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakiCikaranMakam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakKayitNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvDosyaNoKonusu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakiTeslimAlan.Properties)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEvrakKategorisi
            // 
            this.txtEvrakKategorisi.Location = new System.Drawing.Point(186, 34);
            this.txtEvrakKategorisi.Name = "txtEvrakKategorisi";
            this.txtEvrakKategorisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEvrakKategorisi.Properties.DisplayMember = "Kategori";
            this.txtEvrakKategorisi.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtEvrakKategorisi.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtEvrakKategorisi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtEvrakKategorisi.Properties.ValueMember = "Id";
            this.txtEvrakKategorisi.Size = new System.Drawing.Size(187, 20);
            this.txtEvrakKategorisi.TabIndex = 11;
            this.txtEvrakKategorisi.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.txtEvrakKategorisi_ProcessNewValue);
            // 
            // lblEvrakZimmetKategori
            // 
            this.lblEvrakZimmetKategori.Location = new System.Drawing.Point(12, 37);
            this.lblEvrakZimmetKategori.Name = "lblEvrakZimmetKategori";
            this.lblEvrakZimmetKategori.Size = new System.Drawing.Size(159, 13);
            this.lblEvrakZimmetKategori.TabIndex = 12;
            this.lblEvrakZimmetKategori.Text = "Zimmetlenecek Evrağın Kategorisi";
            // 
            // btnEvrakiZimmetle
            // 
            this.btnEvrakiZimmetle.Location = new System.Drawing.Point(276, 115);
            this.btnEvrakiZimmetle.Name = "btnEvrakiZimmetle";
            this.btnEvrakiZimmetle.Size = new System.Drawing.Size(97, 42);
            this.btnEvrakiZimmetle.TabIndex = 13;
            this.btnEvrakiZimmetle.Text = "Zimmetle";
            this.btnEvrakiZimmetle.Click += new System.EventHandler(this.btnEvrakiZimmetle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Zimmetlendiği Tarih";
            // 
            // txtZimmetTarihi
            // 
            this.txtZimmetTarihi.EditValue = null;
            this.txtZimmetTarihi.Location = new System.Drawing.Point(186, 63);
            this.txtZimmetTarihi.Name = "txtZimmetTarihi";
            this.txtZimmetTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtZimmetTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtZimmetTarihi.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.txtZimmetTarihi.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.txtZimmetTarihi.Size = new System.Drawing.Size(187, 20);
            this.txtZimmetTarihi.TabIndex = 14;
            // 
            // lblZimmetSiraNo
            // 
            this.lblZimmetSiraNo.Location = new System.Drawing.Point(12, 10);
            this.lblZimmetSiraNo.Name = "lblZimmetSiraNo";
            this.lblZimmetSiraNo.Size = new System.Drawing.Size(71, 13);
            this.lblZimmetSiraNo.TabIndex = 12;
            this.lblZimmetSiraNo.Text = "Zimmet Sıra No";
            // 
            // txtZimmetSiraNo
            // 
            this.txtZimmetSiraNo.Location = new System.Drawing.Point(186, 7);
            this.txtZimmetSiraNo.Name = "txtZimmetSiraNo";
            this.txtZimmetSiraNo.Properties.Mask.EditMask = "f0";
            this.txtZimmetSiraNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtZimmetSiraNo.Size = new System.Drawing.Size(187, 20);
            this.txtZimmetSiraNo.TabIndex = 15;
            // 
            // gcZimmetlenenEvrak
            // 
            this.gcZimmetlenenEvrak.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gcZimmetlenenEvrak.Controls.Add(this.gradientPanel1);
            this.gcZimmetlenenEvrak.Controls.Add(this.chkPrvDurum);
            this.gcZimmetlenenEvrak.Controls.Add(this.labelControl7);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvAciklama);
            this.gcZimmetlenenEvrak.Controls.Add(this.labelControl6);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvEvrakIslemSonTarihi);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvGonderdigiMakam);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvGuvenlikNoOncelikDerecesi);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvGizlilikDerecesi);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvEvrakTarihi);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvEvrakKayitTarihi);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvEvrakiCikaranMakam);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvEvrakKayitNo);
            this.gcZimmetlenenEvrak.Controls.Add(this.txtPrvDosyaNoKonusu);
            this.gcZimmetlenenEvrak.Controls.Add(this.labelControl5);
            this.gcZimmetlenenEvrak.Controls.Add(this.lblGuvenlikNoOncelikDerecesi);
            this.gcZimmetlenenEvrak.Controls.Add(this.labelControl8);
            this.gcZimmetlenenEvrak.Controls.Add(this.lblGizlilikDerecesi);
            this.gcZimmetlenenEvrak.Controls.Add(this.labelControl3);
            this.gcZimmetlenenEvrak.Controls.Add(this.lblGonderildigiMakam);
            this.gcZimmetlenenEvrak.Controls.Add(this.lblDurum);
            this.gcZimmetlenenEvrak.Controls.Add(this.lblAciklama);
            this.gcZimmetlenenEvrak.Controls.Add(this.lblEvrakSuresi);
            this.gcZimmetlenenEvrak.Location = new System.Drawing.Point(400, 0);
            this.gcZimmetlenenEvrak.Name = "gcZimmetlenenEvrak";
            this.gcZimmetlenenEvrak.Size = new System.Drawing.Size(459, 492);
            this.gcZimmetlenenEvrak.TabIndex = 16;
            this.gcZimmetlenenEvrak.Text = "Zimmetlenen Evrak Önizleme";
            // 
            // chkPrvDurum
            // 
            this.chkPrvDurum.AllowFocus = false;
            this.chkPrvDurum.Enabled = false;
            this.chkPrvDurum.Location = new System.Drawing.Point(162, 456);
            this.chkPrvDurum.Name = "chkPrvDurum";
            this.chkPrvDurum.Size = new System.Drawing.Size(282, 23);
            this.chkPrvDurum.TabIndex = 25;
            this.chkPrvDurum.Text = "Bekliyor";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 167);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(84, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Dosya No Konusu";
            // 
            // txtPrvAciklama
            // 
            this.txtPrvAciklama.Enabled = false;
            this.txtPrvAciklama.Location = new System.Drawing.Point(163, 341);
            this.txtPrvAciklama.Name = "txtPrvAciklama";
            this.txtPrvAciklama.Size = new System.Drawing.Size(281, 83);
            this.txtPrvAciklama.TabIndex = 24;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 142);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Evrak Tarihi";
            // 
            // txtPrvEvrakIslemSonTarihi
            // 
            this.txtPrvEvrakIslemSonTarihi.Enabled = false;
            this.txtPrvEvrakIslemSonTarihi.Location = new System.Drawing.Point(163, 430);
            this.txtPrvEvrakIslemSonTarihi.Name = "txtPrvEvrakIslemSonTarihi";
            this.txtPrvEvrakIslemSonTarihi.Properties.Mask.EditMask = "f0";
            this.txtPrvEvrakIslemSonTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrvEvrakIslemSonTarihi.Size = new System.Drawing.Size(281, 20);
            this.txtPrvEvrakIslemSonTarihi.TabIndex = 11;
            // 
            // txtPrvGonderdigiMakam
            // 
            this.txtPrvGonderdigiMakam.Enabled = false;
            this.txtPrvGonderdigiMakam.Location = new System.Drawing.Point(163, 315);
            this.txtPrvGonderdigiMakam.Name = "txtPrvGonderdigiMakam";
            this.txtPrvGonderdigiMakam.Properties.Mask.EditMask = "f0";
            this.txtPrvGonderdigiMakam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrvGonderdigiMakam.Size = new System.Drawing.Size(281, 20);
            this.txtPrvGonderdigiMakam.TabIndex = 11;
            // 
            // txtPrvGuvenlikNoOncelikDerecesi
            // 
            this.txtPrvGuvenlikNoOncelikDerecesi.Enabled = false;
            this.txtPrvGuvenlikNoOncelikDerecesi.Location = new System.Drawing.Point(163, 289);
            this.txtPrvGuvenlikNoOncelikDerecesi.Name = "txtPrvGuvenlikNoOncelikDerecesi";
            this.txtPrvGuvenlikNoOncelikDerecesi.Properties.Mask.EditMask = "f0";
            this.txtPrvGuvenlikNoOncelikDerecesi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrvGuvenlikNoOncelikDerecesi.Size = new System.Drawing.Size(281, 20);
            this.txtPrvGuvenlikNoOncelikDerecesi.TabIndex = 11;
            // 
            // txtPrvGizlilikDerecesi
            // 
            this.txtPrvGizlilikDerecesi.Enabled = false;
            this.txtPrvGizlilikDerecesi.Location = new System.Drawing.Point(163, 263);
            this.txtPrvGizlilikDerecesi.Name = "txtPrvGizlilikDerecesi";
            this.txtPrvGizlilikDerecesi.Properties.Mask.EditMask = "f0";
            this.txtPrvGizlilikDerecesi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrvGizlilikDerecesi.Size = new System.Drawing.Size(281, 20);
            this.txtPrvGizlilikDerecesi.TabIndex = 11;
            // 
            // txtPrvEvrakTarihi
            // 
            this.txtPrvEvrakTarihi.Enabled = false;
            this.txtPrvEvrakTarihi.Location = new System.Drawing.Point(163, 135);
            this.txtPrvEvrakTarihi.Name = "txtPrvEvrakTarihi";
            this.txtPrvEvrakTarihi.Properties.Mask.EditMask = "f0";
            this.txtPrvEvrakTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrvEvrakTarihi.Size = new System.Drawing.Size(281, 20);
            this.txtPrvEvrakTarihi.TabIndex = 11;
            // 
            // txtPrvEvrakKayitTarihi
            // 
            this.txtPrvEvrakKayitTarihi.Enabled = false;
            this.txtPrvEvrakKayitTarihi.Location = new System.Drawing.Point(163, 83);
            this.txtPrvEvrakKayitTarihi.Name = "txtPrvEvrakKayitTarihi";
            this.txtPrvEvrakKayitTarihi.Properties.Mask.EditMask = "f0";
            this.txtPrvEvrakKayitTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrvEvrakKayitTarihi.Size = new System.Drawing.Size(281, 20);
            this.txtPrvEvrakKayitTarihi.TabIndex = 11;
            // 
            // txtPrvEvrakiCikaranMakam
            // 
            this.txtPrvEvrakiCikaranMakam.Enabled = false;
            this.txtPrvEvrakiCikaranMakam.Location = new System.Drawing.Point(163, 109);
            this.txtPrvEvrakiCikaranMakam.Name = "txtPrvEvrakiCikaranMakam";
            this.txtPrvEvrakiCikaranMakam.Properties.Mask.EditMask = "f0";
            this.txtPrvEvrakiCikaranMakam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrvEvrakiCikaranMakam.Size = new System.Drawing.Size(281, 20);
            this.txtPrvEvrakiCikaranMakam.TabIndex = 11;
            // 
            // txtPrvEvrakKayitNo
            // 
            this.txtPrvEvrakKayitNo.Enabled = false;
            this.txtPrvEvrakKayitNo.Location = new System.Drawing.Point(163, 58);
            this.txtPrvEvrakKayitNo.Name = "txtPrvEvrakKayitNo";
            this.txtPrvEvrakKayitNo.Properties.Mask.EditMask = "f0";
            this.txtPrvEvrakKayitNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrvEvrakKayitNo.Size = new System.Drawing.Size(281, 20);
            this.txtPrvEvrakKayitNo.TabIndex = 11;
            // 
            // txtPrvDosyaNoKonusu
            // 
            this.txtPrvDosyaNoKonusu.Enabled = false;
            this.txtPrvDosyaNoKonusu.Location = new System.Drawing.Point(163, 161);
            this.txtPrvDosyaNoKonusu.Name = "txtPrvDosyaNoKonusu";
            this.txtPrvDosyaNoKonusu.Size = new System.Drawing.Size(281, 96);
            this.txtPrvDosyaNoKonusu.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Evrakı Çıkaran Makam";
            // 
            // lblGuvenlikNoOncelikDerecesi
            // 
            this.lblGuvenlikNoOncelikDerecesi.Location = new System.Drawing.Point(8, 296);
            this.lblGuvenlikNoOncelikDerecesi.Name = "lblGuvenlikNoOncelikDerecesi";
            this.lblGuvenlikNoOncelikDerecesi.Size = new System.Drawing.Size(137, 13);
            this.lblGuvenlikNoOncelikDerecesi.TabIndex = 21;
            this.lblGuvenlikNoOncelikDerecesi.Text = "Güvenlik No Öncelik Derecesi";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 65);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Evrak Kayıt No";
            // 
            // lblGizlilikDerecesi
            // 
            this.lblGizlilikDerecesi.Location = new System.Drawing.Point(8, 270);
            this.lblGizlilikDerecesi.Name = "lblGizlilikDerecesi";
            this.lblGizlilikDerecesi.Size = new System.Drawing.Size(71, 13);
            this.lblGizlilikDerecesi.TabIndex = 22;
            this.lblGizlilikDerecesi.Text = "Gizlilik Derecesi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Evrak Kayıt Tarihi";
            // 
            // lblGonderildigiMakam
            // 
            this.lblGonderildigiMakam.Location = new System.Drawing.Point(8, 322);
            this.lblGonderildigiMakam.Name = "lblGonderildigiMakam";
            this.lblGonderildigiMakam.Size = new System.Drawing.Size(87, 13);
            this.lblGonderildigiMakam.TabIndex = 23;
            this.lblGonderildigiMakam.Text = "Gönderdiği Makam";
            // 
            // lblDurum
            // 
            this.lblDurum.Location = new System.Drawing.Point(8, 466);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(31, 13);
            this.lblDurum.TabIndex = 18;
            this.lblDurum.Text = "Durum";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(8, 348);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(41, 13);
            this.lblAciklama.TabIndex = 19;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblEvrakSuresi
            // 
            this.lblEvrakSuresi.Location = new System.Drawing.Point(8, 437);
            this.lblEvrakSuresi.Name = "lblEvrakSuresi";
            this.lblEvrakSuresi.Size = new System.Drawing.Size(105, 13);
            this.lblEvrakSuresi.TabIndex = 17;
            this.lblEvrakSuresi.Text = "Evrak İşlem Son Tarihi";
            // 
            // txtEvrakiTeslimAlan
            // 
            this.txtEvrakiTeslimAlan.Location = new System.Drawing.Point(186, 89);
            this.txtEvrakiTeslimAlan.Name = "txtEvrakiTeslimAlan";
            this.txtEvrakiTeslimAlan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEvrakiTeslimAlan.Properties.DisplayMember = "Adi";
            this.txtEvrakiTeslimAlan.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtEvrakiTeslimAlan.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtEvrakiTeslimAlan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtEvrakiTeslimAlan.Properties.ValueMember = "Id";
            this.txtEvrakiTeslimAlan.Size = new System.Drawing.Size(187, 20);
            this.txtEvrakiTeslimAlan.TabIndex = 11;
            this.txtEvrakiTeslimAlan.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.txtEvrakiTeslimAlan_ProcessNewValue);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Evrakı Teslim Alan";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanel1.BackgroundImage")));
            this.gradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel1.Controls.Add(this.txtEvrakTipi);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Location = new System.Drawing.Point(2, 21);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.PageEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gradientPanel1.PageStartColor = System.Drawing.Color.White;
            this.gradientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gradientPanel1.Size = new System.Drawing.Size(455, 27);
            this.gradientPanel1.TabIndex = 17;
            // 
            // txtEvrakTipi
            // 
            this.txtEvrakTipi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtEvrakTipi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEvrakTipi.Location = new System.Drawing.Point(6, 5);
            this.txtEvrakTipi.Name = "txtEvrakTipi";
            this.txtEvrakTipi.Size = new System.Drawing.Size(76, 16);
            this.txtEvrakTipi.TabIndex = 0;
            this.txtEvrakTipi.Text = "#EvrakTipi#";
            // 
            // EvrakZimmetle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 491);
            this.Controls.Add(this.gcZimmetlenenEvrak);
            this.Controls.Add(this.txtZimmetSiraNo);
            this.Controls.Add(this.txtZimmetTarihi);
            this.Controls.Add(this.btnEvrakiZimmetle);
            this.Controls.Add(this.lblZimmetSiraNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblEvrakZimmetKategori);
            this.Controls.Add(this.txtEvrakiTeslimAlan);
            this.Controls.Add(this.txtEvrakKategorisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EvrakZimmetle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evrakı Zimmetle";
            this.Load += new System.EventHandler(this.EvrakZimmetle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakKategorisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimmetTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimmetTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZimmetSiraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcZimmetlenenEvrak)).EndInit();
            this.gcZimmetlenenEvrak.ResumeLayout(false);
            this.gcZimmetlenenEvrak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakIslemSonTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvGonderdigiMakam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvGuvenlikNoOncelikDerecesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvGizlilikDerecesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakKayitTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakiCikaranMakam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvEvrakKayitNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrvDosyaNoKonusu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakiTeslimAlan.Properties)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit txtEvrakKategorisi;
        private DevExpress.XtraEditors.LabelControl lblEvrakZimmetKategori;
        private DevExpress.XtraEditors.SimpleButton btnEvrakiZimmetle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtZimmetTarihi;
        private DevExpress.XtraEditors.LabelControl lblZimmetSiraNo;
        private DevExpress.XtraEditors.TextEdit txtZimmetSiraNo;
        private DevExpress.XtraEditors.GroupControl gcZimmetlenenEvrak;
        private DevExpress.XtraEditors.LabelControl txtEvrakTipi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private GradientPanel gradientPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckButton chkPrvDurum;
        private DevExpress.XtraEditors.MemoEdit txtPrvAciklama;
        private DevExpress.XtraEditors.TextEdit txtPrvEvrakKayitNo;
        private DevExpress.XtraEditors.MemoEdit txtPrvDosyaNoKonusu;
        private DevExpress.XtraEditors.LabelControl lblGuvenlikNoOncelikDerecesi;
        private DevExpress.XtraEditors.LabelControl lblGizlilikDerecesi;
        private DevExpress.XtraEditors.LabelControl lblGonderildigiMakam;
        private DevExpress.XtraEditors.LabelControl lblDurum;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private DevExpress.XtraEditors.LabelControl lblEvrakSuresi;
        private DevExpress.XtraEditors.TextEdit txtPrvEvrakiCikaranMakam;
        private DevExpress.XtraEditors.TextEdit txtPrvGuvenlikNoOncelikDerecesi;
        private DevExpress.XtraEditors.TextEdit txtPrvGizlilikDerecesi;
        private DevExpress.XtraEditors.TextEdit txtPrvEvrakTarihi;
        private DevExpress.XtraEditors.TextEdit txtPrvEvrakKayitTarihi;
        private DevExpress.XtraEditors.TextEdit txtPrvGonderdigiMakam;
        private DevExpress.XtraEditors.TextEdit txtPrvEvrakIslemSonTarihi;
        private DevExpress.XtraEditors.LookUpEdit txtEvrakiTeslimAlan;
        private DevExpress.XtraEditors.LabelControl labelControl2;

    }
}