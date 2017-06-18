using DevExpress.XtraGrid.Views.Grid;
using ETS.VeriKatmani;

namespace ETS
{
    partial class EvrakZimmet
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvrakZimmet));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.colGelenEvrak1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGidenEvrakId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdZimmet = new DevExpress.XtraGrid.GridControl();
            this.entity = new DevExpress.Data.Linq.EntityServerModeSource();
            this.grdVZimmet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZimmetTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEvrakZimmetYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.btnEvrakZimmetExcelCiktiAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnEvrakZimmetPdfCiktiAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnEvrakZimmetYazdirmaGoruntule = new DevExpress.XtraBars.BarButtonItem();
            this.brGridVeriYili = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnYiliUygula = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.rpageGelenEvraklar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnGridiYenile = new DevExpress.XtraBars.BarButtonItem();
            this.btnGelenEvraklarYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.btnGelenEvraklarExcelCiktiAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnGelenEvraklarPdfCiktiAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnGelenEvraklarYazdirmaGoruntule = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdZimmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVZimmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // colGelenEvrak1
            // 
            this.colGelenEvrak1.FieldName = "GelenEvrak1";
            this.colGelenEvrak1.Name = "colGelenEvrak1";
            // 
            // colGidenEvrakId
            // 
            this.colGidenEvrakId.FieldName = "GidenEvrakId";
            this.colGidenEvrakId.Name = "colGidenEvrakId";
            // 
            // grdZimmet
            // 
            this.grdZimmet.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdZimmet.DataSource = this.entity;
            this.grdZimmet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdZimmet.Location = new System.Drawing.Point(0, 142);
            this.grdZimmet.MainView = this.grdVZimmet;
            this.grdZimmet.MenuManager = this.ribbonControl1;
            this.grdZimmet.Name = "grdZimmet";
            this.grdZimmet.Size = new System.Drawing.Size(939, 252);
            this.grdZimmet.TabIndex = 7;
            this.grdZimmet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVZimmet});
            // 
            // entity
            // 
            this.entity.ElementType = typeof(ETS.VeriKatmani.ZimmetDefteri);
            // 
            // grdVZimmet
            // 
            this.grdVZimmet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSiraNo,
            this.colZimmetTarihi,
            this.colEvrakKategori,
            this.colPersonel,
            this.colGidenEvrakId,
            this.colGelenEvrak1,
            this.colId});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.Honeydew;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colGelenEvrak1;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.White;
            styleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.Gainsboro;
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colGidenEvrakId;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.NotEqual;
            this.grdVZimmet.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.grdVZimmet.GridControl = this.grdZimmet;
            this.grdVZimmet.Name = "grdVZimmet";
            this.grdVZimmet.OptionsBehavior.AllowIncrementalSearch = true;
            this.grdVZimmet.OptionsDetail.ShowDetailTabs = false;
            this.grdVZimmet.OptionsFind.AlwaysVisible = true;
            this.grdVZimmet.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdVZimmet.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grdVZimmet.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            this.grdVZimmet.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridView1_MasterRowGetChildList);
            this.grdVZimmet.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView1_MasterRowGetRelationName);
            this.grdVZimmet.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridView1_MasterRowGetRelationCount);
            // 
            // colSiraNo
            // 
            this.colSiraNo.Caption = "Sıra No";
            this.colSiraNo.FieldName = "SiraNo";
            this.colSiraNo.Name = "colSiraNo";
            this.colSiraNo.OptionsColumn.AllowEdit = false;
            this.colSiraNo.Visible = true;
            this.colSiraNo.VisibleIndex = 0;
            this.colSiraNo.Width = 79;
            // 
            // colZimmetTarihi
            // 
            this.colZimmetTarihi.Caption = "Zimmet Tarihi";
            this.colZimmetTarihi.FieldName = "ZimmetTarihi";
            this.colZimmetTarihi.Name = "colZimmetTarihi";
            this.colZimmetTarihi.OptionsColumn.AllowEdit = false;
            this.colZimmetTarihi.Visible = true;
            this.colZimmetTarihi.VisibleIndex = 1;
            this.colZimmetTarihi.Width = 102;
            // 
            // colEvrakKategori
            // 
            this.colEvrakKategori.Caption = "Kategori";
            this.colEvrakKategori.FieldName = "EvrakKategori.Kategori";
            this.colEvrakKategori.Name = "colEvrakKategori";
            this.colEvrakKategori.OptionsColumn.AllowEdit = false;
            this.colEvrakKategori.Visible = true;
            this.colEvrakKategori.VisibleIndex = 2;
            this.colEvrakKategori.Width = 82;
            // 
            // colPersonel
            // 
            this.colPersonel.Caption = "Teslim Alan";
            this.colPersonel.FieldName = "Personel.TamIsim";
            this.colPersonel.Name = "colPersonel";
            this.colPersonel.OptionsColumn.AllowEdit = false;
            this.colPersonel.Visible = true;
            this.colPersonel.VisibleIndex = 3;
            this.colPersonel.Width = 658;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnEvrakZimmetYazdir,
            this.btnEvrakZimmetExcelCiktiAl,
            this.btnEvrakZimmetPdfCiktiAl,
            this.btnEvrakZimmetYazdirmaGoruntule,
            this.brGridVeriYili,
            this.btnYiliUygula,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.ribbonControl1.Size = new System.Drawing.Size(939, 142);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnEvrakZimmetYazdir
            // 
            this.btnEvrakZimmetYazdir.Caption = "Yazdır";
            this.btnEvrakZimmetYazdir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEvrakZimmetYazdir.Glyph")));
            this.btnEvrakZimmetYazdir.Id = 1;
            this.btnEvrakZimmetYazdir.Name = "btnEvrakZimmetYazdir";
            this.btnEvrakZimmetYazdir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem1.Text = "Yazdır";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnEvrakZimmetYazdir.SuperTip = superToolTip1;
            // 
            // btnEvrakZimmetExcelCiktiAl
            // 
            this.btnEvrakZimmetExcelCiktiAl.Caption = "Excel Çıktısı Al";
            this.btnEvrakZimmetExcelCiktiAl.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEvrakZimmetExcelCiktiAl.Glyph")));
            this.btnEvrakZimmetExcelCiktiAl.Id = 5;
            this.btnEvrakZimmetExcelCiktiAl.Name = "btnEvrakZimmetExcelCiktiAl";
            this.btnEvrakZimmetExcelCiktiAl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEvrakZimmetExcelCiktiAl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEvrakZimmetExcelCiktiAl_ItemClick);
            // 
            // btnEvrakZimmetPdfCiktiAl
            // 
            this.btnEvrakZimmetPdfCiktiAl.Caption = "PDF Çıktısı Al";
            this.btnEvrakZimmetPdfCiktiAl.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEvrakZimmetPdfCiktiAl.Glyph")));
            this.btnEvrakZimmetPdfCiktiAl.Id = 6;
            this.btnEvrakZimmetPdfCiktiAl.Name = "btnEvrakZimmetPdfCiktiAl";
            this.btnEvrakZimmetPdfCiktiAl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEvrakZimmetPdfCiktiAl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEvrakZimmetPdfCiktiAl_ItemClick);
            // 
            // btnEvrakZimmetYazdirmaGoruntule
            // 
            this.btnEvrakZimmetYazdirmaGoruntule.Caption = "Yazdırma Görüntüle";
            this.btnEvrakZimmetYazdirmaGoruntule.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEvrakZimmetYazdirmaGoruntule.Glyph")));
            this.btnEvrakZimmetYazdirmaGoruntule.Id = 10;
            this.btnEvrakZimmetYazdirmaGoruntule.Name = "btnEvrakZimmetYazdirmaGoruntule";
            this.btnEvrakZimmetYazdirmaGoruntule.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEvrakZimmetYazdirmaGoruntule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEvrakZimmetYazdirmaGoruntule_ItemClick);
            // 
            // brGridVeriYili
            // 
            this.brGridVeriYili.Caption = "Yıl : ";
            this.brGridVeriYili.Edit = this.repositoryItemSpinEdit1;
            this.brGridVeriYili.Id = 11;
            this.brGridVeriYili.Name = "brGridVeriYili";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Mask.EditMask = "f0";
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // btnYiliUygula
            // 
            this.btnYiliUygula.Caption = "Yılı Uygula";
            this.btnYiliUygula.Glyph = ((System.Drawing.Image)(resources.GetObject("btnYiliUygula.Glyph")));
            this.btnYiliUygula.Id = 12;
            this.btnYiliUygula.Name = "btnYiliUygula";
            this.btnYiliUygula.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYiliUygula_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Al Alll";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpageGelenEvraklar});
            this.ribbonPageCategory1.Text = "Zimmetlenen Evraklar";
            // 
            // rpageGelenEvraklar
            // 
            this.rpageGelenEvraklar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.rpageGelenEvraklar.ImageAlign = DevExpress.Utils.HorzAlignment.Near;
            this.rpageGelenEvraklar.Name = "rpageGelenEvraklar";
            this.rpageGelenEvraklar.Text = "Zimmetlenen Evraklar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.brGridVeriYili);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnYiliUygula);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Ayarlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEvrakZimmetYazdir);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEvrakZimmetYazdirmaGoruntule);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Yazdırma";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEvrakZimmetExcelCiktiAl);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEvrakZimmetPdfCiktiAl);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Çıktı Alma";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.btnGridiYenile);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 367);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(939, 27);
            // 
            // btnGridiYenile
            // 
            this.btnGridiYenile.Caption = "Yenile";
            this.btnGridiYenile.Glyph = global::ETS.Properties.Resources.icoYenile;
            this.btnGridiYenile.Id = 11;
            this.btnGridiYenile.Name = "btnGridiYenile";
            toolTipTitleItem2.Text = "Gridi Yenile";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Tüm verileri yeniden yükle";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem1);
            this.btnGridiYenile.SuperTip = superToolTip2;
            this.btnGridiYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGridiYenile_ItemClick);
            // 
            // btnGelenEvraklarYazdir
            // 
            this.btnGelenEvraklarYazdir.Caption = "Yazdır";
            this.btnGelenEvraklarYazdir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGelenEvraklarYazdir.Glyph")));
            this.btnGelenEvraklarYazdir.Id = 1;
            this.btnGelenEvraklarYazdir.Name = "btnGelenEvraklarYazdir";
            this.btnGelenEvraklarYazdir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem3.Text = "Yazdır";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.btnGelenEvraklarYazdir.SuperTip = superToolTip3;
            // 
            // btnGelenEvraklarExcelCiktiAl
            // 
            this.btnGelenEvraklarExcelCiktiAl.Caption = "Excel Çıktısı Al";
            this.btnGelenEvraklarExcelCiktiAl.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGelenEvraklarExcelCiktiAl.Glyph")));
            this.btnGelenEvraklarExcelCiktiAl.Id = 5;
            this.btnGelenEvraklarExcelCiktiAl.Name = "btnGelenEvraklarExcelCiktiAl";
            this.btnGelenEvraklarExcelCiktiAl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnGelenEvraklarPdfCiktiAl
            // 
            this.btnGelenEvraklarPdfCiktiAl.Caption = "PDF Çıktısı Al";
            this.btnGelenEvraklarPdfCiktiAl.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGelenEvraklarPdfCiktiAl.Glyph")));
            this.btnGelenEvraklarPdfCiktiAl.Id = 6;
            this.btnGelenEvraklarPdfCiktiAl.Name = "btnGelenEvraklarPdfCiktiAl";
            this.btnGelenEvraklarPdfCiktiAl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnGelenEvraklarYazdirmaGoruntule
            // 
            this.btnGelenEvraklarYazdirmaGoruntule.Caption = "Yazdırma Görüntüle";
            this.btnGelenEvraklarYazdirmaGoruntule.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGelenEvraklarYazdirmaGoruntule.Glyph")));
            this.btnGelenEvraklarYazdirmaGoruntule.Id = 10;
            this.btnGelenEvraklarYazdirmaGoruntule.Name = "btnGelenEvraklarYazdirmaGoruntule";
            this.btnGelenEvraklarYazdirmaGoruntule.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = null;
            this.barEditItem1.Id = 1;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // EvrakZimmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 394);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.grdZimmet);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EvrakZimmet";
            this.Text = "Evrak Zimmet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdZimmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVZimmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpageGelenEvraklar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnEvrakZimmetYazdir;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.BarButtonItem btnEvrakZimmetExcelCiktiAl;
        private DevExpress.XtraBars.BarButtonItem btnEvrakZimmetPdfCiktiAl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnEvrakZimmetYazdirmaGoruntule;
        private DevExpress.Data.Linq.EntityServerModeSource entity;
        private DevExpress.XtraGrid.GridControl grdZimmet;
        private GridView grdVZimmet;
        private DevExpress.XtraGrid.Columns.GridColumn colSiraNo;
        private DevExpress.XtraGrid.Columns.GridColumn colZimmetTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakKategori;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnGridiYenile;
        private DevExpress.XtraBars.BarButtonItem btnGelenEvraklarYazdir;
        private DevExpress.XtraBars.BarButtonItem btnGelenEvraklarExcelCiktiAl;
        private DevExpress.XtraBars.BarButtonItem btnGelenEvraklarPdfCiktiAl;
        private DevExpress.XtraBars.BarButtonItem btnGelenEvraklarYazdirmaGoruntule;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colGidenEvrakId;
        private DevExpress.XtraGrid.Columns.GridColumn colGelenEvrak1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarEditItem brGridVeriYili;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraBars.BarButtonItem btnYiliUygula;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}