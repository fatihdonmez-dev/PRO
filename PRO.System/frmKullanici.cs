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
    public partial class frmKullanici : frmBase
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        public string _userName = string.Empty;
        public override void ExFormLoad()
        {
            DataLoad();
        }

        private void DataLoad()
        {
            ds.UDF_UserModulYetki.Clear();
            ds.UDF_UserMenuTree.Clear();
            dtUserMenu.Fill(ds.UDF_UserMenuTree, _userName, 1, Session.Instance.CurrentUser.Lang);
        }

        DSSystem.UDF_UserMenuTreeRow _MenuTree = null;
        private void treeMenu_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            _MenuTree = (((System.Data.DataRowView)(treeMenu.GetDataRecordByNode(e.Node))).Row) as DSSystem.UDF_UserMenuTreeRow;
            if (_MenuTree == null) return;
            ds.UDF_UserModulYetki.Clear();
            dtModulYetki.Fill(ds.UDF_UserModulYetki, _userName, 1, _MenuTree.MenuNo, Session.Instance.CurrentUser.Lang);

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
                bsUserMenu.EndEdit();
                bsModulYetki.EndEdit();
                gridYetki.XPostEditor();

                dtUserMenu.Update(ds.UDF_UserMenuTree);
                dtModulYetki.Update(ds.UDF_UserModulYetki);

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

        private void mnuYetkileriGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Procs.SetUserYetki();
            DataLoad();
        }

    }
}