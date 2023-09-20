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
    public partial class frmFirmaAdresAra : frmBase
    {
        public DSGlobal.V_CHK_Kart_AnaAdresRow _AnaRow;
        public DSGlobal.CHK_KartRow _KartRow;
        public DSGlobal.V_CHK_Kart_FaturaAdresRow _FaturaRow;
        public DSGlobal.V_CHK_Kart_SevkAdresRow _SevkRow;
        public string _kartTipi = KartTipi.Tumu.ToString();

        public frmFirmaAdresAra()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            DataLoad();
        }

        private void DataLoad()
        {
            ds.CHK_Kart.Clear();
            ds.V_CHK_Kart_AnaAdres.Clear();
            ds.V_CHK_Kart_FaturaAdres.Clear();
            ds.V_CHK_Kart_SevkAdres.Clear();

            if (_kartTipi == KartTipi.Tumu.ToString())
                dtKart.FillByAktifTumu(ds.CHK_Kart);
            else
                dtKart.FillAktif(ds.CHK_Kart, _kartTipi);
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
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
            if (gwKart.GetFocusedDataRow() != null)
            {
                _KartRow = (DSGlobal.CHK_KartRow)gwKart.GetFocusedDataRow();
                _AnaRow = (DSGlobal.V_CHK_Kart_AnaAdresRow)gwAnaAdres.GetFocusedDataRow();
                _FaturaRow = (DSGlobal.V_CHK_Kart_FaturaAdresRow)gwFaturaAdres.GetFocusedDataRow();
                _SevkRow = (DSGlobal.V_CHK_Kart_SevkAdresRow)gwSevkAdres.GetFocusedDataRow();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void gwKart_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {   
            var rw = (DSGlobal.CHK_KartRow)gwKart.GetFocusedDataRow();
            if(rw == null) return;

            ds.V_CHK_Kart_AnaAdres.Clear();
            ds.V_CHK_Kart_FaturaAdres.Clear();
            ds.V_CHK_Kart_SevkAdres.Clear();

            dtAnaAdres.Fill(ds.V_CHK_Kart_AnaAdres, rw.HesapID);
            dtFaturaAdres.Fill(ds.V_CHK_Kart_FaturaAdres, rw.HesapID);
            dtSevkAdres.Fill(ds.V_CHK_Kart_SevkAdres, rw.HesapID);
        }

        #region Ozellikler

        private void mnuOzKartGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridKart, true);
        }

        private void mnuOzKartListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwKart, true);
        }

        private void gwKart_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwKart_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupKart.ShowPopup(MousePosition);
        }

        private void mnuOzAnaAdresGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridAnaAdres, true);
        }

        private void mnuOzAnaAdresListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwAnaAdres, true);
        }

        private void gwAnaAdres_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwAnaAdres_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupAnaAdres.ShowPopup(MousePosition);
        }

        private void mnuOzFaturaGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridFaturaAdres, true);
        }

        private void mnuOzFaturaListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwFaturaAdres, true);
        }

        private void gwFaturaAdres_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwFaturaAdres_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupFatura.ShowPopup(MousePosition);
        }

        private void mnuOzSevkGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridSevkAdres, true);
        }

        private void mnuOzSevkListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwSevkAdres, true);
        }

        private void gwSevkAdres_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwSevkAdres_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupSevk.ShowPopup(MousePosition);
        }
        #endregion

    
    }
}