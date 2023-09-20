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
    [ProvideProperty("MenuYetki", typeof(Object))]
    public partial class MenuYetki : System.ComponentModel.Component, System.ComponentModel.IExtenderProvider
    {

        public MenuYetki()
        {
            //InitializeComponent();
            controlList = new Hashtable();
        }

        #region Members

        private Hashtable controlList;
        public event EventHandler OnMenuYetkiBegin;
        public event EventHandler OnMenuYetkiFinish;

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
        public string GetMenuYetki(Object c)
        {
            if (controlList[c] == null)
            {
                return string.Empty;
            }
            return controlList[c].ToString();
        }
        public void SetMenuYetki(Object c, string value)
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

        public void MenuYetkiUpdate(DSSystem.UDF_UserMenuDataTable _yetkiList)
        {
            if (OnMenuYetkiBegin != null)
            {
                OnMenuYetkiBegin(this, EventArgs.Empty);
            }

            DoEnable(_yetkiList);

            if (OnMenuYetkiFinish != null)
            {
                OnMenuYetkiFinish(this, EventArgs.Empty);
            }
        }


        private void DoEnable(DSSystem.UDF_UserMenuDataTable kullaniciMenu)
        {

            foreach (DictionaryEntry ctrl in controlList)
            {
                var row = kullaniciMenu.Where(p => p.ID == Convert.ToInt32(ctrl.Value.ToString())).FirstOrDefault();
                if (row == null)
                {
                    if (ctrl.Key is BarSubItem) (ctrl.Key as BarSubItem).Visibility = BarItemVisibility.Never;
                    else if (ctrl.Key is BarButtonItem) (ctrl.Key as BarButtonItem).Visibility = BarItemVisibility.Never;
                    else if (ctrl.Key is RibbonPage) (ctrl.Key as RibbonPage).Visible = false;
                    else if (ctrl.Key is RibbonPageGroup) (ctrl.Key as RibbonPageGroup).Visible = false;
                }
                else
                {
                    if (row.MenuIsAkif == true && row.UserIsAktif == true)
                    {
                        if (ctrl.Key is BarSubItem) (ctrl.Key as BarSubItem).Visibility = BarItemVisibility.Always;
                        else if (ctrl.Key is BarButtonItem) (ctrl.Key as BarButtonItem).Visibility = BarItemVisibility.Always;
                        else if (ctrl.Key is RibbonPage) (ctrl.Key as RibbonPage).Visible = true;
                        else if (ctrl.Key is RibbonPageGroup) (ctrl.Key as RibbonPageGroup).Visible = true;
                    }
                    else
                    {
                        if (ctrl.Key is BarSubItem) (ctrl.Key as BarSubItem).Visibility = BarItemVisibility.Never;
                        else if (ctrl.Key is BarButtonItem) (ctrl.Key as BarButtonItem).Visibility = BarItemVisibility.Never;
                        else if (ctrl.Key is RibbonPage) (ctrl.Key as RibbonPage).Visible = false;
                        else if (ctrl.Key is RibbonPageGroup) (ctrl.Key as RibbonPageGroup).Visible = false;
                    }
                }




            }

        }

    }
}