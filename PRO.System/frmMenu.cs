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
using PRO.Data.DSDataSystemTableAdapters;

namespace PRO.Sistem
{
    public partial class frmMenu : frmBase
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            InitData();
            InitLoad();
            DataLoad();
        }

        private void DataLoad()
        {
            ds.SYS_Menu.Clear();
            dt.Fill(ds.SYS_Menu);
            InitLoad();
        }

        private void InitLoad()
        {
            DSDataSystem.UDF_ModulListDataTable _dt = new DSDataSystem.UDF_ModulListDataTable();

            using (UDF_ModulListTableAdapter adap = new UDF_ModulListTableAdapter())
            {
                _dt = adap.GetData(Session.Instance.CurrentUser.Lang);
                _dt.BindToControl(reMenuNo, "MenuNo", "Caption");
            }
        }
        private void InitData()
        {

            #region SYS_Modul
            ds.SYS_Menu.TableNewRow += (o, e) =>
            {

                e.Row[ds.SYS_Menu.IDColumn] = 0;
                e.Row[ds.SYS_Menu.ParentIDColumn] = 0;
                e.Row[ds.SYS_Menu.MenuDilKeyColumn] = string.Empty;
                e.Row[ds.SYS_Menu.MenuNoColumn] = string.Empty;
                e.Row[ds.SYS_Menu.IsAktifColumn] = true;
                e.Row[ds.SYS_Menu.IsMenuColumn] = true;
                e.Row[ds.SYS_Menu.ImageIDColumn] = -1;

            };
            #endregion
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void mnuYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataLoad();
        }

        private void mnuKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Kaydet(true);
        } 
        
        bool Kaydet(bool msg)
        {
            try
            {
                bs.EndEdit();
                gridListe.XPostEditor();

                dt.Update(ds.SYS_Menu);

                if (msg)
                    XtraMessageBox.Show("Kaydetme İşlemi Tamamlandı.", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XChanged = false;
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata!!");
                return false;
            }
        }

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XSil(gwListe.GetFocusedDataRow());
        }

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = ds.SYS_Menu.NewSYS_MenuRow();
            ds.SYS_Menu.Rows.Add(rw);
            gwListe.MoveLast();
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
    }
}