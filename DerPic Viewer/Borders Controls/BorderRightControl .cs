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
        private void BorderRight_MouseDown(object sender, MouseEventArgs e)
        {
            scaling = true;
            xPos = Cursor.Position.X;
            wSize = Size.Width;
        }

        private void BorderRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (scaling)
                Size = new Size(wSize + (Cursor.Position.X - xPos), Size.Height);
        }

        private void BorderRight_MouseUp(object sender, MouseEventArgs e)
        {
            scaling = false;
        }

        private void BorderRight_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeWE;
        }

        private void BorderRight_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}
