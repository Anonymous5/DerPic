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
        private void CornerTR_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void CornerTR_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void CornerTR_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void CornerTR_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeNESW;
        }

        private void CornerTR_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}
