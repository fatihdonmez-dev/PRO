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
using PRO.Data.Stok;

namespace PRO.Win.Stok
{
    public partial class frmStokGrup : frmBase
    {
        public frmStokGrup()
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
            #region Grup

            ds.STK_Grup.ColumnChanged += (o, e) => { XChanged = true; };
            ds.STK_Grup.TableNewRow += (o, e) =>
            {
                e.Row[ds.STK_Grup.GrupIDColumn] = Guid.NewGuid();
                e.Row[ds.STK_Grup.GrupKodColumn] = GrupKodOlustur();
                e.Row[ds.STK_Grup.GrupAdColumn] = string.Empty;
                e.Row[ds.STK_Grup.PasifColumn] = false;
                e.Row[ds.STK_Grup.SilindiColumn] = false;
                e.Row[ds.STK_Grup.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.STK_Grup.KayitDateColumn] = DateTime.Now;
                e.Row[ds.STK_Grup.DegisByColumn] = string.Empty;
                e.Row[ds.STK_Grup.VersiyonColumn] = DateTime.Now;
            };
            #endregion

            #region Cins

            ds.STK_GrupCins.ColumnChanged += (o, e) => { XChanged = true; };
            ds.STK_GrupCins.TableNewRow += (o, e) =>
            {
                e.Row[ds.STK_GrupCins.CinsIDColumn] = Guid.NewGuid();

                var row = (DSStok.STK_GrupRow)gwGrup.GetFocusedDataRow();
                if (row != null)
                    e.Row[ds.STK_GrupCins.GrupIDColumn] = row.GrupID;
                else
                    e.Row[ds.STK_GrupCins.GrupIDColumn] = Guid.Empty;

                e.Row[ds.STK_GrupCins.CinsKoduColumn] = GrupCinsKodOlustur();
                e.Row[ds.STK_GrupCins.CinsAdiColumn] = string.Empty;
                e.Row[ds.STK_GrupCins.TipColumn] = 0;
                e.Row[ds.STK_GrupCins.PasifColumn] = false;
                e.Row[ds.STK_GrupCins.SilindiColumn] = false;
                e.Row[ds.STK_GrupCins.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.STK_GrupCins.KayitDateColumn] = DateTime.Now;
                e.Row[ds.STK_GrupCins.DegisByColumn] = string.Empty;
                e.Row[ds.STK_GrupCins.VersiyonColumn] = DateTime.Now;
            };
            #endregion

            #region Tur

            ds.STK_GrupCinsTur.ColumnChanged += (o, e) => { XChanged = true; };
            ds.STK_GrupCinsTur.TableNewRow += (o, e) =>
            {
                e.Row[ds.STK_GrupCinsTur.TurIDColumn] = Guid.NewGuid();

                var row = (DSStok.STK_GrupCinsRow)gwCins.GetFocusedDataRow();
                if (row != null)
                    e.Row[ds.STK_GrupCinsTur.CinsIDColumn] = row.CinsID;
                else
                    e.Row[ds.STK_GrupCinsTur.CinsIDColumn] = Guid.Empty;

                e.Row[ds.STK_GrupCinsTur.TurKoduColumn] = GrupCinsTurKodOlustur();
                e.Row[ds.STK_GrupCinsTur.TurAdiColumn] = string.Empty;
                e.Row[ds.STK_GrupCinsTur.KisaAdiColumn] = string.Empty;
                e.Row[ds.STK_GrupCinsTur.PasifColumn] = false;
                e.Row[ds.STK_GrupCinsTur.KayitByColumn] = Session.Instance.CurrentUser.UserName;
                e.Row[ds.STK_GrupCinsTur.KayitDateColumn] = DateTime.Now;
                e.Row[ds.STK_GrupCinsTur.DegisByColumn] = string.Empty;
                e.Row[ds.STK_GrupCinsTur.VersiyonColumn] = DateTime.Now;
            };


            #endregion

        }

        private void DataLoad()
        {
            ds.STK_Grup.Clear();
            ds.STK_GrupCins.Clear();
            ds.STK_GrupCinsTur.Clear();

            dtGrup.Fill(ds.STK_Grup);
        }

        string GrupKodOlustur()
        {
            var _max = ds.STK_Grup.Max(p => p.GrupKod);

            return KodOlustur(_max, "");
        }

        string GrupCinsKodOlustur()
        {
            var row = (DSStok.STK_GrupRow)gwGrup.GetFocusedDataRow();
            if (row == null) return "";

            var _max = ds.STK_GrupCins.Where(x => x.RowState != DataRowState.Deleted).Max(p => p.CinsKodu);

            return KodOlustur(_max, row.GrupKod);
        }

        string GrupCinsTurKodOlustur()
        {
            var row = (DSStok.STK_GrupCinsRow)gwCins.GetFocusedDataRow();
            if (row == null) return "";

            var _max = ds.STK_GrupCinsTur.Where(x => x.RowState != DataRowState.Deleted).Max(p => p.TurKodu);

            return KodOlustur(_max, row.CinsKodu);
        }

        string KodOlustur(string sonKod, string ustKod)
        {
            int kodDeger;
            string ilkKisim = "";
            if (sonKod == null)
            {
                kodDeger = 1;
                ilkKisim = ustKod;
            }
            else
            {
                if (sonKod.ToString().Length > 2)
                    ilkKisim = sonKod.Substring(0, sonKod.ToString().Length - 2);
                else ilkKisim = ustKod;
                kodDeger = Convert.ToInt16(sonKod.Substring(sonKod.Length - 2, 2)) + 1;
            }

            if (kodDeger < 10)
                return ilkKisim + "0" + kodDeger.ToString();
            else
                return ilkKisim + kodDeger.ToString();
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
                bsGrup.EndEdit();
                bsCins.EndEdit();
                bsTur.EndEdit();

                if(XChanged)
                {
                    ds.STK_Grup.SetVersyon();
                    ds.STK_GrupCins.SetVersyon();
                    ds.STK_GrupCinsTur.SetVersyon();
                }

                dtGrup.Update(ds.STK_Grup);
                dtCins.Update(ds.STK_GrupCins);
                dtTur.Update(ds.STK_GrupCinsTur);

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

        #region Ozellikler

        private void mnuOzGrupGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridGrup, true);
        }

        private void mnuOzGrupListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwGrup, true);
        }

        private void gwGrup_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwGrup_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupGrup.ShowPopup(MousePosition);
        }

        private void mnuOzTurGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridTur, true);
        }

        private void mnuOzTurListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwTur, true);
        }

        private void gwTur_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }

        private void gwTur_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupTur.ShowPopup(MousePosition);
        }

        private void mnuOzCinsGenel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gridCins, true);
        }

        private void mnuOzCinsListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XProperty(gwCins, true);
        }

        private void gwCins_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            XProperty(e.FocusedColumn, false);
        }
        private void gwCins_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            popupCins.ShowPopup(MousePosition);
        }

        #endregion

        private void gwGrup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var rw = (DSStok.STK_GrupRow)gwGrup.GetFocusedDataRow();

            if (gwGrup.GetFocusedDataRow() == null)
            {
                gwCins.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                gwTur.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;

                ds.STK_GrupCinsTur.Clear();
                ds.STK_GrupCins.Clear();
            }
            else
            {
                gwCins.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

                ds.STK_GrupCins.Clear();
                ds.STK_GrupCinsTur.Clear();
                dtCins.Fill(ds.STK_GrupCins, rw.GrupID);
            }

        }

        private void gwCins_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var rw = (DSStok.STK_GrupCinsRow)gwCins.GetFocusedDataRow();
            
            if(rw == null)
            {
                gwTur.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                ds.STK_GrupCinsTur.Clear();
            }
            else
            {
                gwTur.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;

                ds.STK_GrupCinsTur.Clear();
                dtTur.Fill(ds.STK_GrupCinsTur, rw.CinsID);
            }
        }

        private void mnuTurPasif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XPasif(gwTur.GetFocusedDataRow());
        }

        private void mnuCinsSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XSil(gwCins.GetFocusedDataRow());
        }

        private void mnuCinsPasif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XPasif(gwCins.GetFocusedDataRow());
        }

        private void mnuGrupSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XSil(gwGrup.GetFocusedDataRow());
        }

        private void mnuGrupPasif_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XPasif(gwGrup.GetFocusedDataRow());
        }

        private void mnuYenile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataLoad();
        }
        
    }
}