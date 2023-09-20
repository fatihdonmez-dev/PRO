using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
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

namespace PRO.Control
{
    [ProvideProperty("EnableKey", typeof(Object))]
    public partial class EnableControls : Component, IExtenderProvider
    {


        public EnableControls()
        {
            //InitializeComponent();
            controlList = new Hashtable();
        }
        #region Members

        private Hashtable controlList;
        public event EventHandler OnDenetleBegin;
        public event EventHandler OnDenetleFinish;

        #endregion

        #region IExtenderProvider Members

        public bool CanExtend(object extendee)
        {
            if (extendee is EnableControls)
                return false;

            return
                (extendee is Object);
        }

        #endregion

        [Category("PRO Properties")]
        [DefaultValue("")]
        public string GetEnableKey(Object c)
        {
            if (controlList[c] == null)
            {
                return string.Empty;
            }
            return controlList[c].ToString();
        }
        public void SetEnableKey(Object c, string value)
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

        public void EnableDuzenle(string _deger = "", bool _kilitle = true, bool _gizle = false)
        {
            if (OnDenetleBegin != null)
            {
                OnDenetleBegin(this, EventArgs.Empty);
            }

            DoDenetle(_deger, _kilitle);

            if (OnDenetleFinish != null)
            {
                OnDenetleFinish(this, EventArgs.Empty);
            }
        }
        private void DoDenetle(string _deger, bool _kilitle)
        {

            foreach (DictionaryEntry ctrl in controlList)
            {
                if (ctrl.Value.ToString() == _deger.ToString())
                {
                    if (ctrl.Key is TextEdit) (ctrl.Key as TextEdit).Enabled = _kilitle;
                    else if (ctrl.Key is GridColumn) (ctrl.Key as GridColumn).OptionsColumn.AllowEdit = _kilitle;
                    else if (ctrl.Key is TreeListColumn) (ctrl.Key as TreeListColumn).OptionsColumn.AllowEdit = _kilitle;
                    else if (ctrl.Key is ButtonEdit) (ctrl.Key as ButtonEdit).Enabled = _kilitle;
                    else if (ctrl.Key is MemoEdit) (ctrl.Key as MemoEdit).Enabled = _kilitle;
                    else if (ctrl.Key is SpinEdit) (ctrl.Key as SpinEdit).Enabled = _kilitle;
                    else if (ctrl.Key is LookUpEdit) (ctrl.Key as LookUpEdit).Enabled = _kilitle;
                    else if (ctrl.Key is TimeEdit) (ctrl.Key as TimeEdit).Enabled = _kilitle;
                    else if (ctrl.Key is ComboBoxEdit) (ctrl.Key as ComboBoxEdit).Enabled = _kilitle;
                    else if (ctrl.Key is PictureEdit) (ctrl.Key as PictureEdit).Enabled = _kilitle;
                    else if (ctrl.Key is ImageComboBoxEdit) (ctrl.Key as ImageComboBoxEdit).Enabled = _kilitle;
                    else if (ctrl.Key is CalcEdit) (ctrl.Key as CalcEdit).Enabled = _kilitle;
                    else if (ctrl.Key is CheckEdit) (ctrl.Key as CheckEdit).Enabled = _kilitle;
                    else if (ctrl.Key is ImageEdit) (ctrl.Key as ImageEdit).Enabled = _kilitle;
                    else if (ctrl.Key is ColorEdit) (ctrl.Key as ColorEdit).Enabled = _kilitle;
                    else if (ctrl.Key is BarButtonItem) (ctrl.Key as BarButtonItem).Enabled = _kilitle;
                    else if (ctrl.Key is BarCheckItem) (ctrl.Key as BarCheckItem).Enabled = _kilitle;
                    else if (ctrl.Key is DevExpress.XtraGrid.Views.Grid.GridView) (ctrl.Key as DevExpress.XtraGrid.Views.Grid.GridView).OptionsBehavior.Editable = _kilitle;

                }



            }

        }

        public void VisibleDuzenle(string _deger = "", bool _gizle = false)
        {
            if (OnDenetleBegin != null)
            {
                OnDenetleBegin(this, EventArgs.Empty);
            }

            DoDenetleVisible(_deger, _gizle);

            if (OnDenetleFinish != null)
            {
                OnDenetleFinish(this, EventArgs.Empty);
            }
        }
        private void DoDenetleVisible(string _deger, bool _gizle)
        {

            foreach (DictionaryEntry ctrl in controlList)
            {
                if (_gizle == false)
                {
                    if (ctrl.Value.ToString() == _deger.ToString())
                    {
                        if (ctrl.Key is TextEdit) (ctrl.Key as TextEdit).Visible = false;
                        else if (ctrl.Key is GridColumn) (ctrl.Key as GridColumn).Visible = false;
                        else if (ctrl.Key is TreeListColumn) (ctrl.Key as TreeListColumn).Visible = false;
                        else if (ctrl.Key is ButtonEdit) (ctrl.Key as ButtonEdit).Visible = false;
                        else if (ctrl.Key is MemoEdit) (ctrl.Key as MemoEdit).Visible = false;
                        else if (ctrl.Key is SpinEdit) (ctrl.Key as SpinEdit).Visible = false;
                        else if (ctrl.Key is LookUpEdit) (ctrl.Key as LookUpEdit).Visible = false;
                        else if (ctrl.Key is TimeEdit) (ctrl.Key as TimeEdit).Visible = false;
                        else if (ctrl.Key is ComboBoxEdit) (ctrl.Key as ComboBoxEdit).Visible = false;
                        else if (ctrl.Key is PictureEdit) (ctrl.Key as PictureEdit).Visible = false;
                        else if (ctrl.Key is ImageComboBoxEdit) (ctrl.Key as ImageComboBoxEdit).Visible = false;
                        else if (ctrl.Key is CalcEdit) (ctrl.Key as CalcEdit).Enabled = false;
                        else if (ctrl.Key is CheckEdit) (ctrl.Key as CheckEdit).Visible = false;
                        else if (ctrl.Key is ImageEdit) (ctrl.Key as ImageEdit).Visible = false;
                        else if (ctrl.Key is ColorEdit) (ctrl.Key as ColorEdit).Visible = false;
                        else if (ctrl.Key is BarButtonItem) (ctrl.Key as BarButtonItem).Visibility = BarItemVisibility.Never;
                        else if (ctrl.Key is BarButtonItemLink) (ctrl.Key as BarButtonItemLink).Visible = false;
                    }
                }
                else
                {
                    if (ctrl.Value.ToString() == _deger.ToString())
                    {
                        if (ctrl.Key is TextEdit) (ctrl.Key as TextEdit).Visible = true;
                        else if (ctrl.Key is GridColumn) (ctrl.Key as GridColumn).Visible = true;
                        else if (ctrl.Key is TreeListColumn) (ctrl.Key as TreeListColumn).Visible = true;
                        else if (ctrl.Key is ButtonEdit) (ctrl.Key as ButtonEdit).Visible = true;
                        else if (ctrl.Key is MemoEdit) (ctrl.Key as MemoEdit).Visible = true;
                        else if (ctrl.Key is SpinEdit) (ctrl.Key as SpinEdit).Visible = true;
                        else if (ctrl.Key is LookUpEdit) (ctrl.Key as LookUpEdit).Visible = true;
                        else if (ctrl.Key is TimeEdit) (ctrl.Key as TimeEdit).Visible = true;
                        else if (ctrl.Key is ComboBoxEdit) (ctrl.Key as ComboBoxEdit).Visible = true;
                        else if (ctrl.Key is PictureEdit) (ctrl.Key as PictureEdit).Visible = true;
                        else if (ctrl.Key is ImageComboBoxEdit) (ctrl.Key as ImageComboBoxEdit).Visible = true;
                        else if (ctrl.Key is CalcEdit) (ctrl.Key as CalcEdit).Enabled = true;
                        else if (ctrl.Key is CheckEdit) (ctrl.Key as CheckEdit).Visible = true;
                        else if (ctrl.Key is ImageEdit) (ctrl.Key as ImageEdit).Visible = true;
                        else if (ctrl.Key is ColorEdit) (ctrl.Key as ColorEdit).Visible = true;
                        else if (ctrl.Key is BarButtonItem) (ctrl.Key as BarButtonItem).Visibility = BarItemVisibility.Always;
                        else if (ctrl.Key is BarButtonItemLink) (ctrl.Key as BarButtonItemLink).Visible = true;
                    }
                }



            }

        }

    }
}