namespace PRO.Win.Global
{
    partial class frmFirmaAdresAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmaAdresAra));
            this.bManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuSec = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.IMG24 = new DevExpress.Utils.ImageCollection();
            this.mnuOzKartGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzKartListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzAnaAdresGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzAnaAdresListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzFaturaGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzFaturaListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzSevkGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzSevkListe = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.gridSevkAdres = new DevExpress.XtraGrid.GridControl();
            this.bsSevkAdres = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.Global.DSGlobal();
            this.gwSevkAdres = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSevkLokasyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkLokasyonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkAdres1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkAdres2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFaturaAdres = new DevExpress.XtraGrid.GridControl();
            this.bsFaturaAdres = new System.Windows.Forms.BindingSource();
            this.gwFaturaAdres = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFaturaLokasyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaLokasyonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaAdres1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaAdres2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAnaAdres = new DevExpress.XtraGrid.GridControl();
            this.bsAnaAdres = new System.Windows.Forms.BindingSource();
            this.gwAnaAdres = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLokasyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLokasyonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridKart = new DevExpress.XtraGrid.GridControl();
            this.bsKart = new System.Windows.Forms.BindingSource();
            this.gwKart = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHesapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKartTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridKart = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyAnaAdres = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyFaturaAdres = new DevExpress.XtraLayout.LayoutControlItem();
            this.lySevkAdres = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtKart = new PRO.Data.Global.DSGlobalTableAdapters.CHK_KartTableAdapter();
            this.dtAnaAdres = new PRO.Data.Global.DSGlobalTableAdapters.V_CHK_Kart_AnaAdresTableAdapter();
            this.dtFaturaAdres = new PRO.Data.Global.DSGlobalTableAdapters.V_CHK_Kart_FaturaAdresTableAdapter();
            this.dtSevkAdres = new PRO.Data.Global.DSGlobalTableAdapters.V_CHK_Kart_SevkAdresTableAdapter();
            this.popupKart = new DevExpress.XtraBars.PopupMenu();
            this.popupAnaAdres = new DevExpress.XtraBars.PopupMenu();
            this.popupFatura = new DevExpress.XtraBars.PopupMenu();
            this.popupSevk = new DevExpress.XtraBars.PopupMenu();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSevkAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSevkAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwSevkAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaturaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFaturaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwFaturaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwAnaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyAnaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupKart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupAnaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupFatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupSevk)).BeginInit();
            this.SuspendLayout();
            // 
            // bManager
            // 
            this.bManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.bManager.DockControls.Add(this.barDockControlTop);
            this.bManager.DockControls.Add(this.barDockControlBottom);
            this.bManager.DockControls.Add(this.barDockControlLeft);
            this.bManager.DockControls.Add(this.barDockControlRight);
            this.bManager.Form = this;
            this.bManager.Images = this.IMG24;
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuSec,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuOzKartGenel,
            this.mnuOzKartListe,
            this.mnuOzAnaAdresGenel,
            this.mnuOzAnaAdresListe,
            this.mnuOzFaturaGenel,
            this.mnuOzFaturaListe,
            this.mnuOzSevkGenel,
            this.mnuOzSevkListe});
            this.bManager.MaxItemId = 12;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSec),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKapat, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // mnuSec
            // 
            this.mnuSec.Caption = "Seç";
            this.mnuSec.Id = 0;
            this.mnuSec.ImageIndex = 1;
            this.mnuSec.Name = "mnuSec";
            this.mnuSec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSec_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 1;
            this.mnuKapat.ImageIndex = 0;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 2;
            this.barSubItem1.ImageIndex = 3;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGorunumKaydet)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnuGorunumKaydet
            // 
            this.mnuGorunumKaydet.Caption = "Görünüm Kaydet";
            this.mnuGorunumKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuGorunumKaydet.Glyph")));
            this.mnuGorunumKaydet.Id = 3;
            this.mnuGorunumKaydet.Name = "mnuGorunumKaydet";
            this.mnuGorunumKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGorunumKaydet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(735, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 426);
            this.barDockControlBottom.Size = new System.Drawing.Size(735, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 387);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(735, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 387);
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "cikis1.png");
            this.IMG24.Images.SetKeyName(1, "Ok.png");
            this.IMG24.Images.SetKeyName(2, "printer70.png");
            this.IMG24.Images.SetKeyName(3, "Settings.png");
            // 
            // mnuOzKartGenel
            // 
            this.mnuOzKartGenel.Caption = "Genel Özellikler";
            this.mnuOzKartGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzKartGenel.Glyph")));
            this.mnuOzKartGenel.Id = 4;
            this.mnuOzKartGenel.Name = "mnuOzKartGenel";
            this.mnuOzKartGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzKartGenel_ItemClick);
            // 
            // mnuOzKartListe
            // 
            this.mnuOzKartListe.Caption = "Liste Özellikler";
            this.mnuOzKartListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzKartListe.Glyph")));
            this.mnuOzKartListe.Id = 5;
            this.mnuOzKartListe.Name = "mnuOzKartListe";
            this.mnuOzKartListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzKartListe_ItemClick);
            // 
            // mnuOzAnaAdresGenel
            // 
            this.mnuOzAnaAdresGenel.Caption = "Genel Özellikler";
            this.mnuOzAnaAdresGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzAnaAdresGenel.Glyph")));
            this.mnuOzAnaAdresGenel.Id = 6;
            this.mnuOzAnaAdresGenel.Name = "mnuOzAnaAdresGenel";
            this.mnuOzAnaAdresGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzAnaAdresGenel_ItemClick);
            // 
            // mnuOzAnaAdresListe
            // 
            this.mnuOzAnaAdresListe.Caption = "Liste Özellikler";
            this.mnuOzAnaAdresListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzAnaAdresListe.Glyph")));
            this.mnuOzAnaAdresListe.Id = 7;
            this.mnuOzAnaAdresListe.Name = "mnuOzAnaAdresListe";
            this.mnuOzAnaAdresListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzAnaAdresListe_ItemClick);
            // 
            // mnuOzFaturaGenel
            // 
            this.mnuOzFaturaGenel.Caption = "Genel Özellikler";
            this.mnuOzFaturaGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzFaturaGenel.Glyph")));
            this.mnuOzFaturaGenel.Id = 8;
            this.mnuOzFaturaGenel.Name = "mnuOzFaturaGenel";
            this.mnuOzFaturaGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzFaturaGenel_ItemClick);
            // 
            // mnuOzFaturaListe
            // 
            this.mnuOzFaturaListe.Caption = "Liste Özellikler";
            this.mnuOzFaturaListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzFaturaListe.Glyph")));
            this.mnuOzFaturaListe.Id = 9;
            this.mnuOzFaturaListe.Name = "mnuOzFaturaListe";
            this.mnuOzFaturaListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzFaturaListe_ItemClick);
            // 
            // mnuOzSevkGenel
            // 
            this.mnuOzSevkGenel.Caption = "Genel Özellikler";
            this.mnuOzSevkGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzSevkGenel.Glyph")));
            this.mnuOzSevkGenel.Id = 10;
            this.mnuOzSevkGenel.Name = "mnuOzSevkGenel";
            this.mnuOzSevkGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzSevkGenel_ItemClick);
            // 
            // mnuOzSevkListe
            // 
            this.mnuOzSevkListe.Caption = "Liste Özellikler";
            this.mnuOzSevkListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzSevkListe.Glyph")));
            this.mnuOzSevkListe.Id = 11;
            this.mnuOzSevkListe.Name = "mnuOzSevkListe";
            this.mnuOzSevkListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzSevkListe_ItemClick);
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.gridSevkAdres);
            this._Layout.Controls.Add(this.gridFaturaAdres);
            this._Layout.Controls.Add(this.gridAnaAdres);
            this._Layout.Controls.Add(this.gridKart);
            this._Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Layout.Location = new System.Drawing.Point(0, 39);
            this._Layout.Name = "_Layout";
            this._Layout.OptionsCustomizationForm.ShowPropertyGrid = true;
            this._Layout.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.CustomSize;
            this._Layout.OptionsSerialization.DiscardOldItems = true;
            this._Layout.OptionsSerialization.RestoreAppearanceItemCaption = true;
            this._Layout.OptionsSerialization.RestoreAppearanceTabPage = true;
            this._Layout.OptionsSerialization.RestoreGroupPadding = true;
            this._Layout.OptionsSerialization.RestoreGroupSpacing = true;
            this._Layout.OptionsSerialization.RestoreLayoutGroupAppearanceGroup = true;
            this._Layout.OptionsSerialization.RestoreLayoutItemPadding = true;
            this._Layout.OptionsSerialization.RestoreLayoutItemSpacing = true;
            this._Layout.OptionsSerialization.RestoreRootGroupPadding = true;
            this._Layout.OptionsSerialization.RestoreRootGroupSpacing = true;
            this._Layout.OptionsSerialization.RestoreTabbedGroupPadding = true;
            this._Layout.OptionsSerialization.RestoreTabbedGroupSpacing = true;
            this._Layout.OptionsSerialization.RestoreTextToControlDistance = true;
            this._Layout.OptionsView.AllowHotTrack = true;
            this._Layout.OptionsView.HighlightFocusedItem = true;
            this._Layout.Root = this.layoutControlGroup1;
            this._Layout.Size = new System.Drawing.Size(735, 387);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // gridSevkAdres
            // 
            this.gridSevkAdres.DataSource = this.bsSevkAdres;
            this.gridSevkAdres.Location = new System.Drawing.Point(369, 247);
            this.gridSevkAdres.MainView = this.gwSevkAdres;
            this.gridSevkAdres.MenuManager = this.bManager;
            this.gridSevkAdres.Name = "gridSevkAdres";
            this.gridSevkAdres.Size = new System.Drawing.Size(354, 128);
            this.gridSevkAdres.TabIndex = 7;
            this.gridSevkAdres.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwSevkAdres});
            // 
            // bsSevkAdres
            // 
            this.bsSevkAdres.DataMember = "V_CHK_Kart_SevkAdres";
            this.bsSevkAdres.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSGlobal";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gwSevkAdres
            // 
            this.gwSevkAdres.ColumnPanelRowHeight = 35;
            this.gwSevkAdres.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSevkLokasyon,
            this.colSevkLokasyonAdi,
            this.colSevkAdres1,
            this.colSevkAdres2,
            this.colSevkSehir,
            this.colSevkIlce,
            this.colSevkSemt});
            this.gwSevkAdres.GridControl = this.gridSevkAdres;
            this.gwSevkAdres.Name = "gwSevkAdres";
            this.gwSevkAdres.OptionsBehavior.Editable = false;
            this.gwSevkAdres.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwSevkAdres.OptionsLayout.Columns.StoreAppearance = true;
            this.gwSevkAdres.OptionsLayout.StoreAllOptions = true;
            this.gwSevkAdres.OptionsLayout.StoreAppearance = true;
            this.gwSevkAdres.OptionsLayout.StoreFormatRules = true;
            this.gwSevkAdres.OptionsView.ColumnAutoWidth = false;
            this.gwSevkAdres.OptionsView.ShowGroupPanel = false;
            this.gwSevkAdres.OptionsView.ShowIndicator = false;
            this.gwSevkAdres.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwSevkAdres_PopupMenuShowing);
            this.gwSevkAdres.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwSevkAdres_FocusedColumnChanged);
            // 
            // colSevkLokasyon
            // 
            this.colSevkLokasyon.AppearanceHeader.Options.UseTextOptions = true;
            this.colSevkLokasyon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkLokasyon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSevkLokasyon.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSevkLokasyon.FieldName = "SevkLokasyon";
            this.colSevkLokasyon.Name = "colSevkLokasyon";
            this.colSevkLokasyon.Visible = true;
            this.colSevkLokasyon.VisibleIndex = 0;
            // 
            // colSevkLokasyonAdi
            // 
            this.colSevkLokasyonAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colSevkLokasyonAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkLokasyonAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSevkLokasyonAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSevkLokasyonAdi.Caption = "Lokasyon Adı";
            this.colSevkLokasyonAdi.FieldName = "SevkLokasyonAdi";
            this.colSevkLokasyonAdi.Name = "colSevkLokasyonAdi";
            this.colSevkLokasyonAdi.Visible = true;
            this.colSevkLokasyonAdi.VisibleIndex = 1;
            // 
            // colSevkAdres1
            // 
            this.colSevkAdres1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSevkAdres1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkAdres1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSevkAdres1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSevkAdres1.FieldName = "SevkAdres1";
            this.colSevkAdres1.Name = "colSevkAdres1";
            this.colSevkAdres1.Visible = true;
            this.colSevkAdres1.VisibleIndex = 2;
            // 
            // colSevkAdres2
            // 
            this.colSevkAdres2.AppearanceHeader.Options.UseTextOptions = true;
            this.colSevkAdres2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkAdres2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSevkAdres2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSevkAdres2.FieldName = "SevkAdres2";
            this.colSevkAdres2.Name = "colSevkAdres2";
            this.colSevkAdres2.Visible = true;
            this.colSevkAdres2.VisibleIndex = 3;
            // 
            // colSevkSehir
            // 
            this.colSevkSehir.AppearanceHeader.Options.UseTextOptions = true;
            this.colSevkSehir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkSehir.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSevkSehir.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSevkSehir.Caption = "Sevk Şehir";
            this.colSevkSehir.FieldName = "SevkSehir";
            this.colSevkSehir.Name = "colSevkSehir";
            this.colSevkSehir.Visible = true;
            this.colSevkSehir.VisibleIndex = 4;
            // 
            // colSevkIlce
            // 
            this.colSevkIlce.AppearanceHeader.Options.UseTextOptions = true;
            this.colSevkIlce.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkIlce.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSevkIlce.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSevkIlce.Caption = "Sevk İlçe";
            this.colSevkIlce.FieldName = "SevkIlce";
            this.colSevkIlce.Name = "colSevkIlce";
            this.colSevkIlce.Visible = true;
            this.colSevkIlce.VisibleIndex = 5;
            // 
            // colSevkSemt
            // 
            this.colSevkSemt.AppearanceHeader.Options.UseTextOptions = true;
            this.colSevkSemt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSevkSemt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSevkSemt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSevkSemt.FieldName = "SevkSemt";
            this.colSevkSemt.Name = "colSevkSemt";
            this.colSevkSemt.Visible = true;
            this.colSevkSemt.VisibleIndex = 6;
            // 
            // gridFaturaAdres
            // 
            this.gridFaturaAdres.DataSource = this.bsFaturaAdres;
            this.gridFaturaAdres.Location = new System.Drawing.Point(12, 247);
            this.gridFaturaAdres.MainView = this.gwFaturaAdres;
            this.gridFaturaAdres.MenuManager = this.bManager;
            this.gridFaturaAdres.Name = "gridFaturaAdres";
            this.gridFaturaAdres.Size = new System.Drawing.Size(353, 128);
            this.gridFaturaAdres.TabIndex = 6;
            this.gridFaturaAdres.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwFaturaAdres});
            // 
            // bsFaturaAdres
            // 
            this.bsFaturaAdres.DataMember = "V_CHK_Kart_FaturaAdres";
            this.bsFaturaAdres.DataSource = this.ds;
            // 
            // gwFaturaAdres
            // 
            this.gwFaturaAdres.ColumnPanelRowHeight = 35;
            this.gwFaturaAdres.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFaturaLokasyon,
            this.colFaturaLokasyonAdi,
            this.colFaturaAdres1,
            this.colFaturaAdres2,
            this.colFaturaSehir,
            this.colFaturaIlce,
            this.colFaturaSemt});
            this.gwFaturaAdres.GridControl = this.gridFaturaAdres;
            this.gwFaturaAdres.Name = "gwFaturaAdres";
            this.gwFaturaAdres.OptionsBehavior.Editable = false;
            this.gwFaturaAdres.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwFaturaAdres.OptionsLayout.Columns.StoreAppearance = true;
            this.gwFaturaAdres.OptionsLayout.StoreAllOptions = true;
            this.gwFaturaAdres.OptionsLayout.StoreAppearance = true;
            this.gwFaturaAdres.OptionsLayout.StoreFormatRules = true;
            this.gwFaturaAdres.OptionsView.ColumnAutoWidth = false;
            this.gwFaturaAdres.OptionsView.ShowGroupPanel = false;
            this.gwFaturaAdres.OptionsView.ShowIndicator = false;
            this.gwFaturaAdres.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwFaturaAdres_PopupMenuShowing);
            this.gwFaturaAdres.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwFaturaAdres_FocusedColumnChanged);
            // 
            // colFaturaLokasyon
            // 
            this.colFaturaLokasyon.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaturaLokasyon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaturaLokasyon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFaturaLokasyon.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFaturaLokasyon.FieldName = "FaturaLokasyon";
            this.colFaturaLokasyon.Name = "colFaturaLokasyon";
            this.colFaturaLokasyon.Visible = true;
            this.colFaturaLokasyon.VisibleIndex = 0;
            // 
            // colFaturaLokasyonAdi
            // 
            this.colFaturaLokasyonAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaturaLokasyonAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaturaLokasyonAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFaturaLokasyonAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFaturaLokasyonAdi.Caption = "Lokasyon Adı";
            this.colFaturaLokasyonAdi.FieldName = "FaturaLokasyonAdi";
            this.colFaturaLokasyonAdi.Name = "colFaturaLokasyonAdi";
            this.colFaturaLokasyonAdi.Visible = true;
            this.colFaturaLokasyonAdi.VisibleIndex = 1;
            // 
            // colFaturaAdres1
            // 
            this.colFaturaAdres1.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaturaAdres1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaturaAdres1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFaturaAdres1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFaturaAdres1.FieldName = "FaturaAdres1";
            this.colFaturaAdres1.Name = "colFaturaAdres1";
            this.colFaturaAdres1.Visible = true;
            this.colFaturaAdres1.VisibleIndex = 2;
            // 
            // colFaturaAdres2
            // 
            this.colFaturaAdres2.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaturaAdres2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaturaAdres2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFaturaAdres2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFaturaAdres2.FieldName = "FaturaAdres2";
            this.colFaturaAdres2.Name = "colFaturaAdres2";
            this.colFaturaAdres2.Visible = true;
            this.colFaturaAdres2.VisibleIndex = 3;
            // 
            // colFaturaSehir
            // 
            this.colFaturaSehir.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaturaSehir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaturaSehir.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFaturaSehir.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFaturaSehir.Caption = "Fatura Şehir";
            this.colFaturaSehir.FieldName = "FaturaSehir";
            this.colFaturaSehir.Name = "colFaturaSehir";
            this.colFaturaSehir.Visible = true;
            this.colFaturaSehir.VisibleIndex = 4;
            // 
            // colFaturaIlce
            // 
            this.colFaturaIlce.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaturaIlce.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaturaIlce.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFaturaIlce.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFaturaIlce.Caption = "Fatura İlçe";
            this.colFaturaIlce.FieldName = "FaturaIlce";
            this.colFaturaIlce.Name = "colFaturaIlce";
            this.colFaturaIlce.Visible = true;
            this.colFaturaIlce.VisibleIndex = 5;
            // 
            // colFaturaSemt
            // 
            this.colFaturaSemt.AppearanceHeader.Options.UseTextOptions = true;
            this.colFaturaSemt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFaturaSemt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFaturaSemt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFaturaSemt.FieldName = "FaturaSemt";
            this.colFaturaSemt.Name = "colFaturaSemt";
            this.colFaturaSemt.Visible = true;
            this.colFaturaSemt.VisibleIndex = 6;
            // 
            // gridAnaAdres
            // 
            this.gridAnaAdres.DataSource = this.bsAnaAdres;
            this.gridAnaAdres.Location = new System.Drawing.Point(369, 35);
            this.gridAnaAdres.MainView = this.gwAnaAdres;
            this.gridAnaAdres.MenuManager = this.bManager;
            this.gridAnaAdres.Name = "gridAnaAdres";
            this.gridAnaAdres.Size = new System.Drawing.Size(354, 185);
            this.gridAnaAdres.TabIndex = 5;
            this.gridAnaAdres.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwAnaAdres});
            // 
            // bsAnaAdres
            // 
            this.bsAnaAdres.DataMember = "V_CHK_Kart_AnaAdres";
            this.bsAnaAdres.DataSource = this.ds;
            // 
            // gwAnaAdres
            // 
            this.gwAnaAdres.ColumnPanelRowHeight = 35;
            this.gwAnaAdres.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLokasyon,
            this.colLokasyonAdi,
            this.colAdres1,
            this.colAdres2,
            this.colSehir,
            this.colIlce,
            this.colSemt});
            this.gwAnaAdres.GridControl = this.gridAnaAdres;
            this.gwAnaAdres.Name = "gwAnaAdres";
            this.gwAnaAdres.OptionsBehavior.Editable = false;
            this.gwAnaAdres.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwAnaAdres.OptionsLayout.Columns.StoreAppearance = true;
            this.gwAnaAdres.OptionsLayout.StoreAllOptions = true;
            this.gwAnaAdres.OptionsLayout.StoreAppearance = true;
            this.gwAnaAdres.OptionsLayout.StoreFormatRules = true;
            this.gwAnaAdres.OptionsView.ColumnAutoWidth = false;
            this.gwAnaAdres.OptionsView.ShowGroupPanel = false;
            this.gwAnaAdres.OptionsView.ShowIndicator = false;
            this.gwAnaAdres.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwAnaAdres_PopupMenuShowing);
            this.gwAnaAdres.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwAnaAdres_FocusedColumnChanged);
            // 
            // colLokasyon
            // 
            this.colLokasyon.AppearanceHeader.Options.UseTextOptions = true;
            this.colLokasyon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLokasyon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colLokasyon.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLokasyon.FieldName = "Lokasyon";
            this.colLokasyon.Name = "colLokasyon";
            this.colLokasyon.Visible = true;
            this.colLokasyon.VisibleIndex = 0;
            // 
            // colLokasyonAdi
            // 
            this.colLokasyonAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colLokasyonAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLokasyonAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colLokasyonAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLokasyonAdi.Caption = "Lokasyon Adı";
            this.colLokasyonAdi.FieldName = "LokasyonAdi";
            this.colLokasyonAdi.Name = "colLokasyonAdi";
            this.colLokasyonAdi.Visible = true;
            this.colLokasyonAdi.VisibleIndex = 1;
            // 
            // colAdres1
            // 
            this.colAdres1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdres1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdres1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colAdres1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAdres1.FieldName = "Adres1";
            this.colAdres1.Name = "colAdres1";
            this.colAdres1.Visible = true;
            this.colAdres1.VisibleIndex = 2;
            // 
            // colAdres2
            // 
            this.colAdres2.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdres2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdres2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colAdres2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAdres2.FieldName = "Adres2";
            this.colAdres2.Name = "colAdres2";
            this.colAdres2.Visible = true;
            this.colAdres2.VisibleIndex = 3;
            // 
            // colSehir
            // 
            this.colSehir.AppearanceHeader.Options.UseTextOptions = true;
            this.colSehir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSehir.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSehir.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSehir.Caption = "Şehir";
            this.colSehir.FieldName = "Sehir";
            this.colSehir.Name = "colSehir";
            this.colSehir.Visible = true;
            this.colSehir.VisibleIndex = 4;
            // 
            // colIlce
            // 
            this.colIlce.AppearanceHeader.Options.UseTextOptions = true;
            this.colIlce.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIlce.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colIlce.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIlce.Caption = "İlçe";
            this.colIlce.FieldName = "Ilce";
            this.colIlce.Name = "colIlce";
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 5;
            // 
            // colSemt
            // 
            this.colSemt.AppearanceHeader.Options.UseTextOptions = true;
            this.colSemt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSemt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSemt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 6;
            // 
            // gridKart
            // 
            this.gridKart.DataSource = this.bsKart;
            this.gridKart.Location = new System.Drawing.Point(12, 35);
            this.gridKart.MainView = this.gwKart;
            this.gridKart.MenuManager = this.bManager;
            this.gridKart.Name = "gridKart";
            this.gridKart.Size = new System.Drawing.Size(353, 185);
            this.gridKart.TabIndex = 4;
            this.gridKart.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwKart});
            // 
            // bsKart
            // 
            this.bsKart.DataMember = "CHK_Kart";
            this.bsKart.DataSource = this.ds;
            // 
            // gwKart
            // 
            this.gwKart.ColumnPanelRowHeight = 35;
            this.gwKart.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHesapKodu,
            this.colHesapAdi,
            this.colKartTipi,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colTel1,
            this.colTel2,
            this.colGsm});
            this.gwKart.GridControl = this.gridKart;
            this.gwKart.Name = "gwKart";
            this.gwKart.OptionsBehavior.Editable = false;
            this.gwKart.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwKart.OptionsLayout.Columns.StoreAppearance = true;
            this.gwKart.OptionsLayout.StoreAllOptions = true;
            this.gwKart.OptionsLayout.StoreAppearance = true;
            this.gwKart.OptionsLayout.StoreFormatRules = true;
            this.gwKart.OptionsView.ColumnAutoWidth = false;
            this.gwKart.OptionsView.ShowAutoFilterRow = true;
            this.gwKart.OptionsView.ShowGroupPanel = false;
            this.gwKart.OptionsView.ShowIndicator = false;
            this.gwKart.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwKart_PopupMenuShowing);
            this.gwKart.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gwKart_FocusedRowChanged);
            this.gwKart.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwKart_FocusedColumnChanged);
            // 
            // colHesapKodu
            // 
            this.colHesapKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colHesapKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHesapKodu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colHesapKodu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHesapKodu.Caption = "Firma Kodu";
            this.colHesapKodu.FieldName = "HesapKodu";
            this.colHesapKodu.Name = "colHesapKodu";
            this.colHesapKodu.Visible = true;
            this.colHesapKodu.VisibleIndex = 0;
            // 
            // colHesapAdi
            // 
            this.colHesapAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colHesapAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHesapAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colHesapAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHesapAdi.Caption = "Firma Adı";
            this.colHesapAdi.FieldName = "HesapAdi";
            this.colHesapAdi.Name = "colHesapAdi";
            this.colHesapAdi.Visible = true;
            this.colHesapAdi.VisibleIndex = 1;
            // 
            // colKartTipi
            // 
            this.colKartTipi.AppearanceHeader.Options.UseTextOptions = true;
            this.colKartTipi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKartTipi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colKartTipi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKartTipi.Caption = "Firma Tipi";
            this.colKartTipi.FieldName = "KartTipi";
            this.colKartTipi.Name = "colKartTipi";
            this.colKartTipi.Visible = true;
            this.colKartTipi.VisibleIndex = 2;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.AppearanceHeader.Options.UseTextOptions = true;
            this.colVergiDairesi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVergiDairesi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colVergiDairesi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 3;
            // 
            // colVergiNo
            // 
            this.colVergiNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colVergiNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colVergiNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colVergiNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 4;
            // 
            // colTel1
            // 
            this.colTel1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTel1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTel1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTel1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTel1.FieldName = "Tel1";
            this.colTel1.Name = "colTel1";
            this.colTel1.Visible = true;
            this.colTel1.VisibleIndex = 5;
            // 
            // colTel2
            // 
            this.colTel2.AppearanceHeader.Options.UseTextOptions = true;
            this.colTel2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTel2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTel2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTel2.FieldName = "Tel2";
            this.colTel2.Name = "colTel2";
            this.colTel2.Visible = true;
            this.colTel2.VisibleIndex = 6;
            // 
            // colGsm
            // 
            this.colGsm.AppearanceHeader.Options.UseTextOptions = true;
            this.colGsm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGsm.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colGsm.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colGsm.FieldName = "Gsm";
            this.colGsm.Name = "colGsm";
            this.colGsm.Visible = true;
            this.colGsm.VisibleIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridKart,
            this.lyAnaAdres,
            this.lyFaturaAdres,
            this.lySevkAdres});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(735, 387);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyGridKart
            // 
            this.lyGridKart.Control = this.gridKart;
            this.lyGridKart.Location = new System.Drawing.Point(0, 0);
            this.lyGridKart.Name = "lyGridKart";
            this.lyGridKart.Size = new System.Drawing.Size(357, 212);
            this.lyGridKart.Text = "Firmalar";
            this.lyGridKart.TextLocation = DevExpress.Utils.Locations.Top;
            this.lyGridKart.TextSize = new System.Drawing.Size(50, 20);
            // 
            // lyAnaAdres
            // 
            this.lyAnaAdres.Control = this.gridAnaAdres;
            this.lyAnaAdres.Location = new System.Drawing.Point(357, 0);
            this.lyAnaAdres.Name = "lyAnaAdres";
            this.lyAnaAdres.Size = new System.Drawing.Size(358, 212);
            this.lyAnaAdres.Text = "Ana Adres";
            this.lyAnaAdres.TextLocation = DevExpress.Utils.Locations.Top;
            this.lyAnaAdres.TextSize = new System.Drawing.Size(50, 20);
            // 
            // lyFaturaAdres
            // 
            this.lyFaturaAdres.Control = this.gridFaturaAdres;
            this.lyFaturaAdres.Location = new System.Drawing.Point(0, 212);
            this.lyFaturaAdres.Name = "lyFaturaAdres";
            this.lyFaturaAdres.Size = new System.Drawing.Size(357, 155);
            this.lyFaturaAdres.Text = "Fatura Adres";
            this.lyFaturaAdres.TextLocation = DevExpress.Utils.Locations.Top;
            this.lyFaturaAdres.TextSize = new System.Drawing.Size(50, 20);
            // 
            // lySevkAdres
            // 
            this.lySevkAdres.Control = this.gridSevkAdres;
            this.lySevkAdres.Location = new System.Drawing.Point(357, 212);
            this.lySevkAdres.Name = "lySevkAdres";
            this.lySevkAdres.Size = new System.Drawing.Size(358, 155);
            this.lySevkAdres.Text = "Sevk Adres";
            this.lySevkAdres.TextLocation = DevExpress.Utils.Locations.Top;
            this.lySevkAdres.TextSize = new System.Drawing.Size(50, 20);
            // 
            // dtKart
            // 
            this.dtKart.ClearBeforeFill = true;
            // 
            // dtAnaAdres
            // 
            this.dtAnaAdres.ClearBeforeFill = true;
            // 
            // dtFaturaAdres
            // 
            this.dtFaturaAdres.ClearBeforeFill = true;
            // 
            // dtSevkAdres
            // 
            this.dtSevkAdres.ClearBeforeFill = true;
            // 
            // popupKart
            // 
            this.popupKart.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzKartGenel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzKartListe)});
            this.popupKart.Manager = this.bManager;
            this.popupKart.Name = "popupKart";
            // 
            // popupAnaAdres
            // 
            this.popupAnaAdres.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzAnaAdresGenel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzAnaAdresListe)});
            this.popupAnaAdres.Manager = this.bManager;
            this.popupAnaAdres.Name = "popupAnaAdres";
            // 
            // popupFatura
            // 
            this.popupFatura.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzFaturaGenel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzFaturaListe)});
            this.popupFatura.Manager = this.bManager;
            this.popupFatura.Name = "popupFatura";
            // 
            // popupSevk
            // 
            this.popupSevk.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzSevkGenel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzSevkListe)});
            this.popupSevk.Manager = this.bManager;
            this.popupSevk.Name = "popupSevk";
            // 
            // frmFirmaAdresAra
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 426);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmFirmaAdresAra";
            this.Text = "frmFirmaAdresAra";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSevkAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSevkAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwSevkAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFaturaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFaturaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwFaturaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwAnaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyAnaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupKart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupAnaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupFatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupSevk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem mnuSec;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridSevkAdres;
        private DevExpress.XtraGrid.Views.Grid.GridView gwSevkAdres;
        private DevExpress.XtraGrid.GridControl gridFaturaAdres;
        private DevExpress.XtraGrid.Views.Grid.GridView gwFaturaAdres;
        private DevExpress.XtraGrid.GridControl gridAnaAdres;
        private DevExpress.XtraGrid.Views.Grid.GridView gwAnaAdres;
        private DevExpress.XtraGrid.GridControl gridKart;
        private DevExpress.XtraGrid.Views.Grid.GridView gwKart;
        private DevExpress.XtraLayout.LayoutControlItem lyGridKart;
        private DevExpress.XtraLayout.LayoutControlItem lyAnaAdres;
        private DevExpress.XtraLayout.LayoutControlItem lyFaturaAdres;
        private DevExpress.XtraLayout.LayoutControlItem lySevkAdres;
        private Data.Global.DSGlobal ds;
        private Data.Global.DSGlobalTableAdapters.CHK_KartTableAdapter dtKart;
        private Data.Global.DSGlobalTableAdapters.V_CHK_Kart_AnaAdresTableAdapter dtAnaAdres;
        private Data.Global.DSGlobalTableAdapters.V_CHK_Kart_FaturaAdresTableAdapter dtFaturaAdres;
        private Data.Global.DSGlobalTableAdapters.V_CHK_Kart_SevkAdresTableAdapter dtSevkAdres;
        private System.Windows.Forms.BindingSource bsKart;
        private System.Windows.Forms.BindingSource bsAnaAdres;
        private System.Windows.Forms.BindingSource bsFaturaAdres;
        private System.Windows.Forms.BindingSource bsSevkAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkLokasyon;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkLokasyonAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkAdres1;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkAdres2;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkSehir;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaLokasyon;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaLokasyonAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaAdres1;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaAdres2;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaSehir;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colLokasyon;
        private DevExpress.XtraGrid.Columns.GridColumn colLokasyonAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres2;
        private DevExpress.XtraGrid.Columns.GridColumn colSehir;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKartTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTel1;
        private DevExpress.XtraGrid.Columns.GridColumn colTel2;
        private DevExpress.XtraGrid.Columns.GridColumn colGsm;
        private DevExpress.XtraBars.BarButtonItem mnuOzKartGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzKartListe;
        private DevExpress.XtraBars.PopupMenu popupKart;
        private DevExpress.XtraBars.PopupMenu popupAnaAdres;
        private DevExpress.XtraBars.PopupMenu popupFatura;
        private DevExpress.XtraBars.PopupMenu popupSevk;
        private DevExpress.XtraBars.BarButtonItem mnuOzAnaAdresGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzAnaAdresListe;
        private DevExpress.XtraBars.BarButtonItem mnuOzFaturaGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzFaturaListe;
        private DevExpress.XtraBars.BarButtonItem mnuOzSevkGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzSevkListe;
        private DevExpress.Utils.ImageCollection IMG24;
    }
}