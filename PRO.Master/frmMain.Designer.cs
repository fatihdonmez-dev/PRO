namespace PRO.Master
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.IMG32 = new DevExpress.Utils.ImageCollection(this.components);
            this.lbUser = new DevExpress.XtraBars.BarStaticItem();
            this.lbSirket = new DevExpress.XtraBars.BarStaticItem();
            this.lbFormSirket = new DevExpress.XtraBars.BarStaticItem();
            this.lbDB = new DevExpress.XtraBars.BarStaticItem();
            this.mnuFirma = new DevExpress.XtraBars.BarButtonItem();
            this.mnuModul = new DevExpress.XtraBars.BarButtonItem();
            this.mnuMenu = new DevExpress.XtraBars.BarButtonItem();
            this.mnuKullanici = new DevExpress.XtraBars.BarButtonItem();
            this.mnuFirmaListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuStokKarti = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDepoKart = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSiparisGiris = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSiparisListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDepoKartListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSatinAlmaListe = new DevExpress.XtraBars.BarButtonItem();
            this.mnuSatinAlma = new DevExpress.XtraBars.BarButtonItem();
            this.mnuStokGrup = new DevExpress.XtraBars.BarButtonItem();
            this.mnuStokGrupTree = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDilKey = new DevExpress.XtraBars.BarButtonItem();
            this.mnuUlkeSehir = new DevExpress.XtraBars.BarButtonItem();
            this.mnuStokGiris = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpFinans = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpStok = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpSiparis = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpSatinAlma = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpSistem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.E_Localizer = new PRO.Control.Localizer();
            this.E_MenuYetki = new PRO.Control.MenuYetki();
            this._Tab = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Tab)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.GhostWhite;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ForeColor = System.Drawing.Color.Black;
            this.ribbon.Images = this.IMG32;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.lbUser,
            this.lbSirket,
            this.lbFormSirket,
            this.lbDB,
            this.mnuFirma,
            this.mnuModul,
            this.mnuMenu,
            this.mnuKullanici,
            this.mnuFirmaListe,
            this.mnuStokKarti,
            this.mnuDepoKart,
            this.mnuSiparisGiris,
            this.mnuSiparisListe,
            this.mnuDepoKartListe,
            this.mnuSatinAlmaListe,
            this.mnuSatinAlma,
            this.mnuStokGrup,
            this.mnuStokGrupTree,
            this.mnuDilKey,
            this.mnuUlkeSehir,
            this.mnuStokGiris});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 25;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.lbUser);
            this.ribbon.PageHeaderItemLinks.Add(this.lbSirket);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage5,
            this.ribbonPage4,
            this.ribbonPage6,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(904, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // IMG32
            // 
            this.IMG32.ImageSize = new System.Drawing.Size(32, 32);
            this.IMG32.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG32.ImageStream")));
            this.IMG32.Images.SetKeyName(0, "arac_giris.png");
            this.IMG32.Images.SetKeyName(1, "boxes2.png");
            this.IMG32.Images.SetKeyName(2, "business100.png");
            this.IMG32.Images.SetKeyName(3, "call37 copy.png");
            this.IMG32.Images.SetKeyName(4, "firma.png");
            this.IMG32.Images.SetKeyName(5, "global5 (1).png");
            this.IMG32.Images.SetKeyName(6, "list80 copy.png");
            this.IMG32.Images.SetKeyName(7, "Modul.png");
            this.IMG32.Images.SetKeyName(8, "papers1.png");
            this.IMG32.Images.SetKeyName(9, "sack1.png");
            this.IMG32.Images.SetKeyName(10, "stacked7 copy.png");
            this.IMG32.Images.SetKeyName(11, "three115 copy.png");
            this.IMG32.Images.SetKeyName(12, "delivery33 copy.png");
            this.IMG32.Images.SetKeyName(13, "factory6.png");
            this.IMG32.Images.SetKeyName(14, "career.png");
            this.IMG32.Images.SetKeyName(15, "multiple25 copy.png");
            this.IMG32.Images.SetKeyName(16, "packages2 copy.png");
            this.IMG32.Images.SetKeyName(17, "siparisGiris.png");
            this.IMG32.Images.SetKeyName(18, "factory3.png");
            this.IMG32.Images.SetKeyName(19, "budget1.png");
            this.IMG32.Images.SetKeyName(20, "business156 copy.png");
            this.IMG32.Images.SetKeyName(21, "dollar146 copy.png");
            this.IMG32.Images.SetKeyName(22, "euro51 copy.png");
            this.IMG32.Images.SetKeyName(23, "packages2 copy.png");
            this.IMG32.Images.SetKeyName(24, "cardboard-box.png");
            this.IMG32.Images.SetKeyName(25, "package4 copy.png");
            this.IMG32.Images.SetKeyName(26, "configure.png");
            this.IMG32.Images.SetKeyName(27, "extract1.png");
            // 
            // lbUser
            // 
            this.lbUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbUser.Caption = "UserName";
            this.lbUser.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.lbUser.Glyph = ((System.Drawing.Image)(resources.GetObject("lbUser.Glyph")));
            this.lbUser.Id = 1;
            this.lbUser.Name = "lbUser";
            this.lbUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbSirket
            // 
            this.lbSirket.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbSirket.Caption = "Şirket";
            this.lbSirket.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.lbSirket.Glyph = ((System.Drawing.Image)(resources.GetObject("lbSirket.Glyph")));
            this.lbSirket.Id = 2;
            this.lbSirket.Name = "lbSirket";
            this.lbSirket.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbFormSirket
            // 
            this.lbFormSirket.Caption = "Form Şirket";
            this.lbFormSirket.Glyph = ((System.Drawing.Image)(resources.GetObject("lbFormSirket.Glyph")));
            this.lbFormSirket.Id = 5;
            this.lbFormSirket.Name = "lbFormSirket";
            this.lbFormSirket.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbDB
            // 
            this.lbDB.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbDB.Caption = "DB";
            this.lbDB.Glyph = ((System.Drawing.Image)(resources.GetObject("lbDB.Glyph")));
            this.lbDB.Id = 6;
            this.lbDB.Name = "lbDB";
            this.lbDB.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.lbDB.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // mnuFirma
            // 
            this.mnuFirma.Caption = "Firma";
            this.mnuFirma.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuFirma, "_CariKart");
            this.mnuFirma.Id = 7;
            this.mnuFirma.ImageIndex = 4;
            this.E_MenuYetki.SetMenuYetki(this.mnuFirma, "201");
            this.mnuFirma.Name = "mnuFirma";
            this.mnuFirma.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuFirma.Tag = "201";
            this.mnuFirma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuModul
            // 
            this.mnuModul.Caption = "Modül";
            this.mnuModul.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuModul.Id = 8;
            this.mnuModul.ImageIndex = 7;
            this.E_MenuYetki.SetMenuYetki(this.mnuModul, "9001");
            this.mnuModul.Name = "mnuModul";
            this.mnuModul.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuModul.Tag = "9001";
            this.mnuModul.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuMenu
            // 
            this.mnuMenu.Caption = "Menü";
            this.mnuMenu.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuMenu.Id = 9;
            this.mnuMenu.ImageIndex = 17;
            this.E_MenuYetki.SetMenuYetki(this.mnuMenu, "9002");
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuMenu.Tag = "9002";
            this.mnuMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuKullanici
            // 
            this.mnuKullanici.Caption = "Kullanıcı";
            this.mnuKullanici.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuKullanici.Id = 10;
            this.mnuKullanici.ImageIndex = 15;
            this.E_MenuYetki.SetMenuYetki(this.mnuKullanici, "9003");
            this.mnuKullanici.Name = "mnuKullanici";
            this.mnuKullanici.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuKullanici.Tag = "9003";
            this.mnuKullanici.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuFirmaListe
            // 
            this.mnuFirmaListe.Caption = "Firma Listesi";
            this.mnuFirmaListe.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuFirmaListe, "_CariKartListe");
            this.mnuFirmaListe.Id = 11;
            this.mnuFirmaListe.ImageIndex = 13;
            this.E_MenuYetki.SetMenuYetki(this.mnuFirmaListe, "200");
            this.mnuFirmaListe.Name = "mnuFirmaListe";
            this.mnuFirmaListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuFirmaListe.Tag = "200";
            this.mnuFirmaListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuStokKarti
            // 
            this.mnuStokKarti.Caption = "Stok Kartı";
            this.mnuStokKarti.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuStokKarti, "_StokKart");
            this.mnuStokKarti.Id = 12;
            this.mnuStokKarti.ImageIndex = 24;
            this.E_MenuYetki.SetMenuYetki(this.mnuStokKarti, "300");
            this.mnuStokKarti.Name = "mnuStokKarti";
            this.mnuStokKarti.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuStokKarti.Tag = "300";
            this.mnuStokKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuDepoKart
            // 
            this.mnuDepoKart.Caption = "Depo Kartı";
            this.mnuDepoKart.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuDepoKart, "_DepoKart");
            this.mnuDepoKart.Id = 13;
            this.mnuDepoKart.ImageIndex = 1;
            this.E_MenuYetki.SetMenuYetki(this.mnuDepoKart, "400");
            this.mnuDepoKart.Name = "mnuDepoKart";
            this.mnuDepoKart.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuDepoKart.Tag = "400";
            this.mnuDepoKart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuSiparisGiris
            // 
            this.mnuSiparisGiris.Caption = "Sipariş Giriş";
            this.mnuSiparisGiris.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuSiparisGiris, "_SiparisGiris");
            this.mnuSiparisGiris.Id = 14;
            this.mnuSiparisGiris.ImageIndex = 0;
            this.E_MenuYetki.SetMenuYetki(this.mnuSiparisGiris, "501");
            this.mnuSiparisGiris.Name = "mnuSiparisGiris";
            this.mnuSiparisGiris.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuSiparisGiris.Tag = "501";
            this.mnuSiparisGiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuSiparisListe
            // 
            this.mnuSiparisListe.Caption = "Sipariş Listesi";
            this.mnuSiparisListe.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuSiparisListe, "_SiparisListe");
            this.mnuSiparisListe.Id = 15;
            this.mnuSiparisListe.ImageIndex = 10;
            this.E_MenuYetki.SetMenuYetki(this.mnuSiparisListe, "500");
            this.mnuSiparisListe.Name = "mnuSiparisListe";
            this.mnuSiparisListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuSiparisListe.Tag = "500";
            this.mnuSiparisListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuDepoKartListe
            // 
            this.mnuDepoKartListe.Caption = "Depo Listesi";
            this.mnuDepoKartListe.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuDepoKartListe, "_DepoKartListe");
            this.mnuDepoKartListe.Id = 16;
            this.mnuDepoKartListe.ImageIndex = 18;
            this.E_MenuYetki.SetMenuYetki(this.mnuDepoKartListe, "401");
            this.mnuDepoKartListe.Name = "mnuDepoKartListe";
            this.mnuDepoKartListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuDepoKartListe.Tag = "401";
            this.mnuDepoKartListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuSatinAlmaListe
            // 
            this.mnuSatinAlmaListe.Caption = "Satın Alma Listesi";
            this.mnuSatinAlmaListe.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuSatinAlmaListe, "_SatinAlmaListe");
            this.mnuSatinAlmaListe.Id = 17;
            this.mnuSatinAlmaListe.ImageIndex = 20;
            this.E_MenuYetki.SetMenuYetki(this.mnuSatinAlmaListe, "502");
            this.mnuSatinAlmaListe.Name = "mnuSatinAlmaListe";
            this.mnuSatinAlmaListe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuSatinAlmaListe.Tag = "502";
            this.mnuSatinAlmaListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuSatinAlma
            // 
            this.mnuSatinAlma.Caption = "Satın Alma";
            this.mnuSatinAlma.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuSatinAlma, "_SatinAlma");
            this.mnuSatinAlma.Id = 18;
            this.mnuSatinAlma.ImageIndex = 21;
            this.E_MenuYetki.SetMenuYetki(this.mnuSatinAlma, "503");
            this.mnuSatinAlma.Name = "mnuSatinAlma";
            this.mnuSatinAlma.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuSatinAlma.Tag = "503";
            this.mnuSatinAlma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuStokGrup
            // 
            this.mnuStokGrup.Caption = "Stok Grup";
            this.mnuStokGrup.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuStokGrup, "_StokGrup");
            this.mnuStokGrup.Id = 19;
            this.mnuStokGrup.ImageIndex = 25;
            this.mnuStokGrup.Name = "mnuStokGrup";
            this.mnuStokGrup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuStokGrup.Tag = "301";
            this.mnuStokGrup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.mnuStokGrup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuStokGrupTree
            // 
            this.mnuStokGrupTree.Caption = "Stok Grup Listesi";
            this.mnuStokGrupTree.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuStokGrupTree, "_StokGrupTree");
            this.mnuStokGrupTree.Id = 20;
            this.mnuStokGrupTree.ImageIndex = 25;
            this.E_MenuYetki.SetMenuYetki(this.mnuStokGrupTree, "302");
            this.mnuStokGrupTree.Name = "mnuStokGrupTree";
            this.mnuStokGrupTree.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuStokGrupTree.Tag = "302";
            this.mnuStokGrupTree.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuDilKey
            // 
            this.mnuDilKey.Caption = "DilKey Tanım";
            this.mnuDilKey.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuDilKey, "_DilKeyTanim");
            this.mnuDilKey.Id = 21;
            this.mnuDilKey.ImageIndex = 26;
            this.E_MenuYetki.SetMenuYetki(this.mnuDilKey, "9004");
            this.mnuDilKey.Name = "mnuDilKey";
            this.mnuDilKey.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuDilKey.Tag = "9004";
            this.mnuDilKey.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuUlkeSehir
            // 
            this.mnuUlkeSehir.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.mnuUlkeSehir.Caption = "Ülke/Şehir/İlçe/Semt";
            this.mnuUlkeSehir.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuUlkeSehir, "_UlkeSehir");
            this.mnuUlkeSehir.Id = 22;
            this.mnuUlkeSehir.ImageIndex = 5;
            this.E_MenuYetki.SetMenuYetki(this.mnuUlkeSehir, "8001");
            this.mnuUlkeSehir.Name = "mnuUlkeSehir";
            this.mnuUlkeSehir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuUlkeSehir.Tag = "8001";
            this.mnuUlkeSehir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // mnuStokGiris
            // 
            this.mnuStokGiris.Caption = "Stok Giriş";
            this.mnuStokGiris.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.E_Localizer.SetDilKey(this.mnuStokGiris, "_StokGiris");
            this.mnuStokGiris.Id = 23;
            this.mnuStokGiris.ImageIndex = 16;
            this.E_MenuYetki.SetMenuYetki(this.mnuStokGiris, "303");
            this.mnuStokGiris.Name = "mnuStokGiris";
            this.mnuStokGiris.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mnuStokGiris.Tag = "303";
            this.mnuStokGiris.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menu_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpFinans});
            this.E_MenuYetki.SetMenuYetki(this.ribbonPage1, "2");
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Finans";
            // 
            // rbpFinans
            // 
            this.rbpFinans.ItemLinks.Add(this.mnuFirma);
            this.rbpFinans.ItemLinks.Add(this.mnuFirmaListe);
            this.rbpFinans.Name = "rbpFinans";
            this.rbpFinans.ShowCaptionButton = false;
            this.rbpFinans.Text = "Finans";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpStok,
            this.ribbonPageGroup4});
            this.E_MenuYetki.SetMenuYetki(this.ribbonPage3, "3");
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Stok";
            // 
            // rbpStok
            // 
            this.rbpStok.ItemLinks.Add(this.mnuStokGrup);
            this.rbpStok.ItemLinks.Add(this.mnuStokGrupTree);
            this.rbpStok.ItemLinks.Add(this.mnuStokKarti);
            this.rbpStok.Name = "rbpStok";
            this.rbpStok.ShowCaptionButton = false;
            this.rbpStok.Text = "Stok Tanım";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.mnuStokGiris);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Stok İşlem";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpSiparis,
            this.rbpSatinAlma});
            this.E_MenuYetki.SetMenuYetki(this.ribbonPage5, "5");
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Sipariş";
            // 
            // rbpSiparis
            // 
            this.rbpSiparis.ItemLinks.Add(this.mnuSiparisGiris);
            this.rbpSiparis.ItemLinks.Add(this.mnuSiparisListe);
            this.rbpSiparis.Name = "rbpSiparis";
            this.rbpSiparis.ShowCaptionButton = false;
            this.rbpSiparis.Text = "Sipariş";
            // 
            // rbpSatinAlma
            // 
            this.rbpSatinAlma.ItemLinks.Add(this.mnuSatinAlma);
            this.rbpSatinAlma.ItemLinks.Add(this.mnuSatinAlmaListe);
            this.rbpSatinAlma.Name = "rbpSatinAlma";
            this.rbpSatinAlma.ShowCaptionButton = false;
            this.rbpSatinAlma.Text = "Satın Alma";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.E_MenuYetki.SetMenuYetki(this.ribbonPage4, "4");
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Depo";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuDepoKart);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuDepoKartListe);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Depo";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.E_MenuYetki.SetMenuYetki(this.ribbonPage6, "8");
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Tanımlar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowMinimize = false;
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.mnuUlkeSehir);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Genel Tanımlar";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpSistem,
            this.ribbonPageGroup2});
            this.E_MenuYetki.SetMenuYetki(this.ribbonPage2, "1");
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Sistem";
            // 
            // rbpSistem
            // 
            this.rbpSistem.ItemLinks.Add(this.mnuModul);
            this.rbpSistem.ItemLinks.Add(this.mnuMenu);
            this.rbpSistem.ItemLinks.Add(this.mnuKullanici);
            this.rbpSistem.Name = "rbpSistem";
            this.rbpSistem.ShowCaptionButton = false;
            this.rbpSistem.Text = "Sistem";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.mnuDilKey);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Tanım";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lbFormSirket);
            this.ribbonStatusBar.ItemLinks.Add(this.lbDB);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 415);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(904, 31);
            // 
            // _Tab
            // 
            this._Tab.MdiParent = this;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 446);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "FD Yazılım";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Tab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpFinans;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem lbUser;
        private DevExpress.XtraBars.BarStaticItem lbSirket;
        private DevExpress.XtraBars.BarStaticItem lbFormSirket;
        private DevExpress.XtraBars.BarStaticItem lbDB;
        private Control.Localizer E_Localizer;
        private Control.MenuYetki E_MenuYetki;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpStok;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpSistem;
        private DevExpress.XtraBars.BarButtonItem mnuFirma;
        private DevExpress.XtraBars.BarButtonItem mnuModul;
        private DevExpress.XtraBars.BarButtonItem mnuMenu;
        private DevExpress.XtraBars.BarButtonItem mnuKullanici;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager _Tab;
        private DevExpress.XtraBars.BarButtonItem mnuFirmaListe;
        private DevExpress.XtraBars.BarButtonItem mnuStokKarti;
        private DevExpress.XtraBars.BarButtonItem mnuDepoKart;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpSiparis;
        private DevExpress.XtraBars.BarButtonItem mnuSiparisGiris;
        private DevExpress.XtraBars.BarButtonItem mnuSiparisListe;
        private DevExpress.Utils.ImageCollection IMG32;
        private DevExpress.XtraBars.BarButtonItem mnuDepoKartListe;
        private DevExpress.XtraBars.BarButtonItem mnuSatinAlmaListe;
        private DevExpress.XtraBars.BarButtonItem mnuSatinAlma;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpSatinAlma;
        private DevExpress.XtraBars.BarButtonItem mnuStokGrup;
        private DevExpress.XtraBars.BarButtonItem mnuStokGrupTree;
        private DevExpress.XtraBars.BarButtonItem mnuDilKey;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem mnuUlkeSehir;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem mnuStokGiris;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}