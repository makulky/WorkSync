using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkSync;

namespace WorkSync.backup
{
	public partial class backupFormulario : Form
	{
		public backupFormulario()
		{
			InitializeComponent();
		}

		private void rutaGuardarButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog directorioGuardar = new FolderBrowserDialog();
			if (directorioGuardar.ShowDialog() == DialogResult.OK)
			{
				rutaGuardarTextBox.Text = directorioGuardar.SelectedPath;
				guardarButton.Enabled = true;
			}
		}

		private void guardarButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
				{
					MySqlCommand comando = new MySqlCommand();
					MySqlBackup bk = new MySqlBackup(comando);

					comando.Connection = conexion;
					conexion.Open();
					string ruta = rutaGuardarTextBox.Text + "\\database-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".sql";
					bk.ExportInfo.AddCreateDatabase = true;
					bk.ExportToFile(ruta);
				}
				cargaBarraProgreso(progressBar1, "Copia de seguridad realizada correctamente.");
			}
			catch (Exception error)
			{
				MessageBox.Show($"Error al realizar copia de seguridad.\n\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void cargaBarraProgreso(ProgressBar pb, string s)
		{
			this.Enabled = false;
			pb.Value = 0;
			pb.Visible = true;
			for (int x = 0; x <= 17; x++)
			{
				await Task.Delay(20);
				pb.Value = x;
			}

			await Task.Delay(2000);

			pb.Visible = true;
			for (int x = 17; x <= 100; x++)
			{
				await Task.Delay(10);
				pb.Value = x;
			}

			await Task.Delay(1000);

			if (pb.Value == 100)
			{
				DialogResult dr = MessageBox.Show(s, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (dr == DialogResult.OK || dr == DialogResult.Cancel)
				{
					pb.Visible = false;
					rutaGuardarTextBox.Text = string.Empty;
					rutaCargarTextBox.Text = string.Empty;
					guardarButton.Enabled = false;
					cargarButton.Enabled = false;
					this.Enabled = true;
				}
			}
		}

		private void rutaCargarButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog directorioCargar = new OpenFileDialog();
			directorioCargar.Filter = "Archivo SQL (*.sql) | *.sql";
			if (directorioCargar.ShowDialog() == DialogResult.OK)
			{
				rutaCargarTextBox.Text = directorioCargar.FileName;
				cargarButton.Enabled = true;
			}
		}

		private void cargarButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
				{
					MySqlCommand comando = new MySqlCommand();
					MySqlBackup bk = new MySqlBackup(comando);

					comando.Connection = conexion;
					conexion.Open();
					bk.ImportFromFile(rutaCargarTextBox.Text);
				}
				cargaBarraProgreso(progressBar2, "Se ha restablecido la copia de seguridad.");
			}
			catch (Exception error)
			{
				MessageBox.Show($"{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}