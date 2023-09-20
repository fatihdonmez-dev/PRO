namespace PRO.Win.Finans.Fatura
{
    partial class frmFatura
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.bManager = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mnuYeni = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuSil = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKaydet = new DevExpress.XtraBars.BarLargeButtonItem();
            this.mnuKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.mnuGorunumKaydet = new DevExpress.XtraBars.BarButtonItem();
            this._Layout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridDetay = new DevExpress.XtraGrid.GridControl();
            this.gwDetay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lyGridDetay = new DevExpress.XtraLayout.LayoutControlItem();
            this.beFirma = new DevExpress.XtraEditors.ButtonEdit();
            this.lyFirma = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.lyTarih = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupDetay = new DevExpress.XtraBars.PopupMenu();
            this.mnuDetaySil = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerGenel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuOzelliklerListe = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).BeginInit();
            this._Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTarih)).BeginInit();
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
            this.bManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuYeni,
            this.mnuSil,
            this.mnuKaydet,
            this.mnuKapat,
            this.barSubItem1,
            this.mnuGorunumKaydet,
            this.mnuDetaySil,
            this.mnuOzelliklerGenel,
            this.mnuOzelliklerListe});
            this.bManager.MaxItemId = 9;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(664, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 399);
            this.barDockControlBottom.Size = new System.Drawing.Size(664, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 370);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(664, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 370);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKaydet, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuKapat, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // mnuYeni
            // 
            this.mnuYeni.Caption = "Yeni";
            this.mnuYeni.Id = 0;
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuYeni_ItemClick);
            // 
            // mnuSil
            // 
            this.mnuSil.Caption = "Sil";
            this.mnuSil.Id = 1;
            this.mnuSil.Name = "mnuSil";
            this.mnuSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuSil_ItemClick);
            // 
            // mnuKaydet
            // 
            this.mnuKaydet.Caption = "Kaydet";
            this.mnuKaydet.Id = 2;
            this.mnuKaydet.Name = "mnuKaydet";
            this.mnuKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKaydet_ItemClick);
            // 
            // mnuKapat
            // 
            this.mnuKapat.Caption = "Kapat";
            this.mnuKapat.Id = 3;
            this.mnuKapat.Name = "mnuKapat";
            this.mnuKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuKapat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Ayarlar";
            this.barSubItem1.Id = 4;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuGorunumKaydet)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // mnuGorunumKaydet
            // 
            this.mnuGorunumKaydet.Caption = "Görünüm Kaydet";
            this.mnuGorunumKaydet.Id = 5;
            this.mnuGorunumKaydet.Name = "mnuGorunumKaydet";
            this.mnuGorunumKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuGorunumKaydet_ItemClick);
            // 
            // _Layout
            // 
            this._Layout.Controls.Add(this.dateEdit1);
            this._Layout.Controls.Add(this.beFirma);
            this._Layout.Controls.Add(this.gridDetay);
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
            this._Layout.Size = new System.Drawing.Size(664, 370);
            this._Layout.TabIndex = 4;
            this._Layout.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGridDetay,
            this.lyFirma,
            this.lyTarih});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(664, 370);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // gridDetay
            // 
            this.gridDetay.Location = new System.Drawing.Point(66, 60);
            this.gridDetay.MainView = this.gwDetay;
            this.gridDetay.MenuManager = this.bManager;
            this.gridDetay.Name = "gridDetay";
            this.gridDetay.Size = new System.Drawing.Size(586, 298);
            this.gridDetay.TabIndex = 4;
            this.gridDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwDetay});
            // 
            // gwDetay
            // 
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
            // 
            // lyGridDetay
            // 
            this.lyGridDetay.Control = this.gridDetay;
            this.lyGridDetay.Location = new System.Drawing.Point(0, 48);
            this.lyGridDetay.Name = "lyGridDetay";
            this.lyGridDetay.Size = new System.Drawing.Size(644, 302);
            this.lyGridDetay.TextSize = new System.Drawing.Size(50, 20);
            // 
            // beFirma
            // 
            this.beFirma.Location = new System.Drawing.Point(66, 12);
            this.beFirma.MenuManager = this.bManager;
            this.beFirma.Name = "beFirma";
            this.beFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.beFirma.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beFirma.Size = new System.Drawing.Size(586, 20);
            this.beFirma.StyleController = this._Layout;
            this.beFirma.TabIndex = 5;
            // 
            // lyFirma
            // 
            this.lyFirma.Control = this.beFirma;
            this.lyFirma.Location = new System.Drawing.Point(0, 0);
            this.lyFirma.Name = "lyFirma";
            this.lyFirma.Size = new System.Drawing.Size(644, 24);
            this.lyFirma.Text = "Firma";
            this.lyFirma.TextSize = new System.Drawing.Size(50, 20);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(66, 36);
            this.dateEdit1.MenuManager = this.bManager;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Size = new System.Drawing.Size(586, 20);
            this.dateEdit1.StyleController = this._Layout;
            this.dateEdit1.TabIndex = 6;
            // 
            // lyTarih
            // 
            this.lyTarih.Control = this.dateEdit1;
            this.lyTarih.Location = new System.Drawing.Point(0, 24);
            this.lyTarih.Name = "lyTarih";
            this.lyTarih.Size = new System.Drawing.Size(644, 24);
            this.lyTarih.Text = "Tarih";
            this.lyTarih.TextSize = new System.Drawing.Size(50, 20);
            // 
            // popupDetay
            // 
            this.popupDetay.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuDetaySil),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerGenel, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuOzelliklerListe)});
            this.popupDetay.Manager = this.bManager;
            this.popupDetay.Name = "popupDetay";
            // 
            // mnuDetaySil
            // 
            this.mnuDetaySil.Caption = "Sil";
            this.mnuDetaySil.Id = 6;
            this.mnuDetaySil.Name = "mnuDetaySil";
            this.mnuDetaySil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuDetaySil_ItemClick);
            // 
            // mnuOzelliklerGenel
            // 
            this.mnuOzelliklerGenel.Caption = "Genel Özellikler";
            this.mnuOzelliklerGenel.Id = 7;
            this.mnuOzelliklerGenel.Name = "mnuOzelliklerGenel";
            this.mnuOzelliklerGenel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzelliklerGenel_ItemClick);
            // 
            // mnuOzelliklerListe
            // 
            this.mnuOzelliklerListe.Caption = "Liste Özellikler";
            this.mnuOzelliklerListe.Id = 8;
            this.mnuOzelliklerListe.Name = "mnuOzelliklerListe";
            this.mnuOzelliklerListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuOzelliklerListe_ItemClick);
            // 
            // frmFatura
            // 
            this.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 399);
            this.Controls.Add(this._Layout);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmFatura";
            this.Text = "frmFatura";
            ((System.ComponentModel.ISupportInitialize)(this.bManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Layout)).EndInit();
            this._Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGridDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupDetay)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraBars.BarLargeButtonItem mnuKaydet;
        private DevExpress.XtraBars.BarLargeButtonItem mnuKapat;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem mnuGorunumKaydet;
        private DevExpress.XtraLayout.LayoutControl _Layout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridDetay;
        private DevExpress.XtraGrid.Views.Grid.GridView gwDetay;
        private DevExpress.XtraLayout.LayoutControlItem lyGridDetay;
        private DevExpress.XtraEditors.ButtonEdit beFirma;
        private DevExpress.XtraLayout.LayoutControlItem lyFirma;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lyTarih;
        private DevExpress.XtraBars.PopupMenu popupDetay;
        private DevExpress.XtraBars.BarButtonItem mnuDetaySil;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerGenel;
        private DevExpress.XtraBars.BarButtonItem mnuOzelliklerListe;
    }
}