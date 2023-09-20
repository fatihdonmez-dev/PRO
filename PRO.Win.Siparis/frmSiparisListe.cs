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
using PRO.Data.Siparis;
using PRO.Win.Stok;

namespace PRO.Win.Siparis
{
    public partial class frmSiparisListe : frmBase
    {
        public frmSiparisListe()
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
            ds.V_SiparisListe.Clear();
            dt.Fill(ds.V_SiparisListe);
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Yeni(Guid.Empty);
        }

        private void Yeni(Guid _evrakID)
        {
            MenuData frmData = new MenuData("SIP002", "_SiparisGiris", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmSiparis frm = new frmSiparis();
            frm._evrakID = _evrakID;
            frm.FormData = frmData;
            if(frm.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                DataLoad();
            }
            
        }

        private void mnuDuzelt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = (DSSiparis.V_SiparisListeRow)gwListe.GetFocusedDataRow();
            if (rw == null) return;

            Yeni(rw.EvrakID);
        }

        private void mnuYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataLoad();
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

        private void mnuDetayDuzelt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = (DSSiparis.V_SiparisListeRow)gwListe.GetFocusedDataRow();
            if (rw == null) return;

            Yeni(rw.EvrakID);
        }

        private void mnuStokGozlem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = (DSSiparis.V_SiparisListeRow)gwListe.GetFocusedDataRow();
            if (rw == null || rw.StokID == Guid.Empty) return;

            MenuData frmData = new MenuData("STK001", "_StokKart", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmStokKart frm = new frmStokKart();
            frm.FormData = frmData;
            frm._StokID = rw.StokID;
            frm.ShowDialog();

        }
    }
}