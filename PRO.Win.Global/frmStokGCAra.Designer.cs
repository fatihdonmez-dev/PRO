namespace PRO.Win.Global
{
    partial class frmStokGCAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokGCAra));
            this.bManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYenile = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuSec = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.IMG24 = new DevExpress.Utils.ImageCollection(this.components);
            this.mnuOzelliklerGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerListe = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.gridListe = new DevExpress.XtraGrid.GridControl();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new PRO.Data.Global.DSGlobal();
            this.gwListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeSeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeSira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurucuTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBedelsiz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridListe = new DevExpress.XtraLayout.LayoutControlItem();
            this.dt = new PRO.Data.Global.DSGlobalTableAdapters.V_STI_EvrakListeTableAdapter();
            this.popupListe = new DevExpress.XtraBars.PopupMenu(this.components);
            this.colHesapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
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
            this.bManager.Form = this;
            this.bManager.Images = this.IMG24;
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuYenile,
            this.mnuSec,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuOzelliklerGenel,
            this.mnuOzelliklerListe});
            this.bManager.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYenile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSec, true),
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
            this.mnuYenile.Id = 0;
            this.mnuYenile.ImageIndex = 5;
            this.mnuYenile.Name = "mnuYenile";
            this.mnuYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYenile_ItemClick);
            // 
            // mnuSec
            // 
            this.mnuSec.Caption = "Seç";
            this.mnuSec.Id = 1;
            this.mnuSec.ImageIndex = 3;
            this.mnuSec.Name = "mnuSec";
            this.mnuSec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSec_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 2;
            this.mnuKapat.ImageIndex = 1;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 3;
            this.barSubItem1.ImageIndex = 4;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGorunumKaydet)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnuGorunumKaydet
            // 
            this.mnuGorunumKaydet.Caption = "Görünüm Kaydet";
            this.mnuGorunumKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuGorunumKaydet.Glyph")));
            this.mnuGorunumKaydet.Id = 4;
            this.mnuGorunumKaydet.Name = "mnuGorunumKaydet";
            this.mnuGorunumKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGorunumKaydet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(865, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 388);
            this.barDockControlBottom.Size = new System.Drawing.Size(865, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 349);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(865, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 349);
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "arama.png");
            this.IMG24.Images.SetKeyName(1, "cikis1.png");
            this.IMG24.Images.SetKeyName(2, "floppy1.png");
            this.IMG24.Images.SetKeyName(3, "Ok.png");
            this.IMG24.Images.SetKeyName(4, "Settings.png");
            this.IMG24.Images.SetKeyName(5, "refresh.png");
            // 
            // mnuOzelliklerGenel
            // 
            this.mnuOzelliklerGenel.Caption = "Genel Özellikler";
            this.mnuOzelliklerGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzelliklerGenel.Glyph")));
            this.mnuOzelliklerGenel.Id = 5;
            this.mnuOzelliklerGenel.Name = "mnuOzelliklerGenel";
            this.mnuOzelliklerGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzelliklerGenel_ItemClick);
            // 
            // mnuOzelliklerListe
            // 
            this.mnuOzelliklerListe.Caption = "Liste Özellikler";
            this.mnuOzelliklerListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzelliklerListe.Glyph")));
            this.mnuOzelliklerListe.Id = 6;
            this.mnuOzelliklerListe.Name = "mnuOzelliklerListe";
            this.mnuOzelliklerListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzelliklerListe_ItemClick);
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.gridListe);
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
            this._Layout.Size = new System.Drawing.Size(865, 349);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // gridListe
            // 
            this.gridListe.DataSource = this.bs;
            this.gridListe.Location = new System.Drawing.Point(15, 12);
            this.gridListe.MainView = this.gwListe;
            this.gridListe.MenuManager = this.bManager;
            this.gridListe.Name = "gridListe";
            this.gridListe.Size = new System.Drawing.Size(838, 325);
            this.gridListe.TabIndex = 4;
            this.gridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwListe});
            // 
            // bs
            // 
            this.bs.DataMember = "V_STI_EvrakListe";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSGlobal";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gwListe
            // 
            this.gwListe.ColumnPanelRowHeight = 35;
            this.gwListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHesapAdi,
            this.colTarih,
            this.colFisNo,
            this.colBelgeTarihi,
            this.colBelgeSeri,
            this.colBelgeSira,
            this.colPlaka,
            this.colSurucuTel,
            this.colDurum,
            this.colEvrakNo,
            this.colDepoAdi,
            this.colDepoAdres,
            this.colBirim,
            this.colMiktar,
            this.colFiyat,
            this.colTutar,
            this.colBedelsiz,
            this.colStokKodu,
            this.colStokAdi,
            this.colStokTipi,
            this.colBarkod});
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
            this.gwListe.DoubleClick += new System.EventHandler(this.gwListe_DoubleClick);
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
            this.colTarih.VisibleIndex = 1;
            // 
            // colFisNo
            // 
            this.colFisNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colFisNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFisNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFisNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFisNo.Caption = "Fiş No";
            this.colFisNo.FieldName = "FisNo";
            this.colFisNo.Name = "colFisNo";
            this.colFisNo.Visible = true;
            this.colFisNo.VisibleIndex = 2;
            // 
            // colBelgeTarihi
            // 
            this.colBelgeTarihi.AppearanceHeader.Options.UseTextOptions = true;
            this.colBelgeTarihi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBelgeTarihi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colBelgeTarihi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBelgeTarihi.FieldName = "BelgeTarihi";
            this.colBelgeTarihi.Name = "colBelgeTarihi";
            this.colBelgeTarihi.Visible = true;
            this.colBelgeTarihi.VisibleIndex = 3;
            // 
            // colBelgeSeri
            // 
            this.colBelgeSeri.AppearanceHeader.Options.UseTextOptions = true;
            this.colBelgeSeri.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBelgeSeri.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colBelgeSeri.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBelgeSeri.FieldName = "BelgeSeri";
            this.colBelgeSeri.Name = "colBelgeSeri";
            this.colBelgeSeri.Visible = true;
            this.colBelgeSeri.VisibleIndex = 4;
            // 
            // colBelgeSira
            // 
            this.colBelgeSira.AppearanceHeader.Options.UseTextOptions = true;
            this.colBelgeSira.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBelgeSira.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colBelgeSira.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBelgeSira.Caption = "Belge Sıra";
            this.colBelgeSira.FieldName = "BelgeSira";
            this.colBelgeSira.Name = "colBelgeSira";
            this.colBelgeSira.Visible = true;
            this.colBelgeSira.VisibleIndex = 5;
            // 
            // colPlaka
            // 
            this.colPlaka.AppearanceHeader.Options.UseTextOptions = true;
            this.colPlaka.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPlaka.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colPlaka.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPlaka.FieldName = "Plaka";
            this.colPlaka.Name = "colPlaka";
            this.colPlaka.Visible = true;
            this.colPlaka.VisibleIndex = 6;
            // 
            // colSurucuTel
            // 
            this.colSurucuTel.AppearanceHeader.Options.UseTextOptions = true;
            this.colSurucuTel.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSurucuTel.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSurucuTel.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSurucuTel.Caption = "Sürücü Tel";
            this.colSurucuTel.FieldName = "SurucuTel";
            this.colSurucuTel.Name = "colSurucuTel";
            this.colSurucuTel.Visible = true;
            this.colSurucuTel.VisibleIndex = 7;
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
            this.colDurum.VisibleIndex = 8;
            // 
            // colEvrakNo
            // 
            this.colEvrakNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colEvrakNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEvrakNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colEvrakNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colEvrakNo.FieldName = "EvrakNo";
            this.colEvrakNo.Name = "colEvrakNo";
            this.colEvrakNo.Visible = true;
            this.colEvrakNo.VisibleIndex = 9;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepoAdi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepoAdi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDepoAdi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 10;
            // 
            // colDepoAdres
            // 
            this.colDepoAdres.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepoAdres.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepoAdres.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDepoAdres.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDepoAdres.FieldName = "DepoAdres";
            this.colDepoAdres.Name = "colDepoAdres";
            this.colDepoAdres.Visible = true;
            this.colDepoAdres.VisibleIndex = 11;
            // 
            // colBirim
            // 
            this.colBirim.AppearanceHeader.Options.UseTextOptions = true;
            this.colBirim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirim.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colBirim.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 12;
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
            this.colMiktar.VisibleIndex = 13;
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
            this.colFiyat.VisibleIndex = 14;
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
            this.colTutar.VisibleIndex = 15;
            // 
            // colBedelsiz
            // 
            this.colBedelsiz.AppearanceHeader.Options.UseTextOptions = true;
            this.colBedelsiz.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBedelsiz.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colBedelsiz.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBedelsiz.FieldName = "Bedelsiz";
            this.colBedelsiz.Name = "colBedelsiz";
            this.colBedelsiz.Visible = true;
            this.colBedelsiz.VisibleIndex = 16;
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
            this.colStokKodu.VisibleIndex = 17;
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
            this.colStokAdi.VisibleIndex = 18;
            // 
            // colStokTipi
            // 
            this.colStokTipi.AppearanceHeader.Options.UseTextOptions = true;
            this.colStokTipi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStokTipi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colStokTipi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colStokTipi.FieldName = "StokTipi";
            this.colStokTipi.Name = "colStokTipi";
            this.colStokTipi.Visible = true;
            this.colStokTipi.VisibleIndex = 19;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridListe});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.AlignControlsWithHiddenText = true;
            this.layoutControlGroup1.Size = new System.Drawing.Size(865, 349);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyGridListe
            // 
            this.lyGridListe.Control = this.gridListe;
            this.lyGridListe.Location = new System.Drawing.Point(0, 0);
            this.lyGridListe.Name = "lyGridListe";
            this.lyGridListe.Size = new System.Drawing.Size(845, 329);
            this.lyGridListe.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridListe.TextVisible = false;
            // 
            // dt
            // 
            this.dt.ClearBeforeFill = true;
            // 
            // popupListe
            // 
            this.popupListe.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerGenel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerListe)});
            this.popupListe.Manager = this.bManager;
            this.popupListe.Name = "popupListe";
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
            this.colHesapAdi.VisibleIndex = 0;
            // 
            // colBarkod
            // 
            this.colBarkod.AppearanceHeader.Options.UseTextOptions = true;
            this.colBarkod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBarkod.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colBarkod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 20;
            // 
            // frmStokGCAra
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 388);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmStokGCAra";
            this.Text = "frmStokGCAra";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem mnuYenile;
        private DevExpress.XtraBars.BarLargeButtonItem mnuSec;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gwListe;
        private DevExpress.XtraLayout.LayoutControlItem lyGridListe;
        private System.Windows.Forms.BindingSource bs;
        private Data.Global.DSGlobal ds;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colFisNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeSeri;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeSira;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaka;
        private DevExpress.XtraGrid.Columns.GridColumn colSurucuTel;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colEvrakNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colBedelsiz;
        private Data.Global.DSGlobalTableAdapters.V_STI_EvrakListeTableAdapter dt;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerListe;
        private DevExpress.Utils.ImageCollection IMG24;
        private DevExpress.XtraBars.PopupMenu popupListe;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
    }
}