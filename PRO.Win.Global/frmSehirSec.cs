using System;
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
using PRO.Data.Global;

namespace PRO.Win.Global
{
    public partial class frmSehirSec : frmBase
    {
        public DSGlobal.V_SehirListeRow row;
        public frmSehirSec()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            DataLoad();
        }

        private void DataLoad()
        {
            ds.REF_Sehir.Clear();
            dt.Fill(ds.V_SehirListe);
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void mnuSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KayitSec();
        }

        private void KayitSec()
        {
            row = (DSGlobal.V_SehirListeRow)gwListe.GetFocusedDataRow();
            if (row != null)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
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

        private void gwListe_DoubleClick(object sender, EventArgs e)
        {
            KayitSec();
        }
    }
}