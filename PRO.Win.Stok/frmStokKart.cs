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
using PRO.Win.Global;

namespace PRO.Win.Stok
{
    public partial class frmStokKart : frmBase
    {
        public Guid _StokID = Guid.Empty;
        public frmStokKart()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            InitData();
            if (_StokID == Guid.Empty)
                Yeni();
            else
                DataLoad(_StokID);
        }

        private void InitData()
        {
            _Tables.STK_KartBirim.GetDataList().BindToControl(leBirim, "Kod", "Deger");

            ds.STK_Kart.ColumnChanged += (o, e) => { XChanged = true; };
            ds.STK_Kart.TableNewRow += (o, e) =>
            {
                e.Row[ds.STK_Kart.StokIDColumn] = Guid.NewGuid();
                e.Row[ds.STK_Kart.FirmaColumn] = FormData.Firma;
                e.Row[ds.STK_Kart.StokKoduColumn] = string.Empty;
                e.Row[ds.STK_Kart.StokAdiColumn] = string.Empty;
                e.Row[ds.STK_Kart.StokTipiColumn] = 0;
                e.Row[ds.STK_Kart.MenseiColumn] = string.Empty;
                e.Row[ds.STK_Kart.HesapIDColumn] = Guid.Empty;
                e.Row[ds.STK_Kart.HesapAdiColumn] = string.Empty;
                e.Row[ds.STK_Kart.GrupIDColumn] = Guid.Empty;
                e.Row[ds.STK_Kart.SonAlisFiyatiColumn] = 0;
                e.Row[ds.STK_Kart.SatisFiyatiColumn] = 0;
                e.Row[ds.STK_Kart.IskontoOranColumn] = 0;
                e.Row[ds.STK_Kart.TeminSuresiColumn] = 0;
                e.Row[ds.STK_Kart.BirimColumn] = string.Empty;
                e.Row[ds.STK_Kart.StokSayacColumn] = 0;
                e.Row[ds.STK_Kart.AsgariMiktarColumn] = 0;
                e.Row[ds.STK_Kart.AzamiMiktarColumn] = 0;
                e.Row[ds.STK_Kart.AlarmSeviyesiColumn] = 0;
                e.Row[ds.STK_Kart.MinSiparisMiktarColumn] = 0;
                e.Row[ds.STK_Kart.KDVOraniColumn] = 0;
                e.Row[ds.STK_Kart.PasifColumn] = false;
                e.Row[ds.STK_Kart.SilindiColumn] = false;
                e.Row[ds.STK_Kart.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.STK_Kart.KayitDateColumn] = DateTime.Today;
                e.Row[ds.STK_Kart.DegisByColumn] = string.Empty;
            };

        }

        private void DataLoad(Guid _stokID)
        {
            ds.STK_Kart.Clear();
            dt.Fill(ds.STK_Kart, _stokID);
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
            ds.STK_Kart.Clear();

            var rw = ds.STK_Kart.NewSTK_KartRow();
            ds.STK_Kart.Rows.Add(rw);
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

                var rw = ds.STK_Kart[0];

                if(rw.HesapID == Guid.Empty)
                {
                    XtraMessageBox.Show("Firma Seçimi Yapılmadı! İşlem İptal Edilecek.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if(rw.StokTipi == 0)
                {
                    XtraMessageBox.Show("Stok Grubu Seçilmedi! İşlem İptal Edilecek.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (rw.StokKodu == string.Empty)
                    rw.StokKodu = Procs.StokKoduOlustur(FormData.Firma, rw.StokTipi.ToString());

                dt.Update(ds.STK_Kart);

                if(msg)
                    XtraMessageBox.Show("Kaydetme işlemi Tamamlandı.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XChanged = false;
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata!");
                return false;
            }
        }

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XSil(ds.STK_Kart[0]))
            {
                Kaydet(false);
                Yeni();
            }
            
        }

        private void mnuAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuData frmData = new MenuData("STK0010", "_StokAra", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmStokAra frm = new frmStokAra();
            frm.FormData = frmData;
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataLoad(frm.row.StokID);
            }
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void beFirma_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
             if(e.Button.Index == 0)
                 CariHesapSec(false);
             else
                 CariHesapSec(true);
        }

        private void CariHesapSec(bool _temizle)
        {
            var rw = ds.STK_Kart[0];
            if (rw == null) return;

            if (_temizle)
            {
                rw.HesapID = Guid.Empty;
                rw.HesapAdi = string.Empty;
                
                return;
            }
            MenuData frmData = new MenuData("FNS0020", "_FirmaAra", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmFirmaAra frm = new frmFirmaAra();
            frm.FormData = frmData;
            frm._KartTipi = "110,113";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rw.HesapID = frm.rw.HesapID;
                rw.HesapAdi = frm.rw.HesapAdi;
            }
        }

        private void Resim_DoubleClick(object sender, EventArgs e)
        {
            MenuData frmData = new MenuData("RES000", "_ResimForm", "", "0", "Std", FormData.Sirket, FormData.SirketAdi, FormData.Firma, FormData.FirmaAdi, "", "", "", FormData.ConnStr);
            frmResimGoster _resim = new frmResimGoster();
            _resim.FormData = frmData;
            _resim._resim = Resim.Image;
            _resim.Show();
        }

        private void beStokGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 0)
                StokGrupSec(false);
            else
                StokGrupSec(true);
        }

        void StokGrupSec(bool _temizle)
        {
            var rw = ds.STK_Kart[0];
            if (rw == null) return;

            if(_temizle)
            {
                rw.BeginEdit();
                rw.StokTipi = 0;
                rw.StokTipAdi = string.Empty;
                rw.EndEdit();

                return;
            }

            MenuData frmData = new MenuData("STK003", "_StokGrupTree", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmStokGrupTree frm = new frmStokGrupTree();
            frm.FormData = frmData;
            frm._sec = true;
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rw.BeginEdit();
                rw.StokTipi = frm.row.RowNr;
                rw.StokTipAdi = frm.row.Tanim;
                rw.EndEdit();
            }
            
        }

    }
}