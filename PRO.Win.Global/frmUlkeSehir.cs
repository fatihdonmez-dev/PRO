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
    public partial class frmUlkeSehir : frmBase
    {
        public frmUlkeSehir()
        {
            InitializeComponent();
        }

        public int _tip = 0;
        public override void ExFormLoad()
        {
            InitData();
            DataLoad();

            VisibleOptions();
        }

        private void InitData()
        {
            ds.REF_Sehir.ColumnChanged += (o, e) => { XChanged = true; };
            ds.REF_Sehir.TableNewRow += (o, e) =>
            {
                e.Row[ds.REF_Sehir.TipColumn] = _tip;
                e.Row[ds.REF_Sehir.UlkeColumn] = string.Empty;
                e.Row[ds.REF_Sehir.SehirColumn] = string.Empty;
                e.Row[ds.REF_Sehir.IlceColumn] = string.Empty;
                e.Row[ds.REF_Sehir.SemtColumn] = string.Empty;
                e.Row[ds.REF_Sehir.KodColumn] = string.Empty;
                e.Row[ds.REF_Sehir.TanimColumn] = string.Empty;
                e.Row[ds.REF_Sehir.TelefonKoduColumn] = string.Empty;
                e.Row[ds.REF_Sehir.PasifColumn] = false;
                e.Row[ds.REF_Sehir.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.REF_Sehir.KayitDateColumn] = DateTime.Today;
                e.Row[ds.REF_Sehir.DegisByColumn] = string.Empty;
                e.Row[ds.REF_Sehir.VersiyonColumn] = DateTime.Now;
            };
        }

        private void DataLoad()
        {
            ds.REF_Sehir.Clear();

            if (_tip == 0)
                dt.FillByUlke(ds.REF_Sehir);
            else if (_tip == 1)
                dt.FillBySehir(ds.REF_Sehir, _ulke);
            else if (_tip == 2)
                dt.FillByIlce(ds.REF_Sehir, _ulke, _sehir);
            else if (_tip == 3)
                dt.FillBySemt(ds.REF_Sehir, _ulke, _sehir, _ilce);
        }

        void VisibleOptions()
        {
            if(_tip == 0)
            {
                colUlke.Visible = true;
                colUlke.Caption = "Kod";
                colUlke.VisibleIndex = 0;

                colSehir.Visible = false;
                colIlce.Visible = false;
                colSemt.Visible = false;
            }

            else if(_tip == 1)
            {
                colSehir.Visible = true;
                colSehir.Caption = "Kod";
                colSehir.VisibleIndex = 0;

                colUlke.Visible = false;
                colIlce.Visible = false;
                colSemt.Visible = false;
            }

            else if(_tip == 2)
            {
                colIlce.Visible = true;
                colIlce.Caption = "Kod";
                colIlce.VisibleIndex = 0;

                colUlke.Visible = false;
                colSehir.Visible = false;
                colSemt.Visible = false;
            }

            else if (_tip == 3)
            {
                colSemt.Visible = true;
                colSemt.Caption = "Kod";
                colSemt.VisibleIndex = 0;

                colUlke.Visible = false;
                colIlce.Visible = false;
                colSehir.Visible = false;
            }
        }

        string _ulke = string.Empty;
        string _sehir = string.Empty;
        string _ilce = string.Empty;

        void KaydetGrid()
        {
            gridListe.XPostEditor();
            if (ds.REF_Sehir.Count == 0) return;

            var list = from x in ds.REF_Sehir.AsEnumerable()
                       where x.Kod == string.Empty
                       select x;

            foreach (var rw in list.ToList())
            {
                rw.BeginEdit();
                if (_tip == 0)
                    rw.Kod = rw.Ulke;
                else if (_tip == 1)
                {
                    rw.Ulke = _ulke;
                    rw.Kod = rw.Ulke + "." + rw.Sehir;
                }
                else if (_tip == 2)
                {
                    rw.Ulke = _ulke;
                    rw.Sehir = _sehir;
                    rw.Kod = rw.Ulke + "." + rw.Sehir + "." + rw.Ilce;
                }
                else if (_tip == 3)
                {
                    rw.Ulke = _ulke;
                    rw.Sehir = _sehir;
                    rw.Ilce = _ilce;
                    rw.Kod = rw.Ulke + "." + rw.Sehir + "." + rw.Ilce + "." + rw.Semt;
                }

                rw.EndEdit();
            }

            bs.EndEdit();
            dt.Update(ds.REF_Sehir);
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void btnUlke_Click(object sender, EventArgs e)
        {
            _tip = 0;

            btnSehir.Enabled = true;
            btnIlce.Enabled = false;
            btnSemt.Enabled = false;

            DataLoad();
            VisibleOptions();
        }

        private void btnSehir_Click(object sender, EventArgs e)
        {
            var rw = (DSGlobal.REF_SehirRow)gwListe.GetFocusedDataRow();
            if (rw != null)
            {
                _ulke = rw.Ulke;
            }

            KaydetGrid();
            _tip = 1;

            btnIlce.Enabled = true;
            btnSemt.Enabled = false;

            DataLoad();
            VisibleOptions();
        }

        private void btnIlce_Click(object sender, EventArgs e)
        {
            var rw = (DSGlobal.REF_SehirRow)gwListe.GetFocusedDataRow();
            if (rw != null)
            {
                //_ulke = rw.Ulke;
                _sehir = rw.Sehir;
            }

            KaydetGrid();
            _tip = 2;

            btnSemt.Enabled = true;

            DataLoad();
            VisibleOptions();
        }

        private void btnSemt_Click(object sender, EventArgs e)
        {
            var rw = (DSGlobal.REF_SehirRow)gwListe.GetFocusedDataRow();
            if (rw != null)
            {
                //_ulke = rw.Ulke;
                //_sehir = rw.Sehir;
                _ilce = rw.Ilce;
            }

            KaydetGrid();

            _tip = 3;
            DataLoad();
            VisibleOptions();
        }

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = ds.REF_Sehir.NewREF_SehirRow();
            ds.REF_Sehir.Rows.Add(rw);
        }

        private void mnuKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KaydetGrid();
            XtraMessageBox.Show("Kaydetme İşlemi Tamamlandı.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}