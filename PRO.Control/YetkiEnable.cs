using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using PRO.Global;

using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraBars.Ribbon;
using PRO.Data;


namespace PRO.Control
{
    [ProvideProperty("YetkiEnable", typeof(Object))]
    public partial class YetkiEnable : System.ComponentModel.Component, System.ComponentModel.IExtenderProvider
    {

        public YetkiEnable()
        {
            //InitializeComponent();
            controlList = new Hashtable();
        }

        #region Members

        private Hashtable controlList;
        public event EventHandler OnEnableBegin;
        public event EventHandler OnEnableFinish;

        #endregion

        #region IExtenderProvider Members

        public bool CanExtend(object extendee)
        {
            if (extendee is YetkiEnable)
                return false;

            return
                (extendee is Object);
        }

        #endregion

        [Category("PRO Properties")]
        [DefaultValue("")]
        public string GetYetkiEnable(Object c)
        {
            if (controlList[c] == null)
            {
                return string.Empty;
            }
            return controlList[c].ToString();
        }
        public void SetYetkiEnable(Object c, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                if (controlList.ContainsKey(c))
                    controlList.Remove(c);
            }
            else
            {
                controlList[c] = value;
            }
        }

        public void YetkiEnableDuzenle(int Sirket, string MenuNo, DSSystem.SYSUserYetkiDataTable _yetkiList)
        {
            if (OnEnableBegin != null)
            {
                OnEnableBegin(this, EventArgs.Empty);
            }

            DoEnable(Sirket, MenuNo, _yetkiList);

            if (OnEnableFinish != null)
            {
                OnEnableFinish(this, EventArgs.Empty);
            }
        }


        private void DoEnable(int Fabrika, string MenuNo, DSSystem.SYSUserYetkiDataTable _yetkiList)
        {

            foreach (DictionaryEntry ctrl in controlList)
            {
                bool _enable = false;
                string _key = string.Format("{0}{1}", MenuNo, ctrl.Value.ToString());
                _enable = _yetkiList.Where(p => p.YetkiKodu == _key && p.Yetki == true).Any();


                if (ctrl.Key is TextEdit) (ctrl.Key as TextEdit).Enabled = _enable;
                else if (ctrl.Key is GridColumn) (ctrl.Key as GridColumn).OptionsColumn.ReadOnly = _enable;
                else if (ctrl.Key is TreeListColumn) (ctrl.Key as TreeListColumn).OptionsColumn.ReadOnly = _enable;
                else if (ctrl.Key is ButtonEdit) (ctrl.Key as ButtonEdit).Enabled = _enable;
                else if (ctrl.Key is MemoEdit) (ctrl.Key as MemoEdit).Enabled = _enable;
                else if (ctrl.Key is SpinEdit) (ctrl.Key as SpinEdit).Enabled = _enable;
                else if (ctrl.Key is LookUpEdit) (ctrl.Key as LookUpEdit).Enabled = _enable;
                else if (ctrl.Key is TimeEdit) (ctrl.Key as TimeEdit).Enabled = _enable;
                else if (ctrl.Key is ComboBoxEdit) (ctrl.Key as ComboBoxEdit).Enabled = _enable;
                else if (ctrl.Key is PictureEdit) (ctrl.Key as PictureEdit).Enabled = _enable;
                else if (ctrl.Key is ImageComboBoxEdit) (ctrl.Key as ImageComboBoxEdit).Enabled = _enable;
                else if (ctrl.Key is CalcEdit) (ctrl.Key as CalcEdit).Enabled = _enable;
                else if (ctrl.Key is CheckEdit) (ctrl.Key as CheckEdit).Enabled = _enable;
                else if (ctrl.Key is ImageEdit) (ctrl.Key as ImageEdit).Enabled = _enable;
                else if (ctrl.Key is ColorEdit) (ctrl.Key as ColorEdit).Enabled = _enable;
                else if (ctrl.Key is BarButtonItem) (ctrl.Key as BarButtonItem).Enabled = _enable;
                else if (ctrl.Key is BarCheckItem) (ctrl.Key as BarCheckItem).Enabled = _enable;

            }

        }

    }
}
