namespace ETS
{
    partial class TasnifAyarlari
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.txtTasnifBaslik = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTasnifAltBaslik = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTasnifSuc = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTasnifGrup = new DevExpress.XtraEditors.LookUpEdit();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
            this.txtAltBaslik = new DevExpress.XtraEditors.TextEdit();
            this.txtSuc = new DevExpress.XtraEditors.TextEdit();
            this.txtGrup = new DevExpress.XtraEditors.TextEdit();
            this.txtKanunMaddesi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifAltBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifSuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifGrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKanunMaddesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTasnifBaslik
            // 
            this.txtTasnifBaslik.Location = new System.Drawing.Point(56, 38);
            this.txtTasnifBaslik.Name = "txtTasnifBaslik";
            this.txtTasnifBaslik.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTasnifBaslik.Properties.NullText = "Lütfen seçim yapınız";
            this.txtTasnifBaslik.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtTasnifBaslik.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTasnifBaslik.Size = new System.Drawing.Size(270, 20);
            this.txtTasnifBaslik.TabIndex = 0;
            this.txtTasnifBaslik.EditValueChanged += new System.EventHandler(this.txtval1_EditValueChanged);
            // 
            // txtTasnifAltBaslik
            // 
            this.txtTasnifAltBaslik.Enabled = false;
            this.txtTasnifAltBaslik.Location = new System.Drawing.Point(56, 64);
            this.txtTasnifAltBaslik.Name = "txtTasnifAltBaslik";
            this.txtTasnifAltBaslik.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTasnifAltBaslik.Properties.NullText = "Lütfen seçim yapınız";
            this.txtTasnifAltBaslik.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtTasnifAltBaslik.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTasnifAltBaslik.Size = new System.Drawing.Size(270, 20);
            this.txtTasnifAltBaslik.TabIndex = 0;
            this.txtTasnifAltBaslik.EditValueChanged += new System.EventHandler(this.txtval2_EditValueChanged);
            // 
            // txtTasnifSuc
            // 
            this.txtTasnifSuc.Enabled = false;
            this.txtTasnifSuc.Location = new System.Drawing.Point(56, 90);
            this.txtTasnifSuc.Name = "txtTasnifSuc";
            this.txtTasnifSuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTasnifSuc.Properties.NullText = "Lütfen seçim yapınız";
            this.txtTasnifSuc.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtTasnifSuc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTasnifSuc.Size = new System.Drawing.Size(270, 20);
            this.txtTasnifSuc.TabIndex = 0;
            this.txtTasnifSuc.EditValueChanged += new System.EventHandler(this.txtval3_EditValueChanged);
            // 
            // txtTasnifGrup
            // 
            this.txtTasnifGrup.Enabled = false;
            this.txtTasnifGrup.Location = new System.Drawing.Point(56, 116);
            this.txtTasnifGrup.Name = "txtTasnifGrup";
            this.txtTasnifGrup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTasnifGrup.Properties.NullText = "Lütfen seçim yapınız";
            this.txtTasnifGrup.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtTasnifGrup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTasnifGrup.Size = new System.Drawing.Size(270, 20);
            this.txtTasnifGrup.TabIndex = 0;
            this.txtTasnifGrup.EditValueChanged += new System.EventHandler(this.txtval4_EditValueChanged);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(120, 38);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(252, 20);
            this.txtBaslik.TabIndex = 5;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Lütfen bir başlık giriniz";
            this.validationProvider.SetValidationRule(this.txtBaslik, conditionValidationRule4);
            // 
            // txtAltBaslik
            // 
            this.txtAltBaslik.Location = new System.Drawing.Point(120, 64);
            this.txtAltBaslik.Name = "txtAltBaslik";
            this.txtAltBaslik.Size = new System.Drawing.Size(252, 20);
            this.txtAltBaslik.TabIndex = 5;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Lütfen Alt Başlık giriniz";
            this.validationProvider.SetValidationRule(this.txtAltBaslik, conditionValidationRule5);
            // 
            // txtSuc
            // 
            this.txtSuc.Location = new System.Drawing.Point(120, 90);
            this.txtSuc.Name = "txtSuc";
            this.txtSuc.Size = new System.Drawing.Size(252, 20);
            this.txtSuc.TabIndex = 5;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "Lütfen Suç giriniz";
            this.validationProvider.SetValidationRule(this.txtSuc, conditionValidationRule6);
            // 
            // txtGrup
            // 
            this.txtGrup.Location = new System.Drawing.Point(120, 116);
            this.txtGrup.Name = "txtGrup";
            this.txtGrup.Size = new System.Drawing.Size(252, 20);
            this.txtGrup.TabIndex = 5;
            conditionValidationRule1.ErrorText = "Lütfen Grup giriniz";
            this.validationProvider.SetValidationRule(this.txtGrup, conditionValidationRule1);
            // 
            // txtKanunMaddesi
            // 
            this.txtKanunMaddesi.Location = new System.Drawing.Point(120, 142);
            this.txtKanunMaddesi.Name = "txtKanunMaddesi";
            this.txtKanunMaddesi.Size = new System.Drawing.Size(252, 20);
            this.txtKanunMaddesi.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Lütfen Kanun Maddesi giriniz";
            this.validationProvider.SetValidationRule(this.txtKanunMaddesi, conditionValidationRule2);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnIptal);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.txtKanunMaddesi);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.txtGrup);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtSuc);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.txtAltBaslik);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtBaslik);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(384, 202);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Yeni Tasnif Ekle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(297, 168);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(16, 145);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(72, 13);
            this.labelControl12.TabIndex = 4;
            this.labelControl12.Text = "Kanun Maddesi";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(16, 119);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(23, 13);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Grup";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 93);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(17, 13);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Suç";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(101, 145);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(4, 13);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = ":";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(101, 119);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(4, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = ":";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 67);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Alt Başlık";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(101, 93);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(4, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = ":";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(101, 67);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(4, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = ":";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Başlık";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(101, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(4, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = ":";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSil);
            this.groupControl2.Controls.Add(this.btnDuzenle);
            this.groupControl2.Controls.Add(this.txtTasnifBaslik);
            this.groupControl2.Controls.Add(this.txtTasnifAltBaslik);
            this.groupControl2.Controls.Add(this.txtTasnifSuc);
            this.groupControl2.Controls.Add(this.txtTasnifGrup);
            this.groupControl2.Location = new System.Drawing.Point(418, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(337, 202);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Tasnifler";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Enabled = false;
            this.btnDuzenle.Location = new System.Drawing.Point(251, 168);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 6;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(170, 168);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(297, 168);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(216, 168);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // TasnifAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 224);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "TasnifAyarlari";
            this.Text = "Tasnifler";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifAltBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifSuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasnifGrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAltBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKanunMaddesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit txtTasnifBaslik;
        private DevExpress.XtraEditors.LookUpEdit txtTasnifAltBaslik;
        private DevExpress.XtraEditors.LookUpEdit txtTasnifSuc;
        private DevExpress.XtraEditors.LookUpEdit txtTasnifGrup;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAltBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSuc;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtGrup;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtKanunMaddesi;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnIptal;

    }
}