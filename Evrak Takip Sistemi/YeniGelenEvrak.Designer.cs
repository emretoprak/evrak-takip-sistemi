using DevExpress.XtraEditors;
using ETS.OzelKontrol;

namespace ETS
{
    partial class YeniGelenEvrak
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.grpcYeniGelenEvrak = new DevExpress.XtraEditors.GroupControl();
            this.lblOlayYeri = new DevExpress.XtraEditors.LabelControl();
            this.txtOlayYeri = new ETS.OzelKontrol.BetsLookUpEdit();
            this.txtOlayDurumu = new ETS.OzelKontrol.BetsLookUpEdit();
            this.lblOlayDurumu = new DevExpress.XtraEditors.LabelControl();
            this.txtPersonel = new ETS.OzelKontrol.BetsLookUpEdit();
            this.txtGuvenlikNoOncelikDerecesi = new ETS.OzelKontrol.BetsLookUpEdit();
            this.txtGizlilikDerecesi = new ETS.OzelKontrol.BetsLookUpEdit();
            this.txtEvrakiCikaranMakam = new ETS.OzelKontrol.BetsLookUpEdit();
            this.chkDurum = new DevExpress.XtraEditors.CheckButton();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtDosyaNoKonusu = new DevExpress.XtraEditors.MemoEdit();
            this.lblGuvenlikNoOncelikDerecesi = new DevExpress.XtraEditors.LabelControl();
            this.lblGizlilikDerecesi = new DevExpress.XtraEditors.LabelControl();
            this.lblGonderildigiMakam = new DevExpress.XtraEditors.LabelControl();
            this.lblEvrakiCikaranMakam = new DevExpress.XtraEditors.LabelControl();
            this.lblDurum = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.txtTarihTSG = new DevExpress.XtraEditors.DateEdit();
            this.lblDosyaNoKonusu = new DevExpress.XtraEditors.LabelControl();
            this.lblTarihTSG = new DevExpress.XtraEditors.LabelControl();
            this.txtEvrakSonTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtEvrakKayitTarihi = new DevExpress.XtraEditors.DateEdit();
            this.lblEvrakKayitTarihi = new DevExpress.XtraEditors.LabelControl();
            this.btnDuzenlemeIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenlemeKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniGelenEvrakGonder = new DevExpress.XtraEditors.SimpleButton();
            this.lblEvrakSuresi = new DevExpress.XtraEditors.LabelControl();
            this.txtEvrakKayitNo = new DevExpress.XtraEditors.TextEdit();
            this.lblEvrakKayitNo = new DevExpress.XtraEditors.LabelControl();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grpcYeniGelenEvrak)).BeginInit();
            this.grpcYeniGelenEvrak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOlayYeri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOlayDurumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuvenlikNoOncelikDerecesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGizlilikDerecesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakiCikaranMakam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDosyaNoKonusu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihTSG.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihTSG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakSonTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakSonTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakKayitTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakKayitTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakKayitNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpcYeniGelenEvrak
            // 
            this.grpcYeniGelenEvrak.Controls.Add(this.lblOlayYeri);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtOlayYeri);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtOlayDurumu);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblOlayDurumu);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtPersonel);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtGuvenlikNoOncelikDerecesi);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtGizlilikDerecesi);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtEvrakiCikaranMakam);
            this.grpcYeniGelenEvrak.Controls.Add(this.chkDurum);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtAciklama);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtDosyaNoKonusu);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblGuvenlikNoOncelikDerecesi);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblGizlilikDerecesi);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblGonderildigiMakam);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblEvrakiCikaranMakam);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblDurum);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblAciklama);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtTarihTSG);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblDosyaNoKonusu);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblTarihTSG);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtEvrakSonTarihi);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtEvrakKayitTarihi);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblEvrakKayitTarihi);
            this.grpcYeniGelenEvrak.Controls.Add(this.btnDuzenlemeIptal);
            this.grpcYeniGelenEvrak.Controls.Add(this.btnDuzenlemeKaydet);
            this.grpcYeniGelenEvrak.Controls.Add(this.btnYeniGelenEvrakGonder);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblEvrakSuresi);
            this.grpcYeniGelenEvrak.Controls.Add(this.txtEvrakKayitNo);
            this.grpcYeniGelenEvrak.Controls.Add(this.lblEvrakKayitNo);
            this.grpcYeniGelenEvrak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpcYeniGelenEvrak.Location = new System.Drawing.Point(0, 0);
            this.grpcYeniGelenEvrak.Name = "grpcYeniGelenEvrak";
            this.grpcYeniGelenEvrak.Size = new System.Drawing.Size(657, 464);
            this.grpcYeniGelenEvrak.TabIndex = 0;
            this.grpcYeniGelenEvrak.Text = "Gelen Evrak";
            // 
            // lblOlayYeri
            // 
            this.lblOlayYeri.Location = new System.Drawing.Point(9, 404);
            this.lblOlayYeri.Name = "lblOlayYeri";
            this.lblOlayYeri.Size = new System.Drawing.Size(64, 13);
            this.lblOlayYeri.TabIndex = 14;
            this.lblOlayYeri.Text = "Köy / Mahalle";
            // 
            // txtOlayYeri
            // 
            this.txtOlayYeri.Location = new System.Drawing.Point(166, 401);
            this.txtOlayYeri.Name = "txtOlayYeri";
            this.txtOlayYeri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtOlayYeri.Properties.DisplayMember = "Makam";
            this.txtOlayYeri.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtOlayYeri.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtOlayYeri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtOlayYeri.Properties.ValueMember = "Id";
            this.txtOlayYeri.Size = new System.Drawing.Size(187, 20);
            this.txtOlayYeri.TabIndex = 12;
            this.txtOlayYeri.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.txtOlayYeri_ProcessNewValue);
            // 
            // txtOlayDurumu
            // 
            this.txtOlayDurumu.Location = new System.Drawing.Point(166, 348);
            this.txtOlayDurumu.Name = "txtOlayDurumu";
            this.txtOlayDurumu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtOlayDurumu.Properties.DisplayMember = "Durum";
            this.txtOlayDurumu.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtOlayDurumu.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtOlayDurumu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtOlayDurumu.Properties.ValueMember = "Id";
            this.txtOlayDurumu.Size = new System.Drawing.Size(187, 20);
            this.txtOlayDurumu.TabIndex = 10;
            this.txtOlayDurumu.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.txtOlayDurumu_ProcessNewValue);
            // 
            // lblOlayDurumu
            // 
            this.lblOlayDurumu.Location = new System.Drawing.Point(9, 351);
            this.lblOlayDurumu.Name = "lblOlayDurumu";
            this.lblOlayDurumu.Size = new System.Drawing.Size(62, 13);
            this.lblOlayDurumu.TabIndex = 11;
            this.lblOlayDurumu.Text = "Olay Durumu";
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(166, 252);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPersonel.Properties.DisplayMember = "Makam";
            this.txtPersonel.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtPersonel.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtPersonel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtPersonel.Properties.ValueMember = "Id";
            this.txtPersonel.Size = new System.Drawing.Size(187, 20);
            this.txtPersonel.TabIndex = 8;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Lütfen bir gönderildiği makam seçiniz.";
            this.validationProvider.SetValidationRule(this.txtPersonel, conditionValidationRule1);
            // 
            // txtGuvenlikNoOncelikDerecesi
            // 
            this.txtGuvenlikNoOncelikDerecesi.Location = new System.Drawing.Point(166, 226);
            this.txtGuvenlikNoOncelikDerecesi.Name = "txtGuvenlikNoOncelikDerecesi";
            this.txtGuvenlikNoOncelikDerecesi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGuvenlikNoOncelikDerecesi.Properties.DisplayMember = "Makam";
            this.txtGuvenlikNoOncelikDerecesi.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtGuvenlikNoOncelikDerecesi.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtGuvenlikNoOncelikDerecesi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtGuvenlikNoOncelikDerecesi.Properties.ValueMember = "Id";
            this.txtGuvenlikNoOncelikDerecesi.Size = new System.Drawing.Size(187, 20);
            this.txtGuvenlikNoOncelikDerecesi.TabIndex = 7;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Lütfen güvenlik no öncelik seçiniz.";
            this.validationProvider.SetValidationRule(this.txtGuvenlikNoOncelikDerecesi, conditionValidationRule2);
            this.txtGuvenlikNoOncelikDerecesi.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.txtGuvenlikNoOncelikDerecesi_ProcessNewValue);
            // 
            // txtGizlilikDerecesi
            // 
            this.txtGizlilikDerecesi.Location = new System.Drawing.Point(166, 200);
            this.txtGizlilikDerecesi.Name = "txtGizlilikDerecesi";
            this.txtGizlilikDerecesi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGizlilikDerecesi.Properties.DisplayMember = "Makam";
            this.txtGizlilikDerecesi.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtGizlilikDerecesi.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtGizlilikDerecesi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtGizlilikDerecesi.Properties.ValueMember = "Id";
            this.txtGizlilikDerecesi.Size = new System.Drawing.Size(187, 20);
            this.txtGizlilikDerecesi.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Lütfen bir gizlilik derecesi seçiniz.";
            this.validationProvider.SetValidationRule(this.txtGizlilikDerecesi, conditionValidationRule3);
            this.txtGizlilikDerecesi.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.txtGizlilikDerecesi_ProcessNewValue);
            // 
            // txtEvrakiCikaranMakam
            // 
            this.txtEvrakiCikaranMakam.Location = new System.Drawing.Point(166, 78);
            this.txtEvrakiCikaranMakam.Name = "txtEvrakiCikaranMakam";
            this.txtEvrakiCikaranMakam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEvrakiCikaranMakam.Properties.DisplayMember = "Makam";
            this.txtEvrakiCikaranMakam.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtEvrakiCikaranMakam.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtEvrakiCikaranMakam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtEvrakiCikaranMakam.Properties.ValueMember = "Id";
            this.txtEvrakiCikaranMakam.Size = new System.Drawing.Size(187, 20);
            this.txtEvrakiCikaranMakam.TabIndex = 3;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Lütfen bir evrakı çkartan makam seçiniz.";
            this.validationProvider.SetValidationRule(this.txtEvrakiCikaranMakam, conditionValidationRule4);
            this.txtEvrakiCikaranMakam.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.txtEvrakiCikaranMakam_ProcessNewValue);
            // 
            // chkDurum
            // 
            this.chkDurum.AllowFocus = false;
            this.chkDurum.Location = new System.Drawing.Point(166, 428);
            this.chkDurum.Name = "chkDurum";
            this.chkDurum.Size = new System.Drawing.Size(75, 23);
            this.chkDurum.TabIndex = 13;
            this.chkDurum.Text = "Bekliyor";
            this.chkDurum.CheckedChanged += new System.EventHandler(this.chkDurum_CheckedChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(166, 280);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(383, 62);
            this.txtAciklama.TabIndex = 9;
            this.txtAciklama.UseOptimizedRendering = true;
            // 
            // txtDosyaNoKonusu
            // 
            this.txtDosyaNoKonusu.Location = new System.Drawing.Point(166, 130);
            this.txtDosyaNoKonusu.Name = "txtDosyaNoKonusu";
            this.txtDosyaNoKonusu.Size = new System.Drawing.Size(383, 64);
            this.txtDosyaNoKonusu.TabIndex = 5;
            this.txtDosyaNoKonusu.UseOptimizedRendering = true;
            // 
            // lblGuvenlikNoOncelikDerecesi
            // 
            this.lblGuvenlikNoOncelikDerecesi.Location = new System.Drawing.Point(9, 229);
            this.lblGuvenlikNoOncelikDerecesi.Name = "lblGuvenlikNoOncelikDerecesi";
            this.lblGuvenlikNoOncelikDerecesi.Size = new System.Drawing.Size(137, 13);
            this.lblGuvenlikNoOncelikDerecesi.TabIndex = 5;
            this.lblGuvenlikNoOncelikDerecesi.Text = "Güvenlik No Öncelik Derecesi";
            // 
            // lblGizlilikDerecesi
            // 
            this.lblGizlilikDerecesi.Location = new System.Drawing.Point(9, 202);
            this.lblGizlilikDerecesi.Name = "lblGizlilikDerecesi";
            this.lblGizlilikDerecesi.Size = new System.Drawing.Size(71, 13);
            this.lblGizlilikDerecesi.TabIndex = 5;
            this.lblGizlilikDerecesi.Text = "Gizlilik Derecesi";
            // 
            // lblGonderildigiMakam
            // 
            this.lblGonderildigiMakam.Location = new System.Drawing.Point(10, 258);
            this.lblGonderildigiMakam.Name = "lblGonderildigiMakam";
            this.lblGonderildigiMakam.Size = new System.Drawing.Size(41, 13);
            this.lblGonderildigiMakam.TabIndex = 5;
            this.lblGonderildigiMakam.Text = "Personel";
            // 
            // lblEvrakiCikaranMakam
            // 
            this.lblEvrakiCikaranMakam.Location = new System.Drawing.Point(9, 81);
            this.lblEvrakiCikaranMakam.Name = "lblEvrakiCikaranMakam";
            this.lblEvrakiCikaranMakam.Size = new System.Drawing.Size(104, 13);
            this.lblEvrakiCikaranMakam.TabIndex = 5;
            this.lblEvrakiCikaranMakam.Text = "Evrakı Çıkaran Makam";
            // 
            // lblDurum
            // 
            this.lblDurum.Location = new System.Drawing.Point(10, 435);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(31, 13);
            this.lblDurum.TabIndex = 3;
            this.lblDurum.Text = "Durum";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(9, 283);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(41, 13);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtTarihTSG
            // 
            this.txtTarihTSG.EditValue = null;
            this.txtTarihTSG.Location = new System.Drawing.Point(166, 104);
            this.txtTarihTSG.Name = "txtTarihTSG";
            this.txtTarihTSG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarihTSG.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarihTSG.Size = new System.Drawing.Size(187, 20);
            this.txtTarihTSG.TabIndex = 4;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Lütfen evrakın tarihini giriniz.";
            this.validationProvider.SetValidationRule(this.txtTarihTSG, conditionValidationRule5);
            // 
            // lblDosyaNoKonusu
            // 
            this.lblDosyaNoKonusu.Location = new System.Drawing.Point(9, 130);
            this.lblDosyaNoKonusu.Name = "lblDosyaNoKonusu";
            this.lblDosyaNoKonusu.Size = new System.Drawing.Size(122, 13);
            this.lblDosyaNoKonusu.TabIndex = 3;
            this.lblDosyaNoKonusu.Text = "Evrakın Dosya No Konusu";
            // 
            // lblTarihTSG
            // 
            this.lblTarihTSG.Location = new System.Drawing.Point(9, 107);
            this.lblTarihTSG.Name = "lblTarihTSG";
            this.lblTarihTSG.Size = new System.Drawing.Size(64, 13);
            this.lblTarihTSG.TabIndex = 3;
            this.lblTarihTSG.Text = "Evrakın Tarihi";
            // 
            // txtEvrakSonTarihi
            // 
            this.txtEvrakSonTarihi.EditValue = null;
            this.txtEvrakSonTarihi.Location = new System.Drawing.Point(166, 375);
            this.txtEvrakSonTarihi.Name = "txtEvrakSonTarihi";
            this.txtEvrakSonTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEvrakSonTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEvrakSonTarihi.Size = new System.Drawing.Size(187, 20);
            this.txtEvrakSonTarihi.TabIndex = 11;
            // 
            // txtEvrakKayitTarihi
            // 
            this.txtEvrakKayitTarihi.EditValue = null;
            this.txtEvrakKayitTarihi.Location = new System.Drawing.Point(166, 52);
            this.txtEvrakKayitTarihi.Name = "txtEvrakKayitTarihi";
            this.txtEvrakKayitTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEvrakKayitTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEvrakKayitTarihi.Properties.Mask.EditMask = "D";
            this.txtEvrakKayitTarihi.Size = new System.Drawing.Size(187, 20);
            this.txtEvrakKayitTarihi.TabIndex = 2;
            // 
            // lblEvrakKayitTarihi
            // 
            this.lblEvrakKayitTarihi.Location = new System.Drawing.Point(9, 55);
            this.lblEvrakKayitTarihi.Name = "lblEvrakKayitTarihi";
            this.lblEvrakKayitTarihi.Size = new System.Drawing.Size(83, 13);
            this.lblEvrakKayitTarihi.TabIndex = 3;
            this.lblEvrakKayitTarihi.Text = "Evrak Kayıt Tarihi";
            // 
            // btnDuzenlemeIptal
            // 
            this.btnDuzenlemeIptal.Location = new System.Drawing.Point(488, 430);
            this.btnDuzenlemeIptal.Name = "btnDuzenlemeIptal";
            this.btnDuzenlemeIptal.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenlemeIptal.TabIndex = 15;
            this.btnDuzenlemeIptal.Text = "Iptal";
            this.btnDuzenlemeIptal.Visible = false;
            this.btnDuzenlemeIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDuzenlemeKaydet
            // 
            this.btnDuzenlemeKaydet.Location = new System.Drawing.Point(569, 430);
            this.btnDuzenlemeKaydet.Name = "btnDuzenlemeKaydet";
            this.btnDuzenlemeKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenlemeKaydet.TabIndex = 14;
            this.btnDuzenlemeKaydet.Text = "Kaydet";
            this.btnDuzenlemeKaydet.Visible = false;
            this.btnDuzenlemeKaydet.Click += new System.EventHandler(this.btnEvrakKaydet_Click);
            // 
            // btnYeniGelenEvrakGonder
            // 
            this.btnYeniGelenEvrakGonder.Location = new System.Drawing.Point(569, 430);
            this.btnYeniGelenEvrakGonder.Name = "btnYeniGelenEvrakGonder";
            this.btnYeniGelenEvrakGonder.Size = new System.Drawing.Size(75, 23);
            this.btnYeniGelenEvrakGonder.TabIndex = 14;
            this.btnYeniGelenEvrakGonder.Text = "Gönder";
            this.btnYeniGelenEvrakGonder.Click += new System.EventHandler(this.btnYeniGelenEvrakGonder_Click);
            // 
            // lblEvrakSuresi
            // 
            this.lblEvrakSuresi.Location = new System.Drawing.Point(9, 377);
            this.lblEvrakSuresi.Name = "lblEvrakSuresi";
            this.lblEvrakSuresi.Size = new System.Drawing.Size(105, 13);
            this.lblEvrakSuresi.TabIndex = 0;
            this.lblEvrakSuresi.Text = "Evrak İşlem Son Tarihi";
            // 
            // txtEvrakKayitNo
            // 
            this.txtEvrakKayitNo.EditValue = "";
            this.txtEvrakKayitNo.Location = new System.Drawing.Point(166, 26);
            this.txtEvrakKayitNo.Name = "txtEvrakKayitNo";
            this.txtEvrakKayitNo.Properties.Mask.EditMask = "f0";
            this.txtEvrakKayitNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEvrakKayitNo.Size = new System.Drawing.Size(187, 20);
            this.txtEvrakKayitNo.TabIndex = 1;
            // 
            // lblEvrakKayitNo
            // 
            this.lblEvrakKayitNo.Location = new System.Drawing.Point(9, 29);
            this.lblEvrakKayitNo.Name = "lblEvrakKayitNo";
            this.lblEvrakKayitNo.Size = new System.Drawing.Size(70, 13);
            this.lblEvrakKayitNo.TabIndex = 0;
            this.lblEvrakKayitNo.Text = "Evrak Kayıt No";
            // 
            // YeniGelenEvrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 464);
            this.Controls.Add(this.grpcYeniGelenEvrak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "YeniGelenEvrak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Gelen Evrak";
            ((System.ComponentModel.ISupportInitialize)(this.grpcYeniGelenEvrak)).EndInit();
            this.grpcYeniGelenEvrak.ResumeLayout(false);
            this.grpcYeniGelenEvrak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOlayYeri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOlayDurumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuvenlikNoOncelikDerecesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGizlilikDerecesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakiCikaranMakam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDosyaNoKonusu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihTSG.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarihTSG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakSonTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakSonTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakKayitTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakKayitTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEvrakKayitNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpcYeniGelenEvrak;
        private DevExpress.XtraEditors.LabelControl lblEvrakKayitNo;
        private DevExpress.XtraEditors.TextEdit txtEvrakKayitNo;
        private DevExpress.XtraEditors.SimpleButton btnYeniGelenEvrakGonder;
        private DevExpress.XtraEditors.LabelControl lblEvrakKayitTarihi;
        private DevExpress.XtraEditors.DateEdit txtEvrakKayitTarihi;
        private DevExpress.XtraEditors.LabelControl lblEvrakiCikaranMakam;
        private DevExpress.XtraEditors.DateEdit txtTarihTSG;
        private DevExpress.XtraEditors.LabelControl lblTarihTSG;
        private DevExpress.XtraEditors.LabelControl lblDosyaNoKonusu;
        private DevExpress.XtraEditors.MemoEdit txtDosyaNoKonusu;
        private DevExpress.XtraEditors.LabelControl lblGizlilikDerecesi;
        private DevExpress.XtraEditors.LabelControl lblGuvenlikNoOncelikDerecesi;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private DevExpress.XtraEditors.CheckButton chkDurum;
        private DevExpress.XtraEditors.LabelControl lblDurum;
        private DevExpress.XtraEditors.DateEdit txtEvrakSonTarihi;
        private DevExpress.XtraEditors.LabelControl lblEvrakSuresi;
        private DevExpress.XtraEditors.LabelControl lblGonderildigiMakam;
        private SimpleButton btnDuzenlemeKaydet;
        private SimpleButton btnDuzenlemeIptal;
        private LabelControl lblOlayDurumu;
        private LabelControl lblOlayYeri;
        private BetsLookUpEdit txtOlayYeri;
        private BetsLookUpEdit txtEvrakiCikaranMakam;
        private BetsLookUpEdit txtPersonel;
        private BetsLookUpEdit txtGuvenlikNoOncelikDerecesi;
        private BetsLookUpEdit txtGizlilikDerecesi;
        private BetsLookUpEdit txtOlayDurumu;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
    }
}