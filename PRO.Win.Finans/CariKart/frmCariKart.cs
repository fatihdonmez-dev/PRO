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
using PRO.Win.Global;
using PRO.Data.Finans;
using PRO.Data.Global;
using PRO.Data.Global.DSGlobalTableAdapters;

namespace PRO.Win.Finans
{
    public partial class frmCariKart : frmBase
    {
        public frmCariKart()
        {
            InitializeComponent();
        }

        public Guid _hesapID = Guid.Empty;
        public override void ExFormLoad()
        {
            InitData();
            if (_hesapID == Guid.Empty)
                Yeni();

            else
                DataLoad(_hesapID);
        }

        private void InitData()
        {
            _Tables.REF_CHKTip.GetDataList().BindToControl(leKartTipi, "KartTipi", "KartTipiAdi");
            _Tables.CHK_Kart_AdresTipi.GetDataList().BindToControl(reAdresTipi, "AdresTipi", "AdresTipiAdi");


            #region CHK_Kart

            ds.CHK_Kart.ColumnChanged += (o, e) => { XChanged = true; };
            ds.CHK_Kart.TableNewRow += (o, e) =>
            {
                e.Row[ds.CHK_Kart.HesapIDColumn] = Guid.NewGuid();
                e.Row[ds.CHK_Kart.HesapKoduColumn] = string.Empty;
                e.Row[ds.CHK_Kart.HesapAdiColumn] = string.Empty;
                e.Row[ds.CHK_Kart.KartTipiColumn] = string.Empty;
                e.Row[ds.CHK_Kart.VergiDairesiColumn] = string.Empty;
                e.Row[ds.CHK_Kart.VergiNoColumn] = string.Empty;
                e.Row[ds.CHK_Kart.Tel1Column] = string.Empty;
                e.Row[ds.CHK_Kart.Tel2Column] = string.Empty;
                e.Row[ds.CHK_Kart.GsmColumn] = string.Empty;
                e.Row[ds.CHK_Kart.PasifColumn] = false;
                e.Row[ds.CHK_Kart.SilindiColumn] = false;
                e.Row[ds.CHK_Kart.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.CHK_Kart.KayitDateColumn] = DateTime.Today;
                e.Row[ds.CHK_Kart.DegisByColumn] = string.Empty;
            };
            #endregion

            #region CHK_Kart_Adres

            ds.CHK_Kart_Adres.ColumnChanged += (o, e) => { XChanged = true; };
            ds.CHK_Kart_Adres.TableNewRow += (o, e) =>
            {
                e.Row[ds.CHK_Kart_Adres.AdresIDColumn] = Guid.NewGuid();
                e.Row[ds.CHK_Kart_Adres.HesapIDColumn] = ds.CHK_Kart[0].HesapID;
                e.Row[ds.CHK_Kart_Adres.AdresTipiColumn] = 0;
                e.Row[ds.CHK_Kart_Adres.LokasyonIDColumn] = Guid.Empty;
                e.Row[ds.CHK_Kart_Adres.LokasyonColumn] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.LokasyonAdiColumn] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.Adres1Column] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.Adres2Column] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.Adres3Column] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.SehirKodColumn] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.UlkeColumn] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.BolgeColumn] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.SehirColumn] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.IlceColumn] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.SemtColumn] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.PostaKoduColumn] = string.Empty;
                e.Row[ds.CHK_Kart_Adres.PasifColumn] = false;
                e.Row[ds.CHK_Kart_Adres.SilindiColumn] = false;
                e.Row[ds.CHK_Kart_Adres.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.CHK_Kart_Adres.KayitDateColumn] = DateTime.Today;
                e.Row[ds.CHK_Kart_Adres.DegisByColumn] = string.Empty;
            };

            #endregion

        }

        private void DataLoad(Guid _hID)
        {
            ds.CHK_Kart.Clear();
            ds.CHK_Kart_Adres.Clear();

            txtHesapAdi.ReadOnly = true;
            txtHesapKodu.ReadOnly = true;

            dt.Fill(ds.CHK_Kart, _hID);
            dtAdres.Fill(ds.CHK_Kart_Adres, _hID);
            
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Yeni();
        }

        private void Yeni()
        {
            ds.CHK_Kart.Clear();
            ds.CHK_Kart_Adres.Clear();

            txtHesapAdi.ReadOnly = false;
            txtHesapKodu.ReadOnly = false;

            var rw = ds.CHK_Kart.NewCHK_KartRow();
            ds.CHK_Kart.Rows.Add(rw);
        }

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XSil(ds.CHK_Kart[0]);
            Kaydet(false);
            Yeni();
        }

        private void mnuPasif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XPasif(ds.CHK_Kart[0]);
            Kaydet(false);
            Yeni();
        }

        private void mnuKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Kaydet(true);
        }

        private bool Kaydet(bool msg)
        {
            try
            {
                bs.EndEdit();
                bsAdres.EndEdit();
                gridAdres.XPostEditor();

                dt.Update(ds.CHK_Kart);
                dtAdres.Update(ds.CHK_Kart_Adres);

                if (msg)
                    XtraMessageBox.Show("Kaydetme İşlemi Tamamlandı.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XChanged = false;
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata!");
                return false;
            }
        }

        private void mnuAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            MenuData frmData = new MenuData("FNS0020", "_FirmaAra", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmFirmaAra frm = new frmFirmaAra();
            frm.FormData = frmData;
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataLoad(frm.rw.HesapID);
            }
        
        }

        #region Ozellikler

        private void mnuOzAdresGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridAdres, true);
        }

        private void mnuOzAdresListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwAdres, true);
        }

        private void gwAdres_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwAdres_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupAdres.ShowPopup(MousePosition);
        }


        #endregion

        private void mnuAdresSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XSil(gwAdres.GetFocusedDataRow());
        }

        private void mnuAdresPasif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             XPasif(gwAdres.GetFocusedDataRow());
        }

        private void mnuYeniAdres_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = ds.CHK_Kart_Adres.NewCHK_Kart_AdresRow();
            ds.CHK_Kart_Adres.Rows.Add(rw);
        }

        private void beSehir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
               if(e.Button.Index == 0)
                   SehirSec(false);
               else
                   SehirSec(true);
        }

        
        private void SehirSec(bool _temizle)
        {
            var rw = (DSFinans.CHK_Kart_AdresRow)gwAdres.GetFocusedDataRow();
            if (rw == null) return;

            if(_temizle)
            {
                rw.BeginEdit();
                rw.Ulke = string.Empty;
                rw.Sehir = string.Empty;
                rw.Ilce = string.Empty;
                rw.Semt = string.Empty;
                rw.EndEdit();
                gridAdres.XPostEditor();
                return;
            }

            DSGlobal.REF_SehirDataTable _dtSehir;
            var adap = new REF_SehirTableAdapter();

            MenuData frmData = new MenuData("TAN0010", "_SehirSec", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmSehirSec frm = new frmSehirSec();
            frm.FormData = frmData;
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _dtSehir = adap.GetData();

                rw.BeginEdit();
                rw.Ulke = _dtSehir.Where(p => p.Pasif == false && p.Tip == 0 && p.Ulke == frm.row.Ulke).FirstOrDefault().Tanim;
                rw.Sehir = frm.row.SehirAd;
                rw.Ilce = frm.row.IlceAd;
                rw.Semt = frm.row.SemtAdi;
                rw.EndEdit();
                gridAdres.XPostEditor();
            }
        }

    }
}