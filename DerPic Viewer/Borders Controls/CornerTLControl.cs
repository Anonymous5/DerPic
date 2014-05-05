using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DerPic_Viewer
{
    public partial class ViewerForm : Form
    {
        private void CornerTL_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void CornerTL_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void CornerTL_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void CornerTL_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeNWSE;
        }

        private void CornerTL_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}
