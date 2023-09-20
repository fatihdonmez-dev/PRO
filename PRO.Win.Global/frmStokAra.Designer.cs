namespace PRO.Win.Global
{
    partial class frmStokAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokAra));
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
            this.mnuOzelliklerGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerListe = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.gridListe = new DevExpress.XtraGrid.GridControl();
            this.bs = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.Stok.DSStok();
            this.gwListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMensei = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHesapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSonAlisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeminSuresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokSayac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsgariMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAzamiMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlarmSeviyesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinSiparisMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDVOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridListe = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupListe = new DevExpress.XtraBars.PopupMenu();
            this.dt = new PRO.Data.Stok.DSStokTableAdapters.V_STK_KartListeTableAdapter();
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
            this.mnuSec,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuOzelliklerGenel,
            this.mnuOzelliklerListe});
            this.bManager.MaxItemId = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(547, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 352);
            this.barDockControlBottom.Size = new System.Drawing.Size(547, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 313);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(547, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 313);
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "cikis1.png");
            this.IMG24.Images.SetKeyName(1, "Ok.png");
            this.IMG24.Images.SetKeyName(2, "Settings.png");
            // 
            // mnuOzelliklerGenel
            // 
            this.mnuOzelliklerGenel.Caption = "Genel Özellikler";
            this.mnuOzelliklerGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzelliklerGenel.Glyph")));
            this.mnuOzelliklerGenel.Id = 4;
            this.mnuOzelliklerGenel.Name = "mnuOzelliklerGenel";
            this.mnuOzelliklerGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzelliklerGenel_ItemClick);
            // 
            // mnuOzelliklerListe
            // 
            this.mnuOzelliklerListe.Caption = "Liste Özellikler";
            this.mnuOzelliklerListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzelliklerListe.Glyph")));
            this.mnuOzelliklerListe.Id = 5;
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
            this._Layout.Size = new System.Drawing.Size(547, 313);
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
            this.gridListe.Size = new System.Drawing.Size(523, 289);
            this.gridListe.TabIndex = 4;
            this.gridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwListe});
            // 
            // bs
            // 
            this.bs.DataMember = "V_STK_KartListe";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSStok";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gwListe
            // 
            this.gwListe.ColumnPanelRowHeight = 40;
            this.gwListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStokKodu,
            this.colStokAdi,
            this.colMensei,
            this.colHesapAdi,
            this.colSonAlisFiyati,
            this.colSatisFiyati,
            this.colIskontoOran,
            this.colTeminSuresi,
            this.colStokSayac,
            this.colAsgariMiktar,
            this.colAzamiMiktar,
            this.colAlarmSeviyesi,
            this.colMinSiparisMiktar,
            this.colKDVOrani,
            this.colDeger,
            this.colStokTipi});
            this.gwListe.GridControl = this.gridListe;
            this.gwListe.Name = "gwListe";
            this.gwListe.OptionsBehavior.Editable = false;
            this.gwListe.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwListe.OptionsLayout.Columns.StoreAppearance = true;
            this.gwListe.OptionsLayout.StoreAllOptions = true;
            this.gwListe.OptionsLayout.StoreAppearance = true;
            this.gwListe.OptionsLayout.StoreFormatRules = true;
            this.gwListe.OptionsView.ColumnAutoWidth = false;
            this.gwListe.OptionsView.ShowAutoFilterRow = true;
            this.gwListe.OptionsView.ShowGroupPanel = false;
            this.gwListe.OptionsView.ShowIndicator = false;
            this.gwListe.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwListe_PopupMenuShowing);
            this.gwListe.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwListe_FocusedColumnChanged);
            this.gwListe.DoubleClick += new System.EventHandler(this.gwListe_DoubleClick);
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
            this.colStokKodu.VisibleIndex = 0;
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
            this.colStokAdi.VisibleIndex = 1;
            // 
            // colMensei
            // 
            this.colMensei.AppearanceHeader.Options.UseTextOptions = true;
            this.colMensei.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMensei.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colMensei.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMensei.Caption = "Menşei";
            this.colMensei.FieldName = "Mensei";
            this.colMensei.Name = "colMensei";
            this.colMensei.Visible = true;
            this.colMensei.VisibleIndex = 2;
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
            this.colHesapAdi.VisibleIndex = 3;
            // 
            // colSonAlisFiyati
            // 
            this.colSonAlisFiyati.AppearanceHeader.Options.UseTextOptions = true;
            this.colSonAlisFiyati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSonAlisFiyati.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSonAlisFiyati.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSonAlisFiyati.Caption = "Son Alış Fiyatı";
            this.colSonAlisFiyati.DisplayFormat.FormatString = "n3";
            this.colSonAlisFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSonAlisFiyati.FieldName = "SonAlisFiyati";
            this.colSonAlisFiyati.Name = "colSonAlisFiyati";
            this.colSonAlisFiyati.Visible = true;
            this.colSonAlisFiyati.VisibleIndex = 4;
            // 
            // colSatisFiyati
            // 
            this.colSatisFiyati.AppearanceHeader.Options.UseTextOptions = true;
            this.colSatisFiyati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSatisFiyati.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSatisFiyati.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSatisFiyati.Caption = "Satış Fiyatı";
            this.colSatisFiyati.DisplayFormat.FormatString = "n3";
            this.colSatisFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatisFiyati.FieldName = "SatisFiyati";
            this.colSatisFiyati.Name = "colSatisFiyati";
            this.colSatisFiyati.Visible = true;
            this.colSatisFiyati.VisibleIndex = 5;
            // 
            // colIskontoOran
            // 
            this.colIskontoOran.AppearanceHeader.Options.UseTextOptions = true;
            this.colIskontoOran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIskontoOran.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colIskontoOran.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colIskontoOran.Caption = "İskonto Oran";
            this.colIskontoOran.DisplayFormat.FormatString = "n2";
            this.colIskontoOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoOran.FieldName = "IskontoOran";
            this.colIskontoOran.Name = "colIskontoOran";
            this.colIskontoOran.Visible = true;
            this.colIskontoOran.VisibleIndex = 6;
            // 
            // colTeminSuresi
            // 
            this.colTeminSuresi.AppearanceHeader.Options.UseTextOptions = true;
            this.colTeminSuresi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTeminSuresi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTeminSuresi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTeminSuresi.Caption = "Temin Süresi";
            this.colTeminSuresi.FieldName = "TeminSuresi";
            this.colTeminSuresi.Name = "colTeminSuresi";
            this.colTeminSuresi.Visible = true;
            this.colTeminSuresi.VisibleIndex = 7;
            // 
            // colStokSayac
            // 
            this.colStokSayac.AppearanceHeader.Options.UseTextOptions = true;
            this.colStokSayac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStokSayac.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colStokSayac.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colStokSayac.Caption = "Stok Sayaç";
            this.colStokSayac.FieldName = "StokSayac";
            this.colStokSayac.Name = "colStokSayac";
            this.colStokSayac.Visible = true;
            this.colStokSayac.VisibleIndex = 8;
            // 
            // colAsgariMiktar
            // 
            this.colAsgariMiktar.AppearanceHeader.Options.UseTextOptions = true;
            this.colAsgariMiktar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAsgariMiktar.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colAsgariMiktar.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAsgariMiktar.FieldName = "AsgariMiktar";
            this.colAsgariMiktar.Name = "colAsgariMiktar";
            this.colAsgariMiktar.Visible = true;
            this.colAsgariMiktar.VisibleIndex = 9;
            // 
            // colAzamiMiktar
            // 
            this.colAzamiMiktar.AppearanceHeader.Options.UseTextOptions = true;
            this.colAzamiMiktar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAzamiMiktar.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colAzamiMiktar.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAzamiMiktar.FieldName = "AzamiMiktar";
            this.colAzamiMiktar.Name = "colAzamiMiktar";
            this.colAzamiMiktar.Visible = true;
            this.colAzamiMiktar.VisibleIndex = 10;
            // 
            // colAlarmSeviyesi
            // 
            this.colAlarmSeviyesi.AppearanceHeader.Options.UseTextOptions = true;
            this.colAlarmSeviyesi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAlarmSeviyesi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colAlarmSeviyesi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAlarmSeviyesi.FieldName = "AlarmSeviyesi";
            this.colAlarmSeviyesi.Name = "colAlarmSeviyesi";
            this.colAlarmSeviyesi.Visible = true;
            this.colAlarmSeviyesi.VisibleIndex = 11;
            // 
            // colMinSiparisMiktar
            // 
            this.colMinSiparisMiktar.AppearanceHeader.Options.UseTextOptions = true;
            this.colMinSiparisMiktar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMinSiparisMiktar.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colMinSiparisMiktar.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMinSiparisMiktar.Caption = "Min. Sipariş Miktarı";
            this.colMinSiparisMiktar.FieldName = "MinSiparisMiktar";
            this.colMinSiparisMiktar.Name = "colMinSiparisMiktar";
            this.colMinSiparisMiktar.Visible = true;
            this.colMinSiparisMiktar.VisibleIndex = 12;
            // 
            // colKDVOrani
            // 
            this.colKDVOrani.AppearanceHeader.Options.UseTextOptions = true;
            this.colKDVOrani.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKDVOrani.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colKDVOrani.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colKDVOrani.Caption = "KDV Oranı";
            this.colKDVOrani.FieldName = "KDVOrani";
            this.colKDVOrani.Name = "colKDVOrani";
            this.colKDVOrani.Visible = true;
            this.colKDVOrani.VisibleIndex = 13;
            // 
            // colDeger
            // 
            this.colDeger.AppearanceHeader.Options.UseTextOptions = true;
            this.colDeger.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDeger.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDeger.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDeger.Caption = "Değer";
            this.colDeger.FieldName = "Deger";
            this.colDeger.Name = "colDeger";
            this.colDeger.Visible = true;
            this.colDeger.VisibleIndex = 14;
            // 
            // colStokTipi
            // 
            this.colStokTipi.AppearanceHeader.Options.UseTextOptions = true;
            this.colStokTipi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStokTipi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colStokTipi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colStokTipi.Caption = "Stok Tipi";
            this.colStokTipi.FieldName = "StokTipi";
            this.colStokTipi.Name = "colStokTipi";
            this.colStokTipi.Visible = true;
            this.colStokTipi.VisibleIndex = 15;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridListe});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(547, 313);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyGridListe
            // 
            this.lyGridListe.Control = this.gridListe;
            this.lyGridListe.Location = new System.Drawing.Point(0, 0);
            this.lyGridListe.Name = "lyGridListe";
            this.lyGridListe.Size = new System.Drawing.Size(527, 293);
            this.lyGridListe.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridListe.TextVisible = false;
            // 
            // popupListe
            // 
            this.popupListe.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerGenel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerListe)});
            this.popupListe.Manager = this.bManager;
            this.popupListe.Name = "popupListe";
            // 
            // dt
            // 
            this.dt.ClearBeforeFill = true;
            // 
            // frmStokAra
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 352);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmStokAra";
            this.Text = "frmStokAra";
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
        private DevExpress.XtraGrid.GridControl gridListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gwListe;
        private DevExpress.XtraLayout.LayoutControlItem lyGridListe;
        private DevExpress.XtraBars.PopupMenu popupListe;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerListe;
        private System.Windows.Forms.BindingSource bs;
        private Data.Stok.DSStok ds;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMensei;
        private DevExpress.XtraGrid.Columns.GridColumn colHesapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSonAlisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colSatisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOran;
        private DevExpress.XtraGrid.Columns.GridColumn colTeminSuresi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokSayac;
        private DevExpress.XtraGrid.Columns.GridColumn colAsgariMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colAzamiMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colAlarmSeviyesi;
        private DevExpress.XtraGrid.Columns.GridColumn colMinSiparisMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKDVOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colDeger;
        private DevExpress.XtraGrid.Columns.GridColumn colStokTipi;
        private Data.Stok.DSStokTableAdapters.V_STK_KartListeTableAdapter dt;
        private DevExpress.Utils.ImageCollection IMG24;
    }
}