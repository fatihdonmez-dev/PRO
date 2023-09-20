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
using PRO.Data.Siparis;

namespace PRO.Win.Siparis
{
    public partial class frmSatinAlmaListe : frmBase
    {
        public frmSatinAlmaListe()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            mnuBasTar.EditValue = DateTime.Today;
            mnuBitTar.EditValue = DateTime.Today;

            _Tables.STK_KartBirim.GetDataList().BindToControl(reBirim, "Kod", "Deger");
            _Tables.TAN_OdemeSekli.GetDataList().BindToControl(reOdemeSekli, "OdemeSekli", "OdemeSekliAdi");
            _Tables.SAS_EvrakDetay_Durum.GetDataList().BindToControl(reDurum, "Durum", "DurumAdi");

            DataLoad();
        }

        private void DataLoad()
        {
            ds.V_SatinAlmaListe.Clear();
            dt.Fill(ds.V_SatinAlmaListe,(DateTime)mnuBasTar.EditValue,(DateTime)mnuBitTar.EditValue);
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
            MenuData frmData = new MenuData("SIP004", "_SatinAlma", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmSatinAlma frm = new frmSatinAlma();
            frm.FormData = frmData;
            frm._evrakID = _evrakID;
            frm.ShowDialog();
            DataLoad();
        }

        private void mnuDuzelt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = (DSSiparis.V_SatinAlmaListeRow)gwListe.GetFocusedDataRow();
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
    }
}