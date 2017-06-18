namespace ETS
{
    partial class RaporSecimEkrani
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbRaporlar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cmbVeriler = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniRapor = new DevExpress.XtraEditors.SimpleButton();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRaporlar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVeriler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbRaporlar);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(385, 61);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Düzenlenecek Rapor";
            // 
            // cmbRaporlar
            // 
            this.cmbRaporlar.Location = new System.Drawing.Point(5, 31);
            this.cmbRaporlar.Name = "cmbRaporlar";
            this.cmbRaporlar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRaporlar.Size = new System.Drawing.Size(375, 20);
            this.cmbRaporlar.TabIndex = 13;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule1.ErrorText = "Lütfen bir seçim yapınız";
            this.dxValidationProvider.SetValidationRule(this.cmbRaporlar, conditionValidationRule1);
            this.cmbRaporlar.SelectedIndexChanged += new System.EventHandler(this.cmbRaporlar_SelectedIndexChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cmbVeriler);
            this.groupControl2.Location = new System.Drawing.Point(12, 79);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(385, 64);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Rapor Verisi";
            // 
            // cmbVeriler
            // 
            this.cmbVeriler.Location = new System.Drawing.Point(5, 31);
            this.cmbVeriler.Name = "cmbVeriler";
            this.cmbVeriler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVeriler.Properties.Items.AddRange(new object[] {
            "Daimi Arama Tutanakları",
            "Gelen Evrak",
            "Giden Evrak",
            "Zimmet Defteri",
            "Gelen Giden Evrak Istatistik",
            "Aylık İcmal",
            "Yıllık İcmal",
            "Yıllık İcmaller",
            "Gelen Giden Evrak Arşiv Sayfa 1",
            "Gelen Giden Evrak Arşiv Sayfa 2",
            "Gelen Giden Evrak Arşiv Sayfa 3"});
            this.cmbVeriler.Size = new System.Drawing.Size(375, 20);
            this.cmbVeriler.TabIndex = 13;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule2.ErrorText = "Lütfen bir seçim yapınız";
            this.dxValidationProvider.SetValidationRule(this.cmbVeriler, conditionValidationRule2);
            this.cmbVeriler.SelectedIndexChanged += new System.EventHandler(this.cmbVeriler_SelectedIndexChanged);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(12, 149);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(385, 23);
            this.btnDuzenle.TabIndex = 13;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniRapor
            // 
            this.btnYeniRapor.Location = new System.Drawing.Point(12, 178);
            this.btnYeniRapor.Name = "btnYeniRapor";
            this.btnYeniRapor.Size = new System.Drawing.Size(385, 23);
            this.btnYeniRapor.TabIndex = 13;
            this.btnYeniRapor.Text = "Yeni Rapor";
            this.btnYeniRapor.Click += new System.EventHandler(this.btnYeniRapor_Click);
            // 
            // RaporSecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 210);
            this.Controls.Add(this.btnYeniRapor);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaporSecimEkrani";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RaporSecimEkrani";
            this.Load += new System.EventHandler(this.RaporSecimEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbRaporlar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbVeriler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbRaporlar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbVeriler;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnYeniRapor;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
    }
}