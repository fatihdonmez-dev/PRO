namespace PRO.Win.Finans.Fatura
{
    partial class frmFaturaListe
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYenile = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuBasTar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.mnuYeni = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuDuzelt = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.popupListe = new DevExpress.XtraBars.PopupMenu();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridListe = new DevExpress.XtraGrid.GridControl();
            this.gwListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lyGridListe = new DevExpress.XtraLayout.LayoutControlItem();
            this.mnuDYeni = new DevExpress.XtraBars.BarButtonItem();
            this.mnuDDuzelt = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerListe = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridListe)).BeginInit();
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
            this.mnuBasTar,
            this.barEditItem1,
            this.mnuYeni,
            this.mnuDuzelt,
            this.mnuKapat,
            this.barSubItem1,
            this.mnGorunumKaydet,
            this.mnuDYeni,
            this.mnuDDuzelt,
            this.mnuOzelliklerGenel,
            this.mnuOzelliklerListe});
            this.bManager.MaxItemId = 12;
            this.bManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(647, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 401);
            this.barDockControlBottom.Size = new System.Drawing.Size(647, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 372);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(647, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 372);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuBasTar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYenile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYeni, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuDuzelt, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKapat, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // mnuYenile
            // 
            this.mnuYenile.Caption = "Yenile";
            this.mnuYenile.Id = 0;
            this.mnuYenile.Name = "mnuYenile";
            this.mnuYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYenile_ItemClick);
            // 
            // mnuBasTar
            // 
            this.mnuBasTar.Caption = "Baş.Tarih";
            this.mnuBasTar.Edit = this.repositoryItemDateEdit1;
            this.mnuBasTar.Id = 1;
            this.mnuBasTar.Name = "mnuBasTar";
            this.mnuBasTar.Width = 85;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Bit.Tarih";
            this.barEditItem1.Edit = this.repositoryItemDateEdit2;
            this.barEditItem1.Id = 2;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 85;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // mnuYeni
            // 
            this.mnuYeni.Caption = "Yeni";
            this.mnuYeni.Id = 3;
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYeni_ItemClick);
            // 
            // mnuDuzelt
            // 
            this.mnuDuzelt.Caption = "Düzelt";
            this.mnuDuzelt.Id = 4;
            this.mnuDuzelt.Name = "mnuDuzelt";
            this.mnuDuzelt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuDuzelt_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 5;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 6;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnGorunumKaydet)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnGorunumKaydet
            // 
            this.mnGorunumKaydet.Caption = "Görünüm Kaydet";
            this.mnGorunumKaydet.Id = 7;
            this.mnGorunumKaydet.Name = "mnGorunumKaydet";
            this.mnGorunumKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnGorunumKaydet_ItemClick);
            // 
            // popupListe
            // 
            this.popupListe.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuDYeni),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuDDuzelt),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerListe)});
            this.popupListe.Manager = this.bManager;
            this.popupListe.Name = "popupListe";
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.gridListe);
            this._Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Layout.Location = new System.Drawing.Point(0, 29);
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
            this._Layout.Size = new System.Drawing.Size(647, 372);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridListe});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(647, 372);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // gridListe
            // 
            this.gridListe.Location = new System.Drawing.Point(66, 12);
            this.gridListe.MainView = this.gwListe;
            this.gridListe.MenuManager = this.bManager;
            this.gridListe.Name = "gridListe";
            this.gridListe.Size = new System.Drawing.Size(569, 348);
            this.gridListe.TabIndex = 4;
            this.gridListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwListe});
            // 
            // gwListe
            // 
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
            // 
            // lyGridListe
            // 
            this.lyGridListe.Control = this.gridListe;
            this.lyGridListe.Location = new System.Drawing.Point(0, 0);
            this.lyGridListe.Name = "lyGridListe";
            this.lyGridListe.Size = new System.Drawing.Size(627, 352);
            this.lyGridListe.TextSize = new System.Drawing.Size(50, 20);
            // 
            // mnuDYeni
            // 
            this.mnuDYeni.Caption = "Yeni";
            this.mnuDYeni.Id = 8;
            this.mnuDYeni.Name = "mnuDYeni";
            this.mnuDYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYeni_ItemClick);
            // 
            // mnuDDuzelt
            // 
            this.mnuDDuzelt.Caption = "Düzelt";
            this.mnuDDuzelt.Id = 9;
            this.mnuDDuzelt.Name = "mnuDDuzelt";
            this.mnuDDuzelt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuDuzelt_ItemClick);
            // 
            // mnuOzelliklerGenel
            // 
            this.mnuOzelliklerGenel.Caption = "Genel Özellikler";
            this.mnuOzelliklerGenel.Id = 10;
            this.mnuOzelliklerGenel.Name = "mnuOzelliklerGenel";
            this.mnuOzelliklerGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzelliklerGenel_ItemClick);
            // 
            // mnuOzelliklerListe
            // 
            this.mnuOzelliklerListe.Caption = "Liste Özellikler";
            this.mnuOzelliklerListe.Id = 11;
            this.mnuOzelliklerListe.Name = "mnuOzelliklerListe";
            this.mnuOzelliklerListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzelliklerListe_ItemClick);
            // 
            // frmFaturaListe
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 401);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmFaturaListe";
            this.Text = "frmFaturaListe";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYenile;
        private DevExpress.XtraBars.BarEditItem mnuBasTar;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYeni;
        private DevExpress.XtraBars.BarLargeButtonItem mnuDuzelt;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnGorunumKaydet;
        private DevExpress.XtraBars.PopupMenu popupListe;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraGrid.GridControl gridListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gwListe;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lyGridListe;
        private DevExpress.XtraBars.BarButtonItem mnuDYeni;
        private DevExpress.XtraBars.BarButtonItem mnuDDuzelt;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerListe;
    }
}