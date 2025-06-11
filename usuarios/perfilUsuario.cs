using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WorkSync.database;

namespace WorkSync.usuarios
{
	public partial class perfilUsuario : Form
	{
		public perfilUsuario()
		{
			InitializeComponent();
			cargarDatos();
		}

		private void cerrarLabel_Click(object sender, EventArgs e)
		{
			puestoComboBox.Items.Clear();
			estadoComboBox.Items.Clear();
			this.Close();
		}

		private void cargarDatos()
		{
			metodos.CargarQrEnPictureBox(gestionUsuarios.dni, qrPerfilPicture);
			nombreTextBox.Text = gestionUsuarios.nombre;
			apellido1TextBox.Text = gestionUsuarios.apellido1;
			apellido2TextBox.Text = gestionUsuarios.apellido2;
			emailTextBox.Text = gestionUsuarios.email;
			telefonoTextBox.Text = gestionUsuarios.telefono;
			direccionTextBox.Text = gestionUsuarios.direccion;
			dniTextBox.Text = gestionUsuarios.dni;
			puestoComboBox.Items.Add(gestionUsuarios.puesto);
			estadoComboBox.Items.Add(gestionUsuarios.estado);
			puestoComboBox.SelectedIndex = 0;
			estadoComboBox.SelectedIndex = 0;
			cargarPicks();
		}

		private void cargarPicks()
		{
			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				try
				{
					conexion.Open();
					string consulta = "SELECT FECHA, HORA_ENTRADA, HORA_SALIDA, DURACION FROM HORARIOS WHERE DNI_TRABAJADOR_FK = @DNI";

					MySqlDataAdapter adapter = new MySqlDataAdapter();
					MySqlCommand comando = new MySqlCommand(consulta, conexion);
					comando.Parameters.AddWithValue("@DNI", dniTextBox.Text);
					adapter.SelectCommand = comando;

					DataTable dt = new DataTable();
					adapter.Fill(dt);

					picksDataGridView.DataSource = dt;
				}

				catch (Exception ex)
				{
					System.Windows.MessageBox.Show("Error al cargar datos." + ex, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}
	}
}
