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
    public partial class frmFirmaAra : frmBase
    {
        public frmFirmaAra()
        {
            InitializeComponent();
        }
        public DSGlobal.CHK_KartRow rw;
        public string _KartTipi = (KartTipi.Tumu).ToString();
        public override void ExFormLoad()
        {
            _Tables.REF_CHKTip.GetDataList().BindToControl(reKartTipi, "KartTipi", "KartTipiAdi");
            DataLoad("0");
        }

        private void DataLoad(string tip)
        {
            ds.CHK_Kart.Clear();

            if (_KartTipi == (KartTipi.Tumu).ToString())
            {
                     if(tip=="0")
                         dt.FillByAktifTumu(ds.CHK_Kart);
                     else
                         dt.FillByPasifTumu(ds.CHK_Kart);
            }
            else
            {
                if (tip == "0")
                    dt.FillAktif(ds.CHK_Kart, _KartTipi);
                else
                    dt.FillByPasif(ds.CHK_Kart, _KartTipi);
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
            var _rw = (DSGlobal.CHK_KartRow)gwListe.GetFocusedDataRow();
            if (_rw == null) return;

            rw = _rw;
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

        private void mnuSatirSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KayitSec();
        }

        private void gwListe_DoubleClick(object sender, EventArgs e)
        {
            KayitSec();
        }

        private void reSecim_EditValueChanged(object sender, EventArgs e)
        {
            string tip = string.Empty;
            tip = (((DevExpress.XtraEditors.ImageComboBoxEdit)sender).EditValue).ToString();
            DataLoad(tip);
        }

    }
}