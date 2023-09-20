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
using PRO.Data.Finans;
using PRO.Win.Report.DSReportTableAdapters;
using PRO.Win.Report;

namespace PRO.Win.Finans
{
    public partial class frmCariKartListe : frmBase
    {
        public frmCariKartListe()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            DataLoad();
            RaporLoad(FormData.MenuNo, FormData.Parametre);
        }

        private void DataLoad()
        {
            ds.V_CHK_KartListe.Clear();
            dt.Fill(ds.V_CHK_KartListe);
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

        private void mnuDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = (DSFinans.V_CHK_KartListeRow)gwListe.GetFocusedDataRow();
            if (rw == null) return;

            MenuData frmData = new MenuData("FNS002", "_CariKart", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmCariKart frm = new frmCariKart();
            frm.FormData = frmData;
            frm._hesapID = rw.HesapID;
            frm.Show();
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

        #region Rapor-Yazıcı
        void RaporLoad(string menuNo, string parametre)
        {
            var _adapRapor = new RaporTableAdapter();
            var _dtRapor = _adapRapor.GetData(menuNo, parametre);
            if (_dtRapor.Rows.Count > 0)
            {
                _dtRapor.BindToControl(leRapor, "RowNr", "Aciklama");
                leRapor.EditValue = _dtRapor[0].RowNr;
            }
            else
                leRapor.EditValue = -1;
        }

        DataSet GetDataSet()
        {
            DataSet _ds = new DataSet("FirmaListesi");
            DataTable _dt = new DSFinans.V_CHK_KartListeDataTable();

            _dt = ds.V_CHK_KartListe.Copy();
            _dt.TableName = "Firmalar";
            _ds.Tables.Add(_dt);

            return _ds;
        }

        void YeniRapor(int nr, DataSet ds)
        {
            frmReport rpr = new frmReport();
            rpr._Ds = ds;
            rpr._raporNr = nr;
            rpr._menuNo = FormData.MenuNo;
            rpr._parametre = FormData.Parametre;
            rpr.OpenReport();
            rpr.Show();
        }

        void Preview()
        {
            if ((int)leRapor.EditValue == -1) return;
            string _s = string.Format("RowNr='{0}'", (int)leRapor.EditValue);
            DataTable _Rapor = _Tables.RPR_Grafik.GetDataList(_s);
            if (_Rapor.Rows.Count > 0)
            {
                System.IO.Stream str;
                byte[] _b = null;
                _b = (byte[])_Rapor.Rows[0]["Report"];
                str = Functions.XConvertByteToStream(_b);

                DevExpress.XtraReports.UI.XtraReport xrpr = new DevExpress.XtraReports.UI.XtraReport();
                xrpr = DevExpress.XtraReports.UI.XtraReport.FromStream(str, true);
                xrpr.DataSource = GetDataSet();

                frmPreview oFrm = new frmPreview(xrpr);
                oFrm.ShowDialog();
            }
        }

        private void mnuYeniRapor_Click_1(object sender, EventArgs e)
        {
            YeniRapor(-1, GetDataSet());
        }

        private void mnuRaporDuzenle_Click_1(object sender, EventArgs e)
        {
            YeniRapor((int)leRapor.EditValue, GetDataSet());
        }

        private void mnuYazdir_Click_1(object sender, EventArgs e)
        {
            Preview();
        }
        #endregion

    }
}