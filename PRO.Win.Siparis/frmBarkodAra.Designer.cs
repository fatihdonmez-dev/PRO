namespace PRO.Win.Siparis
{
    partial class frmBarkodAra
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
            this.bManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYenile = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.mnuOzStokGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzStokListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuEkle = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzBarkodGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzBarkodListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuIptal = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.gridBarkod = new DevExpress.XtraGrid.GridControl();
            this.bsSiparis = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.Siparis.DSSiparis();
            this.gwBarkod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStok = new DevExpress.XtraGrid.GridControl();
            this.gwStok = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lyBarkodOkuyucu = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyBarkod = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lyStokBakiye = new DevExpress.XtraLayout.LayoutControlItem();
            this.lySaticiFirma = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyStokCins = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyStokBirim = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyStokAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyStokAra = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridStokListe = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupStok = new DevExpress.XtraBars.PopupMenu();
            this.popupBarkod = new DevExpress.XtraBars.PopupMenu();
            this.dtSiparis = new PRO.Data.Siparis.DSSiparisTableAdapters.SIP_EvrakDetayTableAdapter();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyBarkodOkuyucu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySaticiFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokCins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridStokListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupBarkod)).BeginInit();
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
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuYenile,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuOzStokGenel,
            this.mnuOzStokListe,
            this.mnuEkle,
            this.mnuOzBarkodGenel,
            this.mnuOzBarkodListe,
            this.mnuIptal});
            this.bManager.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYenile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKapat, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // mnuYenile
            // 
            this.mnuYenile.Caption = "Listeyi Yenile";
            this.mnuYenile.Id = 0;
            this.mnuYenile.Name = "mnuYenile";
            this.mnuYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYenile_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 2;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 3;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGorunumKaydet)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnuGorunumKaydet
            // 
            this.mnuGorunumKaydet.Caption = "Görünüm Kaydet";
            this.mnuGorunumKaydet.Id = 4;
            this.mnuGorunumKaydet.Name = "mnuGorunumKaydet";
            this.mnuGorunumKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGorunumKaydet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(762, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 478);
            this.barDockControlBottom.Size = new System.Drawing.Size(762, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 449);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(762, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 449);
            // 
            // mnuOzStokGenel
            // 
            this.mnuOzStokGenel.Caption = "Genel Özellikler";
            this.mnuOzStokGenel.Id = 5;
            this.mnuOzStokGenel.Name = "mnuOzStokGenel";
            this.mnuOzStokGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzStokGenel_ItemClick);
            // 
            // mnuOzStokListe
            // 
            this.mnuOzStokListe.Caption = "Liste Özellikler";
            this.mnuOzStokListe.Id = 6;
            this.mnuOzStokListe.Name = "mnuOzStokListe";
            this.mnuOzStokListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzStokListe_ItemClick);
            // 
            // mnuEkle
            // 
            this.mnuEkle.Caption = "Ekle";
            this.mnuEkle.Id = 7;
            this.mnuEkle.Name = "mnuEkle";
            this.mnuEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuEkle_ItemClick);
            // 
            // mnuOzBarkodGenel
            // 
            this.mnuOzBarkodGenel.Caption = "Genel Özellikler";
            this.mnuOzBarkodGenel.Id = 8;
            this.mnuOzBarkodGenel.Name = "mnuOzBarkodGenel";
            this.mnuOzBarkodGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzBarkodGenel_ItemClick);
            // 
            // mnuOzBarkodListe
            // 
            this.mnuOzBarkodListe.Caption = "Liste Özellikler";
            this.mnuOzBarkodListe.Id = 9;
            this.mnuOzBarkodListe.Name = "mnuOzBarkodListe";
            this.mnuOzBarkodListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzBarkodListe_ItemClick);
            // 
            // mnuIptal
            // 
            this.mnuIptal.Caption = "İptal";
            this.mnuIptal.Id = 10;
            this.mnuIptal.Name = "mnuIptal";
            this.mnuIptal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuIptal_ItemClick);
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.textEdit5);
            this._Layout.Controls.Add(this.textEdit4);
            this._Layout.Controls.Add(this.textEdit3);
            this._Layout.Controls.Add(this.textEdit2);
            this._Layout.Controls.Add(this.textEdit1);
            this._Layout.Controls.Add(this.txtBarkod);
            this._Layout.Controls.Add(this.gridBarkod);
            this._Layout.Controls.Add(this.gridStok);
            this._Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Layout.Location = new System.Drawing.Point(0, 29);
            this._Layout.Name = "_Layout";
            this._Layout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(604, 251, 450, 540);
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
            this._Layout.Size = new System.Drawing.Size(762, 449);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(466, 118);
            this.textEdit5.MenuManager = this.bManager;
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.ReadOnly = true;
            this.textEdit5.Size = new System.Drawing.Size(272, 20);
            this.textEdit5.StyleController = this._Layout;
            this.textEdit5.TabIndex = 11;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(107, 94);
            this.textEdit4.MenuManager = this.bManager;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Size = new System.Drawing.Size(272, 20);
            this.textEdit4.StyleController = this._Layout;
            this.textEdit4.TabIndex = 10;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(107, 70);
            this.textEdit3.MenuManager = this.bManager;
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(631, 20);
            this.textEdit3.StyleController = this._Layout;
            this.textEdit3.TabIndex = 9;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(107, 118);
            this.textEdit2.MenuManager = this.bManager;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(272, 20);
            this.textEdit2.StyleController = this._Layout;
            this.textEdit2.TabIndex = 8;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(466, 94);
            this.textEdit1.MenuManager = this.bManager;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(272, 20);
            this.textEdit1.StyleController = this._Layout;
            this.textEdit1.TabIndex = 7;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(107, 46);
            this.txtBarkod.MenuManager = this.bManager;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(272, 20);
            this.txtBarkod.StyleController = this._Layout;
            this.txtBarkod.TabIndex = 6;
            // 
            // gridBarkod
            // 
            this.gridBarkod.DataSource = this.bsSiparis;
            this.gridBarkod.Location = new System.Drawing.Point(12, 234);
            this.gridBarkod.MainView = this.gwBarkod;
            this.gridBarkod.MenuManager = this.bManager;
            this.gridBarkod.Name = "gridBarkod";
            this.gridBarkod.Size = new System.Drawing.Size(738, 203);
            this.gridBarkod.TabIndex = 5;
            this.gridBarkod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwBarkod});
            // 
            // bsSiparis
            // 
            this.bsSiparis.DataMember = "SIP_EvrakDetay";
            this.bsSiparis.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSSiparis";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gwBarkod
            // 
            this.gwBarkod.ColumnPanelRowHeight = 40;
            this.gwBarkod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStokKodu,
            this.colStokAdi,
            this.colStokTipi,
            this.colTanim,
            this.colBarkod});
            this.gwBarkod.GridControl = this.gridBarkod;
            this.gwBarkod.Name = "gwBarkod";
            this.gwBarkod.OptionsBehavior.Editable = false;
            this.gwBarkod.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwBarkod.OptionsLayout.Columns.StoreAppearance = true;
            this.gwBarkod.OptionsLayout.StoreAllOptions = true;
            this.gwBarkod.OptionsLayout.StoreAppearance = true;
            this.gwBarkod.OptionsLayout.StoreFormatRules = true;
            this.gwBarkod.OptionsView.ColumnAutoWidth = false;
            this.gwBarkod.OptionsView.ShowFooter = true;
            this.gwBarkod.OptionsView.ShowGroupPanel = false;
            this.gwBarkod.OptionsView.ShowIndicator = false;
            this.gwBarkod.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwBarkod_PopupMenuShowing);
            this.gwBarkod.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwBarkod_FocusedColumnChanged);
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
            this.colStokAdi.FieldName = "StokAdi";
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 1;
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
            this.colStokTipi.VisibleIndex = 2;
            // 
            // colTanim
            // 
            this.colTanim.AppearanceHeader.Options.UseTextOptions = true;
            this.colTanim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTanim.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTanim.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTanim.FieldName = "Tanim";
            this.colTanim.Name = "colTanim";
            this.colTanim.Visible = true;
            this.colTanim.VisibleIndex = 3;
            // 
            // gridStok
            // 
            this.gridStok.Location = new System.Drawing.Point(24, 46);
            this.gridStok.MainView = this.gwStok;
            this.gridStok.MenuManager = this.bManager;
            this.gridStok.Name = "gridStok";
            this.gridStok.Size = new System.Drawing.Size(714, 172);
            this.gridStok.TabIndex = 4;
            this.gridStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwStok});
            // 
            // gwStok
            // 
            this.gwStok.GridControl = this.gridStok;
            this.gwStok.Name = "gwStok";
            this.gwStok.OptionsBehavior.Editable = false;
            this.gwStok.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwStok.OptionsLayout.Columns.StoreAppearance = true;
            this.gwStok.OptionsLayout.StoreAllOptions = true;
            this.gwStok.OptionsLayout.StoreAppearance = true;
            this.gwStok.OptionsLayout.StoreFormatRules = true;
            this.gwStok.OptionsSelection.MultiSelect = true;
            this.gwStok.OptionsView.ColumnAutoWidth = false;
            this.gwStok.OptionsView.ShowAutoFilterRow = true;
            this.gwStok.OptionsView.ShowFooter = true;
            this.gwStok.OptionsView.ShowGroupPanel = false;
            this.gwStok.OptionsView.ShowIndicator = false;
            this.gwStok.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwStok_PopupMenuShowing);
            this.gwStok.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwStok_FocusedColumnChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(762, 449);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1";
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.lyBarkodOkuyucu;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(742, 222);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyBarkodOkuyucu,
            this.lyStokAra});
            // 
            // lyBarkodOkuyucu
            // 
            this.lyBarkodOkuyucu.CustomizationFormText = "Tab1";
            this.lyBarkodOkuyucu.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyBarkod,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.lyStokBakiye,
            this.lySaticiFirma,
            this.lyStokCins,
            this.lyStokBirim,
            this.lyStokAdi});
            this.lyBarkodOkuyucu.Location = new System.Drawing.Point(0, 0);
            this.lyBarkodOkuyucu.Name = "lyBarkodOkuyucu";
            this.lyBarkodOkuyucu.Size = new System.Drawing.Size(718, 176);
            this.lyBarkodOkuyucu.Text = "Barkod Okuyucu";
            // 
            // lyBarkod
            // 
            this.lyBarkod.Control = this.txtBarkod;
            this.lyBarkod.Location = new System.Drawing.Point(0, 0);
            this.lyBarkod.Name = "lyBarkod";
            this.lyBarkod.Size = new System.Drawing.Size(359, 24);
            this.lyBarkod.Text = "Barkod";
            this.lyBarkod.TextSize = new System.Drawing.Size(80, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(718, 80);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(359, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(359, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lyStokBakiye
            // 
            this.lyStokBakiye.Control = this.textEdit2;
            this.lyStokBakiye.Location = new System.Drawing.Point(0, 72);
            this.lyStokBakiye.Name = "lyStokBakiye";
            this.lyStokBakiye.Size = new System.Drawing.Size(359, 24);
            this.lyStokBakiye.Text = "Stok Bakiye";
            this.lyStokBakiye.TextSize = new System.Drawing.Size(80, 20);
            // 
            // lySaticiFirma
            // 
            this.lySaticiFirma.Control = this.textEdit3;
            this.lySaticiFirma.Location = new System.Drawing.Point(0, 24);
            this.lySaticiFirma.Name = "lySaticiFirma";
            this.lySaticiFirma.Size = new System.Drawing.Size(718, 24);
            this.lySaticiFirma.Text = "Satıcı Firma";
            this.lySaticiFirma.TextSize = new System.Drawing.Size(80, 20);
            // 
            // lyStokCins
            // 
            this.lyStokCins.Control = this.textEdit4;
            this.lyStokCins.Location = new System.Drawing.Point(0, 48);
            this.lyStokCins.Name = "lyStokCins";
            this.lyStokCins.Size = new System.Drawing.Size(359, 24);
            this.lyStokCins.Text = "Stok Cinsi";
            this.lyStokCins.TextSize = new System.Drawing.Size(80, 20);
            // 
            // lyStokBirim
            // 
            this.lyStokBirim.Control = this.textEdit5;
            this.lyStokBirim.Location = new System.Drawing.Point(359, 72);
            this.lyStokBirim.Name = "lyStokBirim";
            this.lyStokBirim.Size = new System.Drawing.Size(359, 24);
            this.lyStokBirim.Text = "Stok Birim";
            this.lyStokBirim.TextSize = new System.Drawing.Size(80, 20);
            // 
            // lyStokAdi
            // 
            this.lyStokAdi.Control = this.textEdit1;
            this.lyStokAdi.Location = new System.Drawing.Point(359, 48);
            this.lyStokAdi.Name = "lyStokAdi";
            this.lyStokAdi.Size = new System.Drawing.Size(359, 24);
            this.lyStokAdi.Text = "Stok Adı";
            this.lyStokAdi.TextSize = new System.Drawing.Size(80, 20);
            // 
            // lyStokAra
            // 
            this.lyStokAra.CustomizationFormText = "Tab2";
            this.lyStokAra.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridStokListe});
            this.lyStokAra.Location = new System.Drawing.Point(0, 0);
            this.lyStokAra.Name = "lyStokAra";
            this.lyStokAra.Size = new System.Drawing.Size(718, 176);
            this.lyStokAra.Text = "Stok Ara";
            // 
            // lyGridStokListe
            // 
            this.lyGridStokListe.Control = this.gridStok;
            this.lyGridStokListe.Location = new System.Drawing.Point(0, 0);
            this.lyGridStokListe.Name = "lyGridStokListe";
            this.lyGridStokListe.Size = new System.Drawing.Size(718, 176);
            this.lyGridStokListe.Text = "Stok Listesi";
            this.lyGridStokListe.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridStokListe.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridBarkod;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 222);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(742, 207);
            this.layoutControlItem1.Text = "Eklenmiş Barkodlar";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // popupStok
            // 
            this.popupStok.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuEkle),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzStokGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzStokListe)});
            this.popupStok.Manager = this.bManager;
            this.popupStok.Name = "popupStok";
            // 
            // popupBarkod
            // 
            this.popupBarkod.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuIptal),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzBarkodGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzBarkodListe)});
            this.popupBarkod.Manager = this.bManager;
            this.popupBarkod.Name = "popupBarkod";
            // 
            // dtSiparis
            // 
            this.dtSiparis.ClearBeforeFill = true;
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
            this.colBarkod.VisibleIndex = 4;
            // 
            // frmBarkodAra
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 478);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBarkodAra";
            this.Text = "frmBarkodAra";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyBarkodOkuyucu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySaticiFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokCins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyStokAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridStokListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupBarkod)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup lyBarkodOkuyucu;
        private DevExpress.XtraLayout.LayoutControlGroup lyStokAra;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYenile;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraGrid.GridControl gridStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gwStok;
        private DevExpress.XtraLayout.LayoutControlItem lyGridStokListe;
        private DevExpress.XtraBars.BarButtonItem mnuOzStokGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzStokListe;
        private DevExpress.XtraBars.PopupMenu popupStok;
        private DevExpress.XtraGrid.GridControl gridBarkod;
        private DevExpress.XtraGrid.Views.Grid.GridView gwBarkod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem mnuEkle;
        private DevExpress.XtraBars.BarButtonItem mnuOzBarkodGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzBarkodListe;
        private DevExpress.XtraBars.PopupMenu popupBarkod;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraLayout.LayoutControlItem lyBarkod;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lyStokAdi;
        private DevExpress.XtraLayout.LayoutControlItem lyStokBakiye;
        private DevExpress.XtraLayout.LayoutControlItem lySaticiFirma;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraLayout.LayoutControlItem lyStokCins;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraLayout.LayoutControlItem lyStokBirim;
        private DevExpress.XtraBars.BarButtonItem mnuIptal;
        private System.Windows.Forms.BindingSource bsSiparis;
        private Data.Siparis.DSSiparis ds;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colTanim;
        private Data.Siparis.DSSiparisTableAdapters.SIP_EvrakDetayTableAdapter dtSiparis;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
    }
}