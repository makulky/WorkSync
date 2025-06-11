namespace WorkSync
{
	partial class login
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.minimizeMenu = new System.Windows.Forms.PictureBox();
			this.closeMenu = new System.Windows.Forms.PictureBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.mostrarContraseña = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.contraseñaTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.usuarioTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
			this.splitContainer1.Panel2.Controls.Add(this.minimizeMenu);
			this.splitContainer1.Panel2.Controls.Add(this.closeMenu);
			this.splitContainer1.Panel2.Controls.Add(this.exitButton);
			this.splitContainer1.Panel2.Controls.Add(this.loginButton);
			this.splitContainer1.Panel2.Controls.Add(this.mostrarContraseña);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.contraseñaTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.usuarioTextBox);
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
			this.splitContainer1.Size = new System.Drawing.Size(1308, 614);
			this.splitContainer1.SplitterDistance = 486;
			this.splitContainer1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WorkSync.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(56, 116);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(381, 424);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// minimizeMenu
			// 
			this.minimizeMenu.BackColor = System.Drawing.Color.Transparent;
			this.minimizeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.minimizeMenu.Image = global::WorkSync.Properties.Resources.minimize;
			this.minimizeMenu.Location = new System.Drawing.Point(721, 21);
			this.minimizeMenu.Name = "minimizeMenu";
			this.minimizeMenu.Size = new System.Drawing.Size(36, 39);
			this.minimizeMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.minimizeMenu.TabIndex = 8;
			this.minimizeMenu.TabStop = false;
			this.minimizeMenu.Click += new System.EventHandler(this.minimizeMenu_Click);
			// 
			// closeMenu
			// 
			this.closeMenu.BackColor = System.Drawing.Color.Transparent;
			this.closeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeMenu.Image = global::WorkSync.Properties.Resources.close;
			this.closeMenu.Location = new System.Drawing.Point(759, 21);
			this.closeMenu.Name = "closeMenu";
			this.closeMenu.Size = new System.Drawing.Size(36, 39);
			this.closeMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.closeMenu.TabIndex = 7;
			this.closeMenu.TabStop = false;
			this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.Color.Transparent;
			this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
			this.exitButton.FlatAppearance.BorderSize = 3;
			this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.exitButton.Location = new System.Drawing.Point(481, 443);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(115, 53);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Salir";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.Transparent;
			this.loginButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(173)))), ((int)(((byte)(182)))));
			this.loginButton.FlatAppearance.BorderSize = 3;
			this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.loginButton.Location = new System.Drawing.Point(235, 443);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(217, 53);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "Iniciar sesión";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// mostrarContraseña
			// 
			this.mostrarContraseña.AutoSize = true;
			this.mostrarContraseña.BackColor = System.Drawing.Color.Transparent;
			this.mostrarContraseña.ForeColor = System.Drawing.SystemColors.Control;
			this.mostrarContraseña.Location = new System.Drawing.Point(235, 374);
			this.mostrarContraseña.Name = "mostrarContraseña";
			this.mostrarContraseña.Size = new System.Drawing.Size(173, 24);
			this.mostrarContraseña.TabIndex = 4;
			this.mostrarContraseña.Text = "Mostrar contraseña";
			this.mostrarContraseña.UseVisualStyleBackColor = false;
			this.mostrarContraseña.CheckedChanged += new System.EventHandler(this.mostrarContraseña_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(230, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña:";
			// 
			// contraseñaTextBox
			// 
			this.contraseñaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.contraseñaTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contraseñaTextBox.Location = new System.Drawing.Point(235, 317);
			this.contraseñaTextBox.Name = "contraseñaTextBox";
			this.contraseñaTextBox.PasswordChar = '*';
			this.contraseñaTextBox.Size = new System.Drawing.Size(361, 35);
			this.contraseñaTextBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(230, 174);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Correo electrónico: ";
			// 
			// usuarioTextBox
			// 
			this.usuarioTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.usuarioTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usuarioTextBox.Location = new System.Drawing.Point(235, 216);
			this.usuarioTextBox.Name = "usuarioTextBox";
			this.usuarioTextBox.Size = new System.Drawing.Size(361, 35);
			this.usuarioTextBox.TabIndex = 0;
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1308, 614);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WorkSync";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minimizeMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeMenu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox usuarioTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox contraseñaTextBox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.CheckBox mostrarContraseña;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.PictureBox closeMenu;
		private System.Windows.Forms.PictureBox minimizeMenu;
	}
}

