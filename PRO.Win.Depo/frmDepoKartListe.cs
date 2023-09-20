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
using PRO.Data.Depo;

namespace PRO.Win.Depo
{
    public partial class frmDepoKartListe : frmBase
    {
        public frmDepoKartListe()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            DataLoad();
        }

        private void DataLoad()
        {
            ds.V_DEP_KartListe.Clear();
            dt.Fill(ds.V_DEP_KartListe);
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void mnuYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataLoad();
        }

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Yeni(Guid.Empty);
        }

        private void Yeni(Guid _depoID)
        {
            MenuData frmData = new MenuData("DEP001", "_DepoKart", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmDepoKart frm = new frmDepoKart();
            frm.FormData = frmData;
            frm._DepoID = _depoID;
            frm.ShowDialog();
            DataLoad();
        
        }

        private void mnuDuzelt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = (DSDepo.V_DEP_KartListeRow)gwListe.GetFocusedDataRow();
            if (rw == null) return;

            Yeni(rw.DepoID);
        }

        private void mnuGenelOzellikler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridListe, true);
        }

        private void mnuListeOzellikler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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