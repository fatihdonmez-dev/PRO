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
    public partial class frmKullaniciListe : frmBase
    {
        public frmKullaniciListe()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            InitData();
            DataLoad();
        }

        private void DataLoad()
        {
            ds.SYS_User.Clear();
            dtUser.FillByList(ds.SYS_User);
        }

        private void InitData()
        {
            ds.SYS_User.ColumnChanged += (o, e) => { XChanged = false; };
            ds.SYS_User.TableNewRow += (o, e) =>
            {
                e.Row[ds.SYS_User.KullaniciIDColumn] = Guid.NewGuid();
                e.Row[ds.SYS_User.SicilNoColumn] = 0;
                e.Row[ds.SYS_User.KullaniciColumn] = string.Empty;
                e.Row[ds.SYS_User.KullaniciAdiColumn] = string.Empty;
                e.Row[ds.SYS_User.SifreColumn] = string.Empty;
                e.Row[ds.SYS_User.LanguageColumn] = string.Empty;
                e.Row[ds.SYS_User.GorevColumn] = 0;
                e.Row[ds.SYS_User.PasifColumn] = false;
                e.Row[ds.SYS_User.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.SYS_User.KayitDateColumn] = DateTime.Today;
                e.Row[ds.SYS_User.DegisByColumn] = string.Empty;
            };                                    
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
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
                gridListe.XPostEditor();

                dtUser.Update(ds.SYS_User);

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

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XRemove(gwListe.GetFocusedDataRow());
        }

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = ds.SYS_User.NewSYS_UserRow();
            ds.SYS_User.Rows.Add(rw);
        }

        private void mnuDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var rw = (DSSystem.SYS_UserRow)gwListe.GetFocusedDataRow();
            if (rw == null) return;

            MenuData frmData = new MenuData("SYS0030", "_KullaniciYetki", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmKullanici frm = new frmKullanici();
            frm.FormData = frmData;
            frm._userName = rw.Kullanici;
            frm.ShowDialog();
        
        }                                 
    }
}