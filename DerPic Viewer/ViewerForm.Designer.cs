namespace DerPic_Viewer
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
			this.ButtonMinimize = new System.Windows.Forms.PictureBox();
			this.ButtonExpander = new System.Windows.Forms.PictureBox();
			this.ButtonClose = new System.Windows.Forms.PictureBox();
			this.labelViewer = new System.Windows.Forms.Label();
			this.pictureBoxView = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonExpander)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonMinimize
			// 
			this.ButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
			this.ButtonMinimize.ErrorImage = null;
			this.ButtonMinimize.Image = global::DerPic_Viewer.Properties.Resources.buttonMinimize;
			this.ButtonMinimize.InitialImage = null;
			this.ButtonMinimize.Location = new System.Drawing.Point(746, 6);
			this.ButtonMinimize.Name = "ButtonMinimize";
			this.ButtonMinimize.Size = new System.Drawing.Size(16, 16);
			this.ButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ButtonMinimize.TabIndex = 4;
			this.ButtonMinimize.TabStop = false;
			this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
			this.ButtonMinimize.MouseEnter += new System.EventHandler(this.ButtonMinimize_MouseEnter);
			this.ButtonMinimize.MouseLeave += new System.EventHandler(this.ButtonMinimize_MouseLeave);
			// 
			// ButtonExpander
			// 
			this.ButtonExpander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonExpander.BackColor = System.Drawing.Color.Transparent;
			this.ButtonExpander.ErrorImage = null;
			this.ButtonExpander.Image = global::DerPic_Viewer.Properties.Resources.buttonMaximize;
			this.ButtonExpander.InitialImage = null;
			this.ButtonExpander.Location = new System.Drawing.Point(762, 6);
			this.ButtonExpander.Name = "ButtonExpander";
			this.ButtonExpander.Size = new System.Drawing.Size(16, 16);
			this.ButtonExpander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ButtonExpander.TabIndex = 5;
			this.ButtonExpander.TabStop = false;
			this.ButtonExpander.Click += new System.EventHandler(this.ButtonExpander_Click);
			this.ButtonExpander.MouseEnter += new System.EventHandler(this.ButtonExpander_MouseEnter);
			this.ButtonExpander.MouseLeave += new System.EventHandler(this.ButtonExpander_MouseLeave);
			// 
			// ButtonClose
			// 
			this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
			this.ButtonClose.ErrorImage = null;
			this.ButtonClose.Image = global::DerPic_Viewer.Properties.Resources.buttonClose;
			this.ButtonClose.InitialImage = null;
			this.ButtonClose.Location = new System.Drawing.Point(778, 6);
			this.ButtonClose.Name = "ButtonClose";
			this.ButtonClose.Size = new System.Drawing.Size(16, 16);
			this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ButtonClose.TabIndex = 2;
			this.ButtonClose.TabStop = false;
			this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
			this.ButtonClose.MouseEnter += new System.EventHandler(this.ButtonClose_MouseEnter);
			this.ButtonClose.MouseLeave += new System.EventHandler(this.ButtonClose_MouseLeave);
			// 
			// labelViewer
			// 
			this.labelViewer.AutoSize = true;
			this.labelViewer.BackColor = System.Drawing.Color.Transparent;
			this.labelViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelViewer.ForeColor = System.Drawing.Color.Silver;
			this.labelViewer.Location = new System.Drawing.Point(6, 6);
			this.labelViewer.Name = "labelViewer";
			this.labelViewer.Size = new System.Drawing.Size(93, 16);
			this.labelViewer.TabIndex = 4;
			this.labelViewer.Text = "DerPic Viewer";
			this.labelViewer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseDoubleClick);
			this.labelViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseDown);
			this.labelViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseMove);
			this.labelViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseUp);
			// 
			// pictureBoxView
			// 
			this.pictureBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.pictureBoxView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBoxView.ErrorImage = global::DerPic_Viewer.Properties.Resources.error;
			this.pictureBoxView.InitialImage = global::DerPic_Viewer.Properties.Resources.preloader;
			this.pictureBoxView.Location = new System.Drawing.Point(6, 28);
			this.pictureBoxView.Name = "pictureBoxView";
			this.pictureBoxView.Size = new System.Drawing.Size(788, 566);
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
			this.BackgroundImage = global::DerPic_Viewer.Properties.Resources.background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.ButtonMinimize);
			this.Controls.Add(this.ButtonExpander);
			this.Controls.Add(this.labelViewer);
			this.Controls.Add(this.ButtonClose);
			this.Controls.Add(this.pictureBoxView);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "ViewerForm";
			this.Text = "DerPic Viewer";
			this.Load += new System.EventHandler(this.ViewerForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewerForm_Paint);
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseDoubleClick);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewerForm_MouseUp);
			this.Resize += new System.EventHandler(this.ViewerForm_Resize);
			((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonExpander)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxView;
		private System.Windows.Forms.PictureBox ButtonClose;
		private System.Windows.Forms.PictureBox ButtonMinimize;
		private System.Windows.Forms.PictureBox ButtonExpander;
		private System.Windows.Forms.Label labelViewer;
	}
}

