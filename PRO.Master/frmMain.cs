using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

using System.Resources;
using System.Reflection;
using DevExpress.XtraSplashScreen;
using System.IO;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using PRO.Control;
using PRO.Global;
using PRO.Data;
using PRO.Data.DSSystemTableAdapters;

namespace PRO.Master
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();

            //GlobalEvent.OnSirketFabrika += new GlobalEvent.SirketFabrikaEventHandler(SetSirketFabrika);
            //GlobalEvent.OnHesapKart += new GlobalEvent.HesapKartEventHandler(SaticiDuzenle);
            //GlobalEvent.OnKliseBaskiOlcu += new GlobalEvent.OnKliseBaskiOlcuEventHandler(StokBaskiGuncelle);
            //GlobalEvent.OnUrunKartiAc += new GlobalEvent.OnUrunAcEventHandler(SetUrunKarti);
            //GlobalEvent.OnFaturaAc += new GlobalEvent.OnFaturaAcEventHandler(SetFaturaAc);

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            GetUserMenu();
            SetMain();
            E_Localizer.TranslateControls("0");
            E_MenuYetki.MenuYetkiUpdate(kullaniciMenu);

        }

        //private void mnuSirketDegistir_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    MenuData frmData = new MenuData("S00000", "_SirketSec", "", "0", "Std", (int)Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.SirketAdi, (int)Session.Instance.CurrentUser.Fabrika, Session.Instance.CurrentUser.FabrikaAdi, "", "", "", (string)Session.Instance.CurrentConnect.Connection);
        //    frmFabrikaSec _frm = new frmFabrikaSec();
        //    _frm.FormData = frmData;
        //    if (_frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
                //SetMain();
        //    }
        //}

        void SetMain()
        {
            //CreateMenu();
            lbUser.Caption = Session.Instance.CurrentUser.UserFullName;
            lbSirket.Caption = Session.Instance.CurrentUser.SirketAdi;

            lbDB.Caption = Session.Instance.CurrentConnect.Database;
            lbFormSirket.Caption = Session.Instance.CurrentUser.FirmaAdi;
        }

        DSSystem.UDF_UserMenuDataTable kullaniciMenu = new DSSystem.UDF_UserMenuDataTable();
        private void GetUserMenu()
        {
            using (UDF_UserMenuTableAdapter adapMenu = new UDF_UserMenuTableAdapter())
            {
                if (Session.Instance.CurrentUser.UserName == "Super")
                    kullaniciMenu = adapMenu.GetData(Session.Instance.CurrentUser.UserName, Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.Lang);
                else
                    kullaniciMenu = adapMenu.GetDataBy(Session.Instance.CurrentUser.UserName, Session.Instance.CurrentUser.Sirket, Session.Instance.CurrentUser.Lang);
            }
        }

        private void menu_ItemClick(object sender, ItemClickEventArgs e)
        {

            SplashScreenManager.ShowForm(typeof(WaitForm1));

            int _ID = Convert.ToInt32(e.Item.Tag.ToString());
            var mnu = kullaniciMenu.Where(p => p.ID == _ID).FirstOrDefault();
            if (mnu == null) return;

            if (mnu.ModulIslemFormu == string.Empty) { SplashScreenManager.CloseForm(); return; }

            string asmName = mnu.ModulIslemFormu.Substring(0, mnu.ModulIslemFormu.LastIndexOf('.'));
            string formName = mnu.ModulIslemFormu;

            this.Cursor = Cursors.WaitCursor;
            try
            {

                Assembly asm;
                try
                {
                    asm = Assembly.Load(asmName);

                }
                catch (FileNotFoundException ex)
                {
                    XtraMessageBox.Show(string.Format("Assembly bulunamadı ! File: {0}", ex.FileName), "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SplashScreenManager.CloseForm();
                    return;
                }

                object formObject = asm.CreateInstance(formName);
                if (formObject == null)
                {
                    XtraMessageBox.Show(string.Format("Assembly içerisinde '{0}' formu bulunamadı !", formName), "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SplashScreenManager.CloseForm();
                    return;
                }
                if (!(formObject is frmBase))
                {
                    XtraMessageBox.Show(string.Format("'{0}'\nformunu\nBaseForm'dan Türetmelisiniz!", formName), "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SplashScreenManager.CloseForm();
                    return;
                }

                MenuData menuData = new MenuData
                    (
                    mnu.Modul,
                    mnu.ModulDilKey,
                    mnu.ModulIslemFormu,
                    mnu.ModulParametre,
                    "Std",
                    Session.Instance.CurrentUser.Sirket,
                    Session.Instance.CurrentUser.SirketAdi,
                    Session.Instance.CurrentUser.Firma,
                    Session.Instance.CurrentUser.FirmaAdi,
                    mnu.ModulLoadParam,
                    mnu.ModulDefaultParam,
                    mnu.ModulSeriParam,
                    Session.Instance.CurrentConnect.Connection,
                    mnu.MultiDilKey,
                    mnu.HesapParam,
                    mnu.KHesapParam
                    );

                if (formObject is frmBase)
                {
                    var frm1 = (frmBase)formObject;
                    frm1.FormData = menuData;
                    if (mnu.Popup)
                    {
                        //frm1.MdiParent = this;
                        frm1.ShowDialog();
                    }
                    else
                    {
                        frm1.MdiParent = this;
                        frm1.Show();
                    }
                    
                }

                else
                    return;

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
            SplashScreenManager.CloseForm();


        }

        private void s_Click(object sender, EventArgs e)
        {

        }

        void sqlDepOnChange(object sender, SqlNotificationEventArgs e)
        {
            MessageBox.Show("Veritabanında değişiklik yapıldı.");
        }

    }
}