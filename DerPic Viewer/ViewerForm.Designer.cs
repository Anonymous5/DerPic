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
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.PictureBox();
            this.labelViewer = new System.Windows.Forms.Label();
            this.ButtonExpander = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.BorderRight = new System.Windows.Forms.PictureBox();
            this.BorderBottom = new System.Windows.Forms.PictureBox();
            this.CornerBR = new System.Windows.Forms.PictureBox();
            this.BorderLeft = new System.Windows.Forms.PictureBox();
            this.BorderTop = new System.Windows.Forms.PictureBox();
            this.CornerBL = new System.Windows.Forms.PictureBox();
            this.CornerTL = new System.Windows.Forms.PictureBox();
            this.CornerTR = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExpander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.Controls.Add(this.ButtonMinimize);
            this.ControlPanel.Controls.Add(this.labelViewer);
            this.ControlPanel.Controls.Add(this.ButtonExpander);
            this.ControlPanel.Controls.Add(this.ButtonClose);
            this.ControlPanel.Location = new System.Drawing.Point(6, 6);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(788, 30);
            this.ControlPanel.TabIndex = 3;
            this.ControlPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDoubleClick);
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimize.ErrorImage = null;
            this.ButtonMinimize.Image = global::DerPic_Viewer.Properties.Resources.buttonMinimize;
            this.ButtonMinimize.InitialImage = null;
            this.ButtonMinimize.Location = new System.Drawing.Point(736, 4);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(16, 16);
            this.ButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ButtonMinimize.TabIndex = 4;
            this.ButtonMinimize.TabStop = false;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            this.ButtonMinimize.MouseEnter += new System.EventHandler(this.ButtonMinimize_MouseEnter);
            this.ButtonMinimize.MouseLeave += new System.EventHandler(this.ButtonMinimize_MouseLeave);
            // 
            // labelViewer
            // 
            this.labelViewer.AutoSize = true;
            this.labelViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewer.ForeColor = System.Drawing.Color.Silver;
            this.labelViewer.Location = new System.Drawing.Point(6, 4);
            this.labelViewer.Name = "labelViewer";
            this.labelViewer.Size = new System.Drawing.Size(93, 16);
            this.labelViewer.TabIndex = 4;
            this.labelViewer.Text = "DerPic Viewer";
            // 
            // ButtonExpander
            // 
            this.ButtonExpander.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExpander.ErrorImage = null;
            this.ButtonExpander.Image = global::DerPic_Viewer.Properties.Resources.buttonMaximize;
            this.ButtonExpander.InitialImage = null;
            this.ButtonExpander.Location = new System.Drawing.Point(752, 4);
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
            this.ButtonClose.ErrorImage = null;
            this.ButtonClose.Image = global::DerPic_Viewer.Properties.Resources.buttonClose;
            this.ButtonClose.InitialImage = null;
            this.ButtonClose.Location = new System.Drawing.Point(768, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(16, 16);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.ButtonClose.MouseEnter += new System.EventHandler(this.ButtonClose_MouseEnter);
            this.ButtonClose.MouseLeave += new System.EventHandler(this.ButtonClose_MouseLeave);
            // 
            // BorderRight
            // 
            this.BorderRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderRight.ErrorImage = null;
            this.BorderRight.InitialImage = null;
            this.BorderRight.Location = new System.Drawing.Point(794, 6);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(6, 588);
            this.BorderRight.TabIndex = 4;
            this.BorderRight.TabStop = false;
            this.BorderRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderRight_MouseDown);
            this.BorderRight.MouseEnter += new System.EventHandler(this.BorderRight_MouseEnter);
            this.BorderRight.MouseLeave += new System.EventHandler(this.BorderRight_MouseLeave);
            this.BorderRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderRight_MouseMove);
            this.BorderRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BorderRight_MouseUp);
            // 
            // BorderBottom
            // 
            this.BorderBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderBottom.ErrorImage = null;
            this.BorderBottom.InitialImage = null;
            this.BorderBottom.Location = new System.Drawing.Point(6, 594);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(788, 6);
            this.BorderBottom.TabIndex = 5;
            this.BorderBottom.TabStop = false;
            this.BorderBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderBottom_MouseDown);
            this.BorderBottom.MouseEnter += new System.EventHandler(this.BorderBottom_MouseEnter);
            this.BorderBottom.MouseLeave += new System.EventHandler(this.BorderBottom_MouseLeave);
            this.BorderBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderBottom_MouseMove);
            this.BorderBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BorderBottom_MouseUp);
            // 
            // CornerBR
            // 
            this.CornerBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CornerBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CornerBR.ErrorImage = null;
            this.CornerBR.InitialImage = null;
            this.CornerBR.Location = new System.Drawing.Point(794, 594);
            this.CornerBR.Name = "CornerBR";
            this.CornerBR.Size = new System.Drawing.Size(6, 6);
            this.CornerBR.TabIndex = 6;
            this.CornerBR.TabStop = false;
            this.CornerBR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CornerBR_MouseDown);
            this.CornerBR.MouseEnter += new System.EventHandler(this.CornerBR_MouseEnter);
            this.CornerBR.MouseLeave += new System.EventHandler(this.CornerBR_MouseLeave);
            this.CornerBR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CornerBR_MouseMove);
            this.CornerBR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CornerBR_MouseUp);
            // 
            // BorderLeft
            // 
            this.BorderLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderLeft.ErrorImage = null;
            this.BorderLeft.InitialImage = null;
            this.BorderLeft.Location = new System.Drawing.Point(0, 6);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(6, 588);
            this.BorderLeft.TabIndex = 7;
            this.BorderLeft.TabStop = false;
            this.BorderLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderLeft_MouseDown);
            this.BorderLeft.MouseEnter += new System.EventHandler(this.BorderLeft_MouseEnter);
            this.BorderLeft.MouseLeave += new System.EventHandler(this.BorderLeft_MouseLeave);
            this.BorderLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderLeft_MouseMove);
            this.BorderLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BorderLeft_MouseUp);
            // 
            // BorderTop
            // 
            this.BorderTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BorderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderTop.ErrorImage = null;
            this.BorderTop.InitialImage = null;
            this.BorderTop.Location = new System.Drawing.Point(6, 0);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(788, 6);
            this.BorderTop.TabIndex = 8;
            this.BorderTop.TabStop = false;
            this.BorderTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderTop_MouseDown);
            this.BorderTop.MouseEnter += new System.EventHandler(this.BorderTop_MouseEnter);
            this.BorderTop.MouseLeave += new System.EventHandler(this.BorderTop_MouseLeave);
            this.BorderTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderTop_MouseMove);
            this.BorderTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BorderTop_MouseUp);
            // 
            // CornerBL
            // 
            this.CornerBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CornerBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CornerBL.ErrorImage = null;
            this.CornerBL.InitialImage = null;
            this.CornerBL.Location = new System.Drawing.Point(0, 594);
            this.CornerBL.Name = "CornerBL";
            this.CornerBL.Size = new System.Drawing.Size(6, 6);
            this.CornerBL.TabIndex = 9;
            this.CornerBL.TabStop = false;
            this.CornerBL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CornerBL_MouseDown);
            this.CornerBL.MouseEnter += new System.EventHandler(this.CornerBL_MouseEnter);
            this.CornerBL.MouseLeave += new System.EventHandler(this.CornerBL_MouseLeave);
            this.CornerBL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CornerBL_MouseMove);
            this.CornerBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CornerBL_MouseUp);
            // 
            // CornerTL
            // 
            this.CornerTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CornerTL.ErrorImage = null;
            this.CornerTL.InitialImage = null;
            this.CornerTL.Location = new System.Drawing.Point(0, 0);
            this.CornerTL.Name = "CornerTL";
            this.CornerTL.Size = new System.Drawing.Size(6, 6);
            this.CornerTL.TabIndex = 10;
            this.CornerTL.TabStop = false;
            this.CornerTL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CornerTL_MouseDown);
            this.CornerTL.MouseEnter += new System.EventHandler(this.CornerTL_MouseEnter);
            this.CornerTL.MouseLeave += new System.EventHandler(this.CornerTL_MouseLeave);
            this.CornerTL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CornerTL_MouseMove);
            this.CornerTL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CornerTL_MouseUp);
            // 
            // CornerTR
            // 
            this.CornerTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CornerTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CornerTR.ErrorImage = null;
            this.CornerTR.InitialImage = null;
            this.CornerTR.Location = new System.Drawing.Point(794, 0);
            this.CornerTR.Name = "CornerTR";
            this.CornerTR.Size = new System.Drawing.Size(6, 6);
            this.CornerTR.TabIndex = 11;
            this.CornerTR.TabStop = false;
            this.CornerTR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CornerTR_MouseDown);
            this.CornerTR.MouseEnter += new System.EventHandler(this.CornerTR_MouseEnter);
            this.CornerTR.MouseLeave += new System.EventHandler(this.CornerTR_MouseLeave);
            this.CornerTR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CornerTR_MouseMove);
            this.CornerTR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CornerTR_MouseUp);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBackground.ErrorImage = null;
            this.pictureBoxBackground.Image = global::DerPic_Viewer.Properties.Resources.background;
            this.pictureBoxBackground.InitialImage = null;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(800, 600);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 12;
            this.pictureBoxBackground.TabStop = false;
            // 
            // pictureBoxView
            // 
            this.pictureBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBoxView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxView.ErrorImage = global::DerPic_Viewer.Properties.Resources.error;
            this.pictureBoxView.InitialImage = global::DerPic_Viewer.Properties.Resources.preloader;
            this.pictureBoxView.Location = new System.Drawing.Point(6, 36);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(788, 560);
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
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.pictureBoxView);
            this.Controls.Add(this.CornerTR);
            this.Controls.Add(this.CornerTL);
            this.Controls.Add(this.CornerBL);
            this.Controls.Add(this.BorderTop);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.CornerBR);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.pictureBoxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "ViewerForm";
            this.Text = "RePic";
            this.Load += new System.EventHandler(this.ViewerForm_Load);
            this.Resize += new System.EventHandler(this.ViewerForm_Resize);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExpander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CornerTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxView;
		private System.Windows.Forms.PictureBox ButtonClose;
		private System.Windows.Forms.Panel ControlPanel;
		private System.Windows.Forms.PictureBox ButtonMinimize;
		private System.Windows.Forms.PictureBox ButtonExpander;
		private System.Windows.Forms.Label labelViewer;
		private System.Windows.Forms.PictureBox BorderRight;
		private System.Windows.Forms.PictureBox BorderBottom;
		private System.Windows.Forms.PictureBox CornerBR;
        private System.Windows.Forms.PictureBox BorderLeft;
        private System.Windows.Forms.PictureBox BorderTop;
        private System.Windows.Forms.PictureBox CornerBL;
        private System.Windows.Forms.PictureBox CornerTL;
        private System.Windows.Forms.PictureBox CornerTR;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
	}
}

