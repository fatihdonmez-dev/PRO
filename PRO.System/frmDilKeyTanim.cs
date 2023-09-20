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

namespace PRO.Sistem
{
    public partial class frmDilKeyTanim : frmBase
    {
        public frmDilKeyTanim()
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
            ds.SYS_DilKey.ColumnChanged += (o, e) => { XChanged = true; };
            ds.SYS_DilKey.TableNewRow += (o, e) =>
            {
                e.Row[ds.SYS_DilKey.DilKeyColumn] = string.Empty;
                e.Row[ds.SYS_DilKey.LanguageColumn] = "tr-TR";
                e.Row[ds.SYS_DilKey.ParametreColumn] = 0;
                e.Row[ds.SYS_DilKey.CaptionColumn] = string.Empty;
            };
        }

        private void DataLoad()
        {
            ds.SYS_DilKey.Clear();
            dt.Fill(ds.SYS_DilKey);
        }

        private void mnuGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveLayout(this, "Std", FormData.Parametre);
        }

        private void mnuKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                gridListe.XPostEditor();
                dt.Update(ds.SYS_DilKey);

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

        private void mnuSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XRemove(gwListe.GetFocusedDataRow());
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

        private void mnuYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gwListe.MoveLast();
        }
    }
}