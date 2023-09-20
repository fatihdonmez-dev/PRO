namespace PRO.Win.Siparis
{
    partial class frmSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparis));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.mnuUrunEkle = new DevExpress.XtraBars.BarButtonItem();
            this.mnuUrunSil = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerListe = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit13 = new DevExpress.XtraEditors.TextEdit();
            this.bsEvrak = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.Siparis.DSSiparis();
            this.textEdit12 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.beSevkAdresSec = new DevExpress.XtraEditors.ButtonEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.beFaturaAdresSec = new DevExpress.XtraEditors.ButtonEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.leDurum = new DevExpress.XtraEditors.LookUpEdit();
            this.leOdemeSekli = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.beFirma = new DevExpress.XtraEditors.ButtonEdit();
            this.gridDetay = new DevExpress.XtraGrid.GridControl();
            this.bsEvrakDetay = new System.Windows.Forms.BindingSource();
            this.gwDetay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSiparisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSipNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusSiparisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerminTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reMiktar = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reFiyat = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reTutar = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reDurum = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridDetay = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyFirma = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyVergiDairesi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyVergiNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyTel1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyTel2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyGsm = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyEvrakNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyOdemeSekli = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyAciklama = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lyTarih = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyDurum = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyFaturaAdres = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyFaturaSehir = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyFaturaIlce = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lySevkAdres = new DevExpress.XtraLayout.LayoutControlItem();
            this.lySevkSehir = new DevExpress.XtraLayout.LayoutControlItem();
            this.lySevkIlce = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyFaturaSemt = new DevExpress.XtraLayout.LayoutControlItem();
            this.lySevkSemt = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtEvrak = new PRO.Data.Siparis.DSSiparisTableAdapters.SIP_EvrakTableAdapter();
            this.dtEvrakDetay = new PRO.Data.Siparis.DSSiparisTableAdapters.SIP_EvrakDetayTableAdapter();
            this.popupDetay = new DevExpress.XtraBars.PopupMenu();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvrak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beSevkAdresSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFaturaAdresSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leOdemeSekli.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvrakDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyVergiDairesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyVergiNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGsm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyEvrakNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyOdemeSekli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyAciklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaIlce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkAdres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkIlce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaSemt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkSemt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupDetay)).BeginInit();
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
            this.mnuUrunEkle,
            this.mnuUrunSil,
            this.mnuOzelliklerGenel,
            this.mnuOzelliklerListe});
            this.bManager.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYeni, true),
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
            this.mnuYeni.ImageIndex = 4;
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
            this.mnuKaydet.ImageIndex = 3;
            this.mnuKaydet.Name = "mnuKaydet";
            this.E_Yetki.SetYetkiEnable(this.mnuKaydet, "_KAYDET");
            this.mnuKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKaydet_ItemClick);
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
            this.barSubItem1.ImageIndex = 6;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGorunumKaydet)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnuGorunumKaydet
            // 
            this.mnuGorunumKaydet.Caption = "Görünüm Kaydet";
            this.mnuGorunumKaydet.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuGorunumKaydet.Glyph")));
            this.mnuGorunumKaydet.Id = 5;
            this.mnuGorunumKaydet.Name = "mnuGorunumKaydet";
            this.mnuGorunumKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGorunumKaydet_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(839, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 582);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(839, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 533);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(839, 49);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 533);
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "arama.png");
            this.IMG24.Images.SetKeyName(1, "cikis1.png");
            this.IMG24.Images.SetKeyName(2, "delete81.png");
            this.IMG24.Images.SetKeyName(3, "floppy1.png");
            this.IMG24.Images.SetKeyName(4, "new10.png");
            this.IMG24.Images.SetKeyName(5, "printer70.png");
            this.IMG24.Images.SetKeyName(6, "Settings.png");
            // 
            // mnuUrunEkle
            // 
            this.mnuUrunEkle.Caption = "Ürün Ekle";
            this.mnuUrunEkle.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuUrunEkle.Glyph")));
            this.mnuUrunEkle.Id = 6;
            this.mnuUrunEkle.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuUrunEkle.LargeGlyph")));
            this.mnuUrunEkle.Name = "mnuUrunEkle";
            this.mnuUrunEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuUrunEkle_ItemClick);
            // 
            // mnuUrunSil
            // 
            this.mnuUrunSil.Caption = "Ürün Sil";
            this.mnuUrunSil.Glyph = ((System.Drawing.Image)(resources.GetObject("mnuUrunSil.Glyph")));
            this.mnuUrunSil.Id = 7;
            this.mnuUrunSil.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("mnuUrunSil.LargeGlyph")));
            this.mnuUrunSil.Name = "mnuUrunSil";
            this.mnuUrunSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuUrunSil_ItemClick);
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
            // _Layout
            // 
            this._Layout.Controls.Add(this.textEdit13);
            this._Layout.Controls.Add(this.textEdit12);
            this._Layout.Controls.Add(this.textEdit11);
            this._Layout.Controls.Add(this.textEdit10);
            this._Layout.Controls.Add(this.textEdit9);
            this._Layout.Controls.Add(this.textEdit8);
            this._Layout.Controls.Add(this.textEdit7);
            this._Layout.Controls.Add(this.textEdit6);
            this._Layout.Controls.Add(this.beSevkAdresSec);
            this._Layout.Controls.Add(this.textEdit5);
            this._Layout.Controls.Add(this.textEdit4);
            this._Layout.Controls.Add(this.textEdit3);
            this._Layout.Controls.Add(this.beFaturaAdresSec);
            this._Layout.Controls.Add(this.textEdit2);
            this._Layout.Controls.Add(this.leDurum);
            this._Layout.Controls.Add(this.leOdemeSekli);
            this._Layout.Controls.Add(this.textEdit1);
            this._Layout.Controls.Add(this.dateEdit1);
            this._Layout.Controls.Add(this.beFirma);
            this._Layout.Controls.Add(this.gridDetay);
            this._Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Layout.Location = new System.Drawing.Point(0, 49);
            this._Layout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._Layout.Name = "_Layout";
            this._Layout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(647, 291, 450, 350);
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
            this._Layout.Size = new System.Drawing.Size(839, 533);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // textEdit13
            // 
            this.textEdit13.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "Gsm", true));
            this.textEdit13.Location = new System.Drawing.Point(134, 142);
            this.textEdit13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit13.MenuManager = this.bManager;
            this.textEdit13.Name = "textEdit13";
            this.textEdit13.Properties.ReadOnly = true;
            this.textEdit13.Size = new System.Drawing.Size(674, 22);
            this.textEdit13.StyleController = this._Layout;
            this.textEdit13.TabIndex = 23;
            this.textEdit13.TabStop = false;
            // 
            // bsEvrak
            // 
            this.bsEvrak.DataMember = "SIP_Evrak";
            this.bsEvrak.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSSiparis";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textEdit12
            // 
            this.textEdit12.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "VergiNo", true));
            this.textEdit12.Location = new System.Drawing.Point(525, 86);
            this.textEdit12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit12.MenuManager = this.bManager;
            this.textEdit12.Name = "textEdit12";
            this.textEdit12.Properties.ReadOnly = true;
            this.textEdit12.Size = new System.Drawing.Size(283, 22);
            this.textEdit12.StyleController = this._Layout;
            this.textEdit12.TabIndex = 22;
            this.textEdit12.TabStop = false;
            // 
            // textEdit11
            // 
            this.textEdit11.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "VergiDairesi", true));
            this.textEdit11.Location = new System.Drawing.Point(134, 86);
            this.textEdit11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit11.MenuManager = this.bManager;
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Properties.ReadOnly = true;
            this.textEdit11.Size = new System.Drawing.Size(282, 22);
            this.textEdit11.StyleController = this._Layout;
            this.textEdit11.TabIndex = 21;
            this.textEdit11.TabStop = false;
            // 
            // textEdit10
            // 
            this.textEdit10.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "Tel2", true));
            this.textEdit10.Location = new System.Drawing.Point(525, 114);
            this.textEdit10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit10.MenuManager = this.bManager;
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Properties.ReadOnly = true;
            this.textEdit10.Size = new System.Drawing.Size(283, 22);
            this.textEdit10.StyleController = this._Layout;
            this.textEdit10.TabIndex = 20;
            this.textEdit10.TabStop = false;
            // 
            // textEdit9
            // 
            this.textEdit9.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "Tel1", true));
            this.textEdit9.Location = new System.Drawing.Point(134, 114);
            this.textEdit9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit9.MenuManager = this.bManager;
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Properties.ReadOnly = true;
            this.textEdit9.Size = new System.Drawing.Size(282, 22);
            this.textEdit9.StyleController = this._Layout;
            this.textEdit9.TabIndex = 19;
            this.textEdit9.TabStop = false;
            // 
            // textEdit8
            // 
            this.textEdit8.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "SevkSemt", true));
            this.textEdit8.Location = new System.Drawing.Point(663, 176);
            this.textEdit8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit8.MenuManager = this.bManager;
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.ReadOnly = true;
            this.textEdit8.Size = new System.Drawing.Size(145, 22);
            this.textEdit8.StyleController = this._Layout;
            this.textEdit8.TabIndex = 18;
            this.textEdit8.TabStop = false;
            // 
            // textEdit7
            // 
            this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "SevkIlce", true));
            this.textEdit7.Location = new System.Drawing.Point(402, 176);
            this.textEdit7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit7.MenuManager = this.bManager;
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.ReadOnly = true;
            this.textEdit7.Size = new System.Drawing.Size(152, 22);
            this.textEdit7.StyleController = this._Layout;
            this.textEdit7.TabIndex = 17;
            this.textEdit7.TabStop = false;
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "SevkSehir", true));
            this.textEdit6.Location = new System.Drawing.Point(134, 176);
            this.textEdit6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit6.MenuManager = this.bManager;
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.ReadOnly = true;
            this.textEdit6.Size = new System.Drawing.Size(159, 22);
            this.textEdit6.StyleController = this._Layout;
            this.textEdit6.TabIndex = 16;
            this.textEdit6.TabStop = false;
            // 
            // beSevkAdresSec
            // 
            this.beSevkAdresSec.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "SevkAdres1", true));
            this.beSevkAdresSec.Location = new System.Drawing.Point(134, 148);
            this.beSevkAdresSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beSevkAdresSec.MenuManager = this.bManager;
            this.beSevkAdresSec.Name = "beSevkAdresSec";
            this.beSevkAdresSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beSevkAdresSec.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beSevkAdresSec.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.beSevkAdresSec.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beSevkAdresSec.Size = new System.Drawing.Size(674, 22);
            this.beSevkAdresSec.StyleController = this._Layout;
            this.beSevkAdresSec.TabIndex = 15;
            this.beSevkAdresSec.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beSevkAdresSec_ButtonClick);
            // 
            // textEdit5
            // 
            this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "FaturaSemt", true));
            this.textEdit5.Location = new System.Drawing.Point(663, 86);
            this.textEdit5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit5.MenuManager = this.bManager;
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.ReadOnly = true;
            this.textEdit5.Size = new System.Drawing.Size(145, 22);
            this.textEdit5.StyleController = this._Layout;
            this.textEdit5.TabIndex = 14;
            this.textEdit5.TabStop = false;
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "FaturaIlce", true));
            this.textEdit4.Location = new System.Drawing.Point(402, 86);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit4.MenuManager = this.bManager;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.ReadOnly = true;
            this.textEdit4.Size = new System.Drawing.Size(152, 22);
            this.textEdit4.StyleController = this._Layout;
            this.textEdit4.TabIndex = 13;
            this.textEdit4.TabStop = false;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "FaturaSehir", true));
            this.textEdit3.Location = new System.Drawing.Point(134, 86);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit3.MenuManager = this.bManager;
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(159, 22);
            this.textEdit3.StyleController = this._Layout;
            this.textEdit3.TabIndex = 12;
            this.textEdit3.TabStop = false;
            // 
            // beFaturaAdresSec
            // 
            this.beFaturaAdresSec.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "FaturaAdres1", true));
            this.beFaturaAdresSec.Location = new System.Drawing.Point(134, 58);
            this.beFaturaAdresSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beFaturaAdresSec.MenuManager = this.bManager;
            this.beFaturaAdresSec.Name = "beFaturaAdresSec";
            this.beFaturaAdresSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beFaturaAdresSec.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beFaturaAdresSec.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.beFaturaAdresSec.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beFaturaAdresSec.Size = new System.Drawing.Size(674, 22);
            this.beFaturaAdresSec.StyleController = this._Layout;
            this.beFaturaAdresSec.TabIndex = 11;
            this.beFaturaAdresSec.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beFaturaAdresSec_ButtonClick);
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "Aciklama", true));
            this.textEdit2.Location = new System.Drawing.Point(134, 114);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit2.MenuManager = this.bManager;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(674, 22);
            this.textEdit2.StyleController = this._Layout;
            this.textEdit2.TabIndex = 10;
            // 
            // leDurum
            // 
            this.leDurum.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "Durum", true));
            this.leDurum.Location = new System.Drawing.Point(525, 86);
            this.leDurum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leDurum.MenuManager = this.bManager;
            this.leDurum.Name = "leDurum";
            this.leDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("leDurum.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.leDurum.Properties.NullText = "";
            this.leDurum.Size = new System.Drawing.Size(283, 22);
            this.leDurum.StyleController = this._Layout;
            this.leDurum.TabIndex = 9;
            // 
            // leOdemeSekli
            // 
            this.leOdemeSekli.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "OdemeSekli", true));
            this.leOdemeSekli.Location = new System.Drawing.Point(134, 86);
            this.leOdemeSekli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.leOdemeSekli.MenuManager = this.bManager;
            this.leOdemeSekli.Name = "leOdemeSekli";
            this.leOdemeSekli.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("leOdemeSekli.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.leOdemeSekli.Properties.NullText = "";
            this.leOdemeSekli.Size = new System.Drawing.Size(282, 22);
            this.leOdemeSekli.StyleController = this._Layout;
            this.leOdemeSekli.TabIndex = 8;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "EvrakNo", true));
            this.textEdit1.Location = new System.Drawing.Point(134, 58);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit1.MenuManager = this.bManager;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(282, 22);
            this.textEdit1.StyleController = this._Layout;
            this.textEdit1.TabIndex = 7;
            this.textEdit1.TabStop = false;
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "Tarih", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(525, 58);
            this.dateEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateEdit1.MenuManager = this.bManager;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("dateEdit1.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(283, 22);
            this.dateEdit1.StyleController = this._Layout;
            this.dateEdit1.TabIndex = 6;
            // 
            // beFirma
            // 
            this.beFirma.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsEvrak, "HesapAdi", true));
            this.beFirma.Location = new System.Drawing.Point(134, 58);
            this.beFirma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beFirma.MenuManager = this.bManager;
            this.beFirma.Name = "beFirma";
            this.beFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beFirma.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("beFirma.Properties.Buttons1"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, "", null, null, true)});
            this.beFirma.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beFirma.Size = new System.Drawing.Size(674, 22);
            this.beFirma.StyleController = this._Layout;
            this.beFirma.TabIndex = 5;
            this.beFirma.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beFirma_ButtonClick);
            // 
            // gridDetay
            // 
            this.gridDetay.DataSource = this.bsEvrakDetay;
            this.gridDetay.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gridDetay.Location = new System.Drawing.Point(16, 219);
            this.gridDetay.MainView = this.gwDetay;
            this.gridDetay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridDetay.MenuManager = this.bManager;
            this.gridDetay.Name = "gridDetay";
            this.gridDetay.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reMiktar,
            this.reFiyat,
            this.reTutar,
            this.reDurum});
            this.gridDetay.Size = new System.Drawing.Size(807, 298);
            this.gridDetay.TabIndex = 4;
            this.gridDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwDetay});
            // 
            // bsEvrakDetay
            // 
            this.bsEvrakDetay.DataMember = "SIP_EvrakDetay";
            this.bsEvrakDetay.DataSource = this.ds;
            this.bsEvrakDetay.Filter = "Silindi = 0";
            // 
            // gwDetay
            // 
            this.gwDetay.ColumnPanelRowHeight = 35;
            this.gwDetay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSiparisNo,
            this.colSira,
            this.colSipNo,
            this.colMusSiparisNo,
            this.colTerminTarihi,
            this.colStokKodu,
            this.colStokAdi,
            this.colStokTipi,
            this.colTanim,
            this.colMiktar,
            this.colFiyat,
            this.colTutar,
            this.colDurum,
            this.colAciklama});
            this.gwDetay.GridControl = this.gridDetay;
            this.gwDetay.Name = "gwDetay";
            this.gwDetay.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwDetay.OptionsLayout.Columns.StoreAppearance = true;
            this.gwDetay.OptionsLayout.StoreAllOptions = true;
            this.gwDetay.OptionsLayout.StoreAppearance = true;
            this.gwDetay.OptionsLayout.StoreFormatRules = true;
            this.gwDetay.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwDetay.OptionsView.ColumnAutoWidth = false;
            this.gwDetay.OptionsView.ShowGroupPanel = false;
            this.gwDetay.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gwDetay_PopupMenuShowing);
            this.gwDetay.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gwDetay_FocusedColumnChanged);
            this.gwDetay.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gwDetay_CellValueChanged);
            // 
            // colSiparisNo
            // 
            this.colSiparisNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSiparisNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSiparisNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSiparisNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSiparisNo.Caption = "Sipariş No";
            this.colSiparisNo.FieldName = "SiparisNo";
            this.colSiparisNo.Name = "colSiparisNo";
            this.colSiparisNo.OptionsColumn.AllowEdit = false;
            this.colSiparisNo.Visible = true;
            this.colSiparisNo.VisibleIndex = 0;
            // 
            // colSira
            // 
            this.colSira.AppearanceHeader.Options.UseTextOptions = true;
            this.colSira.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSira.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSira.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSira.Caption = "Sıra";
            this.colSira.FieldName = "Sira";
            this.colSira.Name = "colSira";
            this.colSira.OptionsColumn.AllowEdit = false;
            this.colSira.Visible = true;
            this.colSira.VisibleIndex = 1;
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
            this.colSipNo.OptionsColumn.AllowEdit = false;
            this.colSipNo.Visible = true;
            this.colSipNo.VisibleIndex = 2;
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
            this.colMusSiparisNo.VisibleIndex = 3;
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
            this.colTerminTarihi.VisibleIndex = 4;
            // 
            // colStokKodu
            // 
            this.colStokKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colStokKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStokKodu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colStokKodu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colStokKodu.FieldName = "StokKodu";
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.OptionsColumn.AllowEdit = false;
            this.colStokKodu.Visible = true;
            this.colStokKodu.VisibleIndex = 5;
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
            this.colStokAdi.OptionsColumn.AllowEdit = false;
            this.colStokAdi.Visible = true;
            this.colStokAdi.VisibleIndex = 6;
            // 
            // colStokTipi
            // 
            this.colStokTipi.AppearanceHeader.Options.UseTextOptions = true;
            this.colStokTipi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStokTipi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colStokTipi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colStokTipi.FieldName = "StokTipi";
            this.colStokTipi.Name = "colStokTipi";
            this.colStokTipi.OptionsColumn.AllowEdit = false;
            this.colStokTipi.Visible = true;
            this.colStokTipi.VisibleIndex = 7;
            // 
            // colTanim
            // 
            this.colTanim.AppearanceHeader.Options.UseTextOptions = true;
            this.colTanim.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTanim.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTanim.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTanim.Caption = "Tanım";
            this.colTanim.FieldName = "Tanim";
            this.colTanim.Name = "colTanim";
            this.colTanim.OptionsColumn.AllowEdit = false;
            this.colTanim.Visible = true;
            this.colTanim.VisibleIndex = 8;
            // 
            // colMiktar
            // 
            this.colMiktar.AppearanceHeader.Options.UseTextOptions = true;
            this.colMiktar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMiktar.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colMiktar.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colMiktar.ColumnEdit = this.reMiktar;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 9;
            // 
            // reMiktar
            // 
            this.reMiktar.AutoHeight = false;
            this.reMiktar.DisplayFormat.FormatString = "n0";
            this.reMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.reMiktar.EditFormat.FormatString = "n0";
            this.reMiktar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.reMiktar.Mask.EditMask = "n0";
            this.reMiktar.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.reMiktar.Name = "reMiktar";
            // 
            // colFiyat
            // 
            this.colFiyat.AppearanceHeader.Options.UseTextOptions = true;
            this.colFiyat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFiyat.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colFiyat.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colFiyat.ColumnEdit = this.reFiyat;
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 10;
            // 
            // reFiyat
            // 
            this.reFiyat.AutoHeight = false;
            this.reFiyat.DisplayFormat.FormatString = "n4";
            this.reFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.reFiyat.EditFormat.FormatString = "n4";
            this.reFiyat.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.reFiyat.Mask.EditMask = "n4";
            this.reFiyat.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.reFiyat.Name = "reFiyat";
            // 
            // colTutar
            // 
            this.colTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTutar.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTutar.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTutar.ColumnEdit = this.reTutar;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 11;
            // 
            // reTutar
            // 
            this.reTutar.AutoHeight = false;
            this.reTutar.DisplayFormat.FormatString = "n4";
            this.reTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.reTutar.EditFormat.FormatString = "n4";
            this.reTutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.reTutar.Mask.EditMask = "n4";
            this.reTutar.MaxValue = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.reTutar.Name = "reTutar";
            // 
            // colDurum
            // 
            this.colDurum.AppearanceHeader.Options.UseTextOptions = true;
            this.colDurum.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDurum.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDurum.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDurum.ColumnEdit = this.reDurum;
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 12;
            // 
            // reDurum
            // 
            this.reDurum.AutoHeight = false;
            this.reDurum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reDurum.Name = "reDurum";
            this.reDurum.NullText = "";
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
            this.colAciklama.VisibleIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridDetay,
            this.tabbedControlGroup1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(839, 533);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyGridDetay
            // 
            this.lyGridDetay.Control = this.gridDetay;
            this.lyGridDetay.Location = new System.Drawing.Point(0, 203);
            this.lyGridDetay.Name = "lyGridDetay";
            this.lyGridDetay.Size = new System.Drawing.Size(813, 304);
            this.lyGridDetay.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridDetay.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(813, 203);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup4,
            this.layoutControlGroup3});
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup2.CaptionImage")));
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyFirma,
            this.lyVergiDairesi,
            this.lyVergiNo,
            this.lyTel1,
            this.lyTel2,
            this.lyGsm,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(783, 146);
            this.layoutControlGroup2.Text = "Firma Bilgileri";
            // 
            // lyFirma
            // 
            this.lyFirma.Control = this.beFirma;
            this.lyFirma.Location = new System.Drawing.Point(0, 0);
            this.lyFirma.Name = "lyFirma";
            this.lyFirma.Size = new System.Drawing.Size(783, 28);
            this.lyFirma.Text = "Firma";
            this.lyFirma.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyVergiDairesi
            // 
            this.lyVergiDairesi.Control = this.textEdit11;
            this.lyVergiDairesi.Location = new System.Drawing.Point(0, 28);
            this.lyVergiDairesi.Name = "lyVergiDairesi";
            this.lyVergiDairesi.Size = new System.Drawing.Size(391, 28);
            this.lyVergiDairesi.Text = "Vergi Dairesi";
            this.lyVergiDairesi.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyVergiNo
            // 
            this.lyVergiNo.Control = this.textEdit12;
            this.lyVergiNo.Location = new System.Drawing.Point(391, 28);
            this.lyVergiNo.Name = "lyVergiNo";
            this.lyVergiNo.Size = new System.Drawing.Size(392, 28);
            this.lyVergiNo.Text = "Vergi No";
            this.lyVergiNo.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyTel1
            // 
            this.lyTel1.Control = this.textEdit9;
            this.lyTel1.Location = new System.Drawing.Point(0, 56);
            this.lyTel1.Name = "lyTel1";
            this.lyTel1.Size = new System.Drawing.Size(391, 28);
            this.lyTel1.Text = "Tel (1)";
            this.lyTel1.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyTel2
            // 
            this.lyTel2.Control = this.textEdit10;
            this.lyTel2.Location = new System.Drawing.Point(391, 56);
            this.lyTel2.Name = "lyTel2";
            this.lyTel2.Size = new System.Drawing.Size(392, 28);
            this.lyTel2.Text = "Tel (2)";
            this.lyTel2.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyGsm
            // 
            this.lyGsm.Control = this.textEdit13;
            this.lyGsm.Location = new System.Drawing.Point(0, 84);
            this.lyGsm.Name = "lyGsm";
            this.lyGsm.Size = new System.Drawing.Size(783, 28);
            this.lyGsm.Text = "Gsm";
            this.lyGsm.TextSize = new System.Drawing.Size(100, 20);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 112);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(783, 34);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyEvrakNo,
            this.lyOdemeSekli,
            this.lyAciklama,
            this.emptySpaceItem2,
            this.lyTarih,
            this.lyDurum});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(783, 146);
            this.layoutControlGroup4.Text = "Evrak Bilgileri";
            // 
            // lyEvrakNo
            // 
            this.lyEvrakNo.Control = this.textEdit1;
            this.lyEvrakNo.Location = new System.Drawing.Point(0, 0);
            this.lyEvrakNo.Name = "lyEvrakNo";
            this.lyEvrakNo.Size = new System.Drawing.Size(391, 28);
            this.lyEvrakNo.Text = "Evrak No";
            this.lyEvrakNo.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyOdemeSekli
            // 
            this.lyOdemeSekli.Control = this.leOdemeSekli;
            this.lyOdemeSekli.Location = new System.Drawing.Point(0, 28);
            this.lyOdemeSekli.Name = "lyOdemeSekli";
            this.lyOdemeSekli.Size = new System.Drawing.Size(391, 28);
            this.lyOdemeSekli.Text = "Ödeme Şekli";
            this.lyOdemeSekli.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyAciklama
            // 
            this.lyAciklama.Control = this.textEdit2;
            this.lyAciklama.Location = new System.Drawing.Point(0, 56);
            this.lyAciklama.Name = "lyAciklama";
            this.lyAciklama.Size = new System.Drawing.Size(783, 28);
            this.lyAciklama.Text = "Açıklama";
            this.lyAciklama.TextSize = new System.Drawing.Size(100, 20);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 84);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(783, 62);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lyTarih
            // 
            this.lyTarih.Control = this.dateEdit1;
            this.lyTarih.Location = new System.Drawing.Point(391, 0);
            this.lyTarih.Name = "lyTarih";
            this.lyTarih.Size = new System.Drawing.Size(392, 28);
            this.lyTarih.Text = "Tarih";
            this.lyTarih.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyDurum
            // 
            this.lyDurum.Control = this.leDurum;
            this.lyDurum.Location = new System.Drawing.Point(391, 28);
            this.lyDurum.Name = "lyDurum";
            this.lyDurum.Size = new System.Drawing.Size(392, 28);
            this.lyDurum.Text = "Durum";
            this.lyDurum.TextSize = new System.Drawing.Size(100, 20);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImage")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyFaturaAdres,
            this.lyFaturaSehir,
            this.lyFaturaIlce,
            this.emptySpaceItem1,
            this.lySevkAdres,
            this.lySevkSehir,
            this.lySevkIlce,
            this.lyFaturaSemt,
            this.lySevkSemt});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(783, 146);
            this.layoutControlGroup3.Text = "Sevk && Fatura";
            // 
            // lyFaturaAdres
            // 
            this.lyFaturaAdres.Control = this.beFaturaAdresSec;
            this.lyFaturaAdres.Location = new System.Drawing.Point(0, 0);
            this.lyFaturaAdres.Name = "lyFaturaAdres";
            this.lyFaturaAdres.Size = new System.Drawing.Size(783, 28);
            this.lyFaturaAdres.Text = "Fatura Adres";
            this.lyFaturaAdres.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyFaturaSehir
            // 
            this.lyFaturaSehir.Control = this.textEdit3;
            this.lyFaturaSehir.Location = new System.Drawing.Point(0, 28);
            this.lyFaturaSehir.Name = "lyFaturaSehir";
            this.lyFaturaSehir.Size = new System.Drawing.Size(268, 28);
            this.lyFaturaSehir.Text = "Fatura Şehir";
            this.lyFaturaSehir.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyFaturaIlce
            // 
            this.lyFaturaIlce.Control = this.textEdit4;
            this.lyFaturaIlce.Location = new System.Drawing.Point(268, 28);
            this.lyFaturaIlce.Name = "lyFaturaIlce";
            this.lyFaturaIlce.Size = new System.Drawing.Size(261, 28);
            this.lyFaturaIlce.Text = "Fatura İlçe";
            this.lyFaturaIlce.TextSize = new System.Drawing.Size(100, 20);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 56);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(783, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lySevkAdres
            // 
            this.lySevkAdres.Control = this.beSevkAdresSec;
            this.lySevkAdres.Location = new System.Drawing.Point(0, 90);
            this.lySevkAdres.Name = "lySevkAdres";
            this.lySevkAdres.Size = new System.Drawing.Size(783, 28);
            this.lySevkAdres.Text = "Sevk Adres";
            this.lySevkAdres.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lySevkSehir
            // 
            this.lySevkSehir.Control = this.textEdit6;
            this.lySevkSehir.Location = new System.Drawing.Point(0, 118);
            this.lySevkSehir.Name = "lySevkSehir";
            this.lySevkSehir.Size = new System.Drawing.Size(268, 28);
            this.lySevkSehir.Text = "Sevk Şehir";
            this.lySevkSehir.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lySevkIlce
            // 
            this.lySevkIlce.Control = this.textEdit7;
            this.lySevkIlce.Location = new System.Drawing.Point(268, 118);
            this.lySevkIlce.Name = "lySevkIlce";
            this.lySevkIlce.Size = new System.Drawing.Size(261, 28);
            this.lySevkIlce.Text = "Sevk İlçe";
            this.lySevkIlce.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lyFaturaSemt
            // 
            this.lyFaturaSemt.Control = this.textEdit5;
            this.lyFaturaSemt.Location = new System.Drawing.Point(529, 28);
            this.lyFaturaSemt.Name = "lyFaturaSemt";
            this.lyFaturaSemt.Size = new System.Drawing.Size(254, 28);
            this.lyFaturaSemt.Text = "Fatura Semt";
            this.lyFaturaSemt.TextSize = new System.Drawing.Size(100, 20);
            // 
            // lySevkSemt
            // 
            this.lySevkSemt.Control = this.textEdit8;
            this.lySevkSemt.Location = new System.Drawing.Point(529, 118);
            this.lySevkSemt.Name = "lySevkSemt";
            this.lySevkSemt.Size = new System.Drawing.Size(254, 28);
            this.lySevkSemt.Text = "Sevk Semt";
            this.lySevkSemt.TextSize = new System.Drawing.Size(100, 20);
            // 
            // dtEvrak
            // 
            this.dtEvrak.ClearBeforeFill = true;
            // 
            // dtEvrakDetay
            // 
            this.dtEvrakDetay.ClearBeforeFill = true;
            // 
            // popupDetay
            // 
            this.popupDetay.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuUrunEkle),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuUrunSil),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerListe)});
            this.popupDetay.Manager = this.bManager;
            this.popupDetay.Name = "popupDetay";
            // 
            // frmSiparis
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 582);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmSiparis";
            this.Text = "frmSiparis";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvrak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beSevkAdresSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFaturaAdresSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leOdemeSekli.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEvrakDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyVergiDairesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyVergiNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGsm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyEvrakNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyOdemeSekli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyAciklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaIlce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkAdres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkIlce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFaturaSemt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySevkSemt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYeni;
        private DevExpress.XtraBars.BarLargeButtonItem mnuSil;
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
        private DevExpress.XtraGrid.GridControl gridDetay;
        private DevExpress.XtraGrid.Views.Grid.GridView gwDetay;
        private DevExpress.XtraLayout.LayoutControlItem lyGridDetay;
        private DevExpress.XtraEditors.ButtonEdit beFirma;
        private DevExpress.XtraEditors.LookUpEdit leOdemeSekli;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LookUpEdit leDurum;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.ButtonEdit beSevkAdresSec;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.ButtonEdit beFaturaAdresSec;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlItem lyFaturaAdres;
        private DevExpress.XtraLayout.LayoutControlItem lyFaturaSehir;
        private DevExpress.XtraLayout.LayoutControlItem lyFaturaIlce;
        private DevExpress.XtraLayout.LayoutControlItem lyFaturaSemt;
        private DevExpress.XtraLayout.LayoutControlItem lySevkAdres;
        private DevExpress.XtraLayout.LayoutControlItem lySevkSehir;
        private DevExpress.XtraLayout.LayoutControlItem lySevkIlce;
        private DevExpress.XtraLayout.LayoutControlItem lySevkSemt;
        private DevExpress.XtraEditors.TextEdit textEdit13;
        private DevExpress.XtraEditors.TextEdit textEdit12;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraLayout.LayoutControlItem lyTel1;
        private DevExpress.XtraLayout.LayoutControlItem lyTel2;
        private DevExpress.XtraLayout.LayoutControlItem lyVergiDairesi;
        private DevExpress.XtraLayout.LayoutControlItem lyVergiNo;
        private DevExpress.XtraLayout.LayoutControlItem lyGsm;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem lyFirma;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem lyEvrakNo;
        private DevExpress.XtraLayout.LayoutControlItem lyTarih;
        private DevExpress.XtraLayout.LayoutControlItem lyOdemeSekli;
        private DevExpress.XtraLayout.LayoutControlItem lyDurum;
        private DevExpress.XtraLayout.LayoutControlItem lyAciklama;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource bsEvrakDetay;
        private Data.Siparis.DSSiparis ds;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMusSiparisNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colStokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colStokTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colSira;
        private DevExpress.XtraGrid.Columns.GridColumn colSipNo;
        private Data.Siparis.DSSiparisTableAdapters.SIP_EvrakTableAdapter dtEvrak;
        private Data.Siparis.DSSiparisTableAdapters.SIP_EvrakDetayTableAdapter dtEvrakDetay;
        private System.Windows.Forms.BindingSource bsEvrak;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraBars.PopupMenu popupDetay;
        private DevExpress.XtraBars.BarButtonItem mnuUrunEkle;
        private DevExpress.XtraBars.BarButtonItem mnuUrunSil;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerListe;
        private DevExpress.Utils.ImageCollection IMG24;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit reMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit reFiyat;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit reTutar;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reDurum;
    }
}