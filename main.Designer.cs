namespace WorkSync
{
	partial class main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registroDeAsistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.panelResize = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.maximizedMenu = new System.Windows.Forms.PictureBox();
			this.minimizeMenu = new System.Windows.Forms.PictureBox();
			this.closeMenu = new System.Windows.Forms.PictureBox();
			this.panelMenu.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.panelContenedor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maximizedMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
			this.panelMenu.Controls.Add(this.pictureBox1);
			this.panelMenu.Controls.Add(this.maximizedMenu);
			this.panelMenu.Controls.Add(this.minimizeMenu);
			this.panelMenu.Controls.Add(this.closeMenu);
			this.panelMenu.Controls.Add(this.menuStrip1);
			this.panelMenu.Location = new System.Drawing.Point(-9, -3);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(1541, 49);
			this.panelMenu.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.registroDeAsistenciasToolStripMenuItem,
            this.puestosToolStripMenuItem,
            this.backupToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(60, 6);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1049, 42);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.usuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(240, 38);
			this.usuariosToolStripMenuItem.Text = "Gestión de usuarios";
			this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
			// 
			// registroDeAsistenciasToolStripMenuItem
			// 
			this.registroDeAsistenciasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.registroDeAsistenciasToolStripMenuItem.Name = "registroDeAsistenciasToolStripMenuItem";
			this.registroDeAsistenciasToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
			this.registroDeAsistenciasToolStripMenuItem.Text = "Registro de asistencias";
			this.registroDeAsistenciasToolStripMenuItem.Click += new System.EventHandler(this.registroDeAsistenciasToolStripMenuItem_Click);
			// 
			// puestosToolStripMenuItem
			// 
			this.puestosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
			this.puestosToolStripMenuItem.Size = new System.Drawing.Size(112, 38);
			this.puestosToolStripMenuItem.Text = "Puestos";
			this.puestosToolStripMenuItem.Click += new System.EventHandler(this.puestosToolStripMenuItem_Click);
			// 
			// backupToolStripMenuItem
			// 
			this.backupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
			this.backupToolStripMenuItem.Size = new System.Drawing.Size(237, 38);
			this.backupToolStripMenuItem.Text = "Copia de seguridad";
			this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
			// 
			// panelContenedor
			// 
			this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelContenedor.BackColor = System.Drawing.Color.Transparent;
			this.panelContenedor.Controls.Add(this.panelResize);
			this.panelContenedor.Location = new System.Drawing.Point(1, 49);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(1519, 816);
			this.panelContenedor.TabIndex = 1;
			// 
			// panelResize
			// 
			this.panelResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panelResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.panelResize.Location = new System.Drawing.Point(1509, 806);
			this.panelResize.Name = "panelResize";
			this.panelResize.Size = new System.Drawing.Size(10, 10);
			this.panelResize.TabIndex = 0;
			this.panelResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelResize_MouseDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pictureBox1.Image = global::WorkSync.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(21, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 39);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// maximizedMenu
			// 
			this.maximizedMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.maximizedMenu.BackColor = System.Drawing.Color.Transparent;
			this.maximizedMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.maximizedMenu.Image = global::WorkSync.Properties.Resources.maximized2;
			this.maximizedMenu.Location = new System.Drawing.Point(1435, 7);
			this.maximizedMenu.Name = "maximizedMenu";
			this.maximizedMenu.Size = new System.Drawing.Size(36, 39);
			this.maximizedMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.maximizedMenu.TabIndex = 11;
			this.maximizedMenu.TabStop = false;
			this.maximizedMenu.Click += new System.EventHandler(this.maximizedMenu_Click);
			// 
			// minimizeMenu
			// 
			this.minimizeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimizeMenu.BackColor = System.Drawing.Color.Transparent;
			this.minimizeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.minimizeMenu.Image = global::WorkSync.Properties.Resources.minimize;
			this.minimizeMenu.Location = new System.Drawing.Point(1388, 7);
			this.minimizeMenu.Name = "minimizeMenu";
			this.minimizeMenu.Size = new System.Drawing.Size(36, 39);
			this.minimizeMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.minimizeMenu.TabIndex = 10;
			this.minimizeMenu.TabStop = false;
			this.minimizeMenu.Click += new System.EventHandler(this.minimizeMenu_Click);
			// 
			// closeMenu
			// 
			this.closeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeMenu.BackColor = System.Drawing.Color.Transparent;
			this.closeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeMenu.Image = global::WorkSync.Properties.Resources.close;
			this.closeMenu.Location = new System.Drawing.Point(1484, 7);
			this.closeMenu.Name = "closeMenu";
			this.closeMenu.Size = new System.Drawing.Size(36, 39);
			this.closeMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.closeMenu.TabIndex = 9;
			this.closeMenu.TabStop = false;
			this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
			// 
			// main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1523, 869);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panelMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WorkSync";
			this.panelMenu.ResumeLayout(false);
			this.panelMenu.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelContenedor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maximizedMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeMenu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.PictureBox maximizedMenu;
		private System.Windows.Forms.PictureBox minimizeMenu;
		private System.Windows.Forms.PictureBox closeMenu;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem registroDeAsistenciasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
		private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.Panel panelResize;
	}
}