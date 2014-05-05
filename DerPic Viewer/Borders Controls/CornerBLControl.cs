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
        private void CornerBL_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void CornerBL_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void CornerBL_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void CornerBL_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeNESW;
        }

        private void CornerBL_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}
