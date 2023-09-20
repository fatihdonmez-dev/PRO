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

namespace PRO.Win.Report
{
    public partial class frmPreview : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPreview(DevExpress.XtraReports.UI.XtraReport _Rapor, string _baslik = "")
        {
            InitializeComponent();
            if (_Rapor != null)
            {
                documentViewer1.PrintingSystem = _Rapor.PrintingSystem;
                if (!_Rapor.IsDisposed)
                {
                    _Rapor.CreateDocument();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}