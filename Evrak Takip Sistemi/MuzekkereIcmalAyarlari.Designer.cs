using ETS.OzelKontrol;

namespace ETS
{
    partial class MuzekkereIcmalAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuzekkereIcmalAyarlari));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.btnIcmalleriGoster = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtYil = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKarakol = new DevExpress.XtraEditors.ComboBoxEdit();
            this.validationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtTastikEden = new ETS.OzelKontrol.BetsLookUpEdit();
            this.txtTanzimEden = new ETS.OzelKontrol.BetsLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKarakol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTastikEden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanzimEden.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIcmalleriGoster
            // 
            this.btnIcmalleriGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnIcmalleriGoster.Image")));
            this.btnIcmalleriGoster.Location = new System.Drawing.Point(139, 119);
            this.btnIcmalleriGoster.Name = "btnIcmalleriGoster";
            this.btnIcmalleriGoster.Size = new System.Drawing.Size(187, 36);
            this.btnIcmalleriGoster.TabIndex = 0;
            this.btnIcmalleriGoster.Text = "İcmalleri Göster";
            this.btnIcmalleriGoster.Click += new System.EventHandler(this.btnIcmalleriGoster_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(11, 48);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(55, 13);
            this.labelControl12.TabIndex = 16;
            this.labelControl12.Text = "Tastik Eden";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(11, 22);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(60, 13);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "Tanzim Eden";
            // 
            // txtYil
            // 
            this.txtYil.EditValue = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            this.txtYil.Location = new System.Drawing.Point(139, 67);
            this.txtYil.Name = "txtYil";
            this.txtYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtYil.Properties.MaxValue = new decimal(new int[] {
            2090,
            0,
            0,
            0});
            this.txtYil.Properties.MinValue = new decimal(new int[] {
            1974,
            0,
            0,
            0});
            this.txtYil.Size = new System.Drawing.Size(187, 20);
            this.txtYil.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(10, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Yıl";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Karakol";
            // 
            // txtKarakol
            // 
            this.txtKarakol.Location = new System.Drawing.Point(139, 93);
            this.txtKarakol.Name = "txtKarakol";
            this.txtKarakol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtKarakol.Properties.Items.AddRange(new object[] {
            "Hepsi",
            "Merkez",
            "Kemer"});
            this.txtKarakol.Size = new System.Drawing.Size(187, 20);
            this.txtKarakol.TabIndex = 21;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Lütfen karakol seçimi yapınız.";
            this.validationProvider.SetValidationRule(this.txtKarakol, conditionValidationRule1);
            // 
            // txtTastikEden
            // 
            this.txtTastikEden.Location = new System.Drawing.Point(139, 41);
            this.txtTastikEden.Name = "txtTastikEden";
            this.txtTastikEden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTastikEden.Properties.DisplayMember = "Makam";
            this.txtTastikEden.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtTastikEden.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtTastikEden.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTastikEden.Properties.ValueMember = "Id";
            this.txtTastikEden.Size = new System.Drawing.Size(187, 20);
            this.txtTastikEden.TabIndex = 19;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Lütfen tastik eden personeli seçiniz.";
            this.validationProvider.SetValidationRule(this.txtTastikEden, conditionValidationRule2);
            // 
            // txtTanzimEden
            // 
            this.txtTanzimEden.Location = new System.Drawing.Point(139, 15);
            this.txtTanzimEden.Name = "txtTanzimEden";
            this.txtTanzimEden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTanzimEden.Properties.DisplayMember = "Makam";
            this.txtTanzimEden.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtTanzimEden.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtTanzimEden.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtTanzimEden.Properties.ValueMember = "Id";
            this.txtTanzimEden.Size = new System.Drawing.Size(187, 20);
            this.txtTanzimEden.TabIndex = 18;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Lütfen tanzim eden personeli seçiniz.";
            this.validationProvider.SetValidationRule(this.txtTanzimEden, conditionValidationRule3);
            // 
            // MuzekkereIcmalAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 165);
            this.Controls.Add(this.txtKarakol);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtTastikEden);
            this.Controls.Add(this.txtTanzimEden);
            this.Controls.Add(this.btnIcmalleriGoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MuzekkereIcmalAyarlari";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "İcmal Ayarları";
            this.Load += new System.EventHandler(this.MuzekkereIcmalAyarlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKarakol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTastikEden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanzimEden.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnIcmalleriGoster;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private OzelKontrol.BetsLookUpEdit txtTastikEden;
        private OzelKontrol.BetsLookUpEdit txtTanzimEden;
        private DevExpress.XtraEditors.SpinEdit txtYil;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit txtKarakol;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validationProvider;
    }
}