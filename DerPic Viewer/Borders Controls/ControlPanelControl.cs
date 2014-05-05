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
        private void ControlPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                ButtonExpander.Image = Properties.Resources.buttonNormalize;
                return;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                ButtonExpander.Image = Properties.Resources.buttonMaximize;
            }
        }

        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            draggingW = true;
            xPos = Cursor.Position.X;
            yPos = Cursor.Position.Y;
        }

        private void ControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggingW)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    var dx = (float)e.X / ControlPanel.Size.Width;
                    var dy = (float)e.Y / ControlPanel.Size.Height;
                    WindowState = FormWindowState.Normal;
                    Location = new Point(Cursor.Position.X - (int)(ControlPanel.Size.Width * dx),
                        Cursor.Position.Y - (int)(ControlPanel.Size.Height * dy));
                }

                Location = new Point(Cursor.Position.X + Location.X - xPos, Cursor.Position.Y + Location.Y - yPos);
                xPos = Cursor.Position.X;
                yPos = Cursor.Position.Y;
            }
        }

        private void ControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            draggingW = false;
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonMinimize_MouseEnter(object sender, EventArgs e)
        {
            ButtonMinimize.Image = Properties.Resources.buttonMinimizeS;
        }

        private void ButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            ButtonMinimize.Image = Properties.Resources.buttonMinimize;
        }

        private void ButtonExpander_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                return;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void ButtonExpander_MouseEnter(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                ButtonExpander.Image = Properties.Resources.buttonMaximizeS;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                ButtonExpander.Image = Properties.Resources.buttonNormalizeS;
            }
        }

        private void ButtonExpander_MouseLeave(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                ButtonExpander.Image = Properties.Resources.buttonMaximize;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                ButtonExpander.Image = Properties.Resources.buttonNormalize;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonClose_MouseEnter(object sender, EventArgs e)
        {
            ButtonClose.Image = Properties.Resources.buttonCloseS;
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            ButtonClose.Image = Properties.Resources.buttonClose;
        }
    }
}
