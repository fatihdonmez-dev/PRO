namespace PRO.Win.Stok
{
    partial class frmStokGrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokGrup));
            this.bManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYenile = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKaydet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.IMG24 = new DevExpress.Utils.ImageCollection(this.components);
            this.mnuOzGrupGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzGrupListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzTurGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzTurListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzCinsGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzCinsListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuTurPasif = new DevExpress.XtraBars.BarButtonItem();
            this.mnuCinsSil = new DevExpress.XtraBars.BarButtonItem();
            this.mnuCinsPasif = new DevExpress.XtraBars.BarButtonItem();
            this.mnuGrupSil = new DevExpress.XtraBars.BarButtonItem();
            this.mnuGrupPasif = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.gridCins = new DevExpress.XtraGrid.GridControl();
            this.bsCins = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new PRO.Data.Stok.DSStok();
            this.gwCins = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCinsKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCinsAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridTur = new DevExpress.XtraGrid.GridControl();
            this.bsTur = new System.Windows.Forms.BindingSource(this.components);
            this.gwTur = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTurKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKisaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridGrup = new DevExpress.XtraGrid.GridControl();
            this.bsGrup = new System.Windows.Forms.BindingSource(this.components);
            this.gwGrup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGrupKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridGrup = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyGridTur = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyGridCins = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupGrup = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupTur = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupCins = new DevExpress.XtraBars.PopupMenu(this.components);
            this.dtGrup = new PRO.Data.Stok.DSStokTableAdapters.STK_GrupTableAdapter();
            this.dtCins = new PRO.Data.Stok.DSStokTableAdapters.STK_GrupCinsTableAdapter();
            this.dtTur = new PRO.Data.Stok.DSStokTableAdapters.STK_GrupCinsTurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwCins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridCins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupCins)).BeginInit();
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
            this.mnuKaydet,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuOzGrupGenel,
            this.mnuOzGrupListe,
            this.mnuOzTurGenel,
            this.mnuOzTurListe,
            this.mnuOzCinsGenel,
            this.mnuOzCinsListe,
            this.mnuTurPasif,
            this.mnuCinsSil,
            this.mnuCinsPasif,
            this.mnuGrupSil,
            this.mnuGrupPasif,
            this.mnuYenile});
            this.bManager.MaxItemId = 16;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYenile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKaydet, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKapat, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // mnuYenile
            // 
            this.mnuYenile.Caption = "Yenile";
            this.mnuYenile.Id = 15;
            this.mnuYenile.ImageIndex = 3;
            this.mnuYenile.Name = "mnuYenile";
            this.mnuYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYenile_ItemClick);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Caption = "Kaydet";
            this.mnuKaydet.Id = 0;
            this.mnuKaydet.ImageIndex = 1;
            this.mnuKaydet.Name = "mnuKaydet";
            this.E_Yetki.SetYetkiEnable(this.mnuKaydet, "_KAYDET");
            this.mnuKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKaydet_ItemClick);
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
            this.barSubItem1.ImageIndex = 2;
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
            this.barDockControlTop.Size = new System.Drawing.Size(726, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 394);
            this.barDockControlBottom.Size = new System.Drawing.Size(726, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 355);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(726, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 355);
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "cikis1.png");
            this.IMG24.Images.SetKeyName(1, "floppy1.png");
            this.IMG24.Images.SetKeyName(2, "Settings.png");
            this.IMG24.Images.SetKeyName(3, "refresh.png");
            // 
            // mnuOzGrupGenel
            // 
            this.mnuOzGrupGenel.Caption = "Genel Özellikler";
            this.mnuOzGrupGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzGrupGenel.Glyph")));
            this.mnuOzGrupGenel.Id = 4;
            this.mnuOzGrupGenel.Name = "mnuOzGrupGenel";
            this.mnuOzGrupGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzGrupGenel_ItemClick);
            // 
            // mnuOzGrupListe
            // 
            this.mnuOzGrupListe.Caption = "Liste Özellikler";
            this.mnuOzGrupListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzGrupListe.Glyph")));
            this.mnuOzGrupListe.Id = 5;
            this.mnuOzGrupListe.Name = "mnuOzGrupListe";
            this.mnuOzGrupListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzGrupListe_ItemClick);
            // 
            // mnuOzTurGenel
            // 
            this.mnuOzTurGenel.Caption = "Genel Özellikler";
            this.mnuOzTurGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzTurGenel.Glyph")));
            this.mnuOzTurGenel.Id = 6;
            this.mnuOzTurGenel.Name = "mnuOzTurGenel";
            this.mnuOzTurGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzTurGenel_ItemClick);
            // 
            // mnuOzTurListe
            // 
            this.mnuOzTurListe.Caption = "Liste Özellikler";
            this.mnuOzTurListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzTurListe.Glyph")));
            this.mnuOzTurListe.Id = 7;
            this.mnuOzTurListe.Name = "mnuOzTurListe";
            this.mnuOzTurListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzTurListe_ItemClick);
            // 
            // mnuOzCinsGenel
            // 
            this.mnuOzCinsGenel.Caption = "Genel Özellikler";
            this.mnuOzCinsGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzCinsGenel.Glyph")));
            this.mnuOzCinsGenel.Id = 8;
            this.mnuOzCinsGenel.Name = "mnuOzCinsGenel";
            this.mnuOzCinsGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzCinsGenel_ItemClick);
            // 
            // mnuOzCinsListe
            // 
            this.mnuOzCinsListe.Caption = "Liste Özellikler";
            this.mnuOzCinsListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzCinsListe.Glyph")));
            this.mnuOzCinsListe.Id = 9;
            this.mnuOzCinsListe.Name = "mnuOzCinsListe";
            this.mnuOzCinsListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzCinsListe_ItemClick);
            // 
            // mnuTurPasif
            // 
            this.mnuTurPasif.Caption = "Pasif";
            this.mnuTurPasif.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuTurPasif.Glyph")));
            this.mnuTurPasif.Id = 10;
            this.mnuTurPasif.Name = "mnuTurPasif";
            this.mnuTurPasif.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuTurPasif_ItemClick);
            // 
            // mnuCinsSil
            // 
            this.mnuCinsSil.Caption = "Sil";
            this.mnuCinsSil.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuCinsSil.Glyph")));
            this.mnuCinsSil.Id = 11;
            this.mnuCinsSil.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuCinsSil.LargeGlyph")));
            this.mnuCinsSil.Name = "mnuCinsSil";
            this.mnuCinsSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuCinsSil_ItemClick);
            // 
            // mnuCinsPasif
            // 
            this.mnuCinsPasif.Caption = "Pasif";
            this.mnuCinsPasif.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuCinsPasif.Glyph")));
            this.mnuCinsPasif.Id = 12;
            this.mnuCinsPasif.Name = "mnuCinsPasif";
            this.mnuCinsPasif.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuCinsPasif_ItemClick);
            // 
            // mnuGrupSil
            // 
            this.mnuGrupSil.Caption = "Sil";
            this.mnuGrupSil.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuGrupSil.Glyph")));
            this.mnuGrupSil.Id = 13;
            this.mnuGrupSil.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuGrupSil.LargeGlyph")));
            this.mnuGrupSil.Name = "mnuGrupSil";
            this.mnuGrupSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGrupSil_ItemClick);
            // 
            // mnuGrupPasif
            // 
            this.mnuGrupPasif.Caption = "Pasif";
            this.mnuGrupPasif.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuGrupPasif.Glyph")));
            this.mnuGrupPasif.Id = 14;
            this.mnuGrupPasif.Name = "mnuGrupPasif";
            this.mnuGrupPasif.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGrupPasif_ItemClick);
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.gridCins);
            this._Layout.Controls.Add(this.gridTur);
            this._Layout.Controls.Add(this.gridGrup);
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
            this._Layout.Size = new System.Drawing.Size(726, 355);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // gridCins
            // 
            this.gridCins.DataSource = this.bsCins;
            this.gridCins.Location = new System.Drawing.Point(306, 12);
            this.gridCins.MainView = this.gwCins;
            this.gridCins.MenuManager = this.bManager;
            this.gridCins.Name = "gridCins";
            this.gridCins.Size = new System.Drawing.Size(174, 331);
            this.gridCins.TabIndex = 6;
            this.gridCins.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwCins});
            // 
            // bsCins
            // 
            this.bsCins.DataMember = "STK_GrupCins";
            this.bsCins.DataSource = this.ds;
            this.bsCins.Filter = "Silindi = 0 AND Pasif = 0";
            // 
            // ds
            // 
            this.ds.DataSetName = "DSStok";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gwCins
            // 
            this.gwCins.ColumnPanelRowHeight = 30;
            this.gwCins.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCinsKodu,
            this.colCinsAdi,
            this.colTip});
            this.gwCins.GridControl = this.gridCins;
            this.gwCins.Name = "gwCins";
            this.gwCins.OptionsDetail.EnableMasterViewMode = false;
            this.gwCins.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwCins.OptionsLayout.Columns.StoreAppearance = true;
            this.gwCins.OptionsLayout.StoreAllOptions = true;
            this.gwCins.OptionsLayout.StoreAppearance = true;
            this.gwCins.OptionsLayout.StoreFormatRules = true;
            this.gwCins.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwCins.OptionsView.ColumnAutoWidth = false;
            this.gwCins.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gwCins.OptionsView.ShowGroupPanel = false;
            this.gwCins.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwCins_PopupMenuShowing);
            this.gwCins.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gwCins_FocusedRowChanged);
            this.gwCins.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwCins_FocusedColumnChanged);
            // 
            // colCinsKodu
            // 
            this.colCinsKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colCinsKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCinsKodu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colCinsKodu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCinsKodu.FieldName = "CinsKodu";
            this.colCinsKodu.Name = "colCinsKodu";
            this.colCinsKodu.Visible = true;
            this.colCinsKodu.VisibleIndex = 0;
            // 
            // colCinsAdi
            // 
            this.colCinsAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colCinsAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCinsAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colCinsAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCinsAdi.FieldName = "CinsAdi";
            this.colCinsAdi.Name = "colCinsAdi";
            this.colCinsAdi.Visible = true;
            this.colCinsAdi.VisibleIndex = 1;
            // 
            // colTip
            // 
            this.colTip.AppearanceHeader.Options.UseTextOptions = true;
            this.colTip.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTip.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTip.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTip.FieldName = "Tip";
            this.colTip.Name = "colTip";
            this.colTip.Visible = true;
            this.colTip.VisibleIndex = 2;
            // 
            // gridTur
            // 
            this.gridTur.DataSource = this.bsTur;
            this.gridTur.Location = new System.Drawing.Point(537, 12);
            this.gridTur.MainView = this.gwTur;
            this.gridTur.MenuManager = this.bManager;
            this.gridTur.Name = "gridTur";
            this.gridTur.Size = new System.Drawing.Size(177, 331);
            this.gridTur.TabIndex = 5;
            this.gridTur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwTur});
            // 
            // bsTur
            // 
            this.bsTur.DataMember = "STK_GrupCinsTur";
            this.bsTur.DataSource = this.ds;
            this.bsTur.Filter = "Pasif = 0";
            // 
            // gwTur
            // 
            this.gwTur.ColumnPanelRowHeight = 30;
            this.gwTur.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTurKodu,
            this.colTurAdi,
            this.colKisaAdi});
            this.gwTur.GridControl = this.gridTur;
            this.gwTur.Name = "gwTur";
            this.gwTur.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwTur.OptionsLayout.Columns.StoreAppearance = true;
            this.gwTur.OptionsLayout.StoreAllOptions = true;
            this.gwTur.OptionsLayout.StoreAppearance = true;
            this.gwTur.OptionsLayout.StoreFormatRules = true;
            this.gwTur.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwTur.OptionsView.ColumnAutoWidth = false;
            this.gwTur.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gwTur.OptionsView.ShowGroupPanel = false;
            this.gwTur.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwTur_PopupMenuShowing);
            this.gwTur.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwTur_FocusedColumnChanged);
            // 
            // colTurKodu
            // 
            this.colTurKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colTurKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTurKodu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTurKodu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTurKodu.FieldName = "TurKodu";
            this.colTurKodu.Name = "colTurKodu";
            this.colTurKodu.Visible = true;
            this.colTurKodu.VisibleIndex = 0;
            // 
            // colTurAdi
            // 
            this.colTurAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colTurAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTurAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTurAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTurAdi.FieldName = "TurAdi";
            this.colTurAdi.Name = "colTurAdi";
            this.colTurAdi.Visible = true;
            this.colTurAdi.VisibleIndex = 1;
            // 
            // colKisaAdi
            // 
            this.colKisaAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colKisaAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKisaAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colKisaAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKisaAdi.FieldName = "KisaAdi";
            this.colKisaAdi.Name = "colKisaAdi";
            this.colKisaAdi.Visible = true;
            this.colKisaAdi.VisibleIndex = 2;
            // 
            // gridGrup
            // 
            this.gridGrup.DataSource = this.bsGrup;
            this.gridGrup.Location = new System.Drawing.Point(65, 12);
            this.gridGrup.MainView = this.gwGrup;
            this.gridGrup.MenuManager = this.bManager;
            this.gridGrup.Name = "gridGrup";
            this.gridGrup.Size = new System.Drawing.Size(184, 331);
            this.gridGrup.TabIndex = 4;
            this.gridGrup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwGrup});
            // 
            // bsGrup
            // 
            this.bsGrup.DataMember = "STK_Grup";
            this.bsGrup.DataSource = this.ds;
            this.bsGrup.Filter = "Silindi = 0 AND Pasif = 0";
            // 
            // gwGrup
            // 
            this.gwGrup.ColumnPanelRowHeight = 30;
            this.gwGrup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGrupKod,
            this.colGrupAd});
            this.gwGrup.GridControl = this.gridGrup;
            this.gwGrup.Name = "gwGrup";
            this.gwGrup.OptionsDetail.EnableMasterViewMode = false;
            this.gwGrup.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwGrup.OptionsLayout.Columns.StoreAppearance = true;
            this.gwGrup.OptionsLayout.StoreAllOptions = true;
            this.gwGrup.OptionsLayout.StoreAppearance = true;
            this.gwGrup.OptionsLayout.StoreFormatRules = true;
            this.gwGrup.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwGrup.OptionsView.ColumnAutoWidth = false;
            this.gwGrup.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gwGrup.OptionsView.ShowGroupPanel = false;
            this.gwGrup.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwGrup_PopupMenuShowing);
            this.gwGrup.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gwGrup_FocusedRowChanged);
            this.gwGrup.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwGrup_FocusedColumnChanged);
            // 
            // colGrupKod
            // 
            this.colGrupKod.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrupKod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrupKod.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colGrupKod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colGrupKod.FieldName = "GrupKod";
            this.colGrupKod.Name = "colGrupKod";
            this.colGrupKod.Visible = true;
            this.colGrupKod.VisibleIndex = 0;
            // 
            // colGrupAd
            // 
            this.colGrupAd.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrupAd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGrupAd.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colGrupAd.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colGrupAd.FieldName = "GrupAd";
            this.colGrupAd.Name = "colGrupAd";
            this.colGrupAd.Visible = true;
            this.colGrupAd.VisibleIndex = 1;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridGrup,
            this.lyGridTur,
            this.lyGridCins});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(726, 355);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyGridGrup
            // 
            this.lyGridGrup.Control = this.gridGrup;
            this.lyGridGrup.Location = new System.Drawing.Point(0, 0);
            this.lyGridGrup.Name = "lyGridGrup";
            this.lyGridGrup.Size = new System.Drawing.Size(241, 335);
            this.lyGridGrup.TextSize = new System.Drawing.Size(50, 20);
            // 
            // lyGridTur
            // 
            this.lyGridTur.Control = this.gridTur;
            this.lyGridTur.Location = new System.Drawing.Point(472, 0);
            this.lyGridTur.Name = "lyGridTur";
            this.lyGridTur.Size = new System.Drawing.Size(234, 335);
            this.lyGridTur.TextSize = new System.Drawing.Size(50, 20);
            // 
            // lyGridCins
            // 
            this.lyGridCins.Control = this.gridCins;
            this.lyGridCins.Location = new System.Drawing.Point(241, 0);
            this.lyGridCins.Name = "lyGridCins";
            this.lyGridCins.Size = new System.Drawing.Size(231, 335);
            this.lyGridCins.TextSize = new System.Drawing.Size(50, 20);
            // 
            // popupGrup
            // 
            this.popupGrup.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGrupSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGrupPasif),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzGrupGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzGrupListe)});
            this.popupGrup.Manager = this.bManager;
            this.popupGrup.Name = "popupGrup";
            // 
            // popupTur
            // 
            this.popupTur.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuTurPasif),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzTurGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzTurListe)});
            this.popupTur.Manager = this.bManager;
            this.popupTur.Name = "popupTur";
            // 
            // popupCins
            // 
            this.popupCins.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuCinsSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuCinsPasif),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzCinsGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzCinsListe)});
            this.popupCins.Manager = this.bManager;
            this.popupCins.Name = "popupCins";
            // 
            // dtGrup
            // 
            this.dtGrup.ClearBeforeFill = true;
            // 
            // dtCins
            // 
            this.dtCins.ClearBeforeFill = true;
            // 
            // dtTur
            // 
            this.dtTur.ClearBeforeFill = true;
            // 
            // frmStokGrup
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 394);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmStokGrup";
            this.Text = "frmStokGrup";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwCins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridCins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGrup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupCins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
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
        private DevExpress.XtraGrid.GridControl gridGrup;
        private DevExpress.XtraGrid.Views.Grid.GridView gwGrup;
        private DevExpress.XtraLayout.LayoutControlItem lyGridGrup;
        private DevExpress.XtraGrid.GridControl gridTur;
        private DevExpress.XtraGrid.Views.Grid.GridView gwTur;
        private DevExpress.XtraLayout.LayoutControlItem lyGridTur;
        private DevExpress.XtraGrid.GridControl gridCins;
        private DevExpress.XtraGrid.Views.Grid.GridView gwCins;
        private DevExpress.XtraLayout.LayoutControlItem lyGridCins;
        private DevExpress.XtraBars.BarButtonItem mnuOzGrupGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzGrupListe;
        private DevExpress.XtraBars.PopupMenu popupGrup;
        private DevExpress.XtraBars.BarButtonItem mnuOzTurGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzTurListe;
        private DevExpress.XtraBars.PopupMenu popupTur;
        private DevExpress.XtraBars.PopupMenu popupCins;
        private DevExpress.XtraBars.BarButtonItem mnuOzCinsGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzCinsListe;
        private Data.Stok.DSStok ds;
        private Data.Stok.DSStokTableAdapters.STK_GrupTableAdapter dtGrup;
        private Data.Stok.DSStokTableAdapters.STK_GrupCinsTableAdapter dtCins;
        private Data.Stok.DSStokTableAdapters.STK_GrupCinsTurTableAdapter dtTur;
        private System.Windows.Forms.BindingSource bsCins;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTip;
        private System.Windows.Forms.BindingSource bsTur;
        private DevExpress.XtraGrid.Columns.GridColumn colTurKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colTurAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKisaAdi;
        private System.Windows.Forms.BindingSource bsGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupKod;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAd;
        private DevExpress.XtraBars.BarButtonItem mnuTurPasif;
        private DevExpress.XtraBars.BarButtonItem mnuCinsSil;
        private DevExpress.XtraBars.BarButtonItem mnuCinsPasif;
        private DevExpress.XtraBars.BarButtonItem mnuGrupSil;
        private DevExpress.XtraBars.BarButtonItem mnuGrupPasif;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYenile;
        private DevExpress.Utils.ImageCollection IMG24;
    }
}