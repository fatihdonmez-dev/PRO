using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using PRO.Global;

namespace PRO.Win.Report
{
    public partial class frmReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DataSet _Ds;
        public int _raporNr = -1;
        public string _menuNo = string.Empty;
        public string _parametre = string.Empty;
        public frmReport()
        {
            InitializeComponent();
        }

        public void OpenReport()
        {
            ds.RPR_Grafik.Clear();
            dt.Fill(ds.RPR_Grafik, _raporNr);
            DevExpress.XtraReports.UI.XtraReport xrpr = new DevExpress.XtraReports.UI.XtraReport();
            if (ds.RPR_Grafik.Rows.Count > 0)
            {
                System.IO.Stream str;
                byte[] _b = null;
                _b = (byte[])ds.RPR_Grafik[0].Report;
                str = Functions.XConvertByteToStream(_b);
                xrpr = DevExpress.XtraReports.UI.XtraReport.FromStream(str, true);
            }
            else
            {
                var r = ds.RPR_Grafik.NewRPR_GrafikRow();
                r.RowID = Guid.NewGuid();
                r.MenuNo = _menuNo;
                r.Parametre = _parametre;
                r.Aciklama = string.Empty;
                r.Standart = false;
                r.Pasif = false;
                r.Silindi = false;
                r.KayitBy = Session.Instance.CurrentUser.UserName;
                r.KayitDate = DateTime.Now;
                r.DegisBy = string.Empty;
                ds.RPR_Grafik.Rows.Add(r);
            }
            xrpr.DataSource = _Ds;
            reportDesigner1.OpenReport(xrpr);
        }

        bool Kaydet()
        {
            try
            {
                bs.EndEdit();

                byte[] _b = null;
                _b = Functions.XReportConvertByte(reportDesigner1.ActiveDesignPanel.Report);
                var r = ds.RPR_Grafik[0];
                r.BeginEdit();
                r.Report = _b;
                r.EndEdit();
                dt.Update(ds.RPR_Grafik);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        private void mnuKaydet_Click(object sender, EventArgs e)
        {
            if (Kaydet())
                MessageBox.Show("Kaydetme İşlemi Tamamlandı.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Kaydetme Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}