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
using PRO.Data;
using PRO.Global;
using PRO.Data.DSSystemTableAdapters;
using System.IO;
using DevExpress.XtraGrid;
using DevExpress.XtraBars;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraLayout;
using System.Collections;
using DevExpress.XtraEditors.Repository;

namespace PRO.Control
{
    public partial class frmBase : XtraForm
    {


        #region Members
        public DSSystem.SYSUserYetkiDataTable _yetkiList;
        public MenuData FormData;
        public GrupYetkiData FormDataGrupYetki;
        public bool XChanged = false;
        public string AnaDoviz = "TL";
        static int _Sirket = 0;
        static int _Firma = 0;

        #endregion

        public frmBase()
        {
            InitializeComponent();
        }

        public void LoadUserYetkiTable()
        {
            #region YetkiTable
            _yetkiList = new DSSystem.SYSUserYetkiDataTable();

            var adapKulYetki = new SYSUserYetkiTableAdapter();
            var result = adapKulYetki.GetData(Session.Instance.CurrentUser.UserName, FormData.MenuNo, FormData.Sirket);

            result.CopyToDataTable(_yetkiList, LoadOption.OverwriteChanges);
            #endregion

        }

        public virtual void ExFormLoad()
        {



        }

        public virtual void ExFocus()
        {

        }

        public bool IsYetki(int firma, string yetkiKodu)
        {
            var _list = _yetkiList.Where(p => p.YetkiKodu == yetkiKodu).FirstOrDefault();
            if (_list == null) return false;

            return _list.Yetki;

        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {

                string _langParam = "0";
                if (FormData.MultiLang)
                    _langParam = FormData.Parametre;

                _Firma = this.FormData.Firma;
                _Sirket = this.FormData.Sirket;

                E_Localizer.SetDilKey(this, this.FormData.DilKey.ToString());
                LoadUserYetkiTable();
                LoadLayout(this, FormData.LayoutName, this.FormData.Parametre);
                E_Localizer.TranslateControls(_langParam);

                ExFormLoad();

                YetkileriDuzenle(FormData.Sirket);
                //clsShort.SetShortcut(this);

                SetCharacterCasingEvent(this);
                ExFocus();
            }
        }

        public void YetkileriDuzenle(int _Firma)
        {
            E_Yetki.YetkiEnableDuzenle(_Firma, FormData.MenuNo, _yetkiList);
        }

        #region LAYOUT

        public static void SaveLayout(System.Windows.Forms.Control mainControl, string _LayoutName, string _param)
        {
            Form f = mainControl.FindForm();
            if (f != null)
            {
                LayoutOperation(f, f.Name, PRO.Global.LayoutOperation.SaveLayout, _LayoutName, _param);
                using (DSSystem ds = new DSSystem())
                {
                    using (var adapterF = new SYS_FormLayoutTableAdapter())
                    {
                        string _FormPath = string.Format("{0}_{1}_{2}_{3}_{4}", _Firma.ToString(), "0", "System", _param, f.Name);
                        SaveFormLayoutToDatabase(ds, adapterF, _FormPath, mainControl.ClientSize.Height, mainControl.ClientSize.Width, mainControl.Location.X, mainControl.Location.Y);
                    }
                }
            }


        }

        private static void SaveFormLayoutToDatabase(DSSystem ds, SYS_FormLayoutTableAdapter adapter, string _layID, int _sizeH, int _sizeW, int _locationX, int _locationY)
        {
            try
            {
                adapter.Fill(ds.SYS_FormLayout, _layID);
                if (ds.SYS_FormLayout.Count == 0)
                {
                    var row = ds.SYS_FormLayout.NewSYS_FormLayoutRow();
                    row.LayoutID = _layID;
                    row.SizeH = _sizeH;
                    row.SizeW = _sizeW;
                    row.LocationX = _locationX;
                    row.LocationY = _locationY;
                    row.Versiyon = DateTime.Now;
                    ds.SYS_FormLayout.AddSYS_FormLayoutRow(row);
                }
                else
                {
                    ds.SYS_FormLayout[0].BeginEdit();
                    ds.SYS_FormLayout[0].SizeH = _sizeH;
                    ds.SYS_FormLayout[0].SizeW = _sizeW;
                    ds.SYS_FormLayout[0].LocationX = _locationX;
                    ds.SYS_FormLayout[0].LocationY = _locationY;
                    ds.SYS_FormLayout[0].Versiyon = DateTime.Now;
                    ds.SYS_FormLayout[0].EndEdit();
                }
                adapter.Update(ds.SYS_FormLayout);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        public static void LoadLayout(System.Windows.Forms.Control mainControl, string _LayoutName, string _param)
        {
            Form f = mainControl.FindForm();
            if (f != null)
            {
                LayoutOperation(f, f.Name, PRO.Global.LayoutOperation.LoadLayout, _LayoutName, _param);
                using (DSSystem ds = new DSSystem())
                {
                    using (var adapterF = new SYS_FormLayoutTableAdapter())
                    {
                        string _FormPath = string.Format("{0}_{1}_{2}_{3}_{4}", _Firma.ToString(), "0", "System", _param, f.Name);
                        LoadFormLayoutFromDatabase(mainControl, ds, adapterF, _FormPath);
                    }
                }
            }

        }
        private static void LayoutOperation(System.Windows.Forms.Control mainControl, string ctrlPath, LayoutOperation operation, string _lyt, string _param)
        {
            using (DSSystem ds = new DSSystem())
            {
                using (var adapter = new SYS_LayoutTableAdapter())
                {
                    var _CtrlList = from c in mainControl.Controls.OfType<System.Windows.Forms.Control>()
                                       select c;

                    foreach (var ctrl in _CtrlList)
                    {
                        if (operation == PRO.Global.LayoutOperation.SaveLayout)
                            SaveControlLayoutToDatabase(ds, adapter, ctrl, ctrlPath, _lyt, _param);
                        else
                            LoadControlLayoutFromDatabase(ds, adapter, ctrl, ctrlPath, _lyt, _param, mainControl);

                        if (ctrl.Controls.Count > 0)
                        {
                            LayoutOperation(ctrl, String.Format("{0} / {1}", ctrlPath, ctrl.Name), operation, _lyt, _param);
                        }
                    }
                }
            }
        }
        private static void LoadControlLayoutFromDatabase(DSSystem ds, SYS_LayoutTableAdapter adapter, System.Windows.Forms.Control ctrl, string ctrlPath, string _Lyt, string _param, System.Windows.Forms.Control mainControl)
        {
            string layoutID = String.Format("{0} / {1}", ctrlPath, ctrl.Name);
            DSSystem.SYS_LayoutDataTable _table = new DSSystem.SYS_LayoutDataTable();
            _table = Functions.GetLayoutTable(_Firma, Session.Instance.CurrentUser.UserName, layoutID, _Lyt, _param);
            if (_table.Rows.Count == 0) return;
            DSSystem.SYS_LayoutRow row = (DSSystem.SYS_LayoutRow)_table.Rows[0];

            if (ctrl is GridControl)
            {
                using (var stream = new System.IO.MemoryStream(row.ObjectContent))
                {
                    var grid = ctrl as GridControl;
                    grid.MainView.RestoreLayoutFromStream(stream);
                }
            }
            else if (ctrl is LayoutControl)
            {
                using (var stream = new System.IO.MemoryStream(row.ObjectContent))
                {
                    var _layout = ctrl as LayoutControl;
                    _layout.RestoreLayoutFromStream(stream);
                }
            }
            else if (ctrl is PivotGridControl)
            {
                using (var stream = new System.IO.MemoryStream(row.ObjectContent))
                {
                    var _layout = ctrl as PivotGridControl;
                    _layout.RestoreLayoutFromStream(stream);
                }
            }
        }
        private static void SaveControlLayoutToDatabase(DSSystem ds, SYS_LayoutTableAdapter adapter, System.Windows.Forms.Control ctrl, string ctrlPath, string _Lyt, string _param)
        {
            if (ctrl is GridControl)
            {
                using (var stream = new System.IO.MemoryStream())
                {
                    var grid = ctrl as GridControl;
                    grid.MainView.SaveLayoutToStream(stream);

                    string layoutID = String.Format("{0} / {1}", ctrlPath, ctrl.Name);

                    if (_Lyt == "")

                        adapter.Fill(ds.SYS_Layout, _Firma, Session.Instance.CurrentUser.UserName, layoutID, _param);
                    else
                        adapter.FillBy(ds.SYS_Layout, _Firma, Session.Instance.CurrentUser.UserName, layoutID, _Lyt, _param);

                    if (ds.SYS_Layout.Count == 0)
                    {
                        var row = ds.SYS_Layout.NewSYS_LayoutRow();
                        row.RowID = Guid.NewGuid();
                        row.Firma = _Firma;
                        row.Versiyon = DateTime.Now;
                        row.LayoutID = layoutID;
                        row.Parametre = _param;
                        row.UserName = Session.Instance.CurrentUser.UserName;
                        row.ObjectName = ctrl.Name;
                        row.ObjectType = ctrl.GetType().ToString();

                        row.ObjectContent = stream.ToArray();

                        if (_Lyt == "")
                        {
                            row.Standart = true;
                            row.LayoutName = "Std";
                        }
                        else
                        {
                            row.Standart = false;
                            row.LayoutName = _Lyt;
                        }
                        ds.SYS_Layout.AddSYS_LayoutRow(row);
                    }
                    else
                    {
                        ds.SYS_Layout[0].BeginEdit();
                        ds.SYS_Layout[0].ObjectContent = stream.ToArray();
                        ds.SYS_Layout[0].Versiyon = DateTime.Now;
                        ds.SYS_Layout[0].EndEdit();
                    }

                    try
                    {
                        adapter.Update(ds.SYS_Layout);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }
            else if (ctrl is LayoutControl)
            {
                using (var stream = new System.IO.MemoryStream())
                {
                    var _layout = ctrl as LayoutControl;
                    _layout.SaveLayoutToStream(stream);

                    string layoutID = String.Format("{0} / {1}", ctrlPath, ctrl.Name);

                    if (_Lyt == "")
                        adapter.Fill(ds.SYS_Layout, _Firma, Session.Instance.CurrentUser.UserName, layoutID, _param);
                    else
                        adapter.FillBy(ds.SYS_Layout, _Firma, Session.Instance.CurrentUser.UserName, layoutID, _Lyt, _param);


                    if (ds.SYS_Layout.Count == 0)
                    {
                        var row = ds.SYS_Layout.NewSYS_LayoutRow();
                        row.RowID = Guid.NewGuid();
                        row.Firma = _Firma;
                        row.Versiyon = DateTime.Now;
                        row.LayoutID = layoutID;
                        row.Parametre = _param;
                        row.UserName = Session.Instance.CurrentUser.UserName;
                        row.ObjectName = ctrl.Name;
                        row.ObjectType = ctrl.GetType().ToString();

                        row.ObjectContent = stream.ToArray();

                        if (_Lyt == "")
                        {
                            row.Standart = true;
                            row.LayoutName = "Std";
                        }
                        else
                        {
                            row.Standart = false;
                            row.LayoutName = _Lyt;
                        }
                        ds.SYS_Layout.AddSYS_LayoutRow(row);
                    }
                    else
                    {
                        ds.SYS_Layout[0].BeginEdit();
                        ds.SYS_Layout[0].ObjectContent = stream.ToArray();
                        ds.SYS_Layout[0].Versiyon = DateTime.Now;
                        ds.SYS_Layout[0].EndEdit();
                    }

                    try
                    {
                        adapter.Update(ds.SYS_Layout);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }
            else if (ctrl is PivotGridControl)
            {
                using (var stream = new System.IO.MemoryStream())
                {
                    var _layout = ctrl as PivotGridControl;
                    _layout.SaveLayoutToStream(stream);

                    string layoutID = String.Format("{0} / {1}", ctrlPath, ctrl.Name);

                    if (_Lyt == "")
                        adapter.Fill(ds.SYS_Layout, _Firma, Session.Instance.CurrentUser.UserName, layoutID, _param);
                    else
                        adapter.FillBy(ds.SYS_Layout, _Firma, Session.Instance.CurrentUser.UserName, layoutID, _Lyt, _param);


                    if (ds.SYS_Layout.Count == 0)
                    {
                        var row = ds.SYS_Layout.NewSYS_LayoutRow();
                        row.RowID = Guid.NewGuid();
                        row.Firma = _Firma;
                        row.Versiyon = DateTime.Now;
                        row.LayoutID = layoutID;
                        row.Parametre = _param;
                        row.UserName = Session.Instance.CurrentUser.UserName;
                        row.ObjectName = ctrl.Name;
                        row.ObjectType = ctrl.GetType().ToString();
                        row.ObjectContent = stream.ToArray();

                        if (_Lyt == "")
                        {
                            row.Standart = true;
                            row.LayoutName = "Std";
                        }
                        else
                        {
                            row.Standart = false;
                            row.LayoutName = _Lyt;
                        }
                        ds.SYS_Layout.AddSYS_LayoutRow(row);
                    }
                    else
                    {

                        ds.SYS_Layout[0].BeginEdit();
                        ds.SYS_Layout[0].ObjectContent = stream.ToArray();
                        ds.SYS_Layout[0].EndEdit();
                    }

                    try
                    {
                        adapter.Update(ds.SYS_Layout);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }


        }

        private static void LoadFormLayoutFromDatabase(System.Windows.Forms.Control mainControl, DSSystem ds, SYS_FormLayoutTableAdapter adapter, string _layID)
        {
            DSSystem.SYS_FormLayoutDataTable _formLayoutDT = new DSSystem.SYS_FormLayoutDataTable();
            _formLayoutDT = Functions.GetFormLayoutTable(_layID);

            if (_formLayoutDT.Rows.Count == 0) return;
            DSSystem.SYS_FormLayoutRow row = (DSSystem.SYS_FormLayoutRow)_formLayoutDT.Rows[0];
            mainControl.Height = row.SizeH + 39;
            mainControl.Width = row.SizeW + 16;
            mainControl.Location = new System.Drawing.Point(row.LocationX, row.LocationY);
        }

        #endregion

        #region CHARACTER SET

        public void SetCharacterCasing(System.Windows.Forms.Control _ctr)
        {
            var _CtrlList = from c in _ctr.Controls.OfType<System.Windows.Forms.Control>()
                            select c;

            foreach (System.Windows.Forms.Control cont in _CtrlList)
            {
                if (cont is TextEdit)
                {
                    var _c = cont as TextEdit;
                    _c.Text = GetCharacter(_c.Text);
                }
                else if (cont is ButtonEdit)
                {
                    var _c = cont as ButtonEdit;
                    _c.Text = GetCharacter(_c.Text);
                }
                else if (cont is ImageComboBoxEdit)
                {
                    var _c = cont as ImageComboBoxEdit;
                    _c.Text = GetCharacter(_c.Text);
                }
                else if (cont is MemoEdit)
                {
                    var _c = cont as MemoEdit;
                    _c.Text = GetCharacter(_c.Text);
                }
                else if (cont is ComboBoxEdit)
                {
                    var _c = cont as ComboBoxEdit;
                    _c.Text = GetCharacter(_c.Text);
                }
                else if (cont is LookUpEdit)
                {
                    var _c = cont as LookUpEdit;
                    _c.Text = GetCharacter(_c.Text);
                }

                if (cont.Controls.Count > 0)
                {
                    SetCharacterCasing(cont);
                }
            }
        }
        string GetCharacter(string _deger)
        {
            if (_chrCCasing == 1)
                return _deger.ToUpper(Session.Instance.CurrentCulture.CurrentCulture);
            else if (_chrCCasing == 2)
                return _deger.ToLower(Session.Instance.CurrentCulture.CurrentCulture);
            else
                return _deger;
        }

        public int _chrCCasing = 0;
        void SetCharacterCasingEvent(System.Windows.Forms.Control _ctr)
        {
            var _CtrlList = from c in _ctr.Controls.OfType<System.Windows.Forms.Control>()
                            select c;

            foreach (System.Windows.Forms.Control cont in _CtrlList)
            {
                if (cont is TextEdit)
                {
                    var _c = cont as TextEdit;
                    _c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_KeyPress);
                }
                else if (cont is ButtonEdit)
                {
                    var _c = cont as ButtonEdit;
                    _c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_KeyPress);
                }
                else if (cont is ImageComboBoxEdit)
                {
                    var _c = cont as ImageComboBoxEdit;
                    _c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_KeyPress);
                }
                else if (cont is MemoEdit)
                {
                    var _c = cont as MemoEdit;
                    _c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_KeyPress);
                }
                else if (cont is ComboBoxEdit)
                {
                    var _c = cont as ComboBoxEdit;
                    _c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_KeyPress);
                }
                else if (cont is LookUpEdit)
                {
                    var _c = cont as LookUpEdit;
                    _c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_KeyPress);
                }
                if (cont.Controls.Count > 0)
                {
                    SetCharacterCasingEvent(cont);
                }
            }
        }
        private void _KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (_chrCCasing)
            {
                case 1:
                    e.KeyChar = char.ToUpper(e.KeyChar, Session.Instance.CurrentCulture.CurrentCulture);
                    break;
                case 2:
                    e.KeyChar = char.ToLower(e.KeyChar, Session.Instance.CurrentCulture.CurrentCulture);
                    break;

            }

        }

        #endregion

        #region DATA
        public bool XRemove(DataRow rw)
        {
            if (rw == null) return false;

            if (XtraMessageBox.Show("Kayıt Silinecek. Onaylıyor musunuz?",
                "Kayıt Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                rw.Delete();
                return true;
            }
            return false;
        }
        public bool XSil(DataRow rw)
        {
            if (rw == null) return false;

            if (XtraMessageBox.Show("Kayıt Silinecek. Onaylıyor musunuz?",
                "Kayıt Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {

                if (rw.RowState == DataRowState.Added)
                {
                    rw.Delete();
                    return true;
                }
                else
                {
                    rw.BeginEdit();
                    rw["Silindi"] = true;
                    rw.EndEdit();
                    return true;
                }
            }
            return false;
        }

        public void XSilNoMesaj(DataRow rw)
        {
            if (rw == null) return;

            if (rw.RowState == DataRowState.Added)
                rw.Delete();
            else
            {
                rw.BeginEdit();
                rw["Silindi"] = true;
                rw.EndEdit();
            }

        }

        public void XPasif(DataRow rw)
        {
            if (rw == null) return;

            if (XtraMessageBox.Show("Kayıt Pasif Yapılacak. Onaylıyor musunuz?",
                "Kayıt Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                rw.BeginEdit();
                rw["Pasif"] = true;
                rw.EndEdit();
            }
        }
        public void XAktif(DataRow rw)
        {
            if (rw == null) return;

            if (XtraMessageBox.Show("Kayıt Aktif Yapılacak. Onaylıyor musunuz?",
                "Kayıt Sil",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                rw.BeginEdit();
                rw["Pasif"] = false;
                rw.EndEdit();
            }
        }


        #endregion

        #region PROP
        frmProperty _prop = new frmProperty();
        public void XProperty(object obj, bool show)
        {
            _prop._Property.SelectedObject = obj;
            if (show)
                _prop.Show();
        }



        #endregion

    }
}