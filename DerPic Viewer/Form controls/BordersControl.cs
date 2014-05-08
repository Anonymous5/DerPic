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
	enum SelectedBorder
	{
		N, P, L, R, T, B, TL, TR, BL, BR
	}

	public partial class ViewerForm : Form
	{
		const int borderW = 6;
		const int upperPanelH = 16;
		SelectedBorder selectedBorder;
		int startMouseX;
		int startMouseY;
		int startSizeW;
		int startSizeH;
		int startLocX;
		int startLocY;
		int deltaSizeW;
		int deltaSizeH;
		int deltaLocX;
		int deltaLocY;
		bool WindMove;
		bool resizeL;
		bool resizeR;
		bool resizeT;
		bool resizeB;
		bool Maximized;

		private void ViewerForm_MouseDown(object sender, MouseEventArgs e)
		{
			startMouseX = Cursor.Position.X;
			startMouseY = Cursor.Position.Y;
			startSizeW = Size.Width;
			startSizeH = Size.Height;
			startLocX = Location.X;
			startLocY = Location.Y;
			Maximized = WindowState == FormWindowState.Maximized;
			switch (selectedBorder)
			{
				case SelectedBorder.P:
					WindMove = true;
					break;
				case SelectedBorder.L:
					resizeL = true;
					break;
				case SelectedBorder.R:
					resizeR = true;
					break;
				case SelectedBorder.T:
					resizeT = true;
					break;
				case SelectedBorder.B:
					resizeB = true;
					break;
				case SelectedBorder.TL:
					resizeT = true;
					resizeL = true;
					break;
				case SelectedBorder.TR:
					resizeT = true;
					resizeR = true;
					break;
				case SelectedBorder.BL:
					resizeB = true;
					resizeL = true;
					break;
				case SelectedBorder.BR:
					resizeB = true;
					resizeR = true;
					break;
			}
		}

		private void ViewerForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (WindMove)
			{
				if (Maximized)
				{
					var dx = (float)(startMouseX) / (startSizeW);
					var dy = (float)(startMouseY) / (upperPanelH + 2 * borderW);
					WindowState = FormWindowState.Normal;
					ButtonExpander.Image = Properties.Resources.buttonMaximize;
					Location = new Point((int)(Cursor.Position.X - dx * Size.Width),
						(int)(Cursor.Position.Y - dy * (upperPanelH + 2 * borderW)));
				}
				else
					Location = new Point(Cursor.Position.X + startLocX - startMouseX,
						Cursor.Position.Y + startLocY - startMouseY);
			}

			deltaSizeW = 0;
			deltaSizeH = 0;
			deltaLocX = 0;
			deltaLocY = 0;

			if (resizeR)
				deltaSizeW = Cursor.Position.X - startMouseX;

			if (resizeB)
				deltaSizeH = Cursor.Position.Y - startMouseY;

			if (resizeL)
			{
				deltaSizeW = startMouseX - Cursor.Position.X;
				deltaLocX = deltaSizeW;
			}

			if (resizeT)
			{
				deltaSizeH = startMouseY - Cursor.Position.Y;
				deltaLocY = deltaSizeH;
			}

			if (resizeR || resizeB || resizeL || resizeT)
				Size = new Size(startSizeW + deltaSizeW, startSizeH + deltaSizeH);
			if (resizeL || resizeT)
			{
				if (!resizeR && startSizeW + deltaSizeW < MinimumSize.Width)
					deltaLocX = MinimumSize.Width - startSizeW;
				if (!resizeB && startSizeH + deltaSizeH < MinimumSize.Height)
					deltaLocY = MinimumSize.Height - startSizeH;
				Location = new Point(startLocX - deltaLocX, startLocY - deltaLocY);
			}

			if (resizeR || resizeB || resizeL || resizeT)
				this.Update();

			selectedBorder = SelectedBorder.N;
			if (WindowState == FormWindowState.Maximized)
			{
				if (e.Y < 2 * borderW + upperPanelH)
				{
					selectedBorder = SelectedBorder.P;
				}
			}
			else
			{
				if (e.X >= borderW &&
					e.X < Size.Width - borderW &&
					e.Y >= borderW &&
					e.Y < Size.Height - borderW)
				{
					if (e.Y < 2 * borderW + upperPanelH)
						selectedBorder = SelectedBorder.P;
				}
				else
				{
					selectedBorder = SelectedBorder.R;
					if (e.X < borderW)
						selectedBorder = SelectedBorder.L;
					if (e.Y < 2 * borderW)
					{
						selectedBorder = SelectedBorder.T;
						if (e.X < 2 * borderW)
							selectedBorder = SelectedBorder.TL;
						if (e.X >= Size.Width - 2 * borderW)
							selectedBorder = SelectedBorder.TR;
					}
					if (e.Y >= Size.Height - 2 * borderW)
					{
						selectedBorder = SelectedBorder.B;
						if (e.X < 2 * borderW)
							selectedBorder = SelectedBorder.BL;
						if (e.X >= Size.Width - 2 * borderW)
							selectedBorder = SelectedBorder.BR;
					}
				}
			}
			if (selectedBorder == SelectedBorder.N || selectedBorder == SelectedBorder.P)
				Cursor = Cursors.Arrow;
			if (selectedBorder == SelectedBorder.L || selectedBorder == SelectedBorder.R)
				Cursor = Cursors.SizeWE;
			if (selectedBorder == SelectedBorder.T || selectedBorder == SelectedBorder.B)
				Cursor = Cursors.SizeNS;
			if (selectedBorder == SelectedBorder.TL || selectedBorder == SelectedBorder.BR)
				Cursor = Cursors.SizeNWSE;
			if (selectedBorder == SelectedBorder.BL || selectedBorder == SelectedBorder.TR)
				Cursor = Cursors.SizeNESW;
		}

		private void ViewerForm_MouseUp(object sender, MouseEventArgs e)
		{
			WindMove = false;
			resizeL = false;
			resizeR = false;
			resizeT = false;
			resizeB = false;
		}

		private void ViewerForm_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (WindMove)
			{
				if (WindowState == FormWindowState.Normal)
				{
					WindowState = FormWindowState.Maximized;
					ButtonExpander.Image = Properties.Resources.buttonNormalize;
				}
				else
				{
					WindowState = FormWindowState.Normal;
					ButtonExpander.Image = Properties.Resources.buttonMaximize;
				}
			}
		}
	}
}
