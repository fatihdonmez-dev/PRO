using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRO.Global
{

    #region UserControlDataGuncellendi

    public delegate void UserControlDataGuncellendiDelegate(object sender, UserControlDataGuncellendiEventArgs e);

    public class UserControlDataGuncellendiEventArgs : EventArgs
    {
        public decimal aToplam { get; private set; }
        public decimal bToplam { get; private set; }

        public UserControlDataGuncellendiEventArgs(decimal AToplam, decimal BToplam)
        {
            this.aToplam = AToplam;
            this.bToplam = BToplam;
        }
    }

    #endregion


}
