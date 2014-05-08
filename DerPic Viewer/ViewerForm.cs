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
using System.Windows;

namespace DerPic_Viewer
{
	public partial class ViewerForm : Form
	{
		public string ImgURL;
		Image image;
		float imgScale;
		float minScale;
		float imgOffsetX;
		float imgOffsetY;
		int xPos;
		int yPos;
		bool dragging;
		Cursor hand;
		Cursor grab;
		bool firstimage;

		public ViewerForm()
		{
            ImgURL = null;
			InitializeComponent();
		}

		void Centrize()
		{
			Location = new Point((SystemInformation.VirtualScreen.Width - Size.Width) / 2,
				(SystemInformation.VirtualScreen.Height - 40 - Size.Height) / 2);
		}

		void ShiftAfterZoom(float newScale, int mouseX, int mouseY)
		{
			var oldScale = imgScale;
			imgScale = newScale;
			float dx = ((image.Width * oldScale - pictureBoxView.Width) / 2 - imgOffsetX + mouseX) / image.Width / oldScale - 0.5f;
			float dy = ((image.Height * oldScale - pictureBoxView.Height) / 2 - imgOffsetY + mouseY) / image.Height / oldScale - 0.5f;
			imgOffsetX -= dx * image.Width * (imgScale - oldScale);
			imgOffsetY -= dy * image.Height * (imgScale - oldScale);
		}

		bool CanDrag()
		{
			return image.Width * imgScale - pictureBoxView.Width > 0.5f || 
				image.Height * imgScale - pictureBoxView.Height > 0.5f;
		}

		private void ViewerForm_Load(object sender, EventArgs e)
		{
			this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
            if (!String.IsNullOrEmpty(ImgURL))
            {
                firstimage = true;
                pictureBoxView.ImageLocation = ImgURL;
            }
            else if (Environment.GetCommandLineArgs().Length > 1)
            {
                pictureBoxView.ImageLocation = Environment.GetCommandLineArgs()[1];
            }
            else
            {
                Close();
            }
			Centrize();
			using (var memoryStream = new MemoryStream(Properties.Resources.HandCursor))
				hand = new Cursor(memoryStream);
            using (var memoryStream = new MemoryStream(Properties.Resources.GrabCursor))
				grab = new Cursor(memoryStream);
		}

		private void pictureBoxView_LoadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			image = pictureBoxView.Image;
			pictureBoxView.Image = null;
			if (firstimage)
			{
				firstimage = false;
				if (image.Width > SystemInformation.VirtualScreen.Width - 2 * borderW ||
					image.Height > SystemInformation.VirtualScreen.Height - 40 - 3 * borderW - upperPanelH)
				{
					WindowState = FormWindowState.Maximized;
					ButtonExpander.Image = Properties.Resources.buttonNormalize;
				}
				else
				{
					Size = new Size(image.Width + 2 * borderW, image.Height + 3 * borderW + upperPanelH);
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
			minScale = 1.0f;
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
            MinScale();
            imgScale = (imgScale < minScale) ? minScale : imgScale;
			e.Graphics.DrawImage(image, new Rectangle(
				(int)((pictureBoxView.Width - image.Width * imgScale) / 2 + imgOffsetX),
				(int)((pictureBoxView.Height - image.Height * imgScale) / 2 + imgOffsetY),
				(int)(image.Width * imgScale),
				(int)(image.Height * imgScale)));
			e.Graphics.DrawRectangle(new Pen(Color.Gray), 0, 0, pictureBoxView.Size.Width - 1, 
				pictureBoxView.Size.Height - 1);
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
			ShiftAfterZoom(newScale, e.X, e.Y);
			imgScale = newScale;
            if (CanDrag())
                if (dragging)
                    Cursor = grab;
                else
                    Cursor = hand;
            else
                Cursor = Cursors.Arrow;
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

		private void ViewerForm_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				pictureBoxView.Location = new Point(borderW, upperPanelH + 2 * borderW);
				pictureBoxView.Size = new Size(Size.Width - 2 * borderW, Size.Height - upperPanelH - 3 * borderW);
				ButtonClose.Location = new Point(Size.Width - borderW - ButtonClose.Size.Width, borderW);
				ButtonExpander.Location = new Point(Size.Width - borderW - 2 * ButtonExpander.Size.Width, borderW);
				ButtonMinimize.Location = new Point(Size.Width - borderW - 3 * ButtonMinimize.Size.Width, borderW);
				labelViewer.Location = new Point(borderW, borderW);
			}

			if (WindowState == FormWindowState.Maximized)
			{
				pictureBoxView.Location = new Point(0, upperPanelH + 2 * borderW);
				pictureBoxView.Size = new Size(Size.Width, Size.Height - upperPanelH - 2 * borderW);
				ButtonClose.Location = new Point(Size.Width - borderW - ButtonClose.Size.Width, borderW);
				ButtonExpander.Location = new Point(Size.Width - borderW - 2 * ButtonExpander.Size.Width, borderW);
				ButtonMinimize.Location = new Point(Size.Width - borderW - 3 * ButtonMinimize.Size.Width, borderW);
				labelViewer.Location = new Point(borderW, borderW);
			}
			//this.Update();
		}

		private void ViewerForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Gray), 0, 0, Size.Width - 1, Size.Height - 1);
		}
	}
}
