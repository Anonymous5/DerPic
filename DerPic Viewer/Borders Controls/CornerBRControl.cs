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
        private void CornerBR_MouseDown(object sender, MouseEventArgs e)
        {
            scaling = true;
            xPos = Cursor.Position.X;
            wSize = Size.Width;
            yPos = Cursor.Position.Y;
            hSize = Size.Height;
        }

        private void CornerBR_MouseMove(object sender, MouseEventArgs e)
        {
            if (scaling)
                Size = new Size(wSize + (Cursor.Position.X - xPos), hSize + (Cursor.Position.Y - yPos));
        }

        private void CornerBR_MouseUp(object sender, MouseEventArgs e)
        {
            scaling = false;
            scaling = false;
        }

        private void CornerBR_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeNWSE;
        }

        private void CornerBR_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}
