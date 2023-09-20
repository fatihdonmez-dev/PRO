namespace PRO.Win.Global
{
    partial class frmDepoAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepoAra));
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
            this.ds = new PRO.Data.Global.DSGlobal();
            this.gwListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDepoKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reDepoTip = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGridListe = new DevExpress.XtraLayout.LayoutControlItem();
            this.dt = new PRO.Data.Global.DSGlobalTableAdapters.DEP_KartTableAdapter();
            this.popupListe = new DevExpress.XtraBars.PopupMenu();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reDepoTip)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(444, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 403);
            this.barDockControlBottom.Size = new System.Drawing.Size(444, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 364);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(444, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 364);
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
            this._Layout.Size = new System.Drawing.Size(444, 364);
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
            this.gridListe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.reDepoTip});
            this.gridListe.Size = new System.Drawing.Size(420, 340);
            this.gridListe.TabIndex = 4;
            this.gridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwListe});
            // 
            // bs
            // 
            this.bs.DataMember = "DEP_Kart";
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
            this.colDepoKodu,
            this.colDepoAdi,
            this.colDepoTipi});
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
            // colDepoKodu
            // 
            this.colDepoKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepoKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepoKodu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDepoKodu.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDepoKodu.FieldName = "DepoKodu";
            this.colDepoKodu.Name = "colDepoKodu";
            this.colDepoKodu.Visible = true;
            this.colDepoKodu.VisibleIndex = 0;
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
            this.colDepoAdi.VisibleIndex = 1;
            // 
            // colDepoTipi
            // 
            this.colDepoTipi.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepoTipi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepoTipi.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colDepoTipi.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDepoTipi.Caption = "Depo Tipi";
            this.colDepoTipi.ColumnEdit = this.reDepoTip;
            this.colDepoTipi.FieldName = "DepoTipi";
            this.colDepoTipi.Name = "colDepoTipi";
            this.colDepoTipi.Visible = true;
            this.colDepoTipi.VisibleIndex = 2;
            // 
            // reDepoTip
            // 
            this.reDepoTip.AutoHeight = false;
            this.reDepoTip.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reDepoTip.Name = "reDepoTip";
            this.reDepoTip.NullText = "";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridListe});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(444, 364);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyGridListe
            // 
            this.lyGridListe.Control = this.gridListe;
            this.lyGridListe.Location = new System.Drawing.Point(0, 0);
            this.lyGridListe.Name = "lyGridListe";
            this.lyGridListe.Size = new System.Drawing.Size(424, 344);
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
            // frmDepoAra
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 403);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDepoAra";
            this.Text = "frmDepoAra";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reDepoTip)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reDepoTip;
        private System.Windows.Forms.BindingSource bs;
        private Data.Global.DSGlobal ds;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoTipi;
        private Data.Global.DSGlobalTableAdapters.DEP_KartTableAdapter dt;
        private DevExpress.Utils.ImageCollection IMG24;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerListe;
        private DevExpress.XtraBars.PopupMenu popupListe;
    }
}