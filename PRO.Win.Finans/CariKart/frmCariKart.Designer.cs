namespace PRO.Win.Finans
{
    partial class frmCariKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariKart));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.bManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYeni = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuSil = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuPasif = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKaydet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuAra = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.IMG24 = new DevExpress.Utils.ImageCollection();
            this.mnuOzAdresGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzAdresListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAdresSil = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAdresPasif = new DevExpress.XtraBars.BarButtonItem();
            this.mnuYeniAdres = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.txtHesapAdi = new DevExpress.XtraEditors.TextEdit();
            this.bs = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.Finans.DSFinans();
            this.gridAdres = new DevExpress.XtraGrid.GridControl();
            this.bsAdres = new System.Windows.Forms.BindingSource();
            this.gwAdres = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdresTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reAdresTipi = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colLokasyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLokasyonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSehirKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUlke = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBolge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beSehir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.leKartTipi = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.txtHesapKodu = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyFirmaKodu = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyVergiNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyTel1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyVergiDairesi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyTel2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyGsm = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyMail1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyMail2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridAdres = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyFirmaAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyKartTipi = new DevExpress.XtraLayout.LayoutControlItem();
            this.dt = new PRO.Data.Finans.DSFinansTableAdapters.CHK_KartTableAdapter();
            this.dtAdres = new PRO.Data.Finans.DSFinansTableAdapters.CHK_Kart_AdresTableAdapter();
            this.popupAdres = new DevExpress.XtraBars.PopupMenu();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reAdresTipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leKartTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFirmaKodu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyVergiNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyVergiDairesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGsm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyMail1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyMail2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFirmaAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyKartTipi)).BeginInit();
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
            this.mnuPasif,
            this.mnuKaydet,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuAra,
            this.mnuOzAdresGenel,
            this.mnuOzAdresListe,
            this.mnuAdresSil,
            this.mnuAdresPasif,
            this.mnuYeniAdres});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSil, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuPasif, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKaydet, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAra, true),
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
            this.mnuYeni.ImageIndex = 11;
            this.mnuYeni.Name = "mnuYeni";
            this.E_Yetki.SetYetkiEnable(this.mnuYeni, "_EKLE");
            this.mnuYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYeni_ItemClick);
            // 
            // mnuSil
            // 
            this.mnuSil.Caption = "Sil";
            this.mnuSil.Id = 1;
            this.mnuSil.ImageIndex = 3;
            this.mnuSil.Name = "mnuSil";
            this.E_Yetki.SetYetkiEnable(this.mnuSil, "_SIL");
            this.mnuSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSil_ItemClick);
            // 
            // mnuPasif
            // 
            this.mnuPasif.Caption = "Pasif";
            this.mnuPasif.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuPasif.Glyph")));
            this.mnuPasif.Id = 2;
            this.mnuPasif.Name = "mnuPasif";
            this.E_Yetki.SetYetkiEnable(this.mnuPasif, "_SIL");
            this.mnuPasif.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuPasif_ItemClick);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Caption = "Kaydet";
            this.mnuKaydet.Id = 3;
            this.mnuKaydet.ImageIndex = 7;
            this.mnuKaydet.Name = "mnuKaydet";
            this.E_Yetki.SetYetkiEnable(this.mnuKaydet, "_KAYDET");
            this.mnuKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKaydet_ItemClick);
            // 
            // mnuAra
            // 
            this.mnuAra.Caption = "Ara";
            this.mnuAra.Id = 7;
            this.mnuAra.ImageIndex = 19;
            this.mnuAra.Name = "mnuAra";
            this.mnuAra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuAra_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 4;
            this.mnuKapat.ImageIndex = 0;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 5;
            this.barSubItem1.ImageIndex = 17;
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
            this.barDockControlTop.Size = new System.Drawing.Size(677, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 402);
            this.barDockControlBottom.Size = new System.Drawing.Size(677, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 355);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(677, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 355);
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "cikis1.png");
            this.IMG24.Images.SetKeyName(1, "back36.png");
            this.IMG24.Images.SetKeyName(2, "Delete24.png");
            this.IMG24.Images.SetKeyName(3, "delete81.png");
            this.IMG24.Images.SetKeyName(4, "door9.png");
            this.IMG24.Images.SetKeyName(5, "Edit.png");
            this.IMG24.Images.SetKeyName(6, "ekle24.png");
            this.IMG24.Images.SetKeyName(7, "floppy1.png");
            this.IMG24.Images.SetKeyName(8, "KaydetCik.png");
            this.IMG24.Images.SetKeyName(9, "Kısayol.png");
            this.IMG24.Images.SetKeyName(10, "Kopyala.png");
            this.IMG24.Images.SetKeyName(11, "new10.png");
            this.IMG24.Images.SetKeyName(12, "Ok.png");
            this.IMG24.Images.SetKeyName(13, "Product.png");
            this.IMG24.Images.SetKeyName(14, "refresh.png");
            this.IMG24.Images.SetKeyName(15, "right133.png");
            this.IMG24.Images.SetKeyName(16, "search102.png");
            this.IMG24.Images.SetKeyName(17, "Settings.png");
            this.IMG24.Images.SetKeyName(18, "Yetki.png");
            this.IMG24.Images.SetKeyName(19, "arama.png");
            this.IMG24.Images.SetKeyName(20, "printer70.png");
            // 
            // mnuOzAdresGenel
            // 
            this.mnuOzAdresGenel.Caption = "Genel Özellikler";
            this.mnuOzAdresGenel.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzAdresGenel.Glyph")));
            this.mnuOzAdresGenel.Id = 9;
            this.mnuOzAdresGenel.Name = "mnuOzAdresGenel";
            this.mnuOzAdresGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzAdresGenel_ItemClick);
            // 
            // mnuOzAdresListe
            // 
            this.mnuOzAdresListe.Caption = "Liste Özellikler";
            this.mnuOzAdresListe.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuOzAdresListe.Glyph")));
            this.mnuOzAdresListe.Id = 10;
            this.mnuOzAdresListe.Name = "mnuOzAdresListe";
            this.mnuOzAdresListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzAdresListe_ItemClick);
            // 
            // mnuAdresSil
            // 
            this.mnuAdresSil.Caption = "Sil";
            this.mnuAdresSil.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuAdresSil.Glyph")));
            this.mnuAdresSil.Id = 11;
            this.mnuAdresSil.Name = "mnuAdresSil";
            this.E_Yetki.SetYetkiEnable(this.mnuAdresSil, "_SIL");
            this.mnuAdresSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuAdresSil_ItemClick);
            // 
            // mnuAdresPasif
            // 
            this.mnuAdresPasif.Caption = "Pasif Et";
            this.mnuAdresPasif.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuAdresPasif.Glyph")));
            this.mnuAdresPasif.Id = 12;
            this.mnuAdresPasif.Name = "mnuAdresPasif";
            this.E_Yetki.SetYetkiEnable(this.mnuAdresPasif, "_SIL");
            this.mnuAdresPasif.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuAdresPasif_ItemClick);
            // 
            // mnuYeniAdres
            // 
            this.mnuYeniAdres.Caption = "Yeni";
            this.mnuYeniAdres.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuYeniAdres.Glyph")));
            this.mnuYeniAdres.Id = 13;
            this.mnuYeniAdres.Name = "mnuYeniAdres";
            this.E_Yetki.SetYetkiEnable(this.mnuYeniAdres, "_EKLE");
            this.mnuYeniAdres.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYeniAdres_ItemClick);
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.txtHesapAdi);
            this._Layout.Controls.Add(this.gridAdres);
            this._Layout.Controls.Add(this.textEdit8);
            this._Layout.Controls.Add(this.textEdit7);
            this._Layout.Controls.Add(this.textEdit6);
            this._Layout.Controls.Add(this.textEdit5);
            this._Layout.Controls.Add(this.textEdit4);
            this._Layout.Controls.Add(this.leKartTipi);
            this._Layout.Controls.Add(this.textEdit3);
            this._Layout.Controls.Add(this.textEdit2);
            this._Layout.Controls.Add(this.txtHesapKodu);
            this._Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Layout.Location = new System.Drawing.Point(0, 47);
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
            this._Layout.Size = new System.Drawing.Size(677, 355);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "HesapAdi", true));
            this.txtHesapAdi.Location = new System.Drawing.Point(332, 12);
            this.txtHesapAdi.MenuManager = this.bManager;
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(333, 20);
            this.txtHesapAdi.StyleController = this._Layout;
            this.txtHesapAdi.TabIndex = 15;
            // 
            // bs
            // 
            this.bs.DataMember = "CHK_Kart";
            this.bs.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSFinans";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridAdres
            // 
            this.gridAdres.DataSource = this.bsAdres;
            this.gridAdres.Location = new System.Drawing.Point(24, 145);
            this.gridAdres.MainView = this.gwAdres;
            this.gridAdres.MenuManager = this.bManager;
            this.gridAdres.Name = "gridAdres";
            this.gridAdres.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reAdresTipi,
            this.beSehir});
            this.gridAdres.Size = new System.Drawing.Size(629, 186);
            this.gridAdres.TabIndex = 14;
            this.gridAdres.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwAdres});
            // 
            // bsAdres
            // 
            this.bsAdres.DataMember = "CHK_Kart_Adres";
            this.bsAdres.DataSource = this.ds;
            this.bsAdres.Filter = "Silindi = 0 AND Pasif = 0";
            // 
            // gwAdres
            // 
            this.gwAdres.ColumnPanelRowHeight = 40;
            this.gwAdres.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdresTipi,
            this.colLokasyon,
            this.colLokasyonAdi,
            this.colAdres1,
            this.colAdres2,
            this.colAdres3,
            this.colSehirKod,
            this.colUlke,
            this.colBolge,
            this.colSehir,
            this.colIlce,
            this.colSemt,
            this.colPostaKodu});
            this.gwAdres.GridControl = this.gridAdres;
            this.gwAdres.Name = "gwAdres";
            this.gwAdres.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwAdres.OptionsLayout.Columns.StoreAppearance = true;
            this.gwAdres.OptionsLayout.StoreAllOptions = true;
            this.gwAdres.OptionsLayout.StoreAppearance = true;
            this.gwAdres.OptionsLayout.StoreFormatRules = true;
            this.gwAdres.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwAdres.OptionsView.ColumnAutoWidth = false;
            this.gwAdres.OptionsView.ShowGroupPanel = false;
            this.gwAdres.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwAdres_PopupMenuShowing);
            this.gwAdres.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwAdres_FocusedColumnChanged);
            // 
            // colAdresTipi
            // 
            this.colAdresTipi.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdresTipi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdresTipi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colAdresTipi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAdresTipi.Caption = "Adres Tipi";
            this.colAdresTipi.ColumnEdit = this.reAdresTipi;
            this.colAdresTipi.FieldName = "AdresTipi";
            this.colAdresTipi.Name = "colAdresTipi";
            this.colAdresTipi.Visible = true;
            this.colAdresTipi.VisibleIndex = 0;
            // 
            // reAdresTipi
            // 
            this.reAdresTipi.AutoHeight = false;
            this.reAdresTipi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reAdresTipi.Name = "reAdresTipi";
            this.reAdresTipi.NullText = "";
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
            this.colLokasyon.VisibleIndex = 1;
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
            this.colLokasyonAdi.VisibleIndex = 2;
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
            this.colAdres1.VisibleIndex = 3;
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
            this.colAdres2.VisibleIndex = 4;
            // 
            // colAdres3
            // 
            this.colAdres3.AppearanceHeader.Options.UseTextOptions = true;
            this.colAdres3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAdres3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colAdres3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colAdres3.FieldName = "Adres3";
            this.colAdres3.Name = "colAdres3";
            this.colAdres3.Visible = true;
            this.colAdres3.VisibleIndex = 5;
            // 
            // colSehirKod
            // 
            this.colSehirKod.AppearanceHeader.Options.UseTextOptions = true;
            this.colSehirKod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSehirKod.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSehirKod.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSehirKod.Caption = "Şehir Kodu";
            this.colSehirKod.FieldName = "SehirKod";
            this.colSehirKod.Name = "colSehirKod";
            this.colSehirKod.OptionsColumn.AllowEdit = false;
            this.colSehirKod.Visible = true;
            this.colSehirKod.VisibleIndex = 6;
            // 
            // colUlke
            // 
            this.colUlke.AppearanceHeader.Options.UseTextOptions = true;
            this.colUlke.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUlke.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colUlke.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colUlke.Caption = "Ülke";
            this.colUlke.FieldName = "Ulke";
            this.colUlke.Name = "colUlke";
            this.colUlke.OptionsColumn.AllowEdit = false;
            this.colUlke.Visible = true;
            this.colUlke.VisibleIndex = 7;
            // 
            // colBolge
            // 
            this.colBolge.AppearanceHeader.Options.UseTextOptions = true;
            this.colBolge.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBolge.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colBolge.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colBolge.Caption = "Bölge";
            this.colBolge.FieldName = "Bolge";
            this.colBolge.Name = "colBolge";
            this.colBolge.OptionsColumn.AllowEdit = false;
            this.colBolge.Visible = true;
            this.colBolge.VisibleIndex = 8;
            // 
            // colSehir
            // 
            this.colSehir.AppearanceHeader.Options.UseTextOptions = true;
            this.colSehir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSehir.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSehir.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSehir.Caption = "Şehir";
            this.colSehir.ColumnEdit = this.beSehir;
            this.colSehir.FieldName = "Sehir";
            this.colSehir.Name = "colSehir";
            this.colSehir.Visible = true;
            this.colSehir.VisibleIndex = 9;
            // 
            // beSehir
            // 
            this.beSehir.AutoHeight = false;
            this.beSehir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beSehir.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beSehir.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.beSehir.Name = "beSehir";
            this.beSehir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beSehir.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beSehir_ButtonClick);
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
            this.colIlce.OptionsColumn.AllowEdit = false;
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 10;
            // 
            // colSemt
            // 
            this.colSemt.AppearanceHeader.Options.UseTextOptions = true;
            this.colSemt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSemt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSemt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.OptionsColumn.AllowEdit = false;
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 11;
            // 
            // colPostaKodu
            // 
            this.colPostaKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colPostaKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPostaKodu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colPostaKodu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colPostaKodu.FieldName = "PostaKodu";
            this.colPostaKodu.Name = "colPostaKodu";
            this.colPostaKodu.Visible = true;
            this.colPostaKodu.VisibleIndex = 12;
            // 
            // textEdit8
            // 
            this.textEdit8.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Mail2", true));
            this.textEdit8.Location = new System.Drawing.Point(438, 84);
            this.textEdit8.MenuManager = this.bManager;
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(227, 20);
            this.textEdit8.StyleController = this._Layout;
            this.textEdit8.TabIndex = 13;
            // 
            // textEdit7
            // 
            this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Mail1", true));
            this.textEdit7.Location = new System.Drawing.Point(115, 84);
            this.textEdit7.MenuManager = this.bManager;
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(216, 20);
            this.textEdit7.StyleController = this._Layout;
            this.textEdit7.TabIndex = 12;
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Gsm", true));
            this.textEdit6.Location = new System.Drawing.Point(552, 60);
            this.textEdit6.MenuManager = this.bManager;
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.textEdit6.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textEdit6.Size = new System.Drawing.Size(113, 20);
            this.textEdit6.StyleController = this._Layout;
            this.textEdit6.TabIndex = 11;
            // 
            // textEdit5
            // 
            this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Tel2", true));
            this.textEdit5.Location = new System.Drawing.Point(332, 60);
            this.textEdit5.MenuManager = this.bManager;
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.textEdit5.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textEdit5.Size = new System.Drawing.Size(113, 20);
            this.textEdit5.StyleController = this._Layout;
            this.textEdit5.TabIndex = 10;
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "Tel1", true));
            this.textEdit4.Location = new System.Drawing.Point(115, 60);
            this.textEdit4.MenuManager = this.bManager;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d-\\d\\d\\d\\d";
            this.textEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textEdit4.Size = new System.Drawing.Size(110, 20);
            this.textEdit4.StyleController = this._Layout;
            this.textEdit4.TabIndex = 9;
            // 
            // leKartTipi
            // 
            this.leKartTipi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "KartTipi", true));
            this.leKartTipi.Location = new System.Drawing.Point(115, 36);
            this.leKartTipi.MenuManager = this.bManager;
            this.leKartTipi.Name = "leKartTipi";
            this.leKartTipi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leKartTipi.Properties.NullText = "";
            this.leKartTipi.Size = new System.Drawing.Size(110, 20);
            this.leKartTipi.StyleController = this._Layout;
            this.leKartTipi.TabIndex = 8;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "VergiNo", true));
            this.textEdit3.Location = new System.Drawing.Point(332, 36);
            this.textEdit3.MenuManager = this.bManager;
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(113, 20);
            this.textEdit3.StyleController = this._Layout;
            this.textEdit3.TabIndex = 7;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "VergiDairesi", true));
            this.textEdit2.Location = new System.Drawing.Point(552, 36);
            this.textEdit2.MenuManager = this.bManager;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(113, 20);
            this.textEdit2.StyleController = this._Layout;
            this.textEdit2.TabIndex = 6;
            // 
            // txtHesapKodu
            // 
            this.txtHesapKodu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bs, "HesapKodu", true));
            this.txtHesapKodu.Location = new System.Drawing.Point(115, 12);
            this.txtHesapKodu.MenuManager = this.bManager;
            this.txtHesapKodu.Name = "txtHesapKodu";
            this.txtHesapKodu.Size = new System.Drawing.Size(110, 20);
            this.txtHesapKodu.StyleController = this._Layout;
            this.txtHesapKodu.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyFirmaKodu,
            this.lyVergiNo,
            this.lyTel1,
            this.lyVergiDairesi,
            this.lyTel2,
            this.lyGsm,
            this.lyMail1,
            this.lyMail2,
            this.tabbedControlGroup1,
            this.lyFirmaAdi,
            this.lyKartTipi});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(677, 355);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyFirmaKodu
            // 
            this.lyFirmaKodu.Control = this.txtHesapKodu;
            this.lyFirmaKodu.Location = new System.Drawing.Point(0, 0);
            this.lyFirmaKodu.Name = "lyFirmaKodu";
            this.lyFirmaKodu.Size = new System.Drawing.Size(217, 24);
            this.lyFirmaKodu.Text = "Firma Kodu";
            this.lyFirmaKodu.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyVergiNo
            // 
            this.lyVergiNo.Control = this.textEdit3;
            this.lyVergiNo.Location = new System.Drawing.Point(217, 24);
            this.lyVergiNo.Name = "lyVergiNo";
            this.lyVergiNo.Size = new System.Drawing.Size(220, 24);
            this.lyVergiNo.Text = "Vergi No";
            this.lyVergiNo.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyTel1
            // 
            this.lyTel1.Control = this.textEdit4;
            this.lyTel1.Location = new System.Drawing.Point(0, 48);
            this.lyTel1.Name = "lyTel1";
            this.lyTel1.Size = new System.Drawing.Size(217, 24);
            this.lyTel1.Text = "Tel (1)";
            this.lyTel1.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyVergiDairesi
            // 
            this.lyVergiDairesi.Control = this.textEdit2;
            this.lyVergiDairesi.Location = new System.Drawing.Point(437, 24);
            this.lyVergiDairesi.Name = "lyVergiDairesi";
            this.lyVergiDairesi.Size = new System.Drawing.Size(220, 24);
            this.lyVergiDairesi.Text = "Vergi Dairesi";
            this.lyVergiDairesi.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyTel2
            // 
            this.lyTel2.Control = this.textEdit5;
            this.lyTel2.Location = new System.Drawing.Point(217, 48);
            this.lyTel2.Name = "lyTel2";
            this.lyTel2.Size = new System.Drawing.Size(220, 24);
            this.lyTel2.Text = "Tel (2)";
            this.lyTel2.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyGsm
            // 
            this.lyGsm.Control = this.textEdit6;
            this.lyGsm.Location = new System.Drawing.Point(437, 48);
            this.lyGsm.Name = "lyGsm";
            this.lyGsm.Size = new System.Drawing.Size(220, 24);
            this.lyGsm.Text = "Gsm";
            this.lyGsm.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyMail1
            // 
            this.lyMail1.Control = this.textEdit7;
            this.lyMail1.Location = new System.Drawing.Point(0, 72);
            this.lyMail1.Name = "lyMail1";
            this.lyMail1.Size = new System.Drawing.Size(323, 24);
            this.lyMail1.Text = "Mail (1)";
            this.lyMail1.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyMail2
            // 
            this.lyMail2.Control = this.textEdit8;
            this.lyMail2.Location = new System.Drawing.Point(323, 72);
            this.lyMail2.Name = "lyMail2";
            this.lyMail2.Size = new System.Drawing.Size(334, 24);
            this.lyMail2.Text = "Mail (2)";
            this.lyMail2.TextSize = new System.Drawing.Size(100, 20);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 96);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(657, 239);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup2.CaptionImage")));
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridAdres});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(633, 190);
            this.layoutControlGroup2.Text = "Adresler";
            // 
            // lyGridAdres
            // 
            this.lyGridAdres.Control = this.gridAdres;
            this.lyGridAdres.Location = new System.Drawing.Point(0, 0);
            this.lyGridAdres.Name = "lyGridAdres";
            this.lyGridAdres.Size = new System.Drawing.Size(633, 190);
            this.lyGridAdres.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridAdres.TextVisible = false;
            // 
            // lyFirmaAdi
            // 
            this.lyFirmaAdi.Control = this.txtHesapAdi;
            this.lyFirmaAdi.Location = new System.Drawing.Point(217, 0);
            this.lyFirmaAdi.Name = "lyFirmaAdi";
            this.lyFirmaAdi.Size = new System.Drawing.Size(440, 24);
            this.lyFirmaAdi.Text = "Firma Adı";
            this.lyFirmaAdi.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyKartTipi
            // 
            this.lyKartTipi.Control = this.leKartTipi;
            this.lyKartTipi.Location = new System.Drawing.Point(0, 24);
            this.lyKartTipi.Name = "lyKartTipi";
            this.lyKartTipi.Size = new System.Drawing.Size(217, 24);
            this.lyKartTipi.Text = "Kart Tipi";
            this.lyKartTipi.TextSize = new System.Drawing.Size(100, 20);
            // 
            // dt
            // 
            this.dt.ClearBeforeFill = true;
            // 
            // dtAdres
            // 
            this.dtAdres.ClearBeforeFill = true;
            // 
            // popupAdres
            // 
            this.popupAdres.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYeniAdres),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAdresSil, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAdresPasif),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzAdresGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzAdresListe)});
            this.popupAdres.Manager = this.bManager;
            this.popupAdres.Name = "popupAdres";
            // 
            // frmCariKart
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 402);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCariKart";
            this.Text = "frmCariKart";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reAdresTipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leKartTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFirmaKodu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyVergiNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyVergiDairesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGsm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyMail1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyMail2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFirmaAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyKartTipi)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem mnuPasif;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKaydet;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtHesapKodu;
        private DevExpress.XtraLayout.LayoutControlItem lyFirmaKodu;
        private DevExpress.XtraLayout.LayoutControlItem lyVergiDairesi;
        private DevExpress.XtraLayout.LayoutControlItem lyVergiNo;
        private Data.Finans.DSFinans ds;
        private Data.Finans.DSFinansTableAdapters.CHK_KartTableAdapter dt;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraEditors.LookUpEdit leKartTipi;
        private DevExpress.XtraLayout.LayoutControlItem lyKartTipi;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraLayout.LayoutControlItem lyTel1;
        private DevExpress.XtraLayout.LayoutControlItem lyTel2;
        private DevExpress.XtraLayout.LayoutControlItem lyGsm;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraLayout.LayoutControlItem lyMail1;
        private DevExpress.XtraLayout.LayoutControlItem lyMail2;
        private DevExpress.XtraGrid.GridControl gridAdres;
        private DevExpress.XtraGrid.Views.Grid.GridView gwAdres;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lyGridAdres;
        private DevExpress.XtraBars.BarLargeButtonItem mnuAra;
        private DevExpress.XtraEditors.TextEdit txtHesapAdi;
        private DevExpress.XtraLayout.LayoutControlItem lyFirmaAdi;
        private DevExpress.Utils.ImageCollection IMG24;
        private Data.Finans.DSFinansTableAdapters.CHK_Kart_AdresTableAdapter dtAdres;
        private System.Windows.Forms.BindingSource bsAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colAdresTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colLokasyon;
        private DevExpress.XtraGrid.Columns.GridColumn colLokasyonAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres2;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres3;
        private DevExpress.XtraGrid.Columns.GridColumn colSehirKod;
        private DevExpress.XtraGrid.Columns.GridColumn colUlke;
        private DevExpress.XtraGrid.Columns.GridColumn colBolge;
        private DevExpress.XtraGrid.Columns.GridColumn colSehir;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colPostaKodu;
        private DevExpress.XtraBars.BarButtonItem mnuOzAdresGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzAdresListe;
        private DevExpress.XtraBars.PopupMenu popupAdres;
        private DevExpress.XtraBars.BarButtonItem mnuAdresSil;
        private DevExpress.XtraBars.BarButtonItem mnuAdresPasif;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reAdresTipi;
        private DevExpress.XtraBars.BarButtonItem mnuYeniAdres;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit beSehir;
    }
}