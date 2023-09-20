using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using PRO.Data;

namespace MS.Globals
{
    public class UserLayout
    {
        public DSSystem.SYS_LayoutDataTable _Layout;

        private UserLayout() { }
        public UserLayout(DSSystem.SYS_LayoutDataTable layoutTable)
        {
            //_Layout=new DSSystem.SYS_LayoutDataTable();
            try
            {
                this._Layout = (DSSystem.SYS_LayoutDataTable)layoutTable.Copy();
            }
            catch(Exception)
            {

            }
        }
    }


   

    public class Shortcuts
    {
        public DSSystem.SYS_ShortcutUserDataTable _Shortcut;

        private Shortcuts() { }
        public Shortcuts(DSSystem.SYS_ShortcutUserDataTable shortcut)
        {
            try
            {
                this._Shortcut = (DSSystem.SYS_ShortcutUserDataTable)shortcut.Copy();
            }
            catch (Exception)
            {

            }
        }

    }




}
