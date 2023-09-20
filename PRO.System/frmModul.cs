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
using PRO.Data;

namespace PRO.Sistem
{
    public partial class frmModul : frmBase
    {
        public frmModul()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            InitData();
            DataLoad();
        }

        private void InitData()
        {
            #region SYS_Modul
            ds.SYS_Modul.TableNewRow += (o, e) =>
            {

                e.Row[ds.SYS_Modul.MenuNoColumn] = string.Empty;
                e.Row[ds.SYS_Modul.DilkeyColumn] = string.Empty;
                e.Row[ds.SYS_Modul.IslemFormuColumn] = string.Empty;
                e.Row[ds.SYS_Modul.ParametreColumn] = string.Empty;
                e.Row[ds.SYS_Modul.LoadParamColumn] = string.Empty;
                e.Row[ds.SYS_Modul.DefaultParamColumn] = string.Empty;
                e.Row[ds.SYS_Modul.SeriParamColumn] = string.Empty;
                e.Row[ds.SYS_Modul.IslemIconColumn] = string.Empty;
                e.Row[ds.SYS_Modul.ModulNameColumn] = string.Empty;

                e.Row[ds.SYS_Modul.FormAdiColumn] = string.Empty;
                e.Row[ds.SYS_Modul.HesapParamColumn] = string.Empty;
                e.Row[ds.SYS_Modul.KHesapParamColumn] = string.Empty;

                e.Row[ds.SYS_Modul.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.SYS_Modul.PopupColumn] = false;
                e.Row[ds.SYS_Modul.MultiDilKeyColumn] = false;
                e.Row[ds.SYS_Modul.SystemColumn] = false;
                e.Row[ds.SYS_Modul.KayitDateColumn] = DateTime.Now;
                e.Row[ds.SYS_Modul.DegisByColumn] = string.Empty;
                e.Row[ds.SYS_Modul.VersiyonColumn] = DateTime.Now;

            };
            #endregion

            #region SYS_ModulYetki
            ds.SYS_ModulYetki.TableNewRow += (o, e) =>
            {
                e.Row[ds.SYS_ModulYetki.YetkiIDColumn] = Guid.NewGuid();
                e.Row[ds.SYS_ModulYetki.MenuNoColumn] = string.Empty;
                e.Row[ds.SYS_ModulYetki.YetkiKoduColumn] = string.Empty;
                e.Row[ds.SYS_ModulYetki.YetkiAdiDilKeyColumn] = string.Empty;
                e.Row[ds.SYS_ModulYetki.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.SYS_ModulYetki.KayitDateColumn] = DateTime.Now;
                e.Row[ds.SYS_ModulYetki.DegisByColumn] = string.Empty;
                e.Row[ds.SYS_ModulYetki.VersiyonColumn] = DateTime.Now;

            };
            #endregion
        }

        private void DataLoad()
        {
            ds.SYS_Modul.Clear();
            dtModul.Fill(ds.SYS_Modul);
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
                bsModul.EndEdit();
                bsYetki.EndEdit();
                gridModul.XPostEditor();
                gridYetki.XPostEditor();

                dtModul.Update(ds.SYS_Modul);
                dtYetki.Update(ds.SYS_ModulYetki);

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

        private void mnuYetkiSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XRemove(gwYetki.GetFocusedDataRow());
        }

        private void mnuStandartYetkiler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YetkiEkle("EKLE", "_Ekle");
            YetkiEkle("SIL", "_Sil");
            YetkiEkle("KAYDET", "_Kaydet");
        }

        void YetkiEkle(string _kod, string _ad)
        {
            var rw = (DSDataSystem.SYS_ModulRow)gwModul.GetFocusedDataRow();
            if (rw == null) return;

            var ytk = ds.SYS_ModulYetki.NewSYS_ModulYetkiRow();
            ytk.YetkiID = Guid.NewGuid();
            ytk.MenuNo = rw.MenuNo;
            ytk.YetkiKodu = rw.MenuNo + '_' + _kod;
            ytk.YetkiAdiDilKey = _ad;

            ds.SYS_ModulYetki.Rows.Add(ytk);
        }

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XRemove(gwModul.GetFocusedDataRow());
        }

        private void mnuKopyala_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DSDataSystem.SYS_ModulDataTable _hafiza = (DSDataSystem.SYS_ModulDataTable)ds.SYS_Modul.Clone();

            DSDataSystem.SYS_ModulRow _rw = (DSDataSystem.SYS_ModulRow)gwModul.GetFocusedDataRow();
            _hafiza.Rows.Add(_rw.ItemArray);

            foreach (var item in _hafiza)
            {
                item.BeginEdit();
                item.MenuNo = string.Empty;


                item.EndEdit();
                ds.SYS_Modul.Rows.Add(item.ItemArray);
            }
        }

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oRow = ds.SYS_Modul.NewSYS_ModulRow();
            ds.SYS_Modul.Rows.Add(oRow);

            gwModul.MoveLast();
        }

        private void mnuYetkiEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YetkiEkle("", "");
        }

        private void mnuOzModulGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridModul, true);
        }

        private void mnuOzModulListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwModul, true);
        }

        private void gwModul_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwModul_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupModul.ShowPopup(MousePosition);
        }

        private void mnuOzYetkiGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridYetki, true);
        }

        private void mnuOzYetkiListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwYetki, true);
        }

        private void gwYetki_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwYetki_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupYetki.ShowPopup(MousePosition);
        }

        private void gwModul_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var rw = (DSDataSystem.SYS_ModulRow)gwModul.GetFocusedDataRow();
            if (rw == null) return;

            ds.SYS_ModulYetki.Clear();
            dtYetki.Fill(ds.SYS_ModulYetki, rw.MenuNo);
        }
    }
}