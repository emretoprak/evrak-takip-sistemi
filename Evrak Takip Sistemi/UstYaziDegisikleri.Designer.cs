using ETS.OzelKontrol;

namespace ETS
{
    partial class UstYaziDegisikleri
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
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriyotYili = new DevExpress.XtraEditors.DateEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtBaslik = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnDegisiklikleriUygula = new DevExpress.XtraEditors.SimpleButton();
            this.txtPersonel4 = new BetsLookUpEdit();
            this.txtPersonel3 = new BetsLookUpEdit();
            this.txtPersonel2 = new BetsLookUpEdit();
            this.txtPersonel1 = new BetsLookUpEdit();
            this.grdCAnaBaslik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCUstYaziBaslik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCEkSayisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPeriyot = new BetsLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriyotYili.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriyotYili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriyot.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(13, 17);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(26, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Başlık";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(10, 43);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 13);
            this.labelControl10.TabIndex = 12;
            this.labelControl10.Text = "Periyot Yılı";
            // 
            // txtPeriyotYili
            // 
            this.txtPeriyotYili.EditValue = null;
            this.txtPeriyotYili.Location = new System.Drawing.Point(142, 38);
            this.txtPeriyotYili.Name = "txtPeriyotYili";
            this.txtPeriyotYili.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPeriyotYili.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPeriyotYili.Properties.Mask.EditMask = "yyyy";
            this.txtPeriyotYili.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPeriyotYili.Size = new System.Drawing.Size(218, 20);
            this.txtPeriyotYili.TabIndex = 12;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(10, 69);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(34, 13);
            this.labelControl15.TabIndex = 12;
            this.labelControl15.Text = "Periyot";
            // 
            // txtBaslik
            // 
            this.txtBaslik.EditValue = "Lütfen Seçim Yapınız";
            this.txtBaslik.Location = new System.Drawing.Point(142, 12);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBaslik.Properties.DisplayMember = "AnaBaslik";
            this.txtBaslik.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtBaslik.Properties.ValueMember = "Id";
            this.txtBaslik.Properties.View = this.gridLookUpEdit1View;
            this.txtBaslik.Size = new System.Drawing.Size(218, 20);
            this.txtBaslik.TabIndex = 11;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdCAnaBaslik,
            this.grdCUstYaziBaslik,
            this.grdCPersonel,
            this.grdCEkSayisi});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.Editable = false;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(9, 171);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(50, 13);
            this.labelControl14.TabIndex = 18;
            this.labelControl14.Text = "Personel 4";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(9, 145);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(50, 13);
            this.labelControl13.TabIndex = 19;
            this.labelControl13.Text = "Personel 3";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(9, 119);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(50, 13);
            this.labelControl12.TabIndex = 20;
            this.labelControl12.Text = "Personel 2";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(9, 93);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(50, 13);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Personel 1";
            // 
            // btnDegisiklikleriUygula
            // 
            this.btnDegisiklikleriUygula.Location = new System.Drawing.Point(246, 201);
            this.btnDegisiklikleriUygula.Name = "btnDegisiklikleriUygula";
            this.btnDegisiklikleriUygula.Size = new System.Drawing.Size(114, 23);
            this.btnDegisiklikleriUygula.TabIndex = 26;
            this.btnDegisiklikleriUygula.Text = "Değişiklikleri Uygula";
            this.btnDegisiklikleriUygula.Click += new System.EventHandler(this.btnDegisiklikleriUygula_Click);
            // 
            // txtPersonel4
            // 
            this.txtPersonel4.Location = new System.Drawing.Point(142, 168);
            this.txtPersonel4.Name = "txtPersonel4";
            this.txtPersonel4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPersonel4.Properties.DisplayMember = "Makam";
            this.txtPersonel4.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtPersonel4.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtPersonel4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtPersonel4.Properties.ValueMember = "Id";
            this.txtPersonel4.Size = new System.Drawing.Size(218, 20);
            this.txtPersonel4.TabIndex = 25;
            // 
            // txtPersonel3
            // 
            this.txtPersonel3.Location = new System.Drawing.Point(142, 142);
            this.txtPersonel3.Name = "txtPersonel3";
            this.txtPersonel3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPersonel3.Properties.DisplayMember = "Makam";
            this.txtPersonel3.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtPersonel3.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtPersonel3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtPersonel3.Properties.ValueMember = "Id";
            this.txtPersonel3.Size = new System.Drawing.Size(218, 20);
            this.txtPersonel3.TabIndex = 24;
            // 
            // txtPersonel2
            // 
            this.txtPersonel2.Location = new System.Drawing.Point(142, 116);
            this.txtPersonel2.Name = "txtPersonel2";
            this.txtPersonel2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPersonel2.Properties.DisplayMember = "Makam";
            this.txtPersonel2.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtPersonel2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtPersonel2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtPersonel2.Properties.ValueMember = "Id";
            this.txtPersonel2.Size = new System.Drawing.Size(218, 20);
            this.txtPersonel2.TabIndex = 23;
            // 
            // txtPersonel1
            // 
            this.txtPersonel1.Location = new System.Drawing.Point(142, 90);
            this.txtPersonel1.Name = "txtPersonel1";
            this.txtPersonel1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPersonel1.Properties.DisplayMember = "Makam";
            this.txtPersonel1.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtPersonel1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtPersonel1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtPersonel1.Properties.ValueMember = "Id";
            this.txtPersonel1.Size = new System.Drawing.Size(218, 20);
            this.txtPersonel1.TabIndex = 22;
            // 
            // grdCAnaBaslik
            // 
            this.grdCAnaBaslik.Caption = "Ana Başlik";
            this.grdCAnaBaslik.FieldName = "AnaBaslik";
            this.grdCAnaBaslik.Name = "grdCAnaBaslik";
            this.grdCAnaBaslik.Visible = true;
            this.grdCAnaBaslik.VisibleIndex = 0;
            // 
            // grdCUstYaziBaslik
            // 
            this.grdCUstYaziBaslik.Caption = "Üst Yazı Başlık";
            this.grdCUstYaziBaslik.FieldName = "UstYaziBaslik";
            this.grdCUstYaziBaslik.Name = "grdCUstYaziBaslik";
            this.grdCUstYaziBaslik.Visible = true;
            this.grdCUstYaziBaslik.VisibleIndex = 1;
            // 
            // grdCPersonel
            // 
            this.grdCPersonel.Caption = "Personel";
            this.grdCPersonel.FieldName = "Personel.TamIsim";
            this.grdCPersonel.Name = "grdCPersonel";
            this.grdCPersonel.Visible = true;
            this.grdCPersonel.VisibleIndex = 2;
            // 
            // grdCEkSayisi
            // 
            this.grdCEkSayisi.Caption = "Ek Sayısı";
            this.grdCEkSayisi.FieldName = "EkSayisi";
            this.grdCEkSayisi.Name = "grdCEkSayisi";
            this.grdCEkSayisi.Visible = true;
            this.grdCEkSayisi.VisibleIndex = 3;
            // 
            // txtPeriyot
            // 
            this.txtPeriyot.Location = new System.Drawing.Point(142, 64);
            this.txtPeriyot.Name = "txtPeriyot";
            this.txtPeriyot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPeriyot.Properties.DisplayMember = "Makam";
            this.txtPeriyot.Properties.NullText = "Lütfen Seçim Yapınız";
            this.txtPeriyot.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.txtPeriyot.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtPeriyot.Properties.ValueMember = "Id";
            this.txtPeriyot.Size = new System.Drawing.Size(218, 20);
            this.txtPeriyot.TabIndex = 13;
            // 
            // UstYaziDegisikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(372, 238);
            this.Controls.Add(this.btnDegisiklikleriUygula);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.txtPersonel4);
            this.Controls.Add(this.txtPersonel3);
            this.Controls.Add(this.txtPersonel2);
            this.Controls.Add(this.txtPersonel1);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.txtPeriyotYili);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtPeriyot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UstYaziDegisikleri";
            this.Text = "Tutanak Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriyotYili.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriyotYili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonel1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriyot.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit txtPeriyotYili;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private BetsLookUpEdit txtPeriyot;
        private DevExpress.XtraEditors.GridLookUpEdit txtBaslik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn grdCAnaBaslik;
        private DevExpress.XtraGrid.Columns.GridColumn grdCUstYaziBaslik;
        private DevExpress.XtraGrid.Columns.GridColumn grdCPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn grdCEkSayisi;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private BetsLookUpEdit txtPersonel4;
        private BetsLookUpEdit txtPersonel3;
        private BetsLookUpEdit txtPersonel2;
        private BetsLookUpEdit txtPersonel1;
        private DevExpress.XtraEditors.SimpleButton btnDegisiklikleriUygula;


    }
}