namespace PRO.Sistem
{
    partial class frmKullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanici));
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            this.bManager = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYetkileriGuncelle = new DevExpress.XtraBars.BarLargeButtonItem();
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
            this.gridYetki = new DevExpress.XtraGrid.GridControl();
            this.bsModulYetki = new System.Windows.Forms.BindingSource();
            this.ds = new PRO.Data.DSSystem();
            this.gwYetki = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeMenu = new DevExpress.XtraTreeList.TreeList();
            this.colMenuNo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsAktif = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ceAktif = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.bsUserMenu = new System.Windows.Forms.BindingSource();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyTree = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyGridYetki = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtUserMenu = new PRO.Data.DSSystemTableAdapters.UDF_UserMenuTreeTableAdapter();
            this.dtModulYetki = new PRO.Data.DSSystemTableAdapters.UDF_UserModulYetkiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModulYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridYetki)).BeginInit();
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
            this.mnuYetkileriGuncelle,
            this.mnuKaydet,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet});
            this.bManager.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuYetkileriGuncelle),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKaydet, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKapat, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // mnuYetkileriGuncelle
            // 
            this.mnuYetkileriGuncelle.Caption = "Yetkileri Güncelle";
            this.mnuYetkileriGuncelle.Id = 0;
            this.mnuYetkileriGuncelle.ImageIndex = 18;
            this.mnuYetkileriGuncelle.Name = "mnuYetkileriGuncelle";
            this.mnuYetkileriGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYetkileriGuncelle_ItemClick);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Caption = "Kaydet";
            this.mnuKaydet.Id = 1;
            this.mnuKaydet.ImageIndex = 6;
            this.mnuKaydet.Name = "mnuKaydet";
            this.mnuKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKaydet_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 2;
            this.mnuKapat.ImageIndex = 19;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 4;
            this.barSubItem1.ImageIndex = 16;
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
            this.barDockControlTop.Size = new System.Drawing.Size(639, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 369);
            this.barDockControlBottom.Size = new System.Drawing.Size(639, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 330);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(639, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 330);
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
            this.IMG24.Images.SetKeyName(18, "businessman259.png");
            this.IMG24.Images.SetKeyName(19, "cikis1.png");
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.gridYetki);
            this._Layout.Controls.Add(this.treeMenu);
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
            this._Layout.Size = new System.Drawing.Size(639, 330);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // gridYetki
            // 
            this.gridYetki.DataSource = this.bsModulYetki;
            this.gridYetki.Location = new System.Drawing.Point(361, 12);
            this.gridYetki.MainView = this.gwYetki;
            this.gridYetki.MenuManager = this.bManager;
            this.gridYetki.Name = "gridYetki";
            this.gridYetki.Size = new System.Drawing.Size(266, 306);
            this.gridYetki.TabIndex = 5;
            this.gridYetki.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwYetki});
            // 
            // bsModulYetki
            // 
            this.bsModulYetki.DataMember = "UDF_UserModulYetki";
            this.bsModulYetki.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "DSSystem";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gwYetki
            // 
            this.gwYetki.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCaption,
            this.colYetki});
            this.gwYetki.GridControl = this.gridYetki;
            this.gwYetki.Name = "gwYetki";
            this.gwYetki.OptionsLayout.Columns.StoreAllOptions = true;
            this.gwYetki.OptionsLayout.Columns.StoreAppearance = true;
            this.gwYetki.OptionsLayout.StoreAllOptions = true;
            this.gwYetki.OptionsLayout.StoreAppearance = true;
            this.gwYetki.OptionsLayout.StoreFormatRules = true;
            this.gwYetki.OptionsView.ColumnAutoWidth = false;
            this.gwYetki.OptionsView.ShowGroupPanel = false;
            this.gwYetki.OptionsView.ShowIndicator = false;
            // 
            // colCaption
            // 
            this.colCaption.AppearanceHeader.Options.UseTextOptions = true;
            this.colCaption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCaption.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colCaption.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCaption.Caption = "Yetki Adı";
            this.colCaption.FieldName = "Caption";
            this.colCaption.Name = "colCaption";
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 0;
            // 
            // colYetki
            // 
            this.colYetki.AppearanceHeader.Options.UseTextOptions = true;
            this.colYetki.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYetki.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.colYetki.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colYetki.FieldName = "Yetki";
            this.colYetki.Name = "colYetki";
            this.colYetki.Visible = true;
            this.colYetki.VisibleIndex = 1;
            // 
            // treeMenu
            // 
            this.treeMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colMenuNo,
            this.colIsAktif});
            this.treeMenu.DataSource = this.bsUserMenu;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "1";
            this.treeMenu.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1});
            this.treeMenu.ImageIndexFieldName = "ImageID";
            this.treeMenu.Location = new System.Drawing.Point(12, 12);
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.OptionsBehavior.PopulateServiceColumns = true;
            this.treeMenu.OptionsLayout.RemoveOldColumns = true;
            this.treeMenu.OptionsLayout.StoreAppearance = true;
            this.treeMenu.OptionsMenu.EnableColumnMenu = false;
            this.treeMenu.OptionsMenu.EnableFooterMenu = false;
            this.treeMenu.OptionsMenu.ShowAutoFilterRowItem = false;
            this.treeMenu.OptionsView.AutoWidth = false;
            this.treeMenu.OptionsView.ShowHorzLines = false;
            this.treeMenu.OptionsView.ShowIndicator = false;
            this.treeMenu.OptionsView.ShowVertLines = false;
            this.treeMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ceAktif});
            this.treeMenu.Size = new System.Drawing.Size(345, 306);
            this.treeMenu.TabIndex = 4;
            this.treeMenu.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeMenu_FocusedNodeChanged);
            // 
            // colMenuNo
            // 
            this.colMenuNo.Caption = "Menü No";
            this.colMenuNo.FieldName = "Caption";
            this.colMenuNo.Name = "colMenuNo";
            this.colMenuNo.OptionsColumn.AllowEdit = false;
            this.colMenuNo.Visible = true;
            this.colMenuNo.VisibleIndex = 0;
            this.colMenuNo.Width = 208;
            // 
            // colIsAktif
            // 
            this.colIsAktif.Caption = "Aktf";
            this.colIsAktif.ColumnEdit = this.ceAktif;
            this.colIsAktif.FieldName = "IsAktif";
            this.colIsAktif.Name = "colIsAktif";
            this.colIsAktif.Visible = true;
            this.colIsAktif.VisibleIndex = 1;
            this.colIsAktif.Width = 87;
            // 
            // ceAktif
            // 
            this.ceAktif.AutoHeight = false;
            this.ceAktif.Name = "ceAktif";
            // 
            // bsUserMenu
            // 
            this.bsUserMenu.DataMember = "UDF_UserMenuTree";
            this.bsUserMenu.DataSource = this.ds;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyTree,
            this.lyGridYetki});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(639, 330);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyTree
            // 
            this.lyTree.Control = this.treeMenu;
            this.lyTree.Location = new System.Drawing.Point(0, 0);
            this.lyTree.Name = "lyTree";
            this.lyTree.Size = new System.Drawing.Size(349, 310);
            this.lyTree.TextSize = new System.Drawing.Size(0, 0);
            this.lyTree.TextVisible = false;
            // 
            // lyGridYetki
            // 
            this.lyGridYetki.Control = this.gridYetki;
            this.lyGridYetki.Location = new System.Drawing.Point(349, 0);
            this.lyGridYetki.Name = "lyGridYetki";
            this.lyGridYetki.Size = new System.Drawing.Size(270, 310);
            this.lyGridYetki.TextSize = new System.Drawing.Size(0, 0);
            this.lyGridYetki.TextVisible = false;
            // 
            // dtUserMenu
            // 
            this.dtUserMenu.ClearBeforeFill = true;
            // 
            // dtModulYetki
            // 
            this.dtModulYetki.ClearBeforeFill = true;
            // 
            // frmKullanici
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 369);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKullanici";
            this.Text = "frmKullanici";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModulYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUserMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridYetki)).EndInit();
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
        private DevExpress.XtraBars.BarLargeButtonItem mnuYetkileriGuncelle;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKaydet;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Data.DSSystem ds;
        private Data.DSSystemTableAdapters.UDF_UserMenuTreeTableAdapter dtUserMenu;
        private Data.DSSystemTableAdapters.UDF_UserModulYetkiTableAdapter dtModulYetki;
        private System.Windows.Forms.BindingSource bsUserMenu;
        private System.Windows.Forms.BindingSource bsModulYetki;
        private DevExpress.XtraGrid.GridControl gridYetki;
        private DevExpress.XtraGrid.Views.Grid.GridView gwYetki;
        private DevExpress.XtraTreeList.TreeList treeMenu;
        private DevExpress.XtraLayout.LayoutControlItem lyTree;
        private DevExpress.XtraLayout.LayoutControlItem lyGridYetki;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMenuNo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsAktif;
        private DevExpress.XtraGrid.Columns.GridColumn colCaption;
        private DevExpress.XtraGrid.Columns.GridColumn colYetki;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ceAktif;
        private DevExpress.Utils.ImageCollection IMG24;
    }
}