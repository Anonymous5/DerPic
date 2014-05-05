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

namespace DerPic
{
	public partial class ViewerForm : Form
	{
		public string ImgURL;
		Image image;
		float imgScale;
		float minScale;
		int imgOffsetX;
		int imgOffsetY;
		int xPos;
		int yPos;
		bool dragging;
		int xPosW;
		int yPosW;
		bool draggingW;
		Cursor hand;
		Cursor grab;
		bool scaling;
		bool firstimage;

		public ViewerForm()
		{
			InitializeComponent();
		}

		void Centrize()
		{
			Location = new Point((SystemInformation.VirtualScreen.Width - Size.Width) / 2,
				(SystemInformation.VirtualScreen.Height - Size.Height) / 2);
		}

		void ShiftAfterZoom(float newScale, int mouseX, int mouseY)
		{
			var oldScale = imgScale;
			imgScale = newScale;
			var dx = (float)((image.Width * oldScale - pictureBoxView.Width) / 2 - imgOffsetX + mouseX) / image.Width / oldScale - 0.5f;
			var dy = (float)((image.Height * oldScale - pictureBoxView.Height) / 2 - imgOffsetY + mouseY) / image.Height / oldScale - 0.5f;
			imgOffsetX -= (int)(dx * image.Width * (imgScale - oldScale));
			imgOffsetY -= (int)(dy * image.Height * (imgScale - oldScale));
		}

		bool CanDrag()
		{
			return image.Width * imgScale - pictureBoxView.Width > 0.5 || 
				image.Height * imgScale - pictureBoxView.Height > 0.5;
		}

		private void ViewerForm_Load(object sender, EventArgs e)
		{
			firstimage = true;
			pictureBoxView.ImageLocation = ImgURL;
			using (var memoryStream = new MemoryStream(Resources.HandCursor))
				hand = new Cursor(memoryStream);
			using (var memoryStream = new MemoryStream(Resources.GrabCursor))
				grab = new Cursor(memoryStream);
			Centrize();
		}

		private void pictureBoxView_LoadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			image = pictureBoxView.Image;
			pictureBoxView.Image = null;
			if (firstimage)
			{
				firstimage = false;
				if (image.Width > SystemInformation.VirtualScreen.Width - 24 ||
					image.Height > SystemInformation.VirtualScreen.Height - 36)
					WindowState = FormWindowState.Maximized;
				else
				{
					Size = new Size(image.Width + 24, image.Height + 36);
					Centrize();
				}
					
			}
			imgOffsetX = 0;
			imgOffsetY = 0;
			Centrize();
			MinScale();
			imgScale = minScale;
		}

		void MinScale()
		{
			if (image == null) return;
			minScale = 1;
			if (image.Width > pictureBoxView.Width)
				minScale = (float)pictureBoxView.Width / image.Width;
			if (image.Height * minScale > pictureBoxView.Height)
				minScale = (float)pictureBoxView.Height / image.Height;
		}

		void FixPosition()
		{
			if (image == null) return;
			var left = -(int)(pictureBoxView.Width - image.Width * imgScale) / 2;
			var right = (int)(pictureBoxView.Width - image.Width * imgScale) / 2;
			var top = -(int)(pictureBoxView.Height - image.Height * imgScale) / 2;
			var bottom = (int)(pictureBoxView.Height - image.Height * imgScale) / 2;
			if (imgOffsetX > left) imgOffsetX = left;
			if (imgOffsetY > top) imgOffsetY = top;
			if (imgOffsetX < right) imgOffsetX = right;
			if (imgOffsetY < bottom) imgOffsetY = bottom;
			if (image.Width * imgScale <= pictureBoxView.Width)
				imgOffsetX = 0;
			if (image.Height * imgScale <= pictureBoxView.Height)
				imgOffsetY = 0;
		}

		private void pictureBoxView_Paint(object sender, PaintEventArgs e)
		{
			if (image == null) return;
			FixPosition();
			e.Graphics.DrawImage(image, new Rectangle(
				(int)((pictureBoxView.Width - image.Width * imgScale) / 2 + imgOffsetX),
				(int)((pictureBoxView.Height - image.Height * imgScale) / 2 + imgOffsetY),
				(int)(image.Width * imgScale),
				(int)(image.Height * imgScale)));
		}

		private void pictureBoxView_MouseWheel(object sender, MouseEventArgs e)
		{
			var newScale = imgScale;
			if (e.Delta > 0 && imgScale < 5)
				if (imgScale >= 1)
					newScale += 0.5f;
				else
					newScale += 0.2f;
			if (e.Delta < 0)
				if (imgScale > 1)
					newScale -= 0.5f;
				else
					newScale -= 0.2f;
			newScale = (newScale < minScale) ? minScale : newScale;
			if (CanDrag())
				if (dragging)
					Cursor = grab;
				else
					Cursor = hand;
			else
				Cursor = Cursors.Arrow;
			ShiftAfterZoom(newScale, e.X, e.Y);
			imgScale = newScale;
			pictureBoxView.Invalidate();
		}

		private void pictureBoxView_MouseEnter(object sender, EventArgs e)
		{
			pictureBoxView.Select();
			if (image == null) return;
			if (CanDrag())
			{
				Cursor = hand;
			}
			else
			{
				Cursor = Cursors.Arrow;
			}
		}

		private void pictureBoxView_MouseLeave(object sender, EventArgs e)
		{
			pictureBoxView.Select();
			if (!dragging)
			{
				Cursor = Cursors.Arrow;
			}
		}

		private void pictureBoxView_Resize(object sender, EventArgs e)
		{
			MinScale();
			imgScale = (imgScale < minScale) ? minScale : imgScale;
			pictureBoxView.Invalidate();
		}

		private void pictureBoxView_MouseMove(object sender, MouseEventArgs e)
		{
			if (dragging)
			{
				imgOffsetX = e.X + imgOffsetX - xPos;
				imgOffsetY = e.Y + imgOffsetY - yPos;
				xPos = e.X;
				yPos = e.Y;
				pictureBoxView.Invalidate();
			}
		}

		private void pictureBoxView_MouseDown(object sender, MouseEventArgs e)
		{
			if (CanDrag())
			{
				dragging = true;
				xPos = e.X;
				yPos = e.Y;
				Cursor = grab;
			}
		}

		private void pictureBoxView_MouseUp(object sender, MouseEventArgs e)
		{
			dragging = false;
			if (CanDrag())
				Cursor = hand;
			else
				Cursor = Cursors.Arrow;
		}

		private void pictureBoxView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (Math.Abs(imgScale - minScale) < 0.1)
			{
				ShiftAfterZoom(1, e.X, e.Y);
				imgScale = 1;
			}
			else
				imgScale = minScale;
			pictureBoxView.Invalidate();
		}
		
		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pictureBoxClose_MouseEnter(object sender, EventArgs e)
		{
			pictureBoxClose.Image = Resources.buttonCloseS;
		}

		private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
		{
			pictureBoxClose.Image = Resources.buttonClose;
		}

		private void pictureBoxExpander_Click(object sender, EventArgs e)
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

		private void pictureBoxExpander_MouseEnter(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				pictureBoxExpander.Image = Resources.buttonMaximizeS;
			}
			if (WindowState == FormWindowState.Maximized)
			{
				pictureBoxExpander.Image = Resources.buttonNormalizeS;
			}
		}

		private void pictureBoxExpander_MouseLeave(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				pictureBoxExpander.Image = Resources.buttonMaximize;
			}
			if (WindowState == FormWindowState.Maximized)
			{
				pictureBoxExpander.Image = Resources.buttonNormalize;
			}
		}

		private void pictureBoxMinimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void pictureBoxMinimize_MouseEnter(object sender, EventArgs e)
		{
			pictureBoxMinimize.Image = Resources.buttonMinimizeS;
		}

		private void pictureBoxMinimize_MouseLeave(object sender, EventArgs e)
		{
			pictureBoxMinimize.Image = Resources.buttonMinimize;
		}

		private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;
				pictureBoxExpander.Image = Resources.buttonNormalize;
				return;
			}
			if (WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
				pictureBoxExpander.Image = Resources.buttonMaximize;
			}
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			draggingW = true;
			xPosW = Cursor.Position.X;
			yPosW = Cursor.Position.Y;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (draggingW)
			{
				if (WindowState == FormWindowState.Maximized)
				{
					var dx = (float)e.X / panel1.Size.Width;
					var dy = (float)e.Y / panel1.Size.Height;
					WindowState = FormWindowState.Normal;
					Location = new Point(Cursor.Position.X - (int)(panel1.Size.Width * dx),
						Cursor.Position.Y - (int)(panel1.Size.Height * dy));
				}
				
				Location = new Point(Cursor.Position.X + Location.X - xPosW, Cursor.Position.Y + Location.Y - yPosW);
				xPosW = Cursor.Position.X;
				yPosW = Cursor.Position.Y;
			}
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			draggingW = false;
		}

		private void pictureBoxCorner_MouseEnter(object sender, EventArgs e)
		{
			Cursor = Cursors.SizeNWSE;
			pictureBoxCorner.Image = Resources.cornerS;
		}

		private void pictureBoxCorner_MouseLeave(object sender, EventArgs e)
		{
			Cursor = Cursors.Arrow;
			pictureBoxCorner.Image = Resources.corner;
		}

		private void pictureBoxWidth_MouseEnter(object sender, EventArgs e)
		{
			Cursor = Cursors.SizeWE;
		}

		private void pictureBoxWidth_MouseLeave(object sender, EventArgs e)
		{
			Cursor = Cursors.Arrow;
		}

		private void pictureBoxHeight_MouseLeave(object sender, EventArgs e)
		{
			Cursor = Cursors.Arrow;
		}

		private void pictureBoxHeight_MouseEnter(object sender, EventArgs e)
		{
			Cursor = Cursors.SizeNS;
		}

		private void pictureBoxWidth_MouseDown(object sender, MouseEventArgs e)
		{
			scaling = true;
		}

		private void pictureBoxWidth_MouseMove(object sender, MouseEventArgs e)
		{
			if (scaling)
				Size = new Size(Cursor.Position.X - Location.X + 6, Size.Height);
		}

		private void pictureBoxWidth_MouseUp(object sender, MouseEventArgs e)
		{
			scaling = false;
		}

		private void pictureBoxHeight_MouseDown(object sender, MouseEventArgs e)
		{
			scaling = true;
		}

		private void pictureBoxHeight_MouseMove(object sender, MouseEventArgs e)
		{
			if (scaling)
				Size = new Size(Size.Width, Cursor.Position.Y - Location.Y + 6);
		}

		private void pictureBoxHeight_MouseUp(object sender, MouseEventArgs e)
		{
			scaling = false;
		}

		private void ViewerForm_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				pictureBoxView.Location = new Point(12, 24);
				pictureBoxView.Size = new Size(Size.Width - 24, Size.Height - 36);
				pictureBoxWidth.Visible = true;
				pictureBoxHeight.Visible = true;
				pictureBoxCorner.Visible = true;
			}
			if (WindowState == FormWindowState.Maximized)
			{
				pictureBoxView.Location = new Point(0, 24);
				pictureBoxView.Size = new Size(Size.Width, Size.Height - 24);
				pictureBoxWidth.Visible = false;
				pictureBoxHeight.Visible = false;
				pictureBoxCorner.Visible = false;
			}
		}

		private void pictureBoxCorner_MouseDown(object sender, MouseEventArgs e)
		{
			scaling = true;
			scaling = true;
		}

		private void pictureBoxCorner_MouseMove(object sender, MouseEventArgs e)
		{
			if (scaling)
			{
				Size = new Size(Size.Width, Cursor.Position.Y - Location.Y + 6);
				Size = new Size(Cursor.Position.X - Location.X + 6, Size.Height);
			}
		}

		private void pictureBoxCorner_MouseUp(object sender, MouseEventArgs e)
		{
			scaling = false;
			scaling = false;
		}
	}
}
