namespace PRO.Sistem
{
    partial class frmModul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModul));
            this.bManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYeni = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKopyala = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuSil = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuStandartYetkiler = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuYetkiEkle = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuYetkiSil = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKaydet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.IMG24 = new DevExpress.Utils.ImageCollection();
            this.mnuOzModulGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzModulListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzYetkiGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzYetkiListe = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.gridYetki = new DevExpress.XtraGrid.GridControl();
            this.bsYetki = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.DSDataSystem();
            this.gwYetki = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colYetkiKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetkiAdiDilKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridModul = new DevExpress.XtraGrid.GridControl();
            this.bsModul = new System.Windows.Forms.BindingSource();
            this.gwModul = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMenuNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDilkey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemFormu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParametre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoadParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefaultParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHesapParam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModulName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPopup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMultiDilKey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeriTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSystem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridModul = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyGridYetki = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupModul = new DevExpress.XtraBars.PopupMenu();
            this.popupYetki = new DevExpress.XtraBars.PopupMenu();
            this.dtModul = new PRO.Data.DSDataSystemTableAdapters.SYS_ModulTableAdapter();
            this.dtYetki = new PRO.Data.DSDataSystemTableAdapters.SYS_ModulYetkiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwModul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridModul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupModul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupYetki)).BeginInit();
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
            this.mnuYeni,
            this.mnuSil,
            this.mnuKopyala,
            this.mnuStandartYetkiler,
            this.mnuYetkiSil,
            this.mnuKaydet,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuYetkiEkle,
            this.mnuOzModulGenel,
            this.mnuOzModulListe,
            this.mnuOzYetkiGenel,
            this.mnuOzYetkiListe});
            this.bManager.MaxItemId = 14;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYeni),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKopyala),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSil, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuStandartYetkiler, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuYetkiEkle, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYetkiSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKaydet, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKapat, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // mnuYeni
            // 
            this.mnuYeni.Caption = "Yeni";
            this.mnuYeni.Id = 0;
            this.mnuYeni.ImageIndex = 9;
            this.mnuYeni.Name = "mnuYeni";
            this.E_Yetki.SetYetkiEnable(this.mnuYeni, "_EKLE");
            this.mnuYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYeni_ItemClick);
            // 
            // mnuKopyala
            // 
            this.mnuKopyala.Caption = "Kopyala";
            this.mnuKopyala.Id = 2;
            this.mnuKopyala.ImageIndex = 8;
            this.mnuKopyala.Name = "mnuKopyala";
            this.E_Yetki.SetYetkiEnable(this.mnuKopyala, "_EKLE");
            this.mnuKopyala.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKopyala_ItemClick);
            // 
            // mnuSil
            // 
            this.mnuSil.Caption = "Sil";
            this.mnuSil.Id = 1;
            this.mnuSil.ImageIndex = 2;
            this.mnuSil.Name = "mnuSil";
            this.E_Yetki.SetYetkiEnable(this.mnuSil, "_SIL");
            this.mnuSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSil_ItemClick);
            // 
            // mnuStandartYetkiler
            // 
            this.mnuStandartYetkiler.Caption = "Standart Yetkiler";
            this.mnuStandartYetkiler.Id = 3;
            this.mnuStandartYetkiler.ImageIndex = 19;
            this.mnuStandartYetkiler.Name = "mnuStandartYetkiler";
            this.E_Yetki.SetYetkiEnable(this.mnuStandartYetkiler, "_EKLE");
            this.mnuStandartYetkiler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuStandartYetkiler_ItemClick);
            // 
            // mnuYetkiEkle
            // 
            this.mnuYetkiEkle.Caption = "Yetki Ekle";
            this.mnuYetkiEkle.Id = 9;
            this.mnuYetkiEkle.ImageIndex = 17;
            this.mnuYetkiEkle.Name = "mnuYetkiEkle";
            this.E_Yetki.SetYetkiEnable(this.mnuYetkiEkle, "_EKLE");
            this.mnuYetkiEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYetkiEkle_ItemClick);
            // 
            // mnuYetkiSil
            // 
            this.mnuYetkiSil.Caption = "Yetki Sil";
            this.mnuYetkiSil.Id = 4;
            this.mnuYetkiSil.ImageIndex = 20;
            this.mnuYetkiSil.Name = "mnuYetkiSil";
            this.E_Yetki.SetYetkiEnable(this.mnuYetkiSil, "_SIL");
            this.mnuYetkiSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYetkiSil_ItemClick);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Caption = "Kaydet";
            this.mnuKaydet.Id = 5;
            this.mnuKaydet.ImageIndex = 5;
            this.mnuKaydet.Name = "mnuKaydet";
            this.E_Yetki.SetYetkiEnable(this.mnuKaydet, "_KAYDET");
            this.mnuKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKaydet_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 6;
            this.mnuKapat.ImageIndex = 18;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 7;
            this.barSubItem1.ImageIndex = 15;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGorunumKaydet)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnuGorunumKaydet
            // 
            this.mnuGorunumKaydet.Caption = "Görünüm Kaydet";
            this.mnuGorunumKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuGorunumKaydet.Glyph")));
            this.mnuGorunumKaydet.Id = 8;
            this.mnuGorunumKaydet.Name = "mnuGorunumKaydet";
            this.mnuGorunumKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGorunumKaydet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(673, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Size = new System.Drawing.Size(673, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 370);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(673, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 370);
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "back36.png");
            this.IMG24.Images.SetKeyName(1, "Delete24.png");
            this.IMG24.Images.SetKeyName(2, "delete81.png");
            this.IMG24.Images.SetKeyName(3, "Edit.png");
            this.IMG24.Images.SetKeyName(4, "ekle24.png");
            this.IMG24.Images.SetKeyName(5, "floppy1.png");
            this.IMG24.Images.SetKeyName(6, "KaydetCik.png");
            this.IMG24.Images.SetKeyName(7, "Kısayol.png");
            this.IMG24.Images.SetKeyName(8, "Kopyala.png");
            this.IMG24.Images.SetKeyName(9, "new10.png");
            this.IMG24.Images.SetKeyName(10, "Ok.png");
            this.IMG24.Images.SetKeyName(11, "Product.png");
            this.IMG24.Images.SetKeyName(12, "refresh.png");
            this.IMG24.Images.SetKeyName(13, "right133.png");
            this.IMG24.Images.SetKeyName(14, "search102.png");
            this.IMG24.Images.SetKeyName(15, "Settings.png");
            this.IMG24.Images.SetKeyName(16, "Yetki.png");
            this.IMG24.Images.SetKeyName(17, "list80.png");
            this.IMG24.Images.SetKeyName(18, "cikis1.png");
            this.IMG24.Images.SetKeyName(19, "grafiktalep.png");
            this.IMG24.Images.SetKeyName(20, "cancel3.png");
            // 
            // mnuOzModulGenel
            // 
            this.mnuOzModulGenel.Caption = "Genel Özellikler";
            this.mnuOzModulGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzModulGenel.Glyph")));
            this.mnuOzModulGenel.Id = 10;
            this.mnuOzModulGenel.Name = "mnuOzModulGenel";
            this.mnuOzModulGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzModulGenel_ItemClick);
            // 
            // mnuOzModulListe
            // 
            this.mnuOzModulListe.Caption = "Liste Özellikler";
            this.mnuOzModulListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzModulListe.Glyph")));
            this.mnuOzModulListe.Id = 11;
            this.mnuOzModulListe.Name = "mnuOzModulListe";
            this.mnuOzModulListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzModulListe_ItemClick);
            // 
            // mnuOzYetkiGenel
            // 
            this.mnuOzYetkiGenel.Caption = "Genel Özellikler";
            this.mnuOzYetkiGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzYetkiGenel.Glyph")));
            this.mnuOzYetkiGenel.Id = 12;
            this.mnuOzYetkiGenel.Name = "mnuOzYetkiGenel";
            this.mnuOzYetkiGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzYetkiGenel_ItemClick);
            // 
            // mnuOzYetkiListe
            // 
            this.mnuOzYetkiListe.Caption = "Liste Özellikler";
            this.mnuOzYetkiListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzYetkiListe.Glyph")));
            this.mnuOzYetkiListe.Id = 13;
            this.mnuOzYetkiListe.Name = "mnuOzYetkiListe";
            this.mnuOzYetkiListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzYetkiListe_ItemClick);
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.gridYetki);
            this._Layout.Controls.Add(this.gridModul);
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
            this._Layout.Size = new System.Drawing.Size(673, 370);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // gridYetki
            // 
            this.gridYetki.DataSource = this.bsYetki;
            this.gridYetki.Location = new System.Drawing.Point(506, 12);
            this.gridYetki.MainView = this.gwYetki;
            this.gridYetki.MenuManager = this.bManager;
            this.gridYetki.Name = "gridYetki";
            this.gridYetki.Size = new System.Drawing.Size(155, 346);
            this.gridYetki.TabIndex = 5;
            this.gridYetki.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwYetki});
            // 
            // bsYetki
            // 
            this.bsYetki.DataMember = "SYS_ModulYetki";
            this.bsYetki.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSDataSystem";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gwYetki
            // 
            this.gwYetki.ColumnPanelRowHeight = 40;
            this.gwYetki.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYetkiKodu,
            this.colYetkiAdiDilKey});
            this.gwYetki.GridControl = this.gridYetki;
            this.gwYetki.Name = "gwYetki";
            this.gwYetki.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwYetki.OptionsLayout.Columns.StoreAppearance = true;
            this.gwYetki.OptionsLayout.StoreAllOptions = true;
            this.gwYetki.OptionsLayout.StoreAppearance = true;
            this.gwYetki.OptionsLayout.StoreFormatRules = true;
            this.gwYetki.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwYetki.OptionsView.ColumnAutoWidth = false;
            this.gwYetki.OptionsView.ShowGroupPanel = false;
            this.gwYetki.OptionsView.ShowIndicator = false;
            this.gwYetki.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwYetki_PopupMenuShowing);
            this.gwYetki.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwYetki_FocusedColumnChanged);
            // 
            // colYetkiKodu
            // 
            this.colYetkiKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colYetkiKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYetkiKodu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colYetkiKodu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colYetkiKodu.FieldName = "YetkiKodu";
            this.colYetkiKodu.Name = "colYetkiKodu";
            this.colYetkiKodu.Visible = true;
            this.colYetkiKodu.VisibleIndex = 0;
            // 
            // colYetkiAdiDilKey
            // 
            this.colYetkiAdiDilKey.AppearanceHeader.Options.UseTextOptions = true;
            this.colYetkiAdiDilKey.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYetkiAdiDilKey.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colYetkiAdiDilKey.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colYetkiAdiDilKey.FieldName = "YetkiAdiDilKey";
            this.colYetkiAdiDilKey.Name = "colYetkiAdiDilKey";
            this.colYetkiAdiDilKey.Visible = true;
            this.colYetkiAdiDilKey.VisibleIndex = 1;
            // 
            // gridModul
            // 
            this.gridModul.DataSource = this.bsModul;
            this.gridModul.Location = new System.Drawing.Point(12, 12);
            this.gridModul.MainView = this.gwModul;
            this.gridModul.MenuManager = this.bManager;
            this.gridModul.Name = "gridModul";
            this.gridModul.Size = new System.Drawing.Size(490, 346);
            this.gridModul.TabIndex = 4;
            this.gridModul.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwModul});
            // 
            // bsModul
            // 
            this.bsModul.DataMember = "SYS_Modul";
            this.bsModul.DataSource = this.ds;
            // 
            // gwModul
            // 
            this.gwModul.ColumnPanelRowHeight = 40;
            this.gwModul.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMenuNo,
            this.colDilkey,
            this.colIslemFormu,
            this.colFormAdi,
            this.colParametre,
            this.colLoadParam,
            this.colDefaultParam,
            this.colSeriParam,
            this.colHesapParam,
            this.colKHesapParam,
            this.colIslemIcon,
            this.colModulName,
            this.colPopup,
            this.colMultiDilKey,
            this.colSeriTanim,
            this.colSystem});
            this.gwModul.GridControl = this.gridModul;
            this.gwModul.Name = "gwModul";
            this.gwModul.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwModul.OptionsLayout.Columns.StoreAppearance = true;
            this.gwModul.OptionsLayout.StoreAllOptions = true;
            this.gwModul.OptionsLayout.StoreAppearance = true;
            this.gwModul.OptionsLayout.StoreFormatRules = true;
            this.gwModul.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwModul.OptionsView.ColumnAutoWidth = false;
            this.gwModul.OptionsView.ShowAutoFilterRow = true;
            this.gwModul.OptionsView.ShowGroupPanel = false;
            this.gwModul.OptionsView.ShowIndicator = false;
            this.gwModul.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwModul_PopupMenuShowing);
            this.gwModul.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gwModul_FocusedRowChanged);
            this.gwModul.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwModul_FocusedColumnChanged);
            // 
            // colMenuNo
            // 
            this.colMenuNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colMenuNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMenuNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colMenuNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMenuNo.FieldName = "MenuNo";
            this.colMenuNo.Name = "colMenuNo";
            this.colMenuNo.Visible = true;
            this.colMenuNo.VisibleIndex = 0;
            // 
            // colDilkey
            // 
            this.colDilkey.AppearanceHeader.Options.UseTextOptions = true;
            this.colDilkey.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDilkey.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDilkey.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDilkey.FieldName = "Dilkey";
            this.colDilkey.Name = "colDilkey";
            this.colDilkey.Visible = true;
            this.colDilkey.VisibleIndex = 1;
            // 
            // colIslemFormu
            // 
            this.colIslemFormu.AppearanceHeader.Options.UseTextOptions = true;
            this.colIslemFormu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIslemFormu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colIslemFormu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIslemFormu.FieldName = "IslemFormu";
            this.colIslemFormu.Name = "colIslemFormu";
            this.colIslemFormu.Visible = true;
            this.colIslemFormu.VisibleIndex = 2;
            // 
            // colFormAdi
            // 
            this.colFormAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colFormAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFormAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFormAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFormAdi.FieldName = "FormAdi";
            this.colFormAdi.Name = "colFormAdi";
            this.colFormAdi.Visible = true;
            this.colFormAdi.VisibleIndex = 3;
            // 
            // colParametre
            // 
            this.colParametre.AppearanceHeader.Options.UseTextOptions = true;
            this.colParametre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colParametre.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colParametre.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colParametre.FieldName = "Parametre";
            this.colParametre.Name = "colParametre";
            this.colParametre.Visible = true;
            this.colParametre.VisibleIndex = 4;
            // 
            // colLoadParam
            // 
            this.colLoadParam.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoadParam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoadParam.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colLoadParam.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLoadParam.FieldName = "LoadParam";
            this.colLoadParam.Name = "colLoadParam";
            this.colLoadParam.Visible = true;
            this.colLoadParam.VisibleIndex = 5;
            // 
            // colDefaultParam
            // 
            this.colDefaultParam.AppearanceHeader.Options.UseTextOptions = true;
            this.colDefaultParam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDefaultParam.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDefaultParam.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDefaultParam.FieldName = "DefaultParam";
            this.colDefaultParam.Name = "colDefaultParam";
            this.colDefaultParam.Visible = true;
            this.colDefaultParam.VisibleIndex = 6;
            // 
            // colSeriParam
            // 
            this.colSeriParam.AppearanceHeader.Options.UseTextOptions = true;
            this.colSeriParam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSeriParam.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSeriParam.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSeriParam.FieldName = "SeriParam";
            this.colSeriParam.Name = "colSeriParam";
            this.colSeriParam.Visible = true;
            this.colSeriParam.VisibleIndex = 7;
            // 
            // colHesapParam
            // 
            this.colHesapParam.AppearanceHeader.Options.UseTextOptions = true;
            this.colHesapParam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHesapParam.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colHesapParam.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colHesapParam.FieldName = "HesapParam";
            this.colHesapParam.Name = "colHesapParam";
            this.colHesapParam.Visible = true;
            this.colHesapParam.VisibleIndex = 8;
            // 
            // colKHesapParam
            // 
            this.colKHesapParam.AppearanceHeader.Options.UseTextOptions = true;
            this.colKHesapParam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKHesapParam.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colKHesapParam.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKHesapParam.FieldName = "KHesapParam";
            this.colKHesapParam.Name = "colKHesapParam";
            this.colKHesapParam.Visible = true;
            this.colKHesapParam.VisibleIndex = 9;
            // 
            // colIslemIcon
            // 
            this.colIslemIcon.AppearanceHeader.Options.UseTextOptions = true;
            this.colIslemIcon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIslemIcon.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colIslemIcon.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIslemIcon.FieldName = "IslemIcon";
            this.colIslemIcon.Name = "colIslemIcon";
            this.colIslemIcon.Visible = true;
            this.colIslemIcon.VisibleIndex = 10;
            // 
            // colModulName
            // 
            this.colModulName.AppearanceHeader.Options.UseTextOptions = true;
            this.colModulName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colModulName.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colModulName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colModulName.FieldName = "ModulName";
            this.colModulName.Name = "colModulName";
            this.colModulName.Visible = true;
            this.colModulName.VisibleIndex = 11;
            // 
            // colPopup
            // 
            this.colPopup.AppearanceHeader.Options.UseTextOptions = true;
            this.colPopup.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPopup.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colPopup.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPopup.FieldName = "Popup";
            this.colPopup.Name = "colPopup";
            this.colPopup.Visible = true;
            this.colPopup.VisibleIndex = 12;
            // 
            // colMultiDilKey
            // 
            this.colMultiDilKey.AppearanceHeader.Options.UseTextOptions = true;
            this.colMultiDilKey.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMultiDilKey.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colMultiDilKey.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMultiDilKey.FieldName = "MultiDilKey";
            this.colMultiDilKey.Name = "colMultiDilKey";
            this.colMultiDilKey.Visible = true;
            this.colMultiDilKey.VisibleIndex = 13;
            // 
            // colSeriTanim
            // 
            this.colSeriTanim.AppearanceHeader.Options.UseTextOptions = true;
            this.colSeriTanim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSeriTanim.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSeriTanim.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSeriTanim.FieldName = "SeriTanim";
            this.colSeriTanim.Name = "colSeriTanim";
            this.colSeriTanim.Visible = true;
            this.colSeriTanim.VisibleIndex = 14;
            // 
            // colSystem
            // 
            this.colSystem.AppearanceHeader.Options.UseTextOptions = true;
            this.colSystem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSystem.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSystem.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSystem.FieldName = "System";
            this.colSystem.Name = "colSystem";
            this.colSystem.Visible = true;
            this.colSystem.VisibleIndex = 15;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridModul,
            this.lyGridYetki});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(673, 370);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyGridModul
            // 
            this.lyGridModul.Control = this.gridModul;
            this.lyGridModul.Location = new System.Drawing.Point(0, 0);
            this.lyGridModul.Name = "lyGridModul";
            this.lyGridModul.Size = new System.Drawing.Size(494, 350);
            this.lyGridModul.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridModul.TextVisible = false;
            // 
            // lyGridYetki
            // 
            this.lyGridYetki.Control = this.gridYetki;
            this.lyGridYetki.Location = new System.Drawing.Point(494, 0);
            this.lyGridYetki.Name = "lyGridYetki";
            this.lyGridYetki.Size = new System.Drawing.Size(159, 350);
            this.lyGridYetki.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridYetki.TextVisible = false;
            // 
            // popupModul
            // 
            this.popupModul.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzModulGenel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzModulListe)});
            this.popupModul.Manager = this.bManager;
            this.popupModul.Name = "popupModul";
            // 
            // popupYetki
            // 
            this.popupYetki.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzYetkiGenel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzYetkiListe)});
            this.popupYetki.Manager = this.bManager;
            this.popupYetki.Name = "popupYetki";
            // 
            // dtModul
            // 
            this.dtModul.ClearBeforeFill = true;
            // 
            // dtYetki
            // 
            this.dtYetki.ClearBeforeFill = true;
            // 
            // frmModul
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 409);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmModul";
            this.Text = "frmModul";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwModul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridModul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupModul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupYetki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYeni;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKopyala;
        private DevExpress.XtraBars.BarLargeButtonItem mnuSil;
        private DevExpress.XtraBars.BarLargeButtonItem mnuStandartYetkiler;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYetkiSil;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKaydet;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridModul;
        private DevExpress.XtraGrid.Views.Grid.GridView gwModul;
        private DevExpress.XtraLayout.LayoutControlItem lyGridModul;
        private DevExpress.XtraGrid.GridControl gridYetki;
        private DevExpress.XtraGrid.Views.Grid.GridView gwYetki;
        private DevExpress.XtraLayout.LayoutControlItem lyGridYetki;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYetkiEkle;
        private DevExpress.Utils.ImageCollection IMG24;
        private DevExpress.XtraBars.BarButtonItem mnuOzModulGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzModulListe;
        private DevExpress.XtraBars.PopupMenu popupModul;
        private DevExpress.XtraBars.PopupMenu popupYetki;
        private DevExpress.XtraBars.BarButtonItem mnuOzYetkiGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzYetkiListe;
        private Data.DSDataSystemTableAdapters.SYS_ModulTableAdapter dtModul;
        private Data.DSDataSystemTableAdapters.SYS_ModulYetkiTableAdapter dtYetki;
        private Data.DSDataSystem ds;
        private System.Windows.Forms.BindingSource bsModul;
        private System.Windows.Forms.BindingSource bsYetki;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colYetkiAdiDilKey;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDilkey;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemFormu;
        private DevExpress.XtraGrid.Columns.GridColumn colFormAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colParametre;
        private DevExpress.XtraGrid.Columns.GridColumn colLoadParam;
        private DevExpress.XtraGrid.Columns.GridColumn colDefaultParam;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriParam;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapParam;
        private DevExpress.XtraGrid.Columns.GridColumn colKHesapParam;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemIcon;
        private DevExpress.XtraGrid.Columns.GridColumn colModulName;
        private DevExpress.XtraGrid.Columns.GridColumn colPopup;
        private DevExpress.XtraGrid.Columns.GridColumn colMultiDilKey;
        private DevExpress.XtraGrid.Columns.GridColumn colSeriTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colSystem;
    }
}