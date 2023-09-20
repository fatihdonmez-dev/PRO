﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRO.Global;
using PRO.Control;

namespace PRO.Win.Finans.Evrak
{
    public partial class frmEvrakListe : frmBase
    {
        public frmEvrakListe()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            mnuBasTar.EditValue = DateTime.Today;
            mnuBitTar.EditValue = DateTime.Today;
            DataLoad();
        }

        private void DataLoad()
        {

        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnuYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataLoad();
        }

        private void mnuDuzelt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniDuzelt(Guid.NewGuid());
        }

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniDuzelt(Guid.Empty);
        }

        private void YeniDuzelt(Guid _evrakID)
        {
            
        }

        private void mnuOzelliklerGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridListe, true);
        }

        private void mnuOzelliklerListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwListe, true);
        }

        private void gwListe_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwListe_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupListe.ShowPopup(MousePosition);
        }
    }
}