using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraLayout;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList.Columns;
using PRO.Global;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRO.Control
{
     [ProvideProperty("DilKey", typeof(Object))]

    public partial class Localizer : Component,IExtenderProvider
    {

        #region Members

        private Hashtable controlList;
        public event EventHandler OnTranslateBegin;
        public event EventHandler OnTranslateFinish;

        #endregion

        #region IExtenderProvider Members

        public bool CanExtend(object extendee)
        {
            if (extendee is Localizer)
                return false;

            return
                (extendee is Object);
        }

        #endregion

        [Category("PRO Properties")]
        [DefaultValue("")]
        public string GetDilKey(Object c)
        {
            if (controlList[c] == null)
            {
                return string.Empty;
            }
            return controlList[c].ToString();
        }

        public void SetDilKey(Object c, string value)
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

        public Localizer()
        {
            controlList = new Hashtable();
        }

        public void TranslateControls(string parameter)
        {
            if (OnTranslateBegin != null)
            {
                OnTranslateBegin(this, EventArgs.Empty);
            }

            DoTranslate(parameter);

            if (OnTranslateFinish != null)
            {
                OnTranslateFinish(this, EventArgs.Empty);
            }
        }


        private void DoTranslate(string parameter)
        {

            foreach (DictionaryEntry ctrl in controlList)
            {

                string translatedText = Translate(ctrl.Value.ToString(), parameter);

                if (ctrl.Key is LabelControl) (ctrl.Key as LabelControl).Text = translatedText;
                else if (ctrl.Key is SimpleButton) (ctrl.Key as SimpleButton).Text = translatedText;
                else if (ctrl.Key is GridColumn) (ctrl.Key as GridColumn).Caption = translatedText;
                else if (ctrl.Key is TreeListColumn) (ctrl.Key as TreeListColumn).Caption = translatedText;
                else if (ctrl.Key is GroupControl) (ctrl.Key as GroupControl).Text = translatedText;
                else if (ctrl.Key is XtraTabPage) (ctrl.Key as XtraTabPage).Text = translatedText;
                else if (ctrl.Key is Form) (ctrl.Key as Form).Text = translatedText;
                else if (ctrl.Key is BarButtonItem) (ctrl.Key as BarButtonItem).Caption = translatedText;
                else if (ctrl.Key is BarLargeButtonItem) (ctrl.Key as BarLargeButtonItem).Caption = translatedText;
                else if (ctrl.Key is BarSubItem) (ctrl.Key as BarSubItem).Caption = translatedText;
                else if (ctrl.Key is RibbonPage) (ctrl.Key as RibbonPage).Text = translatedText;
                else if (ctrl.Key is RibbonPageGroup) (ctrl.Key as RibbonPageGroup).Text = translatedText;
                else if (ctrl.Key is CheckEdit) (ctrl.Key as CheckEdit).Text = translatedText;
                else if (ctrl.Key is GridBand) (ctrl.Key as GridBand).Caption = translatedText;
                else if (ctrl.Key is BandedGridColumn) (ctrl.Key as BandedGridColumn).Caption = translatedText;
                else if (ctrl.Key is LayoutControlItem)
                {
                    (ctrl.Key as LayoutControlItem).Text = translatedText;
                    (ctrl.Key as LayoutControlItem).CustomizationFormText = translatedText;
                }

            }

        }
        public string Translate(string dilKey, string parameter)
        {
            string result = Session.Instance.CurrentCulture.Translate(dilKey);
            return result ?? "?" + dilKey;
        }



    }
}
