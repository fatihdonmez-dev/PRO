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
using PRO.Data;
using PRO.Data.DSSystemTableAdapters;
using PRO.Data.Siparis;
using PRO.Win.Global;

namespace PRO.Win.Siparis
{
    public partial class frmSatinAlma : frmBase
    {
        public frmSatinAlma()
        {
            InitializeComponent();
        }

        public Guid _evrakID = Guid.Empty;
        public override void ExFormLoad()
        {
            InitData();
            if (_evrakID == Guid.Empty)
                Yeni();
            else
                DataLoad();

            SeriLoad();
        }

        private void InitData()
        {
            _Tables.STK_KartBirim.GetDataList().BindToControl(reBirim, "Kod", "Deger");
            _Tables.TAN_OdemeSekli.GetDataList().BindToControl(leOdemeSekli, "OdemeSekli", "OdemeSekliAdi");
            _Tables.SAS_EvrakDetay_Durum.GetDataList().BindToControl(reDurum, "Durum", "DurumAdi");
            _Tables.STK_GrupTree.GetDataList().BindToControl(leStokTipi, "RowNr", "Tanim");
           

            #region SAS_Evrak

            ds.SAS_Evrak.ColumnChanged += (o, e) => { XChanged = true; };
            ds.SAS_Evrak.TableNewRow += (o, e) =>
            {
                e.Row[ds.SAS_Evrak.EvrakIDColumn] = Guid.NewGuid();
                e.Row[ds.SAS_Evrak.FirmaColumn] = FormData.Firma;
                e.Row[ds.SAS_Evrak.EvrakTipiColumn] = 0;
                e.Row[ds.SAS_Evrak.TarihColumn] = DateTime.Today;
                e.Row[ds.SAS_Evrak.SeriColumn] = string.Empty;
                e.Row[ds.SAS_Evrak.EvrakNoColumn] = string.Empty;
                e.Row[ds.SAS_Evrak.HesapIDColumn] = Guid.Empty;
                e.Row[ds.SAS_Evrak.HesapKoduColumn] = string.Empty;
                e.Row[ds.SAS_Evrak.HesapAdiColumn] = string.Empty;
                e.Row[ds.SAS_Evrak.OdemeSekliColumn] = 0;
                e.Row[ds.SAS_Evrak.AciklamaColumn] = string.Empty;
                e.Row[ds.SAS_Evrak.SilindiColumn] = false;
                e.Row[ds.SAS_Evrak.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.SAS_Evrak.KayitDateColumn] = DateTime.Now;
                e.Row[ds.SAS_Evrak.DegisByColumn] = string.Empty;
            };

            #endregion

            #region SAS_EvrakDetay

            ds.SAS_EvrakDetay.ColumnChanged += (o, e) => { XChanged = true; };
            ds.SAS_EvrakDetay.TableNewRow += (o, e) =>
            {
                e.Row[ds.SAS_EvrakDetay.EvrakDetayIDColumn] = Guid.NewGuid();
                e.Row[ds.SAS_EvrakDetay.EvrakIDColumn] = ds.SAS_Evrak[0].EvrakID;
                e.Row[ds.SAS_EvrakDetay.StokIDColumn] = Guid.Empty;
                e.Row[ds.SAS_EvrakDetay.StokKoduColumn] = string.Empty;
                e.Row[ds.SAS_EvrakDetay.StokAdiColumn] = string.Empty;
                e.Row[ds.SAS_EvrakDetay.BirimColumn] = 0;
                e.Row[ds.SAS_EvrakDetay.MiktarColumn] = 0;
                e.Row[ds.SAS_EvrakDetay.FiyatColumn] = 0;
                e.Row[ds.SAS_EvrakDetay.TutarColumn] = 0;
                e.Row[ds.SAS_EvrakDetay.KdvOranColumn] = 0;
                e.Row[ds.SAS_EvrakDetay.KdvColumn] = 0;
                e.Row[ds.SAS_EvrakDetay.ToplamColumn] = 0;
                e.Row[ds.SAS_EvrakDetay.TeminSuresiColumn] = 0;
                e.Row[ds.SAS_EvrakDetay.TeslimTarihiColumn] = DateTime.Today;
                e.Row[ds.SAS_EvrakDetay.DurumColumn] = 0;
                e.Row[ds.SAS_EvrakDetay.AciklamaColumn] = string.Empty;
                e.Row[ds.SAS_EvrakDetay.SilindiColumn] = false;
                e.Row[ds.SAS_EvrakDetay.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.SAS_EvrakDetay.KayitDateColumn] = DateTime.Now;
                e.Row[ds.SAS_EvrakDetay.DegisByColumn] = string.Empty;

            };

            #endregion

        }

        private void DataLoad()
        {
            ds.SAS_Evrak.Clear();
            ds.SAS_EvrakDetay.Clear();

            dtEvrak.Fill(ds.SAS_Evrak, _evrakID);
            dtEvrakDetay.Fill(ds.SAS_EvrakDetay, _evrakID);
        }


        DSSystem.UDF_SeriGetirDataTable _seri = new DSSystem.UDF_SeriGetirDataTable();
        void SeriLoad()
        {
            var _adap = new UDF_SeriGetirTableAdapter();
            _seri = _adap.GetData(FormData.Parametre, FormData.MenuNo, FormData.Firma);
            _seri.BindToControl(leSeri, "Seri", "Seri");
            SetDefaultSeri();
        }
        void SetDefaultSeri()
        {

            if (_seri.Rows.Count > 0)
            {
                var _sr = _seri.Where(p => p.DefaultSeri == true).FirstOrDefault();
                if (_sr != null)
                {
                    ds.SAS_Evrak[0].Seri = _sr.Seri;
                }
            }
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
            Yeni();
        }

        private void Yeni()
        {
            ds.SAS_Evrak.Clear();
            ds.SAS_EvrakDetay.Clear();

            var rw = ds.SAS_Evrak.NewSAS_EvrakRow();
            ds.SAS_Evrak.Rows.Add(rw);
            SetDefaultSeri();
        }

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XSil(ds.SAS_Evrak[0]))
            {
                Kaydet(false);
                Yeni();
            }
        }

        private void mnuKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Kaydet(true);
        }

        private bool Kaydet(bool msg)
        {
            try
            {
                bsEvrak.EndEdit();
                bsEvrakDetay.EndEdit();
                gridDetay.XPostEditor();

                var rw = ds.SAS_Evrak[0];

                if(rw.HesapID == Guid.Empty)
                {
                    XtraMessageBox.Show("Firma Seçimi Yapmalısınız !", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if(ds.SAS_EvrakDetay.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Detay Satırı Boş Olan Evraklar Kaydedilmez !", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if(rw.EvrakNo == string.Empty)
                {
                    rw.EvrakNo = Procs.GetNextSeriNoGetir(FormData.Firma, FormData.MenuNo, FormData.Parametre, rw.Seri);
                }

                if(XChanged)
                {
                    dtEvrak.Update(ds.SAS_Evrak);
                    dtEvrakDetay.Update(ds.SAS_EvrakDetay);
                }

                if(msg)
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

        private void mnuOzelliklerGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridDetay, true);
        }

        private void mnuOzelliklerListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwDetay, true);
        }

        private void gwDetay_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwDetay_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupDetay.ShowPopup(MousePosition);
        }

        private void mnuYeniDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = ds.SAS_EvrakDetay.NewSAS_EvrakDetayRow();
            rw.EvrakID = ds.SAS_Evrak[0].EvrakID;
            ds.SAS_EvrakDetay.Rows.Add(rw);
        }

        private void mnuDetaySil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XSil(gwDetay.GetFocusedDataRow());
        }

        private void beStokAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var rw = ds.SAS_Evrak[0];
            if (rw == null) return;

            if(rw.HesapID == Guid.Empty)
            {
                XtraMessageBox.Show("Firma Seçimi Yapmalısınız !", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.Button.Index == 0)
                StokAra(false);
            else
                StokAra(true);
        }

        void StokAra(bool _temizle)
        {
            var rw = (DSSiparis.SAS_EvrakDetayRow)gwDetay.GetFocusedDataRow();
            if (rw == null) return;

            if(_temizle)
            {
                rw.BeginEdit();
                rw.StokID = Guid.Empty;
                rw.StokKodu = string.Empty;
                rw.StokAdi = string.Empty;
                rw.StokTipi = 0;
                rw.Birim = string.Empty;
                rw.Miktar = 0;
                rw.TeminSuresi = 0;
                rw.EndEdit();

                gridDetay.XPostEditor();
                return;
            }

            MenuData frmData = new MenuData("STK0010", "_StokAra", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmStokAra frm = new frmStokAra();
            frm.FormData = frmData;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rw.BeginEdit();
                rw.StokID = frm.row.StokID;
                rw.StokKodu = frm.row.StokKodu;
                rw.StokAdi = frm.row.StokAdi;
                rw.StokTipi = frm.row.StokTipi;
                rw.Birim = frm.row.Birim;
                rw.KdvOran = frm.row.KDVOrani;
                rw.Fiyat = frm.row.SonAlisFiyati;
                rw.Miktar = frm.row.MinSiparisMiktar;
                rw.TeminSuresi = frm.row.TeminSuresi;
                rw.EndEdit();

                gridDetay.XPostEditor();

                TutarHesapla();
            }
        }

        private void beFirma_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
                CariHesapSec(false);
            else
                CariHesapSec(true);
        }
        private void CariHesapSec(bool _temizle)
        {
            var rw = ds.SAS_Evrak[0];
            if (rw == null) return;

            if (_temizle)
            {
                rw.HesapID = Guid.Empty;
                rw.HesapKodu = string.Empty;
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
                rw.HesapKodu = frm.rw.HesapKodu;
                rw.HesapAdi = frm.rw.HesapAdi;
            }
        }

        private void gwDetay_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colMiktar" || e.Column.Name == "colFiyat" || e.Column.Name == "colKdv" || e.Column.Name == "colKdvOran")
            {
                TutarHesapla();
            }
        }

        private void TutarHesapla()
        {
            var rw = (DSSiparis.SAS_EvrakDetayRow)gwDetay.GetFocusedDataRow();
            if (rw == null) return;

            rw.BeginEdit();
            rw.Tutar = rw.Miktar * rw.Fiyat;
            rw.Kdv = rw.Tutar * rw.KdvOran;
            rw.Toplam = rw.Tutar + rw.Kdv;
            rw.EndEdit();

            gridDetay.XPostEditor();
        }

    }
}