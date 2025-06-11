using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace WorkSync.backup
{
	partial class backupFormulario
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
			this.rutaGuardarTextBox = new System.Windows.Forms.TextBox();
			this.rutaGuardarButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.guardarButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.cargarButton = new System.Windows.Forms.Button();
			this.rutaCargarButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.rutaCargarTextBox = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// rutaGuardarTextBox
			// 
			this.rutaGuardarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rutaGuardarTextBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rutaGuardarTextBox.Location = new System.Drawing.Point(41, 69);
			this.rutaGuardarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rutaGuardarTextBox.Name = "rutaGuardarTextBox";
			this.rutaGuardarTextBox.ReadOnly = true;
			this.rutaGuardarTextBox.Size = new System.Drawing.Size(573, 37);
			this.rutaGuardarTextBox.TabIndex = 0;
			// 
			// rutaGuardarButton
			// 
			this.rutaGuardarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rutaGuardarButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rutaGuardarButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.rutaGuardarButton.FlatAppearance.BorderSize = 2;
			this.rutaGuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rutaGuardarButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rutaGuardarButton.ForeColor = System.Drawing.Color.DodgerBlue;
			this.rutaGuardarButton.Location = new System.Drawing.Point(350, 114);
			this.rutaGuardarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rutaGuardarButton.Name = "rutaGuardarButton";
			this.rutaGuardarButton.Size = new System.Drawing.Size(94, 38);
			this.rutaGuardarButton.TabIndex = 12;
			this.rutaGuardarButton.Text = "RUTA";
			this.rutaGuardarButton.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(41, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 29);
			this.label1.TabIndex = 13;
			this.label1.Text = "Ruta:";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.progressBar1);
			this.panel1.Controls.Add(this.guardarButton);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.rutaGuardarTextBox);
			this.panel1.Controls.Add(this.rutaGuardarButton);
			this.panel1.Location = new System.Drawing.Point(72, 54);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(659, 181);
			this.panel1.TabIndex = 14;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(62, 121);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.progressBar1.MarqueeAnimationSpeed = 10;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(260, 26);
			this.progressBar1.TabIndex = 15;
			this.progressBar1.Visible = false;
			// 
			// guardarButton
			// 
			this.guardarButton.BackColor = System.Drawing.Color.DodgerBlue;
			this.guardarButton.Enabled = false;
			this.guardarButton.FlatAppearance.BorderSize = 0;
			this.guardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.guardarButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guardarButton.ForeColor = System.Drawing.SystemColors.Control;
			this.guardarButton.Location = new System.Drawing.Point(472, 114);
			this.guardarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.guardarButton.Name = "guardarButton";
			this.guardarButton.Size = new System.Drawing.Size(141, 38);
			this.guardarButton.TabIndex = 14;
			this.guardarButton.Text = "GUARDAR";
			this.guardarButton.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(114, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(278, 29);
			this.label2.TabIndex = 14;
			this.label2.Text = "Guardar copia de seguridad:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(114, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(263, 29);
			this.label3.TabIndex = 15;
			this.label3.Text = "Cargar copia de seguridad:";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.progressBar2);
			this.panel2.Controls.Add(this.cargarButton);
			this.panel2.Controls.Add(this.rutaCargarButton);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.rutaCargarTextBox);
			this.panel2.Location = new System.Drawing.Point(72, 268);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(659, 181);
			this.panel2.TabIndex = 16;
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(62, 122);
			this.progressBar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.progressBar2.MarqueeAnimationSpeed = 10;
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(260, 26);
			this.progressBar2.TabIndex = 17;
			this.progressBar2.Visible = false;
			// 
			// cargarButton
			// 
			this.cargarButton.BackColor = System.Drawing.Color.DodgerBlue;
			this.cargarButton.Enabled = false;
			this.cargarButton.FlatAppearance.BorderSize = 0;
			this.cargarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cargarButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cargarButton.ForeColor = System.Drawing.SystemColors.Control;
			this.cargarButton.Location = new System.Drawing.Point(472, 115);
			this.cargarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cargarButton.Name = "cargarButton";
			this.cargarButton.Size = new System.Drawing.Size(141, 38);
			this.cargarButton.TabIndex = 16;
			this.cargarButton.Text = "CARGAR";
			this.cargarButton.UseVisualStyleBackColor = false;
			// 
			// rutaCargarButton
			// 
			this.rutaCargarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rutaCargarButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.rutaCargarButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.rutaCargarButton.FlatAppearance.BorderSize = 2;
			this.rutaCargarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rutaCargarButton.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rutaCargarButton.ForeColor = System.Drawing.Color.DodgerBlue;
			this.rutaCargarButton.Location = new System.Drawing.Point(350, 115);
			this.rutaCargarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rutaCargarButton.Name = "rutaCargarButton";
			this.rutaCargarButton.Size = new System.Drawing.Size(94, 38);
			this.rutaCargarButton.TabIndex = 15;
			this.rutaCargarButton.Text = "RUTA";
			this.rutaCargarButton.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(41, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 29);
			this.label4.TabIndex = 13;
			this.label4.Text = "Ruta:";
			// 
			// rutaCargarTextBox
			// 
			this.rutaCargarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rutaCargarTextBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rutaCargarTextBox.Location = new System.Drawing.Point(41, 69);
			this.rutaCargarTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rutaCargarTextBox.Name = "rutaCargarTextBox";
			this.rutaCargarTextBox.ReadOnly = true;
			this.rutaCargarTextBox.Size = new System.Drawing.Size(573, 37);
			this.rutaCargarTextBox.TabIndex = 0;
			// 
			// backupFormulario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(806, 499);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "backupFormulario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Copia de seguridad";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox rutaGuardarTextBox;
		private Button rutaGuardarButton;
		private Label label1;
		private Panel panel1;
		private Label label2;
		private Label label3;
		private Panel panel2;
		private Label label4;
		private TextBox rutaCargarTextBox;
		private Button guardarButton;
		private Button cargarButton;
		private Button rutaCargarButton;
		private ProgressBar progressBar1;
		private ProgressBar progressBar2;
	}
}