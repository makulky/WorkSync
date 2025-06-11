namespace WorkSync.asistencias
{
	partial class buscarUsuario
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.buscadorTextBox = new System.Windows.Forms.TextBox();
			this.buscadorPictureBox = new System.Windows.Forms.PictureBox();
			this.empleadosDataGridView = new System.Windows.Forms.DataGridView();
			this.aceptarButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.buscadorPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// buscadorTextBox
			// 
			this.buscadorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buscadorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.buscadorTextBox.Location = new System.Drawing.Point(101, 63);
			this.buscadorTextBox.Name = "buscadorTextBox";
			this.buscadorTextBox.Size = new System.Drawing.Size(756, 35);
			this.buscadorTextBox.TabIndex = 5;
			this.buscadorTextBox.TextChanged += new System.EventHandler(this.buscadorTextBox_TextChanged);
			// 
			// buscadorPictureBox
			// 
			this.buscadorPictureBox.Image = global::WorkSync.Properties.Resources.person_search;
			this.buscadorPictureBox.Location = new System.Drawing.Point(34, 49);
			this.buscadorPictureBox.Name = "buscadorPictureBox";
			this.buscadorPictureBox.Size = new System.Drawing.Size(61, 59);
			this.buscadorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.buscadorPictureBox.TabIndex = 4;
			this.buscadorPictureBox.TabStop = false;
			// 
			// empleadosDataGridView
			// 
			this.empleadosDataGridView.AllowUserToAddRows = false;
			this.empleadosDataGridView.AllowUserToDeleteRows = false;
			this.empleadosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.empleadosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.empleadosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.empleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(41)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.empleadosDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
			this.empleadosDataGridView.Location = new System.Drawing.Point(34, 123);
			this.empleadosDataGridView.MultiSelect = false;
			this.empleadosDataGridView.Name = "empleadosDataGridView";
			this.empleadosDataGridView.ReadOnly = true;
			this.empleadosDataGridView.RowHeadersWidth = 62;
			this.empleadosDataGridView.RowTemplate.Height = 28;
			this.empleadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.empleadosDataGridView.Size = new System.Drawing.Size(1269, 479);
			this.empleadosDataGridView.TabIndex = 3;
			this.empleadosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empleadosDataGridView_CellClick);
			// 
			// aceptarButton
			// 
			this.aceptarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.aceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.aceptarButton.Location = new System.Drawing.Point(1126, 635);
			this.aceptarButton.Name = "aceptarButton";
			this.aceptarButton.Size = new System.Drawing.Size(177, 56);
			this.aceptarButton.TabIndex = 6;
			this.aceptarButton.Text = "Aceptar";
			this.aceptarButton.UseVisualStyleBackColor = true;
			this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
			// 
			// buscarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1335, 715);
			this.Controls.Add(this.aceptarButton);
			this.Controls.Add(this.buscadorTextBox);
			this.Controls.Add(this.buscadorPictureBox);
			this.Controls.Add(this.empleadosDataGridView);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "buscarUsuario";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar usuario";
			((System.ComponentModel.ISupportInitialize)(this.buscadorPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox buscadorTextBox;
		private System.Windows.Forms.PictureBox buscadorPictureBox;
		private System.Windows.Forms.DataGridView empleadosDataGridView;
		private System.Windows.Forms.Button aceptarButton;
	}
}