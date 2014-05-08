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
		private void ButtonMinimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void ButtonMinimize_MouseEnter(object sender, EventArgs e)
		{
			ButtonMinimize.Image = Properties.Resources.buttonMinimizeS;
			Cursor = Cursors.Arrow;
		}

		private void ButtonMinimize_MouseLeave(object sender, EventArgs e)
		{
			ButtonMinimize.Image = Properties.Resources.buttonMinimize;
		}

		private void ButtonExpander_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				WindowState = FormWindowState.Maximized;
			else
				WindowState = FormWindowState.Normal;
		}

		private void ButtonExpander_MouseEnter(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				ButtonExpander.Image = Properties.Resources.buttonMaximizeS;
			else
				ButtonExpander.Image = Properties.Resources.buttonNormalizeS;
			Cursor = Cursors.Arrow;
		}

		private void ButtonExpander_MouseLeave(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
				ButtonExpander.Image = Properties.Resources.buttonMaximize;
			else
				ButtonExpander.Image = Properties.Resources.buttonNormalize;
		}

		private void ButtonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonClose_MouseEnter(object sender, EventArgs e)
		{
			ButtonClose.Image = Properties.Resources.buttonCloseS;
			Cursor = Cursors.Arrow;
		}

		private void ButtonClose_MouseLeave(object sender, EventArgs e)
		{
			ButtonClose.Image = Properties.Resources.buttonClose;
		}
    }
}
