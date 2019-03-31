using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinishLine.Core;
namespace FinishLine
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            MainViewModel _mainVievModel = new MainViewModel();
        }

        private void chbID_CheckedChanged(object sender, EventArgs e)
        {
            if (chbID.Checked == true)
            {
                lbID.Visible = true;
                nupdID.Visible = true;
            }
            else
            {
                lbID.Visible = false;
                nupdID.Visible = false;
            }
        }
    }
}
