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
        private void BorderBottom_MouseDown(object sender, MouseEventArgs e)
        {
            scaling = true;
            yPos = Cursor.Position.Y;
            hSize = Size.Height;
        }

        private void BorderBottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (scaling)
                Size = new Size(Size.Width, hSize + (Cursor.Position.Y - yPos));
        }

        private void BorderBottom_MouseUp(object sender, MouseEventArgs e)
        {
            scaling = false;
        }

        private void BorderBottom_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void BorderBottom_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeNS;
        }
    }
}
