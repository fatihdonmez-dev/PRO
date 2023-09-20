using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace PRO.Control
{
    public partial class frmProperty : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmProperty()
        {
            InitializeComponent();
        }

        private void frmProperty_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}