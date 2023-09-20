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
using PRO.Data.Stok;

namespace PRO.Win.Global
{
    public partial class frmStokAra : frmBase
    {
        public frmStokAra()
        {
            InitializeComponent();
        }

        public DSStok.V_STK_KartListeRow row;
        public Guid _hesapID = Guid.Empty;
        public override void ExFormLoad()
        {
            DataLoad();
        }

        private void DataLoad()
        {
            if (_hesapID != Guid.Empty)
            {
                ds.V_STK_KartListe.Clear();
                dt.FillByFirma(ds.V_STK_KartListe,_hesapID);
            }
            else
            {
                ds.V_STK_KartListe.Clear();
                dt.Fill(ds.V_STK_KartListe);
            }
            
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
            var rw = (DSStok.V_STK_KartListeRow)gwListe.GetFocusedDataRow();
            if (rw == null) return;

            row = rw;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
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