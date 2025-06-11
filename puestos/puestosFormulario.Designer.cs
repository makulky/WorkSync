namespace WorkSync.puestos
{
	partial class puestosFormulario
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
			this.añadirRadioButton = new System.Windows.Forms.RadioButton();
			this.modificarRadioButton = new System.Windows.Forms.RadioButton();
			this.eliminarRadioButton = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.puestoComboBox = new System.Windows.Forms.ComboBox();
			this.añadirLabel = new System.Windows.Forms.Label();
			this.puestoTextBox = new System.Windows.Forms.TextBox();
			this.puestoButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// añadirRadioButton
			// 
			this.añadirRadioButton.AutoSize = true;
			this.añadirRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.añadirRadioButton.Location = new System.Drawing.Point(166, 12);
			this.añadirRadioButton.Name = "añadirRadioButton";
			this.añadirRadioButton.Size = new System.Drawing.Size(87, 26);
			this.añadirRadioButton.TabIndex = 0;
			this.añadirRadioButton.TabStop = true;
			this.añadirRadioButton.Text = "Añadir";
			this.añadirRadioButton.UseVisualStyleBackColor = true;
			this.añadirRadioButton.CheckedChanged += new System.EventHandler(this.añadirRadioButton_CheckedChanged);
			// 
			// modificarRadioButton
			// 
			this.modificarRadioButton.AutoSize = true;
			this.modificarRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.modificarRadioButton.Location = new System.Drawing.Point(259, 12);
			this.modificarRadioButton.Name = "modificarRadioButton";
			this.modificarRadioButton.Size = new System.Drawing.Size(107, 26);
			this.modificarRadioButton.TabIndex = 1;
			this.modificarRadioButton.TabStop = true;
			this.modificarRadioButton.Text = "Modificar";
			this.modificarRadioButton.UseVisualStyleBackColor = true;
			this.modificarRadioButton.CheckedChanged += new System.EventHandler(this.modificarRadioButton_CheckedChanged);
			// 
			// eliminarRadioButton
			// 
			this.eliminarRadioButton.AutoSize = true;
			this.eliminarRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.eliminarRadioButton.Location = new System.Drawing.Point(372, 12);
			this.eliminarRadioButton.Name = "eliminarRadioButton";
			this.eliminarRadioButton.Size = new System.Drawing.Size(99, 26);
			this.eliminarRadioButton.TabIndex = 2;
			this.eliminarRadioButton.TabStop = true;
			this.eliminarRadioButton.Text = "Eliminar";
			this.eliminarRadioButton.UseVisualStyleBackColor = true;
			this.eliminarRadioButton.CheckedChanged += new System.EventHandler(this.eliminarRadioButton_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(42, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "Puestos:";
			// 
			// puestoComboBox
			// 
			this.puestoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.puestoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.puestoComboBox.FormattingEnabled = true;
			this.puestoComboBox.Location = new System.Drawing.Point(154, 81);
			this.puestoComboBox.Name = "puestoComboBox";
			this.puestoComboBox.Size = new System.Drawing.Size(261, 37);
			this.puestoComboBox.TabIndex = 4;
			// 
			// añadirLabel
			// 
			this.añadirLabel.AutoSize = true;
			this.añadirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.añadirLabel.Location = new System.Drawing.Point(42, 166);
			this.añadirLabel.Name = "añadirLabel";
			this.añadirLabel.Size = new System.Drawing.Size(301, 29);
			this.añadirLabel.TabIndex = 5;
			this.añadirLabel.Text = "Introduce un nuevo puesto:";
			// 
			// puestoTextBox
			// 
			this.puestoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.puestoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.puestoTextBox.Location = new System.Drawing.Point(47, 213);
			this.puestoTextBox.Name = "puestoTextBox";
			this.puestoTextBox.Size = new System.Drawing.Size(368, 35);
			this.puestoTextBox.TabIndex = 6;
			// 
			// puestoButton
			// 
			this.puestoButton.Location = new System.Drawing.Point(308, 278);
			this.puestoButton.Name = "puestoButton";
			this.puestoButton.Size = new System.Drawing.Size(148, 52);
			this.puestoButton.TabIndex = 7;
			this.puestoButton.Text = "AÑADIR";
			this.puestoButton.UseVisualStyleBackColor = true;
			this.puestoButton.Click += new System.EventHandler(this.puestoButton_Click);
			// 
			// puestosFormulario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 353);
			this.Controls.Add(this.puestoButton);
			this.Controls.Add(this.puestoTextBox);
			this.Controls.Add(this.añadirLabel);
			this.Controls.Add(this.puestoComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.eliminarRadioButton);
			this.Controls.Add(this.modificarRadioButton);
			this.Controls.Add(this.añadirRadioButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "puestosFormulario";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Puestos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton añadirRadioButton;
		private System.Windows.Forms.RadioButton modificarRadioButton;
		private System.Windows.Forms.RadioButton eliminarRadioButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox puestoComboBox;
		private System.Windows.Forms.Label añadirLabel;
		private System.Windows.Forms.TextBox puestoTextBox;
		private System.Windows.Forms.Button puestoButton;
	}
}