namespace PRO.Win.Global
{
    partial class frmUlkeSehir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUlkeSehir));
            this.bManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYeni = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKaydet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.IMG24 = new DevExpress.Utils.ImageCollection();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.btnSemt = new DevExpress.XtraEditors.SimpleButton();
            this.btnIlce = new DevExpress.XtraEditors.SimpleButton();
            this.btnSehir = new DevExpress.XtraEditors.SimpleButton();
            this.btnUlke = new DevExpress.XtraEditors.SimpleButton();
            this.gridListe = new DevExpress.XtraGrid.GridControl();
            this.bs = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.Global.DSGlobal();
            this.gwListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUlke = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridListe = new DevExpress.XtraLayout.LayoutControlItem();
            this.lybtnUlke = new DevExpress.XtraLayout.LayoutControlItem();
            this.lybtnSehir = new DevExpress.XtraLayout.LayoutControlItem();
            this.lybtnIlce = new DevExpress.XtraLayout.LayoutControlItem();
            this.lybtnSemt = new DevExpress.XtraLayout.LayoutControlItem();
            this.dt = new PRO.Data.Global.DSGlobalTableAdapters.REF_SehirTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.lybtnUlke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lybtnSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lybtnIlce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lybtnSemt)).BeginInit();
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
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuYeni,
            this.mnuKaydet});
            this.bManager.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYeni, true),
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
            this.mnuYeni.Id = 6;
            this.mnuYeni.ImageIndex = 4;
            this.mnuYeni.Name = "mnuYeni";
            this.E_Yetki.SetYetkiEnable(this.mnuYeni, "_EKLE");
            this.mnuYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYeni_ItemClick);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Caption = "Kaydet";
            this.mnuKaydet.Id = 7;
            this.mnuKaydet.ImageIndex = 3;
            this.mnuKaydet.Name = "mnuKaydet";
            this.E_Yetki.SetYetkiEnable(this.mnuKaydet, "_KAYDET");
            this.mnuKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKaydet_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 3;
            this.mnuKapat.ImageIndex = 0;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 4;
            this.barSubItem1.ImageIndex = 5;
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
            this.barDockControlTop.Size = new System.Drawing.Size(539, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 372);
            this.barDockControlBottom.Size = new System.Drawing.Size(539, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 333);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(539, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 333);
            // 
            // IMG24
            // 
            this.IMG24.ImageSize = new System.Drawing.Size(24, 24);
            this.IMG24.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMG24.ImageStream")));
            this.IMG24.Images.SetKeyName(0, "cikis1.png");
            this.IMG24.Images.SetKeyName(1, "delete81.png");
            this.IMG24.Images.SetKeyName(2, "Edit.png");
            this.IMG24.Images.SetKeyName(3, "floppy1.png");
            this.IMG24.Images.SetKeyName(4, "new10.png");
            this.IMG24.Images.SetKeyName(5, "Settings.png");
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.btnSemt);
            this._Layout.Controls.Add(this.btnIlce);
            this._Layout.Controls.Add(this.btnSehir);
            this._Layout.Controls.Add(this.btnUlke);
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
            this._Layout.Size = new System.Drawing.Size(539, 333);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // btnSemt
            // 
            this.btnSemt.Enabled = false;
            this.btnSemt.Image = ((System.Drawing.Image)(resources.GetObject("btnSemt.Image")));
            this.btnSemt.Location = new System.Drawing.Point(399, 12);
            this.btnSemt.Name = "btnSemt";
            this.btnSemt.Size = new System.Drawing.Size(128, 22);
            this.btnSemt.StyleController = this._Layout;
            this.btnSemt.TabIndex = 8;
            this.btnSemt.Text = "Semtler";
            this.btnSemt.Click += new System.EventHandler(this.btnSemt_Click);
            // 
            // btnIlce
            // 
            this.btnIlce.Enabled = false;
            this.btnIlce.Image = ((System.Drawing.Image)(resources.GetObject("btnIlce.Image")));
            this.btnIlce.Location = new System.Drawing.Point(272, 12);
            this.btnIlce.Name = "btnIlce";
            this.btnIlce.Size = new System.Drawing.Size(123, 22);
            this.btnIlce.StyleController = this._Layout;
            this.btnIlce.TabIndex = 7;
            this.btnIlce.Text = "İlçeler";
            this.btnIlce.Click += new System.EventHandler(this.btnIlce_Click);
            // 
            // btnSehir
            // 
            this.btnSehir.Image = ((System.Drawing.Image)(resources.GetObject("btnSehir.Image")));
            this.btnSehir.Location = new System.Drawing.Point(149, 12);
            this.btnSehir.Name = "btnSehir";
            this.btnSehir.Size = new System.Drawing.Size(119, 22);
            this.btnSehir.StyleController = this._Layout;
            this.btnSehir.TabIndex = 6;
            this.btnSehir.Text = "Şehirler";
            this.btnSehir.Click += new System.EventHandler(this.btnSehir_Click);
            // 
            // btnUlke
            // 
            this.btnUlke.Image = ((System.Drawing.Image)(resources.GetObject("btnUlke.Image")));
            this.btnUlke.Location = new System.Drawing.Point(12, 12);
            this.btnUlke.Name = "btnUlke";
            this.btnUlke.Size = new System.Drawing.Size(133, 22);
            this.btnUlke.StyleController = this._Layout;
            this.btnUlke.TabIndex = 5;
            this.btnUlke.Text = "Ülkeler";
            this.btnUlke.Click += new System.EventHandler(this.btnUlke_Click);
            // 
            // gridListe
            // 
            this.gridListe.DataSource = this.bs;
            this.gridListe.Location = new System.Drawing.Point(12, 38);
            this.gridListe.MainView = this.gwListe;
            this.gridListe.MenuManager = this.bManager;
            this.gridListe.Name = "gridListe";
            this.gridListe.Size = new System.Drawing.Size(515, 283);
            this.gridListe.TabIndex = 4;
            this.gridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwListe});
            // 
            // bs
            // 
            this.bs.DataMember = "REF_Sehir";
            this.bs.DataSource = this.ds;
            this.bs.Filter = "";
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
            this.colUlke,
            this.colSehir,
            this.colIlce,
            this.colSemt,
            this.colTanim,
            this.colTelefonKodu});
            this.gwListe.GridControl = this.gridListe;
            this.gwListe.Name = "gwListe";
            this.gwListe.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwListe.OptionsLayout.Columns.StoreAppearance = true;
            this.gwListe.OptionsLayout.StoreAllOptions = true;
            this.gwListe.OptionsLayout.StoreAppearance = true;
            this.gwListe.OptionsLayout.StoreFormatRules = true;
            this.gwListe.OptionsNavigation.EnterMoveNextColumn = true;
            this.gwListe.OptionsView.ColumnAutoWidth = false;
            this.gwListe.OptionsView.ShowGroupPanel = false;
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
            this.colUlke.Visible = true;
            this.colUlke.VisibleIndex = 0;
            // 
            // colSehir
            // 
            this.colSehir.AppearanceHeader.Options.UseTextOptions = true;
            this.colSehir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSehir.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSehir.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSehir.Caption = "Şehir";
            this.colSehir.FieldName = "Sehir";
            this.colSehir.Name = "colSehir";
            this.colSehir.Visible = true;
            this.colSehir.VisibleIndex = 1;
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
            this.colIlce.Visible = true;
            this.colIlce.VisibleIndex = 2;
            // 
            // colSemt
            // 
            this.colSemt.AppearanceHeader.Options.UseTextOptions = true;
            this.colSemt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSemt.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colSemt.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSemt.FieldName = "Semt";
            this.colSemt.Name = "colSemt";
            this.colSemt.Visible = true;
            this.colSemt.VisibleIndex = 3;
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
            this.colTanim.Visible = true;
            this.colTanim.VisibleIndex = 4;
            // 
            // colTelefonKodu
            // 
            this.colTelefonKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colTelefonKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTelefonKodu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colTelefonKodu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colTelefonKodu.FieldName = "TelefonKodu";
            this.colTelefonKodu.Name = "colTelefonKodu";
            this.colTelefonKodu.Visible = true;
            this.colTelefonKodu.VisibleIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridListe,
            this.lybtnUlke,
            this.lybtnSehir,
            this.lybtnIlce,
            this.lybtnSemt});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(539, 333);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyGridListe
            // 
            this.lyGridListe.Control = this.gridListe;
            this.lyGridListe.Location = new System.Drawing.Point(0, 26);
            this.lyGridListe.Name = "lyGridListe";
            this.lyGridListe.Size = new System.Drawing.Size(519, 287);
            this.lyGridListe.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridListe.TextVisible = false;
            // 
            // lybtnUlke
            // 
            this.lybtnUlke.Control = this.btnUlke;
            this.lybtnUlke.Location = new System.Drawing.Point(0, 0);
            this.lybtnUlke.Name = "lybtnUlke";
            this.lybtnUlke.Size = new System.Drawing.Size(137, 26);
            this.lybtnUlke.TextSize = new System.Drawing.Size(0, 0);
            this.lybtnUlke.TextVisible = false;
            // 
            // lybtnSehir
            // 
            this.lybtnSehir.Control = this.btnSehir;
            this.lybtnSehir.Location = new System.Drawing.Point(137, 0);
            this.lybtnSehir.Name = "lybtnSehir";
            this.lybtnSehir.Size = new System.Drawing.Size(123, 26);
            this.lybtnSehir.TextSize = new System.Drawing.Size(0, 0);
            this.lybtnSehir.TextVisible = false;
            // 
            // lybtnIlce
            // 
            this.lybtnIlce.Control = this.btnIlce;
            this.lybtnIlce.Location = new System.Drawing.Point(260, 0);
            this.lybtnIlce.Name = "lybtnIlce";
            this.lybtnIlce.Size = new System.Drawing.Size(127, 26);
            this.lybtnIlce.TextSize = new System.Drawing.Size(0, 0);
            this.lybtnIlce.TextVisible = false;
            // 
            // lybtnSemt
            // 
            this.lybtnSemt.Control = this.btnSemt;
            this.lybtnSemt.Location = new System.Drawing.Point(387, 0);
            this.lybtnSemt.Name = "lybtnSemt";
            this.lybtnSemt.Size = new System.Drawing.Size(132, 26);
            this.lybtnSemt.TextSize = new System.Drawing.Size(0, 0);
            this.lybtnSemt.TextVisible = false;
            // 
            // dt
            // 
            this.dt.ClearBeforeFill = true;
            // 
            // frmUlkeSehir
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 372);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmUlkeSehir";
            this.Text = "frmUlkeSehir";
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
            ((System.ComponentModel.ISupportInitialize)(this.lybtnUlke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lybtnSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lybtnIlce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lybtnSemt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource bs;
        private Data.Global.DSGlobal ds;
        private Data.Global.DSGlobalTableAdapters.REF_SehirTableAdapter dt;
        private DevExpress.XtraGrid.GridControl gridListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gwListe;
        private DevExpress.XtraLayout.LayoutControlItem lyGridListe;
        private DevExpress.XtraGrid.Columns.GridColumn colUlke;
        private DevExpress.XtraGrid.Columns.GridColumn colSehir;
        private DevExpress.XtraGrid.Columns.GridColumn colIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colSemt;
        private DevExpress.XtraGrid.Columns.GridColumn colTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonKodu;
        private DevExpress.XtraEditors.SimpleButton btnSemt;
        private DevExpress.XtraEditors.SimpleButton btnIlce;
        private DevExpress.XtraEditors.SimpleButton btnSehir;
        private DevExpress.XtraEditors.SimpleButton btnUlke;
        private DevExpress.XtraLayout.LayoutControlItem lybtnUlke;
        private DevExpress.XtraLayout.LayoutControlItem lybtnSehir;
        private DevExpress.XtraLayout.LayoutControlItem lybtnIlce;
        private DevExpress.XtraLayout.LayoutControlItem lybtnSemt;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYeni;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKaydet;
        private DevExpress.Utils.ImageCollection IMG24;
    }
}