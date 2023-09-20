using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using PRO.Global;
using System.Globalization;
using System.Threading;
using PRO.Data;
using PRO.Data.DSSystemTableAdapters;


namespace PRO.Master
{

    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {

        public frmLogin()
        {
            Variables._connData = Functions._GetConnectData();
            Variables._conStr = Variables._connData._Connect;

            SetConnect();
            InitializeComponent();
            Session.Instance.CurrentCulture.SetCurrentCulture(new CultureInfo("tr-TR"));
            Session.Instance.CurrentConnect = new SessionConnect(Variables._connData._Server, Variables._connData._DataBase, Variables._conStr, "tr-TR");
            E_Localizer.TranslateControls("0");
            txtUser.EditValue = System.Environment.UserName.ToString();
        }


        DSSystem.SYS_UserDataTable dtUSER = new DSSystem.SYS_UserDataTable();
        void GetUser(string _kullanici)
        {
            using (SYS_UserTableAdapter adap = new SYS_UserTableAdapter())
            {
                dtUSER = adap.GetData(_kullanici);
                if (dtUSER.Rows.Count > 0)
                {
                    txtUser.Text = dtUSER.Rows[0]["Kullanici"].ToString();
                    lblUserName.Text = dtUSER.Rows[0]["KullaniciAdi"].ToString();
                    lblUserName.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
                    GetFirma();
                }
                else
                {
                    dtSirket.Clear();
                    dtUSER.Clear();
                    //txtUser.Text = string.Empty;
                    //XtraMessageBox.Show("Kullanıcı Bulunamadı");
                }

            }

        }

        private void _userKod_Validated(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty) return;

            GetUser(txtUser.EditValue.ToString());
        }


        DSSystem.SIR_SirketDataTable dtSirket = new DSSystem.SIR_SirketDataTable();
        void GetFirma()
        {
            using (SIR_SirketTableAdapter adap = new SIR_SirketTableAdapter())
            {
                dtSirket = adap.GetData();
                dtSirket.BindToControl(leSirket, "Firma", "FirmaAdi");
                if(dtSirket.Rows.Count > 0)
                leSirket.EditValue = dtSirket[0].Sirket;
            }

        }

        public void SetConnect()
        {
            string _s = PRO.Global.Variables._conStr;

            PRO.Data.SetConnect.SetProperties(_s);
            PRO.Data.Finans.SetConnect.SetProperties(_s);
            PRO.Data.Global.SetConnect.SetProperties(_s);
            PRO.Data.Stok.SetConnect.SetProperties(_s);
            PRO.Data.Siparis.SetConnect.SetProperties(_s);
            PRO.Data.Depo.SetConnect.SetProperties(_s);
            PRO.Win.Report.SetConnect.SetProperties(_s);
            
        }


        //void ShortcutLoad()
        //{
        //    Thread _thrC = new Thread(new ThreadStart(ThreadShortcut));
        //    _thrC.IsBackground = true;
        //    _thrC.Start();
        //}

        //void ThreadShortcut()
        //{
        //    ShortcutGlobal.InstanceShortcut.CurrentShortcut = new Shortcuts(Functions.GetShortcut());

        //}
        void UserLogin()
        {
            var _sir = dtSirket.Where(p => p.Sirket == (int)leSirket.EditValue).FirstOrDefault();
            if (_sir == null)
            {
                txtUser.Text = string.Empty;
                txtPass.Text = string.Empty;
                XtraMessageBox.Show("Kullanıcı Bulunamadı");
                return;
            }
            var _user = dtUSER[0];
            if (_user == null)
            {
                txtUser.Text = string.Empty;
                txtPass.Text = string.Empty;
                XtraMessageBox.Show("Kullanıcı Bulunamadı");
                return;
            }

            if (_user.Sifre != txtPass.Text)
            {
                XtraMessageBox.Show("Hatalı Kullanıcı/Şifre");
                return;
            }

            Session.Instance.CurrentUser = new SessionUsers
                            (
                            _user.Kullanici,
                            _user.KullaniciAdi,
                            _sir.Firma,
                            _sir.FirmaAdi,
                            _sir.Sirket,
                            _sir.SirketAdi,
                            "tr-TR"
                            );


            SetConnect();
            //ShortcutLoad();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            UserLogin();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


    }
}