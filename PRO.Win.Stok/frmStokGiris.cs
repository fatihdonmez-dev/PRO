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
using PRO.Data.Stok;
using PRO.Win.Report.DSReportTableAdapters;
using PRO.Win.Report;
using PRO.Data.Global;
using PRO.Data.Global.DSGlobalTableAdapters;

namespace PRO.Win.Stok
{
    public partial class frmStokGiris : frmBase
    {
       
        public frmStokGiris()
        {
            InitializeComponent();
        }

        public Guid _evrakID = Guid.Empty;
        public override void ExFormLoad()
        {
            InitData();
            RaporLoadEtiket(FormData.MenuNo, "99");
            RaporLoad(FormData.MenuNo, FormData.Parametre);

            if (_evrakID == Guid.Empty)
                Yeni();
            else
                DataLoad(_evrakID);
        }

        private void InitData()
        {
            _Tables.STK_KartBirim.GetDataList().BindToControl(reBirim, "Kod", "Deger");

            #region Evrak

            ds.V_STI_Evrak.ColumnChanged += (o, e) => { XChanged = true; };
            ds.V_STI_Evrak.TableNewRow += (o, e) =>
            {
                e.Row[ds.V_STI_Evrak.EvrakIDColumn] = Guid.NewGuid();
                e.Row[ds.V_STI_Evrak.FirmaColumn] = FormData.Firma;
                e.Row[ds.V_STI_Evrak.IslemTipiColumn] = FormData.Parametre;
                e.Row[ds.V_STI_Evrak.HesapIDColumn] = Guid.Empty;
                e.Row[ds.V_STI_Evrak.HesapKoduColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.HesapUnvanColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.TarihColumn] = DateTime.Today;
                e.Row[ds.V_STI_Evrak.FisNoColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.BelgeTarihiColumn] = DateTime.Today;
                e.Row[ds.V_STI_Evrak.BelgeSeriColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.BelgeSiraColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.DepoIDColumn] = Guid.Empty;
                e.Row[ds.V_STI_Evrak.DepoKoduColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.DepoAdiColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.PlakaColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.SurucuAdiColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.SurucuTelColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.DurumColumn] = 0;
                e.Row[ds.V_STI_Evrak.YazdirildiColumn] = 0;
                e.Row[ds.V_STI_Evrak.SilindiColumn] = false;
                e.Row[ds.V_STI_Evrak.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.V_STI_Evrak.KayitDateColumn] = DateTime.Now;
                e.Row[ds.V_STI_Evrak.DegisByColumn] = string.Empty;
                e.Row[ds.V_STI_Evrak.VersiyonColumn] = DateTime.Now;
            };

            #endregion

            #region Detay

            ds.V_STI_EvrakDetay.ColumnChanged += (o, e) => { XChanged = true; };
            ds.V_STI_EvrakDetay.TableNewRow += (o, e) =>
            {
                e.Row[ds.V_STI_EvrakDetay.IslemIDColumn] = Guid.NewGuid();
                e.Row[ds.V_STI_EvrakDetay.EvrakIDColumn] = ds.V_STI_Evrak[0].EvrakID;
                e.Row[ds.V_STI_EvrakDetay.EvrakNoColumn] = string.Empty;
                e.Row[ds.V_STI_EvrakDetay.StokIDColumn] = Guid.Empty;
                e.Row[ds.V_STI_EvrakDetay.StokKoduColumn] = string.Empty;
                e.Row[ds.V_STI_EvrakDetay.StokAdiColumn] = string.Empty;
                e.Row[ds.V_STI_EvrakDetay.BarkodColumn] = string.Empty;
                e.Row[ds.V_STI_EvrakDetay.DepoIDColumn] = Guid.Empty;
                e.Row[ds.V_STI_EvrakDetay.DepoKoduColumn] = string.Empty;
                e.Row[ds.V_STI_EvrakDetay.DepoAdiColumn] = string.Empty;
                e.Row[ds.V_STI_EvrakDetay.DepoAdresColumn] = string.Empty;
                e.Row[ds.V_STI_EvrakDetay.BirimColumn] = string.Empty;
                e.Row[ds.V_STI_EvrakDetay.MiktarColumn] = 0;
                e.Row[ds.V_STI_EvrakDetay.FiyatColumn] = 0;
                e.Row[ds.V_STI_EvrakDetay.TutarColumn] = 0;
                e.Row[ds.V_STI_EvrakDetay.BedelsizColumn] = false;
                e.Row[ds.V_STI_EvrakDetay.DurumColumn] = 0;
                e.Row[ds.V_STI_EvrakDetay.SilindiColumn] = false;
                e.Row[ds.V_STI_EvrakDetay.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.V_STI_EvrakDetay.KayitDateColumn] = DateTime.Now;
                e.Row[ds.V_STI_EvrakDetay.DegisByColumn] = string.Empty;
                e.Row[ds.V_STI_EvrakDetay.VersiyonColumn] = DateTime.Now;
            };
            #endregion
        }

        private void DataLoad(Guid _evrkID)
        {
            ds.V_STI_Evrak.Clear();
            ds.V_STI_EvrakDetay.Clear();

            dtEvrak.Fill(ds.V_STI_Evrak, _evrkID);
            dtDetay.Fill(ds.V_STI_EvrakDetay, _evrkID);
        }

        private void Yeni()
        {
            ds.V_STI_Evrak.Clear();
            ds.V_STI_EvrakDetay.Clear();

            var rw = ds.V_STI_Evrak.NewV_STI_EvrakRow();
            ds.V_STI_Evrak.Rows.Add(rw);
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

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XSil(ds.V_STI_Evrak[0]);
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
                bsEvrak.EndEdit();
                bsDetay.EndEdit();
                gridDetay.XPostEditor();

                if(ds.V_STI_EvrakDetay.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Stok Seçimi Yapmadınız! İşlem İptal Edildi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if(ds.V_STI_Evrak[0].HesapID == Guid.Empty)
                {
                    XtraMessageBox.Show("Firma Seçimi Yapmalısınız!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int count = ds.V_STI_EvrakDetay.Where(p => p.RowState != DataRowState.Deleted && p.Silindi == false && p.DepoID == Guid.Empty).Count();
                if (count > 0)
                {
                    XtraMessageBox.Show("Depo Seçimi Yapılmamış Stok Kayıtları var! İşlem İptal Edildi!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int max = 1;
                string _eN = "001";

                ds.V_STI_EvrakDetay.Where(p => p.RowState != DataRowState.Deleted && p.Silindi == false).ToList().ForEach(p =>
                {
                    _eN = ("000" + max.ToString()).xRigt(3);

                    p.BeginEdit();
                    p.EvrakNo = _eN;
                    p.EndEdit();

                    max++;

                });

                if(XChanged)
                {
                    ds.V_STI_Evrak.SetVersyon();
                    ds.V_STI_EvrakDetay.SetVersyon();

                    dtEvrak.Update(ds.V_STI_Evrak);
                    dtDetay.Update(ds.V_STI_EvrakDetay);

                    Procs.StokBarkodOlustur(ds.V_STI_Evrak[0].EvrakID);
                    DataLoad(ds.V_STI_Evrak[0].EvrakID);
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

        private void beFirma_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 0)
                CariHesapSec(false);
            else
                CariHesapSec(true);
        }
        private void CariHesapSec(bool _temizle)
        {
            var rw = ds.V_STI_Evrak[0];
            if (rw == null) return;

            if (_temizle)
            {
                rw.HesapID = Guid.Empty;
                rw.HesapKodu = string.Empty;
                rw.HesapUnvan = string.Empty;

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
                rw.HesapUnvan = frm.rw.HesapAdi;
            }
        }

        private void beDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Index== 0)
                DepoSec(false);
            else
                DepoSec(true);
        }

        private void DepoSec(bool _temizle)
        {
            var rw = ds.V_STI_Evrak[0];
            if (rw == null) return;

            if(_temizle)
            {
                rw.BeginEdit();
                rw.DepoID = Guid.Empty;
                rw.DepoKodu = string.Empty;
                rw.DepoAdi = string.Empty;
                rw.EndEdit();

                return;
            }

            MenuData frmData = new MenuData("DEP0010", "_DepoAra", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmDepoAra frm = new frmDepoAra();
            frm.FormData = frmData;
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rw.BeginEdit();
                rw.DepoID = frm.row.DepoID;
                rw.DepoKodu = frm.row.DepoKodu;
                rw.DepoAdi = frm.row.DepoAdi;
                rw.EndEdit();
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
            XProperty(e.FocusedColumn,false);
        }

        private void gwDetay_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupDetay.ShowPopup(MousePosition);
        }

        private void mnuYeniStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var _row = ds.V_STI_Evrak[0];

            if(_row.HesapID == Guid.Empty)
            {
                XtraMessageBox.Show("Firma Seçimi Yapmalısınız!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_row.DepoID == Guid.Empty)
            {
                XtraMessageBox.Show("Depo Seçimi Yapmalısınız!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var rw = ds.V_STI_EvrakDetay.NewV_STI_EvrakDetayRow();

            MenuData frmData = new MenuData("STK0010", "_StokAra", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmStokAra frm = new frmStokAra();
            frm._hesapID = _row.HesapID;
            frm.FormData = frmData;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rw.BeginEdit();
                rw.StokID = frm.row.StokID;
                rw.StokKodu = frm.row.StokKodu;
                rw.StokAdi = frm.row.StokAdi;
                rw.Birim = frm.row.Birim;
                rw.Fiyat = frm.row.SonAlisFiyati;
                rw.Miktar = frm.row.MinSiparisMiktar;
                rw.DepoID = _row.DepoID;
                rw.DepoKodu = _row.DepoKodu;
                rw.DepoAdi = _row.DepoAdi;
                rw.EndEdit();

                ds.V_STI_EvrakDetay.Rows.Add(rw);
                gridDetay.XPostEditor();
            }

        }

        private void beDDepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          if(e.Button.Index == 0)
              DetayDepoSec(false);
          else
              DetayDepoSec(true);
        }

        private void DetayDepoSec(bool _temizle)
        {
            var rw = (DSStok.V_STI_EvrakDetayRow)gwDetay.GetFocusedDataRow();
            if (rw == null) return;

            if (_temizle)
            {
                rw.BeginEdit();
                rw.DepoID = Guid.Empty;
                rw.DepoKodu = string.Empty;
                rw.DepoAdi = string.Empty;
                rw.EndEdit();
                gridDetay.XPostEditor();

                return;
            }

            MenuData frmData = new MenuData("DEP0010", "_DepoAra", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmDepoAra frm = new frmDepoAra();
            frm.FormData = frmData;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rw.BeginEdit();
                rw.DepoID = frm.row.DepoID;
                rw.DepoKodu = frm.row.DepoKodu;
                rw.DepoAdi = frm.row.DepoAdi;
                rw.EndEdit();
                gridDetay.XPostEditor();
            }

        }

        private void mnuAra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {                   
            MenuData frmData = new MenuData("STK0040", "_StokGCAra", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmStokGCAra frm = new frmStokGCAra();
            frm.FormData = frmData;
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataLoad(frm.row.EvrakID);
            }
        }


        #region Rapor-Liste
        void RaporLoad(string menuNo, string parametre)
        {
            var _adapRapor = new RaporTableAdapter();
            var _dtRapor = _adapRapor.GetData(menuNo, parametre);
            if (_dtRapor.Rows.Count > 0)
            {
                _dtRapor.BindToControl(leRaporlar, "RowNr", "Aciklama");
                mnuRaporlar.EditValue = _dtRapor[0].RowNr;
            }
            else
                mnuRaporlar.EditValue = -1;
        }

        DataSet GetDataSet()
        {
            DataSet _ds = new DataSet("StokListesi");
            DataTable _dt = new DSGlobal.V_STI_EvrakListeDataTable();
            var adap = new V_STI_EvrakListeTableAdapter();

            _dt = adap.GetDataBy(ds.V_STI_Evrak[0].EvrakID);
            _dt.TableName = "Stok";
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
            if ((int)mnuRaporlar.EditValue == -1) return;
            string _s = string.Format("RowNr='{0}'", (int)mnuRaporlar.EditValue);
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

        private void mnuYeniRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniRapor(-1, GetDataSet());
        }

        private void mnuRaporDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniRapor((int)mnuRaporlar.EditValue, GetDataSet());
        }

        private void mnuYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Preview();
        }

        #endregion

        #region Etiket-Yazdir
        void RaporLoadEtiket(string menuNo, string parametre)
        {
            var _adapRapor = new RaporTableAdapter();
            var _dtRapor = _adapRapor.GetData(menuNo, parametre);
            if (_dtRapor.Rows.Count > 0)
            {
                _dtRapor.BindToControl(leEtiketRapor, "RowNr", "Aciklama");
                mnuEtiketRapor.EditValue = _dtRapor[0].RowNr;
            }
            else
                mnuEtiketRapor.EditValue = -1;
        }

        DataSet GetDataSetEtiket()
        {
            DataSet _ds = new DataSet("FirmaListesi");
            //DataTable _dt = new DSStok.V_STI_EvrakDetayDataTable();

            //_dt = ds.V_STI_EvrakDetay.Copy();
            //_dt.TableName = "Detay";
            //_ds.Tables.Add(_dt);

            return _ds;
        }

        void YeniRaporEtiket(int nr, DataSet ds)
        {
            frmReport rpr = new frmReport();
            rpr._Ds = ds;
            rpr._raporNr = nr;
            rpr._menuNo = FormData.MenuNo;
            rpr._parametre = "99";
            rpr.OpenReport();
            rpr.Show();
        }

        void Previewetiket()
        {
            if ((int)mnuEtiketRapor.EditValue == -1) return;
            string _s = string.Format("RowNr='{0}'", (int)mnuEtiketRapor.EditValue);
            DataTable _Rapor = _Tables.RPR_Grafik.GetDataList(_s);
            if (_Rapor.Rows.Count > 0)
            {
                System.IO.Stream str;
                byte[] _b = null;
                _b = (byte[])_Rapor.Rows[0]["Report"];
                str = Functions.XConvertByteToStream(_b);

                DevExpress.XtraReports.UI.XtraReport xrpr = new DevExpress.XtraReports.UI.XtraReport();
                xrpr = DevExpress.XtraReports.UI.XtraReport.FromStream(str, true);
                xrpr.DataSource = GetDataSetEtiket();

                frmPreview oFrm = new frmPreview(xrpr);
                oFrm.ShowDialog();
            }
        }

        private void mnuYeniEtiket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniRaporEtiket(-1, GetDataSetEtiket());
        }

        private void mnuEtiketDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniRaporEtiket((int)mnuEtiketRapor.EditValue, GetDataSetEtiket());
        }

        private void mnuEtiketBas_Click(object sender, EventArgs e)
        {
            Previewetiket();
        }

        #endregion


    }
}