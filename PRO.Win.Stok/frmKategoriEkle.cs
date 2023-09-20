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

namespace PRO.Win.Stok
{
    public partial class frmKategoriEkle : frmBase
    {
        public frmKategoriEkle()
        {
            InitializeComponent();
        }

        public override void ExFormLoad()
        {
            
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void mnuOk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTanim.EditValue == string.Empty)
            {
                XtraMessageBox.Show("Bir Tanım Giriniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}