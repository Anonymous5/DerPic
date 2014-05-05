namespace DerPic
{
	partial class ViewerForm
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelViewer = new System.Windows.Forms.Label();
			this.pictureBoxWidth = new System.Windows.Forms.PictureBox();
			this.pictureBoxHeight = new System.Windows.Forms.PictureBox();
			this.pictureBoxCorner = new System.Windows.Forms.PictureBox();
			this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
			this.pictureBoxExpander = new System.Windows.Forms.PictureBox();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.pictureBoxView = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorner)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpander)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.pictureBoxMinimize);
			this.panel1.Controls.Add(this.labelViewer);
			this.panel1.Controls.Add(this.pictureBoxExpander);
			this.panel1.Controls.Add(this.pictureBoxClose);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 24);
			this.panel1.TabIndex = 3;
			this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
			// 
			// labelViewer
			// 
			this.labelViewer.AutoSize = true;
			this.labelViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelViewer.ForeColor = System.Drawing.Color.Silver;
			this.labelViewer.Location = new System.Drawing.Point(23, 4);
			this.labelViewer.Name = "labelViewer";
			this.labelViewer.Size = new System.Drawing.Size(93, 16);
			this.labelViewer.TabIndex = 4;
			this.labelViewer.Text = "DerPic Viewer";
			// 
			// pictureBoxWidth
			// 
			this.pictureBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureBoxWidth.ErrorImage = null;
			this.pictureBoxWidth.InitialImage = null;
			this.pictureBoxWidth.Location = new System.Drawing.Point(788, 24);
			this.pictureBoxWidth.Name = "pictureBoxWidth";
			this.pictureBoxWidth.Size = new System.Drawing.Size(12, 564);
			this.pictureBoxWidth.TabIndex = 4;
			this.pictureBoxWidth.TabStop = false;
			this.pictureBoxWidth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWidth_MouseDown);
			this.pictureBoxWidth.MouseEnter += new System.EventHandler(this.pictureBoxWidth_MouseEnter);
			this.pictureBoxWidth.MouseLeave += new System.EventHandler(this.pictureBoxWidth_MouseLeave);
			this.pictureBoxWidth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWidth_MouseMove);
			this.pictureBoxWidth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWidth_MouseUp);
			// 
			// pictureBoxHeight
			// 
			this.pictureBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureBoxHeight.ErrorImage = null;
			this.pictureBoxHeight.InitialImage = null;
			this.pictureBoxHeight.Location = new System.Drawing.Point(0, 588);
			this.pictureBoxHeight.Name = "pictureBoxHeight";
			this.pictureBoxHeight.Size = new System.Drawing.Size(788, 12);
			this.pictureBoxHeight.TabIndex = 5;
			this.pictureBoxHeight.TabStop = false;
			this.pictureBoxHeight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHeight_MouseDown);
			this.pictureBoxHeight.MouseEnter += new System.EventHandler(this.pictureBoxHeight_MouseEnter);
			this.pictureBoxHeight.MouseLeave += new System.EventHandler(this.pictureBoxHeight_MouseLeave);
			this.pictureBoxHeight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHeight_MouseMove);
			this.pictureBoxHeight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHeight_MouseUp);
			// 
			// pictureBoxCorner
			// 
			this.pictureBoxCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxCorner.ErrorImage = null;
			this.pictureBoxCorner.Image = global::DerPic.Resources.corner;
			this.pictureBoxCorner.InitialImage = null;
			this.pictureBoxCorner.Location = new System.Drawing.Point(788, 588);
			this.pictureBoxCorner.Name = "pictureBoxCorner";
			this.pictureBoxCorner.Size = new System.Drawing.Size(12, 12);
			this.pictureBoxCorner.TabIndex = 6;
			this.pictureBoxCorner.TabStop = false;
			this.pictureBoxCorner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCorner_MouseDown);
			this.pictureBoxCorner.MouseEnter += new System.EventHandler(this.pictureBoxCorner_MouseEnter);
			this.pictureBoxCorner.MouseLeave += new System.EventHandler(this.pictureBoxCorner_MouseLeave);
			this.pictureBoxCorner.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCorner_MouseMove);
			this.pictureBoxCorner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCorner_MouseUp);
			// 
			// pictureBoxMinimize
			// 
			this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxMinimize.ErrorImage = null;
			this.pictureBoxMinimize.Image = global::DerPic.Resources.buttonMinimize;
			this.pictureBoxMinimize.InitialImage = null;
			this.pictureBoxMinimize.Location = new System.Drawing.Point(748, 4);
			this.pictureBoxMinimize.Name = "pictureBoxMinimize";
			this.pictureBoxMinimize.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxMinimize.TabIndex = 4;
			this.pictureBoxMinimize.TabStop = false;
			this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
			this.pictureBoxMinimize.MouseEnter += new System.EventHandler(this.pictureBoxMinimize_MouseEnter);
			this.pictureBoxMinimize.MouseLeave += new System.EventHandler(this.pictureBoxMinimize_MouseLeave);
			// 
			// pictureBoxExpander
			// 
			this.pictureBoxExpander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxExpander.ErrorImage = null;
			this.pictureBoxExpander.Image = global::DerPic.Resources.buttonMaximize;
			this.pictureBoxExpander.InitialImage = null;
			this.pictureBoxExpander.Location = new System.Drawing.Point(764, 4);
			this.pictureBoxExpander.Name = "pictureBoxExpander";
			this.pictureBoxExpander.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxExpander.TabIndex = 5;
			this.pictureBoxExpander.TabStop = false;
			this.pictureBoxExpander.Click += new System.EventHandler(this.pictureBoxExpander_Click);
			this.pictureBoxExpander.MouseEnter += new System.EventHandler(this.pictureBoxExpander_MouseEnter);
			this.pictureBoxExpander.MouseLeave += new System.EventHandler(this.pictureBoxExpander_MouseLeave);
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxClose.ErrorImage = null;
			this.pictureBoxClose.Image = global::DerPic.Resources.buttonClose;
			this.pictureBoxClose.InitialImage = null;
			this.pictureBoxClose.Location = new System.Drawing.Point(780, 4);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(16, 16);
			this.pictureBoxClose.TabIndex = 2;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			this.pictureBoxClose.MouseEnter += new System.EventHandler(this.pictureBoxClose_MouseEnter);
			this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
			// 
			// pictureBoxView
			// 
			this.pictureBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.pictureBoxView.ErrorImage = global::DerPic.Resources.error;
			this.pictureBoxView.InitialImage = global::DerPic.Resources.preloader;
			this.pictureBoxView.Location = new System.Drawing.Point(12, 24);
			this.pictureBoxView.Name = "pictureBoxView";
			this.pictureBoxView.Size = new System.Drawing.Size(776, 564);
			this.pictureBoxView.TabIndex = 0;
			this.pictureBoxView.TabStop = false;
			this.pictureBoxView.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBoxView_LoadCompleted);
			this.pictureBoxView.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxView_Paint);
			this.pictureBoxView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxView_MouseDoubleClick);
			this.pictureBoxView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxView_MouseDown);
			this.pictureBoxView.MouseEnter += new System.EventHandler(this.pictureBoxView_MouseEnter);
			this.pictureBoxView.MouseLeave += new System.EventHandler(this.pictureBoxView_MouseLeave);
			this.pictureBoxView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxView_MouseMove);
			this.pictureBoxView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxView_MouseUp);
			this.pictureBoxView.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBoxView_MouseWheel);
			this.pictureBoxView.Resize += new System.EventHandler(this.pictureBoxView_Resize);
			// 
			// ViewerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.pictureBoxCorner);
			this.Controls.Add(this.pictureBoxHeight);
			this.Controls.Add(this.pictureBoxWidth);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBoxView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(200, 150);
			this.Name = "ViewerForm";
			this.Text = "RePic";
			this.Load += new System.EventHandler(this.ViewerForm_Load);
			this.Resize += new System.EventHandler(this.ViewerForm_Resize);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorner)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpander)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxView;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBoxMinimize;
		private System.Windows.Forms.PictureBox pictureBoxExpander;
		private System.Windows.Forms.Label labelViewer;
		private System.Windows.Forms.PictureBox pictureBoxWidth;
		private System.Windows.Forms.PictureBox pictureBoxHeight;
		private System.Windows.Forms.PictureBox pictureBoxCorner;
	}
}

