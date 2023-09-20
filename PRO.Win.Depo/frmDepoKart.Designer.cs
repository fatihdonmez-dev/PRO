namespace PRO.Win.Depo
{
    partial class frmDepoKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepoKart));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.bManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYeni = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuSil = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKaydet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.IMG24 = new DevExpress.Utils.ImageCollection();
            this.mnuOzelliklerGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAdresSil = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.bs = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.Depo.DSDepo();
            this.beLokasyon = new DevExpress.XtraEditors.ButtonEdit();
            this.leDepoTip = new DevExpress.XtraEditors.LookUpEdit();
            this.gridAdres = new DevExpress.XtraGrid.GridControl();
            this.bsAdres = new System.Windows.Forms.BindingSource();
            this.gwAdres = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenislik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYukseklik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPasif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyDepoKodu = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyGridAdres = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyDepoAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyDepoTipi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyPasif = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupAdres = new DevExpress.XtraBars.PopupMenu();
            this.dt = new PRO.Data.Depo.DSDepoTableAdapters.DEP_KartTableAdapter();
            this.dtAdres = new PRO.Data.Depo.DSDepoTableAdapters.DEP_Kart_AdresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beLokasyon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDepoTip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDepoKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDepoAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDepoTipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyPasif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupAdres)).BeginInit();
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
            this.mnuKaydet,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuOzelliklerGenel,
            this.mnuOzelliklerListe,
            this.mnuAdresSil});
            this.bManager.MaxItemId = 12;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYeni),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSil, true),
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
            this.mnuYeni.ImageIndex = 10;
            this.mnuYeni.Name = "mnuYeni";
            this.E_Yetki.SetYetkiEnable(this.mnuYeni, "_EKLE");
            this.mnuYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYeni_ItemClick);
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
            // mnuKaydet
            // 
            this.mnuKaydet.Caption = "Kaydet";
            this.mnuKaydet.Id = 2;
            this.mnuKaydet.ImageIndex = 6;
            this.mnuKaydet.Name = "mnuKaydet";
            this.E_Yetki.SetYetkiEnable(this.mnuKaydet, "_KAYDET");
            this.mnuKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKaydet_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 3;
            this.mnuKapat.ImageIndex = 19;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 5;
            this.barSubItem1.ImageIndex = 16;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGorunumKaydet)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnuGorunumKaydet
            // 
            this.mnuGorunumKaydet.Caption = "Görünüm Kaydet";
            this.mnuGorunumKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuGorunumKaydet.Glyph")));
            this.mnuGorunumKaydet.Id = 6;
            this.mnuGorunumKaydet.Name = "mnuGorunumKaydet";
            this.mnuGorunumKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGorunumKaydet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(598, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 391);
            this.barDockControlBottom.Size = new System.Drawing.Size(598, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 352);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(598, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 352);
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "back36.png");
            this.IMG24.Images.SetKeyName(1, "Delete24.png");
            this.IMG24.Images.SetKeyName(2, "delete81.png");
            this.IMG24.Images.SetKeyName(3, "door9.png");
            this.IMG24.Images.SetKeyName(4, "Edit.png");
            this.IMG24.Images.SetKeyName(5, "ekle24.png");
            this.IMG24.Images.SetKeyName(6, "floppy1.png");
            this.IMG24.Images.SetKeyName(7, "KaydetCik.png");
            this.IMG24.Images.SetKeyName(8, "Kısayol.png");
            this.IMG24.Images.SetKeyName(9, "Kopyala.png");
            this.IMG24.Images.SetKeyName(10, "new10.png");
            this.IMG24.Images.SetKeyName(11, "Ok.png");
            this.IMG24.Images.SetKeyName(12, "Product.png");
            this.IMG24.Images.SetKeyName(13, "refresh.png");
            this.IMG24.Images.SetKeyName(14, "right133.png");
            this.IMG24.Images.SetKeyName(15, "search102.png");
            this.IMG24.Images.SetKeyName(16, "Settings.png");
            this.IMG24.Images.SetKeyName(17, "Yetki.png");
            this.IMG24.Images.SetKeyName(18, "arama.png");
            this.IMG24.Images.SetKeyName(19, "cikis1.png");
            this.IMG24.Images.SetKeyName(20, "printer70.png");
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
            // mnuAdresSil
            // 
            this.mnuAdresSil.Caption = "Sil";
            this.mnuAdresSil.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuAdresSil.Glyph")));
            this.mnuAdresSil.Id = 10;
            this.mnuAdresSil.Name = "mnuAdresSil";
            this.E_Yetki.SetYetkiEnable(this.mnuAdresSil, "_SIL");
            this.mnuAdresSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuAdresSil_ItemClick);
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.checkEdit1);
            this._Layout.Controls.Add(this.beLokasyon);
            this._Layout.Controls.Add(this.leDepoTip);
            this._Layout.Controls.Add(this.gridAdres);
            this._Layout.Controls.Add(this.textEdit2);
            this._Layout.Controls.Add(this.textEdit1);
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
            this._Layout.Size = new System.Drawing.Size(598, 352);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Pasif", true));
            this.checkEdit1.Location = new System.Drawing.Point(474, 12);
            this.checkEdit1.MenuManager = this.bManager;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "Pasif";
            this.checkEdit1.Size = new System.Drawing.Size(112, 19);
            this.checkEdit1.StyleController = this._Layout;
            this.checkEdit1.TabIndex = 9;
            // 
            // bs
            // 
            this.bs.DataMember = "DEP_Kart";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSDepo";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beLokasyon
            // 
            this.beLokasyon.Location = new System.Drawing.Point(115, 60);
            this.beLokasyon.MenuManager = this.bManager;
            this.beLokasyon.Name = "beLokasyon";
            this.beLokasyon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beLokasyon.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beLokasyon.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.beLokasyon.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beLokasyon.Size = new System.Drawing.Size(471, 20);
            this.beLokasyon.StyleController = this._Layout;
            this.beLokasyon.TabIndex = 8;
            // 
            // leDepoTip
            // 
            this.leDepoTip.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "DepoTipi", true));
            this.leDepoTip.Location = new System.Drawing.Point(115, 12);
            this.leDepoTip.MenuManager = this.bManager;
            this.leDepoTip.Name = "leDepoTip";
            this.leDepoTip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("leDepoTip.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.leDepoTip.Properties.NullText = "";
            this.leDepoTip.Size = new System.Drawing.Size(355, 20);
            this.leDepoTip.StyleController = this._Layout;
            this.leDepoTip.TabIndex = 7;
            // 
            // gridAdres
            // 
            this.gridAdres.DataSource = this.bsAdres;
            this.gridAdres.Location = new System.Drawing.Point(12, 84);
            this.gridAdres.MainView = this.gwAdres;
            this.gridAdres.MenuManager = this.bManager;
            this.gridAdres.Name = "gridAdres";
            this.gridAdres.Size = new System.Drawing.Size(574, 256);
            this.gridAdres.TabIndex = 6;
            this.gridAdres.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwAdres});
            // 
            // bsAdres
            // 
            this.bsAdres.DataMember = "DEP_Kart_Adres";
            this.bsAdres.DataSource = this.ds;
            // 
            // gwAdres
            // 
            this.gwAdres.ColumnPanelRowHeight = 40;
            this.gwAdres.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdres,
            this.colGenislik,
            this.colYukseklik,
            this.colPasif});
            this.gwAdres.GridControl = this.gridAdres;
            this.gwAdres.Name = "gwAdres";
            this.gwAdres.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwAdres.OptionsLayout.Columns.StoreAppearance = true;
            this.gwAdres.OptionsLayout.StoreAllOptions = true;
            this.gwAdres.OptionsLayout.StoreAppearance = true;
            this.gwAdres.OptionsLayout.StoreFormatRules = true;
            this.gwAdres.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwAdres.OptionsView.ColumnAutoWidth = false;
            this.gwAdres.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gwAdres.OptionsView.ShowGroupPanel = false;
            this.gwAdres.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwAdres_PopupMenuShowing);
            this.gwAdres.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwAdres_FocusedColumnChanged);
            // 
            // colAdres
            // 
            this.colAdres.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdres.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdres.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colAdres.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 0;
            // 
            // colGenislik
            // 
            this.colGenislik.AppearanceHeader.Options.UseTextOptions = true;
            this.colGenislik.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGenislik.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colGenislik.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colGenislik.Caption = "Genişlik";
            this.colGenislik.FieldName = "Genislik";
            this.colGenislik.Name = "colGenislik";
            this.colGenislik.Visible = true;
            this.colGenislik.VisibleIndex = 1;
            // 
            // colYukseklik
            // 
            this.colYukseklik.AppearanceHeader.Options.UseTextOptions = true;
            this.colYukseklik.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYukseklik.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colYukseklik.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colYukseklik.Caption = "Yükseklik";
            this.colYukseklik.FieldName = "Yukseklik";
            this.colYukseklik.Name = "colYukseklik";
            this.colYukseklik.Visible = true;
            this.colYukseklik.VisibleIndex = 2;
            // 
            // colPasif
            // 
            this.colPasif.AppearanceHeader.Options.UseTextOptions = true;
            this.colPasif.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPasif.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colPasif.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPasif.FieldName = "Pasif";
            this.colPasif.Name = "colPasif";
            this.colPasif.Visible = true;
            this.colPasif.VisibleIndex = 3;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "DepoAdi", true));
            this.textEdit2.Location = new System.Drawing.Point(324, 36);
            this.textEdit2.MenuManager = this.bManager;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(262, 20);
            this.textEdit2.StyleController = this._Layout;
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "DepoKodu", true));
            this.textEdit1.Location = new System.Drawing.Point(115, 36);
            this.textEdit1.MenuManager = this.bManager;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(102, 20);
            this.textEdit1.StyleController = this._Layout;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyDepoKodu,
            this.lyGridAdres,
            this.lyDepoAdi,
            this.layoutControlItem1,
            this.lyDepoTipi,
            this.lyPasif});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(598, 352);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyDepoKodu
            // 
            this.lyDepoKodu.Control = this.textEdit1;
            this.lyDepoKodu.Location = new System.Drawing.Point(0, 24);
            this.lyDepoKodu.Name = "lyDepoKodu";
            this.lyDepoKodu.Size = new System.Drawing.Size(209, 24);
            this.lyDepoKodu.Text = "Depo Kodu";
            this.lyDepoKodu.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyGridAdres
            // 
            this.lyGridAdres.Control = this.gridAdres;
            this.lyGridAdres.Location = new System.Drawing.Point(0, 72);
            this.lyGridAdres.Name = "lyGridAdres";
            this.lyGridAdres.Size = new System.Drawing.Size(578, 260);
            this.lyGridAdres.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridAdres.TextVisible = false;
            // 
            // lyDepoAdi
            // 
            this.lyDepoAdi.Control = this.textEdit2;
            this.lyDepoAdi.Location = new System.Drawing.Point(209, 24);
            this.lyDepoAdi.Name = "lyDepoAdi";
            this.lyDepoAdi.Size = new System.Drawing.Size(369, 24);
            this.lyDepoAdi.Text = "Depo Adı";
            this.lyDepoAdi.TextSize = new System.Drawing.Size(100, 20);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.beLokasyon;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(578, 24);
            this.layoutControlItem1.Text = "Lokasyon";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyDepoTipi
            // 
            this.lyDepoTipi.Control = this.leDepoTip;
            this.lyDepoTipi.Location = new System.Drawing.Point(0, 0);
            this.lyDepoTipi.Name = "lyDepoTipi";
            this.lyDepoTipi.Size = new System.Drawing.Size(462, 24);
            this.lyDepoTipi.Text = "Depo Tipi";
            this.lyDepoTipi.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyPasif
            // 
            this.lyPasif.Control = this.checkEdit1;
            this.lyPasif.Location = new System.Drawing.Point(462, 0);
            this.lyPasif.Name = "lyPasif";
            this.lyPasif.Size = new System.Drawing.Size(116, 24);
            this.lyPasif.TextSize = new System.Drawing.Size(0, 0);
            this.lyPasif.TextVisible = false;
            // 
            // popupAdres
            // 
            this.popupAdres.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAdresSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerListe)});
            this.popupAdres.Manager = this.bManager;
            this.popupAdres.Name = "popupAdres";
            // 
            // dt
            // 
            this.dt.ClearBeforeFill = true;
            // 
            // dtAdres
            // 
            this.dtAdres.ClearBeforeFill = true;
            // 
            // frmDepoKart
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 391);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDepoKart";
            this.Text = "frmDepoKart";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beLokasyon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDepoTip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDepoKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDepoAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDepoTipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyPasif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupAdres)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem mnuYeni;
        private DevExpress.XtraBars.BarLargeButtonItem mnuSil;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKaydet;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridAdres;
        private DevExpress.XtraGrid.Views.Grid.GridView gwAdres;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lyDepoKodu;
        private DevExpress.XtraLayout.LayoutControlItem lyGridAdres;
        private DevExpress.XtraLayout.LayoutControlItem lyDepoAdi;
        private DevExpress.XtraEditors.LookUpEdit leDepoTip;
        private DevExpress.XtraLayout.LayoutControlItem lyDepoTipi;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerListe;
        private DevExpress.XtraBars.PopupMenu popupAdres;
        private Data.Depo.DSDepo ds;
        private DevExpress.XtraEditors.ButtonEdit beLokasyon;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private Data.Depo.DSDepoTableAdapters.DEP_KartTableAdapter dt;
        private Data.Depo.DSDepoTableAdapters.DEP_Kart_AdresTableAdapter dtAdres;
        private System.Windows.Forms.BindingSource bsAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colGenislik;
        private DevExpress.XtraGrid.Columns.GridColumn colYukseklik;
        private DevExpress.XtraGrid.Columns.GridColumn colPasif;
        private DevExpress.XtraBars.BarButtonItem mnuAdresSil;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lyPasif;
        private DevExpress.Utils.ImageCollection IMG24;
    }
}