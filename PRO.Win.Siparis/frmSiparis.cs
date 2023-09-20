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
using PRO.Data.Siparis;

namespace PRO.Win.Siparis
{
    public partial class frmSiparis : frmBase
    {
        public Guid _evrakID = Guid.Empty;

        public frmSiparis()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            InitData();

            if (_evrakID == Guid.Empty)
                Yeni();
            else
                DataLoad();
        }

        private void InitData()
        {
            _Tables.TAN_OdemeSekli.GetDataList().BindToControl(leOdemeSekli, "OdemeSekli", "OdemeSekliAdi");
            _Tables.SIP_Evrak_Durum.GetDataList().BindToControl(leDurum, "Durum", "DurumAdi");
            _Tables.SIP_EvrakDetay_Durum.GetDataList().BindToControl(reDurum, "Durum", "DurumAdi");

            #region SIP_Evrak

            ds.SIP_Evrak.ColumnChanged += (o, e) => { XChanged = true; };
            ds.SIP_Evrak.TableNewRow += (o, e) =>
            {
                e.Row[ds.SIP_Evrak.EvrakIDColumn] = Guid.NewGuid();
                e.Row[ds.SIP_Evrak.FirmaColumn] = FormData.Firma;
                e.Row[ds.SIP_Evrak.TarihColumn] = DateTime.Today;
                e.Row[ds.SIP_Evrak.HesapIDColumn] = Guid.Empty;
                e.Row[ds.SIP_Evrak.HesapKoduColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.HesapAdiColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.EvrakNoColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.VergiDairesiColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.VergiNoColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.Tel1Column] = string.Empty;
                e.Row[ds.SIP_Evrak.Tel2Column] = string.Empty;
                e.Row[ds.SIP_Evrak.GsmColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.OdemeSekliColumn] = 0;
                e.Row[ds.SIP_Evrak.DurumColumn] = 0;
                e.Row[ds.SIP_Evrak.FaturaAdresIDColumn] = Guid.Empty;
                e.Row[ds.SIP_Evrak.FaturaLokasyonColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.FaturaLokasyonAdiColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.FaturaAdres1Column] = string.Empty;
                e.Row[ds.SIP_Evrak.FaturaAdres2Column] = string.Empty;
                e.Row[ds.SIP_Evrak.FaturaSehirColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.FaturaIlceColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.FaturaSemtColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.SevkAdresIDColumn] = Guid.Empty;
                e.Row[ds.SIP_Evrak.SevkLokasyonColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.SevkLokasyonAdiColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.SevkAdres1Column] = string.Empty;
                e.Row[ds.SIP_Evrak.SevkAdres2Column] = string.Empty;
                e.Row[ds.SIP_Evrak.SevkSehirColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.SevkIlceColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.SevkSemtColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.AciklamaColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.PasifColumn] = false;
                e.Row[ds.SIP_Evrak.SilindiColumn] = false;
                e.Row[ds.SIP_Evrak.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.SIP_Evrak.KayitDateColumn] = DateTime.Now;
                e.Row[ds.SIP_Evrak.DegisByColumn] = string.Empty;
                e.Row[ds.SIP_Evrak.VersiyonColumn] = DateTime.Now;
            };

            #endregion

            #region SIP_EvrakDetay

            ds.SIP_EvrakDetay.ColumnChanged += (o, e) => { XChanged = true; };
            ds.SIP_EvrakDetay.TableNewRow += (o, e) =>
            {
                e.Row[ds.SIP_EvrakDetay.SiparisIDColumn] = Guid.NewGuid();
                e.Row[ds.SIP_EvrakDetay.EvrakIDColumn] = ds.SIP_Evrak[0].EvrakID;
                e.Row[ds.SIP_EvrakDetay.SiparisNoColumn] = string.Empty;
                e.Row[ds.SIP_EvrakDetay.SipNoColumn] = string.Empty;
                e.Row[ds.SIP_EvrakDetay.SiraColumn] = 0;
                e.Row[ds.SIP_EvrakDetay.MusSiparisNoColumn] = string.Empty;
                e.Row[ds.SIP_EvrakDetay.TerminTarihiColumn] = DateTime.Today;
                e.Row[ds.SIP_EvrakDetay.StokIDColumn] = Guid.Empty;
                e.Row[ds.SIP_EvrakDetay.StokKoduColumn] = string.Empty;
                e.Row[ds.SIP_EvrakDetay.StokAdiColumn] = string.Empty;
                e.Row[ds.SIP_EvrakDetay.StokTipiColumn] = 0;
                e.Row[ds.SIP_EvrakDetay.TanimColumn] = string.Empty;
                e.Row[ds.SIP_EvrakDetay.MiktarColumn] = 0;
                e.Row[ds.SIP_EvrakDetay.FiyatColumn] = 0;
                e.Row[ds.SIP_EvrakDetay.TutarColumn] = 0;
                e.Row[ds.SIP_EvrakDetay.DurumColumn] = 0;
                e.Row[ds.SIP_EvrakDetay.AciklamaColumn] = string.Empty;
                e.Row[ds.SIP_EvrakDetay.SilindiColumn] = false;
                e.Row[ds.SIP_EvrakDetay.BarkodIDColumn] = Guid.Empty;
                e.Row[ds.SIP_EvrakDetay.BarkodColumn] = string.Empty;
                e.Row[ds.SIP_EvrakDetay.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.SIP_EvrakDetay.KayitDateColumn] = DateTime.Today;
                e.Row[ds.SIP_EvrakDetay.DegisByColumn] = string.Empty;
                e.Row[ds.SIP_EvrakDetay.VersiyonColumn] = DateTime.Now;
            };

            #endregion
        }

        private void DataLoad()
        {
            ds.SIP_Evrak.Clear();
            ds.SIP_EvrakDetay.Clear();

            dtEvrak.Fill(ds.SIP_Evrak, _evrakID);
            dtEvrakDetay.Fill(ds.SIP_EvrakDetay, _evrakID);
            
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnuKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Kaydet(true);
        }

        private bool Kaydet(bool msg)
        {
            var rw = ds.SIP_Evrak[0];

            try
            {
                bsEvrak.EndEdit();
                bsEvrakDetay.EndEdit();
                gridDetay.XPostEditor();
               

                if(rw.EvrakNo == string.Empty)
                {
                    rw.EvrakNo = Procs.SiparisEvrakNoOlustur(FormData.Firma);
                }

                SetSiparisNo();

                if(XChanged)
                {
                    ds.SIP_Evrak.SetVersyon();
                    ds.SIP_EvrakDetay.SetVersyon();
                    dtEvrak.Update(ds.SIP_Evrak);
                    dtEvrakDetay.Update(ds.SIP_EvrakDetay);
                }

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

        void SetSiparisNo()
        {
            string _evrakNo = ds.SIP_Evrak[0].EvrakNo;

            string _k = "01";
            int _sr = 1;
            ds.SIP_EvrakDetay.Where(p => p.RowState != DataRowState.Deleted).Where(p => p.Silindi == false).ToList().ForEach(x =>
            {
                
                _k = ("00" + _sr.ToString()).xRigt(2);
                if (_k != x.Sira)
                {
                    x.BeginEdit();
                    x.Sira = _k;
                    x.EndEdit();
                }
                _sr++;

                x.SiparisNo = _evrakNo;
                x.SipNo = string.Format("{0}-{1}", x.SiparisNo, x.Sira);
            });


        }

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XSil(ds.SIP_Evrak[0]))
            {
                Kaydet(false);
                Yeni();
            }
                
        }

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Yeni();
        }

        private void Yeni()
        {
            ds.SIP_Evrak.Clear();
            ds.SIP_EvrakDetay.Clear();

            var rw = ds.SIP_Evrak.NewSIP_EvrakRow();
            ds.SIP_Evrak.Rows.Add(rw);
        }

        private void mnuUrunEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ds.SIP_Evrak[0].HesapID == Guid.Empty)
                XtraMessageBox.Show("Önce Firma Seçimi Yapmalısınız!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                StokUrunEkle();
        }

        private void mnuUrunSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XSil(gwDetay.GetFocusedDataRow());
        }

        void StokUrunEkle()
        {
            MenuData frmData = new MenuData("STK0010", "_StokAra", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmStokAra frm = new frmStokAra();
            frm.FormData = frmData;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var rw = ds.SIP_EvrakDetay.NewSIP_EvrakDetayRow();
                rw.BeginEdit();
                rw.StokID = frm.row.StokID;
                rw.StokKodu = frm.row.StokKodu;
                rw.StokAdi = frm.row.StokAdi;
                rw.StokTipi = frm.row.StokTipi;
                rw.EndEdit();

                ds.SIP_EvrakDetay.Rows.Add(rw);
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

        private void beFirma_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
                if(e.Button.Index == 0)
                    FirmaSec(false);
                else
                    FirmaSec(true);
        }

        private void FirmaSec(bool _temizle)
        {
            var rw = ds.SIP_Evrak[0];
            if (rw == null) return;

            if (_temizle)
            {
                rw.HesapID = Guid.Empty;
                rw.HesapKodu = string.Empty;
                rw.HesapAdi = string.Empty;
                rw.VergiDairesi = string.Empty;
                rw.VergiNo = string.Empty;
                rw.Tel1 = string.Empty;
                rw.Tel2 = string.Empty;
                rw.Gsm = string.Empty;


                rw.FaturaAdresID = Guid.Empty;
                rw.FaturaLokasyon = string.Empty;
                rw.FaturaLokasyonAdi = string.Empty;
                rw.FaturaAdres1 = string.Empty;
                rw.FaturaAdres2 = string.Empty;
                rw.FaturaSehir = string.Empty;
                rw.FaturaIlce = string.Empty;
                rw.FaturaSemt = string.Empty;


                rw.SevkAdresID = Guid.Empty;
                rw.SevkLokasyon = string.Empty;
                rw.SevkLokasyonAdi = string.Empty;
                rw.SevkAdres1 = string.Empty;
                rw.SevkAdres2 = string.Empty;
                rw.SevkSehir = string.Empty;
                rw.SevkIlce = string.Empty;
                rw.SevkSemt = string.Empty;

                return;
            }

            MenuData frmData = new MenuData("SIP9999", "_FirmaAdresSec", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmFirmaAdresAra frm = new frmFirmaAdresAra();
            frm._kartTipi = "110,113";
            frm.FormData = frmData;
            
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rw.BeginEdit();

                rw.HesapID = frm._KartRow.HesapID;
                rw.HesapKodu = frm._KartRow.HesapKodu;
                rw.HesapAdi = frm._KartRow.HesapAdi;
                rw.VergiDairesi = frm._KartRow.VergiDairesi;
                rw.VergiNo = frm._KartRow.VergiNo;
                rw.Tel1 = frm._KartRow.Tel1;
                rw.Tel2 = frm._KartRow.Tel2;
                rw.Gsm = frm._KartRow.Gsm;

                #region FaturaAdres

                if(frm._FaturaRow != null)
                {
                    rw.FaturaAdresID = frm._FaturaRow.FaturaAdresID;
                    rw.FaturaLokasyon = frm._FaturaRow.FaturaLokasyon;
                    rw.FaturaLokasyonAdi = frm._FaturaRow.FaturaLokasyonAdi;
                    rw.FaturaAdres1 = frm._FaturaRow.FaturaAdres1;
                    rw.FaturaAdres2 = frm._FaturaRow.FaturaAdres2;
                    rw.FaturaSehir = frm._FaturaRow.FaturaSehir;
                    rw.FaturaIlce = frm._FaturaRow.FaturaIlce;
                    rw.FaturaSemt = frm._FaturaRow.FaturaSemt;
                }
                else  if(frm._AnaRow != null)
                {
                    rw.FaturaAdresID = frm._AnaRow.AdresID;
                    rw.FaturaLokasyon = frm._AnaRow.Lokasyon;
                    rw.FaturaLokasyonAdi = frm._AnaRow.LokasyonAdi;
                    rw.FaturaAdres1 = frm._AnaRow.Adres1;
                    rw.FaturaAdres2 = frm._AnaRow.Adres2;
                    rw.FaturaSehir = frm._AnaRow.Sehir;
                    rw.FaturaIlce = frm._AnaRow.Ilce;
                    rw.FaturaSemt = frm._AnaRow.Semt;
                }

                #endregion
              
                #region SevkAdres

                if (frm._FaturaRow != null)
                {
                    rw.SevkAdresID = frm._SevkRow.SevkAdresID;
                    rw.SevkLokasyon = frm._SevkRow.SevkLokasyon;
                    rw.SevkLokasyonAdi = frm._SevkRow.SevkLokasyonAdi;
                    rw.SevkAdres1 = frm._SevkRow.SevkAdres1;
                    rw.SevkAdres2 = frm._SevkRow.SevkAdres2;
                    rw.SevkSehir = frm._SevkRow.SevkSehir;
                    rw.SevkIlce = frm._SevkRow.SevkIlce;
                    rw.SevkSemt = frm._SevkRow.SevkSemt;
                }
                else if (frm._AnaRow != null)
                {
                    rw.SevkAdresID = frm._AnaRow.AdresID;
                    rw.SevkLokasyon = frm._AnaRow.Lokasyon;
                    rw.SevkLokasyonAdi = frm._AnaRow.LokasyonAdi;
                    rw.SevkAdres1 = frm._AnaRow.Adres1;
                    rw.SevkAdres2 = frm._AnaRow.Adres2;
                    rw.SevkSehir = frm._AnaRow.Sehir;
                    rw.SevkIlce = frm._AnaRow.Ilce;
                    rw.SevkSemt = frm._AnaRow.Semt;
                }

                #endregion


                rw.EndEdit();
            }

        }

        private void beFaturaAdresSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 0)
                FaturaAdresSec(false);
            else
                FaturaAdresSec(true);
        }

        void FaturaAdresSec(bool _temizle)
        {
            var rw = ds.SIP_Evrak[0];
            if (rw == null) return;

            if(_temizle)
            {

                rw.FaturaAdresID = Guid.Empty;
                rw.FaturaLokasyon = string.Empty;
                rw.FaturaLokasyonAdi = string.Empty;
                rw.FaturaAdres1 = string.Empty;
                rw.FaturaAdres2 = string.Empty;
                rw.FaturaSehir = string.Empty;
                rw.FaturaIlce = string.Empty;
                rw.FaturaSemt = string.Empty;

                return;
            }

            MenuData frmData = new MenuData("SIP9999", "_FirmaAdresSec", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmFirmaAdresAra frm = new frmFirmaAdresAra();
            frm.FormData = frmData;
            frm._kartTipi = "110,113";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (frm._FaturaRow != null)
                {
                    rw.FaturaAdresID = frm._FaturaRow.FaturaAdresID;
                    rw.FaturaLokasyon = frm._FaturaRow.FaturaLokasyon;
                    rw.FaturaLokasyonAdi = frm._FaturaRow.FaturaLokasyonAdi;
                    rw.FaturaAdres1 = frm._FaturaRow.FaturaAdres1;
                    rw.FaturaAdres2 = frm._FaturaRow.FaturaAdres2;
                    rw.FaturaSehir = frm._FaturaRow.FaturaSehir;
                    rw.FaturaIlce = frm._FaturaRow.FaturaIlce;
                    rw.FaturaSemt = frm._FaturaRow.FaturaSemt;
                }
                else if (frm._AnaRow != null)
                {
                    rw.FaturaAdresID = frm._AnaRow.AdresID;
                    rw.FaturaLokasyon = frm._AnaRow.Lokasyon;
                    rw.FaturaLokasyonAdi = frm._AnaRow.LokasyonAdi;
                    rw.FaturaAdres1 = frm._AnaRow.Adres1;
                    rw.FaturaAdres2 = frm._AnaRow.Adres2;
                    rw.FaturaSehir = frm._AnaRow.Sehir;
                    rw.FaturaIlce = frm._AnaRow.Ilce;
                    rw.FaturaSemt = frm._AnaRow.Semt;
                }
            }
        }

        void SevkAdresSec(bool _temizle)
        {
            var rw = ds.SIP_Evrak[0];
            if (rw == null) return;

            if(_temizle)
            {
                rw.SevkAdresID = Guid.Empty;
                rw.SevkLokasyon = string.Empty;
                rw.SevkLokasyonAdi = string.Empty;
                rw.SevkAdres1 = string.Empty;
                rw.SevkAdres2 = string.Empty;
                rw.SevkSehir = string.Empty;
                rw.SevkIlce = string.Empty;
                rw.SevkSemt = string.Empty;

                return;
            }

            MenuData frmData = new MenuData("SIP9999", "_FirmaAdresSec", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmFirmaAdresAra frm = new frmFirmaAdresAra();
            frm.FormData = frmData;
            frm._kartTipi = "110,113";
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                if (frm._FaturaRow != null)
                {
                    rw.SevkAdresID = frm._SevkRow.SevkAdresID;
                    rw.SevkLokasyon = frm._SevkRow.SevkLokasyon;
                    rw.SevkLokasyonAdi = frm._SevkRow.SevkLokasyonAdi;
                    rw.SevkAdres1 = frm._SevkRow.SevkAdres1;
                    rw.SevkAdres2 = frm._SevkRow.SevkAdres2;
                    rw.SevkSehir = frm._SevkRow.SevkSehir;
                    rw.SevkIlce = frm._SevkRow.SevkIlce;
                    rw.SevkSemt = frm._SevkRow.SevkSemt;
                }
                else if (frm._AnaRow != null)
                {
                    rw.SevkAdresID = frm._AnaRow.AdresID;
                    rw.SevkLokasyon = frm._AnaRow.Lokasyon;
                    rw.SevkLokasyonAdi = frm._AnaRow.LokasyonAdi;
                    rw.SevkAdres1 = frm._AnaRow.Adres1;
                    rw.SevkAdres2 = frm._AnaRow.Adres2;
                    rw.SevkSehir = frm._AnaRow.Sehir;
                    rw.SevkIlce = frm._AnaRow.Ilce;
                    rw.SevkSemt = frm._AnaRow.Semt;

                }
            }
        }

        private void beSevkAdresSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 0)
                SevkAdresSec(false);
            else
                SevkAdresSec(true);
        }

        private void gwDetay_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.Name == "colMiktar" || e.Column.Name =="colFiyat")
            {
                var rw = (DSSiparis.SIP_EvrakDetayRow)gwDetay.GetFocusedDataRow();
                rw.Tutar = rw.Miktar * rw.Fiyat;
            }
        }
    }
}