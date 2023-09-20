using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;

namespace MS.Globals
{
    public class UserLayoutGlobal
    {
        private static UserLayoutGlobal _instanceLayout = new UserLayoutGlobal();
        public static UserLayoutGlobal InstanceLayout
        {
            get { return _instanceLayout; }
            set { _instanceLayout=value; }
        }

        private UserLayout _layout;
        public UserLayout CurrentLayout
        {
            get { return _layout; }
            set {_layout = value; }
        }

    }

    


    public class ShortcutGlobal
    {
        private static ShortcutGlobal _instanceShortcut = new ShortcutGlobal();
        public static ShortcutGlobal InstanceShortcut
        {
            get { return _instanceShortcut; }
            set { _instanceShortcut = value; }
        }

        private Shortcuts _Shortcut;
        public Shortcuts CurrentShortcut
        {
            get { return _Shortcut; }
            set { _Shortcut = value; }
        }

    }






}
