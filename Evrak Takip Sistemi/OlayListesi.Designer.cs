
using ETS.VeriKatmani;

namespace ETS
{
    partial class OlayListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OlayListesi));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCikti = new DevExpress.XtraBars.BarButtonItem();
            this.btnUstYaziDegisiklerle = new DevExpress.XtraBars.BarButtonItem();
            this.btnTopluDuzenle = new DevExpress.XtraBars.BarButtonItem();
            this.btnYazdirmaGoruntule = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelCiktisiAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdfCiktisiAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridiYenile = new DevExpress.XtraBars.BarButtonItem();
            this.btnZamaniGelenT = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.rPageTutanaklar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grdOlaylar = new DevExpress.XtraGrid.GridControl();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.grdVOlaylar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSuclar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOlayTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOlaySorusturmaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaimiAramaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaimiAramaKarariTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZamanAsimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOzet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriyotYili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOlayYerleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriyotlar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersonel3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuzenle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDuzenle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGidenEvraklarYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.btnGidenEvraklarExcelCiktiAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnGidenEvraklarPdfCiktiAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnGidenEvraklarYazdirmaGoruntule = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOlaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVOlaylar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).BeginInit();
            this.SuspendLayout();
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durum";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.OptionsColumn.AllowEdit = false;
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 14;
            this.colDurum.Width = 68;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnCikti,
            this.btnUstYaziDegisiklerle,
            this.btnTopluDuzenle,
            this.btnYazdirmaGoruntule,
            this.btnExcelCiktisiAl,
            this.btnPdfCiktisiAl,
            this.btnGridiYenile,
            this.btnZamaniGelenT,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.Size = new System.Drawing.Size(1000, 142);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnCikti
            // 
            this.btnCikti.Caption = "Üst Yazı";
            this.btnCikti.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCikti.Glyph")));
            this.btnCikti.Id = 1;
            this.btnCikti.Name = "btnCikti";
            this.btnCikti.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCikti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCikti_ItemClick);
            // 
            // btnUstYaziDegisiklerle
            // 
            this.btnUstYaziDegisiklerle.Caption = "Üst Yazı (Değişikliklerle)";
            this.btnUstYaziDegisiklerle.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUstYaziDegisiklerle.Glyph")));
            this.btnUstYaziDegisiklerle.Id = 2;
            this.btnUstYaziDegisiklerle.Name = "btnUstYaziDegisiklerle";
            this.btnUstYaziDegisiklerle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnUstYaziDegisiklerle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUstYaziDegisiklerle_ItemClick);
            // 
            // btnTopluDuzenle
            // 
            this.btnTopluDuzenle.Caption = "Seçili Kolonu Toplu Düzenle";
            this.btnTopluDuzenle.Glyph = global::ETS.Properties.Resources.icoTopluDegistirme;
            this.btnTopluDuzenle.Id = 3;
            this.btnTopluDuzenle.Name = "btnTopluDuzenle";
            this.btnTopluDuzenle.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTopluDuzenle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTopluDuzenle_ItemClick);
            // 
            // btnYazdirmaGoruntule
            // 
            this.btnYazdirmaGoruntule.Caption = "Yazdırma Görüntüle";
            this.btnYazdirmaGoruntule.Glyph = ((System.Drawing.Image)(resources.GetObject("btnYazdirmaGoruntule.Glyph")));
            this.btnYazdirmaGoruntule.Id = 5;
            this.btnYazdirmaGoruntule.Name = "btnYazdirmaGoruntule";
            this.btnYazdirmaGoruntule.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnYazdirmaGoruntule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYazdirmaGoruntule_ItemClick);
            // 
            // btnExcelCiktisiAl
            // 
            this.btnExcelCiktisiAl.Caption = "Excel Çıktısı Al";
            this.btnExcelCiktisiAl.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExcelCiktisiAl.Glyph")));
            this.btnExcelCiktisiAl.Id = 6;
            this.btnExcelCiktisiAl.Name = "btnExcelCiktisiAl";
            this.btnExcelCiktisiAl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnExcelCiktisiAl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcelCiktisiAl_ItemClick);
            // 
            // btnPdfCiktisiAl
            // 
            this.btnPdfCiktisiAl.Caption = "PDF Çıktısı Al";
            this.btnPdfCiktisiAl.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPdfCiktisiAl.Glyph")));
            this.btnPdfCiktisiAl.Id = 7;
            this.btnPdfCiktisiAl.Name = "btnPdfCiktisiAl";
            this.btnPdfCiktisiAl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPdfCiktisiAl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPdfCiktisiAl_ItemClick);
            // 
            // btnGridiYenile
            // 
            this.btnGridiYenile.Caption = "Yenile";
            this.btnGridiYenile.Glyph = global::ETS.Properties.Resources.icoYenile;
            this.btnGridiYenile.Id = 8;
            this.btnGridiYenile.Name = "btnGridiYenile";
            this.btnGridiYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGridiYenile_ItemClick);
            // 
            // btnZamaniGelenT
            // 
            this.btnZamaniGelenT.Caption = "Zaman Aşımı Gelen Tutanaklar";
            this.btnZamaniGelenT.Glyph = global::ETS.Properties.Resources.icoZamaniGelen;
            this.btnZamaniGelenT.Id = 9;
            this.btnZamaniGelenT.Name = "btnZamaniGelenT";
            this.btnZamaniGelenT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnZamaniGelenT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnZamaniGelenT_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Color = System.Drawing.Color.Blue;
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPageTutanaklar});
            this.ribbonPageCategory1.Text = "Olaylar Listesi İşlemleri";
            // 
            // rPageTutanaklar
            // 
            this.rPageTutanaklar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.rPageTutanaklar.Name = "rPageTutanaklar";
            this.rPageTutanaklar.Text = "Olay Listesi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikti);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUstYaziDegisiklerle);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Yazdırma & Önizleme";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTopluDuzenle);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Yapılandırma";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnYazdirmaGoruntule);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Yazdırma İşlemleri";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnExcelCiktisiAl);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPdfCiktisiAl);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Çıktı Alma";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnZamaniGelenT);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Filtreler";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.btnGridiYenile);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 393);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1000, 27);
            // 
            // grdOlaylar
            // 
            this.grdOlaylar.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdOlaylar.DataSource = this.entityServerModeSource1;
            this.grdOlaylar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOlaylar.Location = new System.Drawing.Point(0, 142);
            this.grdOlaylar.MainView = this.grdVOlaylar;
            this.grdOlaylar.MenuManager = this.ribbonControl1;
            this.grdOlaylar.Name = "grdOlaylar";
            this.grdOlaylar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDuzenle,
            this.btnSil});
            this.grdOlaylar.Size = new System.Drawing.Size(1000, 278);
            this.grdOlaylar.TabIndex = 1;
            this.grdOlaylar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdVOlaylar});
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "OlayTarihi ASC";
            this.entityServerModeSource1.ElementType = typeof(ETS.VeriKatmani.DaimiArastirmaTutanaklari);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // grdVOlaylar
            // 
            this.grdVOlaylar.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdVOlaylar.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grdVOlaylar.Appearance.TopNewRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdVOlaylar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSuclar,
            this.colOlayTarihi,
            this.colOlaySorusturmaNo,
            this.colDaimiAramaNo,
            this.colDaimiAramaKarariTarihi,
            this.colZamanAsimi,
            this.colOzet,
            this.colPeriyotYili,
            this.colOlayYerleri,
            this.colPeriyotlar,
            this.colPersonel,
            this.colPersonel1,
            this.colPersonel2,
            this.colPersonel3,
            this.colDurum,
            this.colDuzenle,
            this.colSil,
            this.colId});
            this.grdVOlaylar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.grdVOlaylar.GridControl = this.grdOlaylar;
            this.grdVOlaylar.Name = "grdVOlaylar";
            this.grdVOlaylar.OptionsBehavior.AllowIncrementalSearch = true;
            this.grdVOlaylar.OptionsDetail.EnableDetailToolTip = true;
            this.grdVOlaylar.OptionsFind.AlwaysVisible = true;
            this.grdVOlaylar.OptionsPrint.ExpandAllDetails = true;
            this.grdVOlaylar.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdVOlaylar.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grdVOlaylar.OptionsSelection.InvertSelection = true;
            this.grdVOlaylar.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDurum, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdVOlaylar.Click += new System.EventHandler(this.grdVOlaylar_Click);
            // 
            // colSuclar
            // 
            this.colSuclar.Caption = "Suç";
            this.colSuclar.FieldName = "Suclar.Suc";
            this.colSuclar.Name = "colSuclar";
            this.colSuclar.OptionsColumn.AllowEdit = false;
            this.colSuclar.Visible = true;
            this.colSuclar.VisibleIndex = 0;
            this.colSuclar.Width = 50;
            // 
            // colOlayTarihi
            // 
            this.colOlayTarihi.Caption = "Olay Tarihi";
            this.colOlayTarihi.FieldName = "OlayTarihi";
            this.colOlayTarihi.Name = "colOlayTarihi";
            this.colOlayTarihi.OptionsColumn.AllowEdit = false;
            this.colOlayTarihi.Visible = true;
            this.colOlayTarihi.VisibleIndex = 3;
            this.colOlayTarihi.Width = 46;
            // 
            // colOlaySorusturmaNo
            // 
            this.colOlaySorusturmaNo.Caption = "Soruşturma No";
            this.colOlaySorusturmaNo.FieldName = "OlaySorusturmaNo";
            this.colOlaySorusturmaNo.Name = "colOlaySorusturmaNo";
            this.colOlaySorusturmaNo.OptionsColumn.AllowEdit = false;
            this.colOlaySorusturmaNo.Visible = true;
            this.colOlaySorusturmaNo.VisibleIndex = 4;
            this.colOlaySorusturmaNo.Width = 46;
            // 
            // colDaimiAramaNo
            // 
            this.colDaimiAramaNo.Caption = "Arama No";
            this.colDaimiAramaNo.FieldName = "DaimiAramaNo";
            this.colDaimiAramaNo.Name = "colDaimiAramaNo";
            this.colDaimiAramaNo.OptionsColumn.AllowEdit = false;
            this.colDaimiAramaNo.Visible = true;
            this.colDaimiAramaNo.VisibleIndex = 5;
            this.colDaimiAramaNo.Width = 46;
            // 
            // colDaimiAramaKarariTarihi
            // 
            this.colDaimiAramaKarariTarihi.Caption = "Arama Karar Tarihi";
            this.colDaimiAramaKarariTarihi.FieldName = "DaimiAramaKarariTarihi";
            this.colDaimiAramaKarariTarihi.Name = "colDaimiAramaKarariTarihi";
            this.colDaimiAramaKarariTarihi.OptionsColumn.AllowEdit = false;
            this.colDaimiAramaKarariTarihi.Visible = true;
            this.colDaimiAramaKarariTarihi.VisibleIndex = 6;
            this.colDaimiAramaKarariTarihi.Width = 46;
            // 
            // colZamanAsimi
            // 
            this.colZamanAsimi.FieldName = "ZamanAsimi";
            this.colZamanAsimi.Name = "colZamanAsimi";
            this.colZamanAsimi.OptionsColumn.AllowEdit = false;
            this.colZamanAsimi.Visible = true;
            this.colZamanAsimi.VisibleIndex = 7;
            this.colZamanAsimi.Width = 46;
            // 
            // colOzet
            // 
            this.colOzet.Caption = "Özet";
            this.colOzet.FieldName = "Ozet";
            this.colOzet.Name = "colOzet";
            this.colOzet.OptionsColumn.AllowEdit = false;
            this.colOzet.Visible = true;
            this.colOzet.VisibleIndex = 8;
            this.colOzet.Width = 46;
            // 
            // colPeriyotYili
            // 
            this.colPeriyotYili.Caption = "Periyot Yılı";
            this.colPeriyotYili.FieldName = "PeriyotYili";
            this.colPeriyotYili.Name = "colPeriyotYili";
            this.colPeriyotYili.OptionsColumn.AllowEdit = false;
            this.colPeriyotYili.Visible = true;
            this.colPeriyotYili.VisibleIndex = 9;
            this.colPeriyotYili.Width = 46;
            // 
            // colOlayYerleri
            // 
            this.colOlayYerleri.Caption = "Olay Yeri";
            this.colOlayYerleri.FieldName = "OlayYerleri.OlayYeri";
            this.colOlayYerleri.Name = "colOlayYerleri";
            this.colOlayYerleri.OptionsColumn.AllowEdit = false;
            this.colOlayYerleri.Visible = true;
            this.colOlayYerleri.VisibleIndex = 1;
            this.colOlayYerleri.Width = 50;
            // 
            // colPeriyotlar
            // 
            this.colPeriyotlar.Caption = "Periyot";
            this.colPeriyotlar.FieldName = "Periyotlar.Periyot";
            this.colPeriyotlar.Name = "colPeriyotlar";
            this.colPeriyotlar.OptionsColumn.AllowEdit = false;
            this.colPeriyotlar.Visible = true;
            this.colPeriyotlar.VisibleIndex = 2;
            this.colPeriyotlar.Width = 50;
            // 
            // colPersonel
            // 
            this.colPersonel.Caption = "Personel 1";
            this.colPersonel.FieldName = "Personel.AdiSoyadi";
            this.colPersonel.Name = "colPersonel";
            this.colPersonel.OptionsColumn.AllowEdit = false;
            this.colPersonel.Visible = true;
            this.colPersonel.VisibleIndex = 10;
            this.colPersonel.Width = 50;
            // 
            // colPersonel1
            // 
            this.colPersonel1.Caption = "Personel 2";
            this.colPersonel1.FieldName = "Personel1.AdiSoyadi";
            this.colPersonel1.Name = "colPersonel1";
            this.colPersonel1.OptionsColumn.AllowEdit = false;
            this.colPersonel1.Visible = true;
            this.colPersonel1.VisibleIndex = 11;
            this.colPersonel1.Width = 51;
            // 
            // colPersonel2
            // 
            this.colPersonel2.Caption = "Personel 3";
            this.colPersonel2.FieldName = "Personel2.AdiSoyadi";
            this.colPersonel2.Name = "colPersonel2";
            this.colPersonel2.OptionsColumn.AllowEdit = false;
            this.colPersonel2.Visible = true;
            this.colPersonel2.VisibleIndex = 12;
            this.colPersonel2.Width = 57;
            // 
            // colPersonel3
            // 
            this.colPersonel3.Caption = "Personel 4";
            this.colPersonel3.FieldName = "Personel3.AdiSoyadi";
            this.colPersonel3.Name = "colPersonel3";
            this.colPersonel3.OptionsColumn.AllowEdit = false;
            this.colPersonel3.Visible = true;
            this.colPersonel3.VisibleIndex = 13;
            // 
            // colDuzenle
            // 
            this.colDuzenle.Caption = "Düzenle";
            this.colDuzenle.ColumnEdit = this.btnDuzenle;
            this.colDuzenle.Name = "colDuzenle";
            this.colDuzenle.Visible = true;
            this.colDuzenle.VisibleIndex = 15;
            this.colDuzenle.Width = 57;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.AutoHeight = false;
            this.btnDuzenle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::ETS.Properties.Resources.icoDuzenle, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // colSil
            // 
            this.colSil.Caption = "Sil";
            this.colSil.ColumnEdit = this.btnSil;
            this.colSil.Name = "colSil";
            this.colSil.Visible = true;
            this.colSil.VisibleIndex = 16;
            this.colSil.Width = 21;
            // 
            // btnSil
            // 
            this.btnSil.AutoHeight = false;
            this.btnSil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::ETS.Properties.Resources.icoSil, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.btnSil.Name = "btnSil";
            this.btnSil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // btnGidenEvraklarYazdir
            // 
            this.btnGidenEvraklarYazdir.Caption = "Yazdır";
            this.btnGidenEvraklarYazdir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGidenEvraklarYazdir.Glyph")));
            this.btnGidenEvraklarYazdir.Id = 1;
            this.btnGidenEvraklarYazdir.Name = "btnGidenEvraklarYazdir";
            this.btnGidenEvraklarYazdir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem4.Text = "Yazdır";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.btnGidenEvraklarYazdir.SuperTip = superToolTip4;
            // 
            // btnGidenEvraklarExcelCiktiAl
            // 
            this.btnGidenEvraklarExcelCiktiAl.Caption = "Excel Çıktısı Al";
            this.btnGidenEvraklarExcelCiktiAl.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGidenEvraklarExcelCiktiAl.Glyph")));
            this.btnGidenEvraklarExcelCiktiAl.Id = 5;
            this.btnGidenEvraklarExcelCiktiAl.Name = "btnGidenEvraklarExcelCiktiAl";
            this.btnGidenEvraklarExcelCiktiAl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnGidenEvraklarPdfCiktiAl
            // 
            this.btnGidenEvraklarPdfCiktiAl.Caption = "PDF Çıktısı Al";
            this.btnGidenEvraklarPdfCiktiAl.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGidenEvraklarPdfCiktiAl.Glyph")));
            this.btnGidenEvraklarPdfCiktiAl.Id = 6;
            this.btnGidenEvraklarPdfCiktiAl.Name = "btnGidenEvraklarPdfCiktiAl";
            this.btnGidenEvraklarPdfCiktiAl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnGidenEvraklarYazdirmaGoruntule
            // 
            this.btnGidenEvraklarYazdirmaGoruntule.Caption = "Yazdırma Görüntüle";
            this.btnGidenEvraklarYazdirmaGoruntule.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGidenEvraklarYazdirmaGoruntule.Glyph")));
            this.btnGidenEvraklarYazdirmaGoruntule.Id = 10;
            this.btnGidenEvraklarYazdirmaGoruntule.Name = "btnGidenEvraklarYazdirmaGoruntule";
            this.btnGidenEvraklarYazdirmaGoruntule.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Yardım";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yardım";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem3.Text = "Yardım";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Durum \"0\" : Açık (Görünür)\r\nDurum \"1\" : Kapalı A.Tarafından Bilinmeyen";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem1);
            this.barButtonItem1.SuperTip = superToolTip3;
            // 
            // OlayListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 420);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.grdOlaylar);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "OlayListesi";
            this.Text = "Olay Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOlaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVOlaylar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPageTutanaklar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl grdOlaylar;
        private DevExpress.XtraGrid.Views.Grid.GridView grdVOlaylar;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.BarButtonItem btnCikti;
        private DevExpress.XtraGrid.Columns.GridColumn colSuclar;
        private DevExpress.XtraGrid.Columns.GridColumn colOlayTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colOlaySorusturmaNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDaimiAramaNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDaimiAramaKarariTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colZamanAsimi;
        private DevExpress.XtraGrid.Columns.GridColumn colOzet;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriyotYili;
        private DevExpress.XtraGrid.Columns.GridColumn colOlayYerleri;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriyotlar;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel1;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel2;
        private DevExpress.XtraGrid.Columns.GridColumn colPersonel3;
        private DevExpress.XtraBars.BarButtonItem btnUstYaziDegisiklerle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnTopluDuzenle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnYazdirmaGoruntule;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnExcelCiktisiAl;
        private DevExpress.XtraBars.BarButtonItem btnPdfCiktisiAl;
        private DevExpress.XtraGrid.Columns.GridColumn colDuzenle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDuzenle;
        private DevExpress.XtraGrid.Columns.GridColumn colSil;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSil;
        private DevExpress.XtraBars.BarButtonItem btnGridiYenile;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnGidenEvraklarYazdir;
        private DevExpress.XtraBars.BarButtonItem btnGidenEvraklarExcelCiktiAl;
        private DevExpress.XtraBars.BarButtonItem btnGidenEvraklarPdfCiktiAl;
        private DevExpress.XtraBars.BarButtonItem btnGidenEvraklarYazdirmaGoruntule;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnZamaniGelenT;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;

    }
}