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
using PRO.Control;
using PRO.Global;
using PRO.Data.Global;

namespace PRO.Win.Global
{
    public partial class frmDepoAra : frmBase
    {
        
        public frmDepoAra()
        {
            InitializeComponent();
        }

        public DSGlobal.DEP_KartRow row;
        public override void ExFormLoad()
        {
            DataLoad();
            _Tables.DEP_Kart_Tip.GetDataList().BindToControl(reDepoTip, "DepoTip", "TipAdi");
        }

        private void DataLoad()
        {
            ds.DEP_Kart.Clear();
            dt.Fill(ds.DEP_Kart);
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void mnuSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KayitSec();
        }

        private void KayitSec()
        {
            row = (DSGlobal.DEP_KartRow)gwListe.GetFocusedDataRow();
            if (row != null)
                DialogResult = System.Windows.Forms.DialogResult.OK;
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