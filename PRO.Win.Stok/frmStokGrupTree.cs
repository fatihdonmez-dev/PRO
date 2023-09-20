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
using PRO.Data.Stok;

namespace PRO.Win.Stok
{
    public partial class frmStokGrupTree : frmBase
    {
        public frmStokGrupTree()
        {
            InitializeComponent();
        }

        public bool _sec = false;
        public DSStok.STK_GrupTreeRow row;
        public override void ExFormLoad()
        {
            InitData();
            DataLoad();

            if(_sec)
            {
                mnuSec.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                mnuSec.Enabled = true;
            }
        }

        private void InitData()
        {
            ds.STK_GrupTree.ColumnChanged += (o, e) => { XChanged = true; };
            ds.STK_GrupTree.TableNewRow += (o, e) =>
            {
                e.Row[ds.STK_GrupTree.ParentIDColumn] = 0;
                e.Row[ds.STK_GrupTree.ImageIDColumn] = -1;
                e.Row[ds.STK_GrupTree.TanimColumn] = string.Empty;
                e.Row[ds.STK_GrupTree.SilindiColumn] = false;
                e.Row[ds.STK_GrupTree.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.STK_GrupTree.KayitDateColumn] = DateTime.Now;
                e.Row[ds.STK_GrupTree.DegisByColumn] = string.Empty;
                e.Row[ds.STK_GrupTree.VersiyonColumn] = DateTime.Now;
            };
        }

        private void DataLoad()
        {
            ds.STK_GrupTree.Clear();
            dt.Fill(ds.STK_GrupTree);
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

        private bool Kaydet(bool msg)
        {
            try
            {
                bs.EndEdit();
                if (XChanged)
                    ds.STK_GrupTree.SetVersyon();
                dt.Update(ds.STK_GrupTree);

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


        DSStok.STK_GrupTreeRow _Tree = null;
        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_Tree == null) return;
            if (XtraMessageBox.Show("Kayıt Silinecek. Onaylıyor musunuz?",
                "Kayıt Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Recursive(_Tree.RowNr);
                //XSilNoMesaj(_Tree);
            }

        }
        void Recursive(int _rwNr)
        {
            var _varmi = ds.STK_GrupTree.Where(p => p.RowState != DataRowState.Deleted && p.Silindi == false && p.ParentID == _rwNr).Any();
            if (_varmi)
            {
                ds.STK_GrupTree.Where(p => p.RowState != DataRowState.Deleted && p.Silindi == false && p.ParentID == _rwNr).ToList().ForEach(p =>
                {
                    Recursive(p.RowNr);
                });
            }

            ds.STK_GrupTree.Where(p => p.RowState != DataRowState.Deleted && p.Silindi == false && p.RowNr == _rwNr).ToList().ForEach(p =>
            {
                 XSilNoMesaj(p);
            });

        }
        private void tree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            _Tree = (((System.Data.DataRowView)(tree.GetDataRecordByNode(e.Node))).Row) as DSStok.STK_GrupTreeRow;
        }

        private void mnuKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KategoriEkle(0);
        }

        private void mnuAltKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_Tree == null) return;
            if (_Tree.RowState == DataRowState.Added)
                Kaydet(false);
            KategoriEkle(_Tree.RowNr);
        }

        void KategoriEkle(int _parentID)
        {
            MenuData frmData = new MenuData("STK0030", "_KategoriEkle", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Firma, Session.Instance.CurrentUser.FirmaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
            frmKategoriEkle frm = new frmKategoriEkle();
            frm.FormData = frmData;
            if(frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var rw = ds.STK_GrupTree.NewSTK_GrupTreeRow();
                rw.BeginEdit();
                rw.ParentID = _parentID;
                rw.Tanim = frm.txtTanim.EditValue.ToString();
                rw.EndEdit();
                ds.STK_GrupTree.Rows.Add(rw);
            }
            
        }

        private void mnuSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_Tree == null) return;
            int count = ds.STK_GrupTree.Where(p => p.RowState != DataRowState.Deleted && p.Silindi == false && p.ParentID == _Tree.RowNr).Count();
            
            if(count > 0)
            {
                XtraMessageBox.Show("Yanlış Seçim Yaptınız! Alt Grubu Olan Kategoriler Seçilemez!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                row = _Tree;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        
        }

        private void tree_Load(object sender, EventArgs e)
        {
            
        }

        private void tree_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node.ParentNode == null)
                e.Appearance.Font = new Font("Arial", 10, FontStyle.Bold);
            else
                e.Appearance.Font = new Font("Arial", 8);
        }
    }
}