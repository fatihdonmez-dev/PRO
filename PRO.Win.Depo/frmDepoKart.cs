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

namespace PRO.Win.Depo
{
    public partial class frmDepoKart : frmBase
    {
        public frmDepoKart()
        {
            InitializeComponent();
        }
        public Guid _DepoID = Guid.Empty;
        public override void ExFormLoad()
        {
            InitData();
            if (_DepoID == Guid.Empty)
                Yeni();
            else
                DataLoad();

        }

        private void InitData()
        {
            _Tables.DEP_Kart_Tip.GetDataList().BindToControl(leDepoTip, "DepoTip", "TipAdi");

            #region DEP_Kart

            ds.DEP_Kart.ColumnChanged += (o, e) => { XChanged = true; };
            ds.DEP_Kart.TableNewRow += (o, e) =>
            {
                e.Row[ds.DEP_Kart.DepoIDColumn] = Guid.NewGuid();
                e.Row[ds.DEP_Kart.FirmaColumn] = FormData.Firma;
                e.Row[ds.DEP_Kart.DepoKoduColumn] = string.Empty;
                e.Row[ds.DEP_Kart.DepoAdiColumn] = string.Empty;
                e.Row[ds.DEP_Kart.LokasyonIDColumn] = Guid.Empty;
                e.Row[ds.DEP_Kart.DepoTipiColumn] = 0;
                e.Row[ds.DEP_Kart.PasifColumn] = false;
                e.Row[ds.DEP_Kart.SilindiColumn] = false;
                e.Row[ds.DEP_Kart.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.DEP_Kart.KayitDateColumn] = DateTime.Today;
                e.Row[ds.DEP_Kart.DegisByColumn] = string.Empty;
            };
            #endregion

            #region DEP_Kart_Adres

            ds.DEP_Kart_Adres.ColumnChanged += (o, e) => { XChanged = true; };
            ds.DEP_Kart_Adres.TableNewRow += (o, e) =>
            {
                e.Row[ds.DEP_Kart_Adres.AdresIDColumn] = Guid.NewGuid();
                e.Row[ds.DEP_Kart_Adres.DepoIDColumn] = ds.DEP_Kart[0].DepoID;
                e.Row[ds.DEP_Kart_Adres.AdresColumn] = string.Empty;
                e.Row[ds.DEP_Kart_Adres.GenislikColumn] = 0;
                e.Row[ds.DEP_Kart_Adres.YukseklikColumn] = 0;
                e.Row[ds.DEP_Kart_Adres.PasifColumn] = false;
                e.Row[ds.DEP_Kart_Adres.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.DEP_Kart_Adres.KayitDateColumn] = DateTime.Today;
                e.Row[ds.DEP_Kart_Adres.DegisByColumn] = string.Empty;
            };

            #endregion

        }

        private void DataLoad()
        {
            ds.DEP_Kart.Clear();
            ds.DEP_Kart_Adres.Clear();

            dt.FillBy(ds.DEP_Kart, _DepoID);
            dtAdres.Fill(ds.DEP_Kart_Adres, _DepoID);
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
            try
            {
                bs.EndEdit();
                bsAdres.EndEdit();
                gridAdres.XPostEditor();

                dt.Update(ds.DEP_Kart);
                dtAdres.Update(ds.DEP_Kart_Adres);

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

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Yeni();
        }

        private void Yeni()
        {
            ds.DEP_Kart.Clear();
            var rw = ds.DEP_Kart.NewDEP_KartRow();
            ds.DEP_Kart.Rows.Add(rw);
        }

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XSil(ds.DEP_Kart[0]);
        }

        private void mnuOzelliklerGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridAdres, true);
        }

        private void mnuOzelliklerListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void mnuAdresSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XRemove(gwAdres.GetFocusedDataRow());
        }
    }
}