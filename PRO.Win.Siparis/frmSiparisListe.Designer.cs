namespace PRO.Win.Siparis
{
    partial class frmSiparisListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisListe));
            this.bManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuBasTar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.mnuBitTar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.mnuYenile = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuYeni = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuDuzelt = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.PanelSiparis = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.IMG24 = new DevExpress.Utils.ImageCollection();
            this.mnuOzelliklerGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuStokGozlem = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDetayDuzelt = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.gridListe = new DevExpress.XtraGrid.GridControl();
            this.bs = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.Siparis.DSSiparis();
            this.gwListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGsm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeSekli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaAdres1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkAdres1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSevkSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSipNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusSiparisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerminTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetayDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetayAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridListe = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupListe = new DevExpress.XtraBars.PopupMenu();
            this.dt = new PRO.Data.Siparis.DSSiparisTableAdapters.V_SiparisListeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.PanelSiparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupListe)).BeginInit();
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
            this.bManager.DockManager = this.dockManager1;
            this.bManager.Form = this;
            this.bManager.Images = this.IMG24;
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuYenile,
            this.mnuYeni,
            this.mnuDuzelt,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuBasTar,
            this.mnuBitTar,
            this.mnuGorunumKaydet,
            this.mnuOzelliklerGenel,
            this.mnuOzelliklerListe,
            this.mnuStokGozlem,
            this.mnuDetayDuzelt});
            this.bManager.MaxItemId = 12;
            this.bManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuBasTar),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuBitTar),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYenile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYeni, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuDuzelt, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKapat, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // mnuBasTar
            // 
            this.mnuBasTar.Caption = "Başlangıç Tarihi";
            this.mnuBasTar.Edit = this.repositoryItemDateEdit1;
            this.mnuBasTar.Id = 5;
            this.mnuBasTar.Name = "mnuBasTar";
            this.mnuBasTar.Width = 85;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // mnuBitTar
            // 
            this.mnuBitTar.Caption = "Bitiş Tarihi";
            this.mnuBitTar.Edit = this.repositoryItemDateEdit2;
            this.mnuBitTar.Id = 6;
            this.mnuBitTar.Name = "mnuBitTar";
            this.mnuBitTar.Width = 85;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // mnuYenile
            // 
            this.mnuYenile.Caption = "Yenile";
            this.mnuYenile.Id = 0;
            this.mnuYenile.ImageIndex = 9;
            this.mnuYenile.Name = "mnuYenile";
            this.mnuYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYenile_ItemClick);
            // 
            // mnuYeni
            // 
            this.mnuYeni.Caption = "Yeni";
            this.mnuYeni.Id = 1;
            this.mnuYeni.ImageIndex = 6;
            this.mnuYeni.Name = "mnuYeni";
            this.E_Yetki.SetYetkiEnable(this.mnuYeni, "_EKLE");
            this.mnuYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYeni_ItemClick);
            // 
            // mnuDuzelt
            // 
            this.mnuDuzelt.Caption = "Düzelt";
            this.mnuDuzelt.Id = 2;
            this.mnuDuzelt.ImageIndex = 3;
            this.mnuDuzelt.Name = "mnuDuzelt";
            this.E_Yetki.SetYetkiEnable(this.mnuDuzelt, "_EKLE");
            this.mnuDuzelt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuDuzelt_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 3;
            this.mnuKapat.ImageIndex = 1;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 4;
            this.barSubItem1.ImageIndex = 10;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGorunumKaydet)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnuGorunumKaydet
            // 
            this.mnuGorunumKaydet.Caption = "Görünüm Kaydet";
            this.mnuGorunumKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuGorunumKaydet.Glyph")));
            this.mnuGorunumKaydet.Id = 7;
            this.mnuGorunumKaydet.Name = "mnuGorunumKaydet";
            this.mnuGorunumKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGorunumKaydet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(837, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 404);
            this.barDockControlBottom.Size = new System.Drawing.Size(837, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 365);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(837, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 365);
            // 
            // dockManager1
            // 
            this.dockManager1.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.bManager;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.GhostWhite;
            this.hideContainerLeft.Controls.Add(this.PanelSiparis);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 39);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 365);
            // 
            // PanelSiparis
            // 
            this.PanelSiparis.Controls.Add(this.dockPanel1_Container);
            this.PanelSiparis.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.PanelSiparis.ID = new System.Guid("e043d151-9e6c-48e3-ac46-8e42e2bcf0ec");
            this.PanelSiparis.Location = new System.Drawing.Point(0, 0);
            this.PanelSiparis.Name = "PanelSiparis";
            this.PanelSiparis.Options.ShowCloseButton = false;
            this.PanelSiparis.OriginalSize = new System.Drawing.Size(200, 200);
            this.PanelSiparis.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.PanelSiparis.SavedIndex = 0;
            this.PanelSiparis.Size = new System.Drawing.Size(200, 375);
            this.PanelSiparis.Text = "Raporlar";
            this.PanelSiparis.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 348);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "arama.png");
            this.IMG24.Images.SetKeyName(1, "cikis1.png");
            this.IMG24.Images.SetKeyName(2, "delete81.png");
            this.IMG24.Images.SetKeyName(3, "Edit.png");
            this.IMG24.Images.SetKeyName(4, "ekle24.png");
            this.IMG24.Images.SetKeyName(5, "floppy1.png");
            this.IMG24.Images.SetKeyName(6, "new10.png");
            this.IMG24.Images.SetKeyName(7, "Ok.png");
            this.IMG24.Images.SetKeyName(8, "printer70.png");
            this.IMG24.Images.SetKeyName(9, "refresh.png");
            this.IMG24.Images.SetKeyName(10, "Settings.png");
            // 
            // mnuOzelliklerGenel
            // 
            this.mnuOzelliklerGenel.Caption = "Genel Özellikler";
            this.mnuOzelliklerGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzelliklerGenel.Glyph")));
            this.mnuOzelliklerGenel.Id = 8;
            this.mnuOzelliklerGenel.Name = "mnuOzelliklerGenel";
            this.mnuOzelliklerGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzelliklerGenel_ItemClick);
            // 
            // mnuOzelliklerListe
            // 
            this.mnuOzelliklerListe.Caption = "Liste Özellikler";
            this.mnuOzelliklerListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzelliklerListe.Glyph")));
            this.mnuOzelliklerListe.Id = 9;
            this.mnuOzelliklerListe.Name = "mnuOzelliklerListe";
            this.mnuOzelliklerListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzelliklerListe_ItemClick);
            // 
            // mnuStokGozlem
            // 
            this.mnuStokGozlem.Caption = "Stok / Ürün Gözlem";
            this.mnuStokGozlem.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuStokGozlem.Glyph")));
            this.mnuStokGozlem.Id = 10;
            this.mnuStokGozlem.Name = "mnuStokGozlem";
            this.mnuStokGozlem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuStokGozlem_ItemClick);
            // 
            // mnuDetayDuzelt
            // 
            this.mnuDetayDuzelt.Caption = "Düzelt";
            this.mnuDetayDuzelt.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuDetayDuzelt.Glyph")));
            this.mnuDetayDuzelt.Id = 11;
            this.mnuDetayDuzelt.Name = "mnuDetayDuzelt";
            this.mnuDetayDuzelt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuDetayDuzelt_ItemClick);
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.gridListe);
            this._Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Layout.Location = new System.Drawing.Point(19, 39);
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
            this._Layout.Size = new System.Drawing.Size(818, 365);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // gridListe
            // 
            this.gridListe.DataSource = this.bs;
            this.gridListe.Location = new System.Drawing.Point(12, 12);
            this.gridListe.MainView = this.gwListe;
            this.gridListe.MenuManager = this.bManager;
            this.gridListe.Name = "gridListe";
            this.gridListe.Size = new System.Drawing.Size(794, 341);
            this.gridListe.TabIndex = 4;
            this.gridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwListe});
            // 
            // bs
            // 
            this.bs.DataMember = "V_SiparisListe";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSSiparis";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gwListe
            // 
            this.gwListe.ColumnPanelRowHeight = 35;
            this.gwListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarih,
            this.colHesapKodu,
            this.colHesapAdi,
            this.colVergiDairesi,
            this.colVergiNo,
            this.colTel1,
            this.colTel2,
            this.colGsm,
            this.colOdemeSekli,
            this.colDurum,
            this.colFaturaAdres1,
            this.colFaturaSehir,
            this.colFaturaIlce,
            this.colFaturaSemt,
            this.colSevkAdres1,
            this.colSevkSehir,
            this.colSevkIlce,
            this.colSevkSemt,
            this.colAciklama,
            this.colSipNo,
            this.colMusSiparisNo,
            this.colTerminTarihi,
            this.colStokKodu,
            this.colStokAdi,
            this.colMiktar,
            this.colFiyat,
            this.colTutar,
            this.colDetayDurum,
            this.colDetayAciklama});
            this.gwListe.GridControl = this.gridListe;
            this.gwListe.Name = "gwListe";
            this.gwListe.OptionsBehavior.Editable = false;
            this.gwListe.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwListe.OptionsLayout.Columns.StoreAppearance = true;
            this.gwListe.OptionsLayout.StoreAllOptions = true;
            this.gwListe.OptionsLayout.StoreAppearance = true;
            this.gwListe.OptionsLayout.StoreFormatRules = true;
            this.gwListe.OptionsView.ColumnAutoWidth = false;
            this.gwListe.OptionsView.ShowGroupPanel = false;
            this.gwListe.OptionsView.ShowIndicator = false;
            this.gwListe.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwListe_PopupMenuShowing);
            this.gwListe.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwListe_FocusedColumnChanged);
            // 
            // colTarih
            // 
            this.colTarih.AppearanceHeader.Options.UseTextOptions = true;
            this.colTarih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTarih.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
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
            this.colHesapKodu.VisibleIndex = 1;
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
            this.colHesapAdi.VisibleIndex = 2;
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
            // colOdemeSekli
            // 
            this.colOdemeSekli.AppearanceHeader.Options.UseTextOptions = true;
            this.colOdemeSekli.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOdemeSekli.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colOdemeSekli.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colOdemeSekli.Caption = "Ödeme Şekli";
            this.colOdemeSekli.FieldName = "OdemeSekli";
            this.colOdemeSekli.Name = "colOdemeSekli";
            this.colOdemeSekli.Visible = true;
            this.colOdemeSekli.VisibleIndex = 8;
            // 
            // colDurum
            // 
            this.colDurum.AppearanceHeader.Options.UseTextOptions = true;
            this.colDurum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDurum.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDurum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 9;
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
            this.colFaturaAdres1.VisibleIndex = 10;
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
            this.colFaturaSehir.VisibleIndex = 11;
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
            this.colFaturaIlce.VisibleIndex = 12;
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
            this.colFaturaSemt.VisibleIndex = 13;
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
            this.colSevkAdres1.VisibleIndex = 14;
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
            this.colSevkSehir.VisibleIndex = 15;
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
            this.colSevkIlce.VisibleIndex = 16;
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
            this.colSevkSemt.VisibleIndex = 17;
            // 
            // colAciklama
            // 
            this.colAciklama.AppearanceHeader.Options.UseTextOptions = true;
            this.colAciklama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAciklama.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colAciklama.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 18;
            // 
            // colSipNo
            // 
            this.colSipNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSipNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSipNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSipNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSipNo.Caption = "Sipariş No";
            this.colSipNo.FieldName = "SipNo";
            this.colSipNo.Name = "colSipNo";
            this.colSipNo.Visible = true;
            this.colSipNo.VisibleIndex = 19;
            // 
            // colMusSiparisNo
            // 
            this.colMusSiparisNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colMusSiparisNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMusSiparisNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colMusSiparisNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMusSiparisNo.Caption = "Müşteri Sipariş No";
            this.colMusSiparisNo.FieldName = "MusSiparisNo";
            this.colMusSiparisNo.Name = "colMusSiparisNo";
            this.colMusSiparisNo.Visible = true;
            this.colMusSiparisNo.VisibleIndex = 20;
            // 
            // colTerminTarihi
            // 
            this.colTerminTarihi.AppearanceHeader.Options.UseTextOptions = true;
            this.colTerminTarihi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTerminTarihi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTerminTarihi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTerminTarihi.FieldName = "TerminTarihi";
            this.colTerminTarihi.Name = "colTerminTarihi";
            this.colTerminTarihi.Visible = true;
            this.colTerminTarihi.VisibleIndex = 21;
            // 
            // colStokKodu
            // 
            this.colStokKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colStokKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStokKodu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colStokKodu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 22;
            // 
            // colStokAdi
            // 
            this.colStokAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colStokAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStokAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colStokAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colStokAdi.Caption = "Stok Adı";
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 23;
            // 
            // colMiktar
            // 
            this.colMiktar.AppearanceHeader.Options.UseTextOptions = true;
            this.colMiktar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMiktar.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colMiktar.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 24;
            // 
            // colFiyat
            // 
            this.colFiyat.AppearanceHeader.Options.UseTextOptions = true;
            this.colFiyat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFiyat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFiyat.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 25;
            // 
            // colTutar
            // 
            this.colTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTutar.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTutar.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 26;
            // 
            // colDetayDurum
            // 
            this.colDetayDurum.AppearanceHeader.Options.UseTextOptions = true;
            this.colDetayDurum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDetayDurum.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDetayDurum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDetayDurum.Caption = "Sipariş Durum";
            this.colDetayDurum.FieldName = "DetayDurum";
            this.colDetayDurum.Name = "colDetayDurum";
            this.colDetayDurum.Visible = true;
            this.colDetayDurum.VisibleIndex = 27;
            // 
            // colDetayAciklama
            // 
            this.colDetayAciklama.AppearanceHeader.Options.UseTextOptions = true;
            this.colDetayAciklama.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDetayAciklama.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDetayAciklama.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDetayAciklama.Caption = "Detay Açıklama";
            this.colDetayAciklama.FieldName = "DetayAciklama";
            this.colDetayAciklama.Name = "colDetayAciklama";
            this.colDetayAciklama.Visible = true;
            this.colDetayAciklama.VisibleIndex = 28;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridListe});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(818, 365);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyGridListe
            // 
            this.lyGridListe.Control = this.gridListe;
            this.lyGridListe.Location = new System.Drawing.Point(0, 0);
            this.lyGridListe.Name = "lyGridListe";
            this.lyGridListe.Size = new System.Drawing.Size(798, 345);
            this.lyGridListe.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridListe.TextVisible = false;
            // 
            // popupListe
            // 
            this.popupListe.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuDetayDuzelt),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuStokGozlem),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerListe)});
            this.popupListe.Manager = this.bManager;
            this.popupListe.Name = "popupListe";
            // 
            // dt
            // 
            this.dt.ClearBeforeFill = true;
            // 
            // frmSiparisListe
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 404);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.hideContainerLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSiparisListe";
            this.Text = "frmSiparisListe";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.PanelSiparis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem mnuBasTar;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem mnuBitTar;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYenile;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYeni;
        private DevExpress.XtraBars.BarLargeButtonItem mnuDuzelt;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gwListe;
        private DevExpress.XtraLayout.LayoutControlItem lyGridListe;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerListe;
        private DevExpress.XtraBars.PopupMenu popupListe;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraBars.Docking.DockPanel PanelSiparis;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private Data.Siparis.DSSiparis ds;
        private Data.Siparis.DSSiparisTableAdapters.V_SiparisListeTableAdapter dt;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTel1;
        private DevExpress.XtraGrid.Columns.GridColumn colTel2;
        private DevExpress.XtraGrid.Columns.GridColumn colGsm;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeSekli;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaAdres1;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaSehir;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkAdres1;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkSehir;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSevkSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colSipNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMusSiparisNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDetayDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colDetayAciklama;
        private DevExpress.Utils.ImageCollection IMG24;
        private DevExpress.XtraBars.BarButtonItem mnuStokGozlem;
        private DevExpress.XtraBars.BarButtonItem mnuDetayDuzelt;
    }
}