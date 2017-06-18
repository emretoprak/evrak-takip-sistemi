
using ETS.VeriKatmani;

namespace ETS
{
    partial class PersonelYonetimi
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGorevi = new DevExpress.XtraEditors.TextEdit();
            this.txtSicili = new DevExpress.XtraEditors.TextEdit();
            this.txtPTimi = new DevExpress.XtraEditors.TextEdit();
            this.txtPRutbesi = new DevExpress.XtraEditors.TextEdit();
            this.txtPSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdPersonel = new DevExpress.XtraGrid.GridControl();
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.gvPersonel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutbesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSicili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGorevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaslik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaimiArastirmaTutanaklari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaimiArastirmaTutanaklari1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaimiArastirmaTutanaklari2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaimiArastirmaTutanaklari3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZimmetDefteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTamIsim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdSil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPersonelAktifPasif = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDuzenle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDuzenle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtPAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSicili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTimi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPRutbesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPersonelAktifPasif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // colDurum
            // 
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(15, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adı";
            // 
            // txtPAdi
            // 
            this.txtPAdi.Location = new System.Drawing.Point(106, 34);
            this.txtPAdi.Name = "txtPAdi";
            this.txtPAdi.Size = new System.Drawing.Size(158, 20);
            this.txtPAdi.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule1.ErrorText = "Lütfen Bir İsim Giriniz";
            this.dxValidationProvider.SetValidationRule(this.txtPAdi, conditionValidationRule1);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnPersonelEkle);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtGorevi);
            this.groupControl1.Controls.Add(this.txtSicili);
            this.groupControl1.Controls.Add(this.txtPTimi);
            this.groupControl1.Controls.Add(this.txtPRutbesi);
            this.groupControl1.Controls.Add(this.txtPSoyadi);
            this.groupControl1.Controls.Add(this.txtPAdi);
            this.groupControl1.Location = new System.Drawing.Point(641, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(280, 230);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Yeni Personel";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(189, 193);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(189, 193);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelEkle.TabIndex = 5;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 164);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Görevi";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 138);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(19, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Sicili";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(18, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Timi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Rutbesi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Soyadı";
            // 
            // txtGorevi
            // 
            this.txtGorevi.Location = new System.Drawing.Point(106, 164);
            this.txtGorevi.Name = "txtGorevi";
            this.txtGorevi.Size = new System.Drawing.Size(158, 20);
            this.txtGorevi.TabIndex = 4;
            // 
            // txtSicili
            // 
            this.txtSicili.Location = new System.Drawing.Point(106, 138);
            this.txtSicili.Name = "txtSicili";
            this.txtSicili.Size = new System.Drawing.Size(158, 20);
            this.txtSicili.TabIndex = 4;
            // 
            // txtPTimi
            // 
            this.txtPTimi.Location = new System.Drawing.Point(106, 112);
            this.txtPTimi.Name = "txtPTimi";
            this.txtPTimi.Size = new System.Drawing.Size(158, 20);
            this.txtPTimi.TabIndex = 4;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.dxValidationProvider.SetValidationRule(this.txtPTimi, conditionValidationRule2);
            // 
            // txtPRutbesi
            // 
            this.txtPRutbesi.Location = new System.Drawing.Point(106, 86);
            this.txtPRutbesi.Name = "txtPRutbesi";
            this.txtPRutbesi.Size = new System.Drawing.Size(158, 20);
            this.txtPRutbesi.TabIndex = 3;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule3.ErrorText = "Lütfen Bir Rutbe Giriniz";
            this.dxValidationProvider.SetValidationRule(this.txtPRutbesi, conditionValidationRule3);
            // 
            // txtPSoyadi
            // 
            this.txtPSoyadi.Location = new System.Drawing.Point(106, 60);
            this.txtPSoyadi.Name = "txtPSoyadi";
            this.txtPSoyadi.Size = new System.Drawing.Size(158, 20);
            this.txtPSoyadi.TabIndex = 2;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule4.ErrorText = "Lütfen Soyisim Giriniz";
            this.dxValidationProvider.SetValidationRule(this.txtPSoyadi, conditionValidationRule4);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grdPersonel);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(623, 359);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Personel Listesi";
            // 
            // grdPersonel
            // 
            this.grdPersonel.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdPersonel.DataSource = this.entityInstantFeedbackSource1;
            this.grdPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPersonel.Location = new System.Drawing.Point(2, 21);
            this.grdPersonel.MainView = this.gvPersonel;
            this.grdPersonel.Name = "grdPersonel";
            this.grdPersonel.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnPersonelAktifPasif,
            this.btnDuzenle});
            this.grdPersonel.Size = new System.Drawing.Size(619, 336);
            this.grdPersonel.TabIndex = 0;
            this.grdPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPersonel});
            // 
            // entityInstantFeedbackSource1
            // 
            this.entityInstantFeedbackSource1.DefaultSorting = "TamIsim ASC";
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(ETS.VeriKatmani.Personel);
            this.entityInstantFeedbackSource1.KeyExpression = "Id";
            // 
            // gvPersonel
            // 
            this.gvPersonel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi,
            this.colSoyadi,
            this.colRutbesi,
            this.colTim,
            this.colSicili,
            this.colGorevi,
            this.colBaslik,
            this.colDaimiArastirmaTutanaklari,
            this.colDaimiArastirmaTutanaklari1,
            this.colDaimiArastirmaTutanaklari2,
            this.colDaimiArastirmaTutanaklari3,
            this.colZimmetDefteri,
            this.colId,
            this.colTamIsim,
            this.colAdiSoyadi,
            this.grdSil,
            this.colDurum,
            this.colDuzenle});
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colDurum;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition1.Value1 = "1";
            this.gvPersonel.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gvPersonel.GridControl = this.grdPersonel;
            this.gvPersonel.Name = "gvPersonel";
            this.gvPersonel.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvPersonel_CustomDrawCell);
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 122;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 1;
            this.colSoyadi.Width = 122;
            // 
            // colRutbesi
            // 
            this.colRutbesi.Caption = "Rutbesi";
            this.colRutbesi.FieldName = "Rutbesi";
            this.colRutbesi.Name = "colRutbesi";
            this.colRutbesi.Visible = true;
            this.colRutbesi.VisibleIndex = 2;
            this.colRutbesi.Width = 122;
            // 
            // colTim
            // 
            this.colTim.Caption = "Tim";
            this.colTim.FieldName = "Tim";
            this.colTim.Name = "colTim";
            this.colTim.Visible = true;
            this.colTim.VisibleIndex = 3;
            this.colTim.Width = 215;
            // 
            // colSicili
            // 
            this.colSicili.Caption = "Sicili";
            this.colSicili.FieldName = "Sicili";
            this.colSicili.Name = "colSicili";
            this.colSicili.Visible = true;
            this.colSicili.VisibleIndex = 4;
            // 
            // colGorevi
            // 
            this.colGorevi.Caption = "Görevi";
            this.colGorevi.FieldName = "Gorevi";
            this.colGorevi.Name = "colGorevi";
            this.colGorevi.Visible = true;
            this.colGorevi.VisibleIndex = 5;
            // 
            // colBaslik
            // 
            this.colBaslik.FieldName = "Baslik";
            this.colBaslik.Name = "colBaslik";
            // 
            // colDaimiArastirmaTutanaklari
            // 
            this.colDaimiArastirmaTutanaklari.FieldName = "DaimiArastirmaTutanaklari";
            this.colDaimiArastirmaTutanaklari.Name = "colDaimiArastirmaTutanaklari";
            // 
            // colDaimiArastirmaTutanaklari1
            // 
            this.colDaimiArastirmaTutanaklari1.FieldName = "DaimiArastirmaTutanaklari1";
            this.colDaimiArastirmaTutanaklari1.Name = "colDaimiArastirmaTutanaklari1";
            // 
            // colDaimiArastirmaTutanaklari2
            // 
            this.colDaimiArastirmaTutanaklari2.FieldName = "DaimiArastirmaTutanaklari2";
            this.colDaimiArastirmaTutanaklari2.Name = "colDaimiArastirmaTutanaklari2";
            // 
            // colDaimiArastirmaTutanaklari3
            // 
            this.colDaimiArastirmaTutanaklari3.FieldName = "DaimiArastirmaTutanaklari3";
            this.colDaimiArastirmaTutanaklari3.Name = "colDaimiArastirmaTutanaklari3";
            // 
            // colZimmetDefteri
            // 
            this.colZimmetDefteri.FieldName = "ZimmetDefteri";
            this.colZimmetDefteri.Name = "colZimmetDefteri";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colTamIsim
            // 
            this.colTamIsim.FieldName = "TamIsim";
            this.colTamIsim.Name = "colTamIsim";
            // 
            // colAdiSoyadi
            // 
            this.colAdiSoyadi.FieldName = "AdiSoyadi";
            this.colAdiSoyadi.Name = "colAdiSoyadi";
            // 
            // grdSil
            // 
            this.grdSil.Caption = "Aktif";
            this.grdSil.ColumnEdit = this.btnPersonelAktifPasif;
            this.grdSil.Name = "grdSil";
            this.grdSil.Visible = true;
            this.grdSil.VisibleIndex = 6;
            this.grdSil.Width = 46;
            // 
            // btnPersonelAktifPasif
            // 
            this.btnPersonelAktifPasif.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::ETS.Properties.Resources.icoAktifPasif, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnPersonelAktifPasif.Name = "btnPersonelAktifPasif";
            this.btnPersonelAktifPasif.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnPersonelAktifPasif.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnPersonelSil_ButtonClick);
            // 
            // colDuzenle
            // 
            this.colDuzenle.Caption = "Düzenle";
            this.colDuzenle.ColumnEdit = this.btnDuzenle;
            this.colDuzenle.Name = "colDuzenle";
            this.colDuzenle.Visible = true;
            this.colDuzenle.VisibleIndex = 7;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.AutoHeight = false;
            this.btnDuzenle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::ETS.Properties.Resources.icoDuzenle, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // PersonelYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 381);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "PersonelYonetimi";
            this.Text = "Personel Yönetimi";
            ((System.ComponentModel.ISupportInitialize)(this.txtPAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGorevi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSicili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTimi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPRutbesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPersonelAktifPasif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPAdi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPSoyadi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtPRutbesi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtPTimi;
        private DevExpress.XtraEditors.SimpleButton btnPersonelEkle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grdPersonel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPersonel;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colRutbesi;
        private DevExpress.XtraGrid.Columns.GridColumn colTamIsim;
        private DevExpress.XtraGrid.Columns.GridColumn colTim;
        private DevExpress.XtraGrid.Columns.GridColumn colAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colBaslik;
        private DevExpress.XtraGrid.Columns.GridColumn colDaimiArastirmaTutanaklari;
        private DevExpress.XtraGrid.Columns.GridColumn colDaimiArastirmaTutanaklari1;
        private DevExpress.XtraGrid.Columns.GridColumn colDaimiArastirmaTutanaklari2;
        private DevExpress.XtraGrid.Columns.GridColumn colDaimiArastirmaTutanaklari3;
        private DevExpress.XtraGrid.Columns.GridColumn colZimmetDefteri;
        private DevExpress.XtraGrid.Columns.GridColumn grdSil;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPersonelAktifPasif;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colSicili;
        private DevExpress.XtraGrid.Columns.GridColumn colGorevi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtGorevi;
        private DevExpress.XtraEditors.TextEdit txtSicili;
        private DevExpress.XtraGrid.Columns.GridColumn colDuzenle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}