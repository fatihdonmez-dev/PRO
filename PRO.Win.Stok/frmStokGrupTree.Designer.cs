namespace PRO.Win.Stok
{
    partial class frmStokGrupTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokGrupTree));
            DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
            this.bManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYenile = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuSec = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuSil = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKaydet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKategori = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuAltKategori = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.IMG24 = new DevExpress.Utils.ImageCollection(this.components);
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.tree = new DevExpress.XtraTreeList.TreeList();
            this.colTanim = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new PRO.Data.Stok.DSStok();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyTree = new DevExpress.XtraLayout.LayoutControlItem();
            this.dt = new PRO.Data.Stok.DSStokTableAdapters.STK_GrupTreeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTree)).BeginInit();
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
            this.mnuKaydet,
            this.mnuKategori,
            this.mnuAltKategori,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuSil,
            this.mnuSec});
            this.bManager.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuSil, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.mnuKaydet, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKategori, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuAltKategori),
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
            this.mnuYenile.ImageIndex = 6;
            this.mnuYenile.Name = "mnuYenile";
            this.mnuYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYenile_ItemClick);
            // 
            // mnuSec
            // 
            this.mnuSec.Caption = "Seç";
            this.mnuSec.Enabled = false;
            this.mnuSec.Id = 8;
            this.mnuSec.ImageIndex = 11;
            this.mnuSec.Name = "mnuSec";
            this.mnuSec.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.mnuSec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSec_ItemClick);
            // 
            // mnuSil
            // 
            this.mnuSil.Caption = "Sil";
            this.mnuSil.Id = 7;
            this.mnuSil.ImageIndex = 2;
            this.mnuSil.Name = "mnuSil";
            this.E_Yetki.SetYetkiEnable(this.mnuSil, "_SIL");
            this.mnuSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSil_ItemClick);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Caption = "Kaydet";
            this.mnuKaydet.Id = 1;
            this.mnuKaydet.ImageIndex = 3;
            this.mnuKaydet.Name = "mnuKaydet";
            this.E_Yetki.SetYetkiEnable(this.mnuKaydet, "_KAYDET");
            this.mnuKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKaydet_ItemClick);
            // 
            // mnuKategori
            // 
            this.mnuKategori.Caption = "Kategori Tanımla";
            this.mnuKategori.Id = 2;
            this.mnuKategori.ImageIndex = 9;
            this.mnuKategori.Name = "mnuKategori";
            this.mnuKategori.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKategori_ItemClick);
            // 
            // mnuAltKategori
            // 
            this.mnuAltKategori.Caption = "Alt Kategori Tanımla";
            this.mnuAltKategori.Id = 3;
            this.mnuAltKategori.ImageIndex = 8;
            this.mnuAltKategori.Name = "mnuAltKategori";
            this.mnuAltKategori.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuAltKategori_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 4;
            this.mnuKapat.ImageIndex = 1;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 5;
            this.barSubItem1.ImageIndex = 7;
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
            this.barDockControlTop.Size = new System.Drawing.Size(460, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Size = new System.Drawing.Size(460, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 370);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(460, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 370);
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
            this.IMG24.Images.SetKeyName(6, "refresh.png");
            this.IMG24.Images.SetKeyName(7, "Settings.png");
            this.IMG24.Images.SetKeyName(8, "square75 copy.png");
            this.IMG24.Images.SetKeyName(9, "square81 copy.png");
            this.IMG24.Images.SetKeyName(10, "delete81.png");
            this.IMG24.Images.SetKeyName(11, "Ok.png");
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.tree);
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
            this._Layout.Size = new System.Drawing.Size(460, 370);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // tree
            // 
            this.tree.AppearancePrint.OddRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tree.AppearancePrint.OddRow.Options.UseFont = true;
            this.tree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTanim});
            this.tree.DataSource = this.bs;
            styleFormatCondition1.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 1;
            this.tree.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1});
            this.tree.ImageIndexFieldName = "ImageID";
            this.tree.KeyFieldName = "RowNr";
            this.tree.Location = new System.Drawing.Point(12, 12);
            this.tree.Name = "tree";
            this.tree.OptionsBehavior.PopulateServiceColumns = true;
            this.tree.OptionsLayout.RemoveOldColumns = true;
            this.tree.OptionsLayout.StoreAppearance = true;
            this.tree.OptionsMenu.EnableColumnMenu = false;
            this.tree.OptionsMenu.EnableFooterMenu = false;
            this.tree.OptionsMenu.ShowAutoFilterRowItem = false;
            this.tree.OptionsView.AutoWidth = false;
            this.tree.OptionsView.ShowHorzLines = false;
            this.tree.OptionsView.ShowIndicator = false;
            this.tree.OptionsView.ShowVertLines = false;
            this.tree.Size = new System.Drawing.Size(436, 346);
            this.tree.TabIndex = 4;
            this.tree.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.tree_NodeCellStyle);
            this.tree.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tree_FocusedNodeChanged);
            this.tree.Load += new System.EventHandler(this.tree_Load);
            // 
            // colTanim
            // 
            this.colTanim.FieldName = "Tanim";
            this.colTanim.Name = "colTanim";
            this.colTanim.OptionsColumn.AllowEdit = false;
            this.colTanim.Visible = true;
            this.colTanim.VisibleIndex = 0;
            this.colTanim.Width = 425;
            // 
            // bs
            // 
            this.bs.DataMember = "STK_GrupTree";
            this.bs.DataSource = this.ds;
            this.bs.Filter = "Silindi = 0";
            // 
            // ds
            // 
            this.ds.DataSetName = "DSStok";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyTree});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(460, 370);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lyTree
            // 
            this.lyTree.Control = this.tree;
            this.lyTree.Location = new System.Drawing.Point(0, 0);
            this.lyTree.Name = "lyTree";
            this.lyTree.Size = new System.Drawing.Size(440, 350);
            this.lyTree.TextSize = new System.Drawing.Size(0, 0);
            this.lyTree.TextVisible = false;
            // 
            // dt
            // 
            this.dt.ClearBeforeFill = true;
            // 
            // frmStokGrupTree
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 409);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmStokGrupTree";
            this.Text = "frmStokGrupTree";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager bManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem mnuYenile;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKaydet;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKategori;
        private DevExpress.XtraBars.BarLargeButtonItem mnuAltKategori;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraTreeList.TreeList tree;
        private DevExpress.XtraLayout.LayoutControlItem lyTree;
        private Data.Stok.DSStok ds;
        private Data.Stok.DSStokTableAdapters.STK_GrupTreeTableAdapter dt;
        private System.Windows.Forms.BindingSource bs;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTanim;
        private DevExpress.Utils.ImageCollection IMG24;
        private DevExpress.XtraBars.BarLargeButtonItem mnuSil;
        private DevExpress.XtraBars.BarLargeButtonItem mnuSec;
    }
}