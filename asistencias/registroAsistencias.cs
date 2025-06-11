using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WorkSync.database;

namespace WorkSync.asistencias
{
	public partial class registroAsistencias : Form
	{

		bool switchBuscador = false;

		public registroAsistencias()
		{
			InitializeComponent();
			metodos.cargarPicks(registroAsistenciasDataGridView);
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			if (dateTimePicker.Checked)
			{
				if (switchBuscador)
				{
					using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
					{
						conexion.Open();
						string consulta = "SELECT DNI_TRABAJADOR_FK AS DNI, FECHA, HORA_ENTRADA AS 'HORA ENTRADA', HORA_SALIDA AS 'HORA SALIDA', DURACION FROM HORARIOS WHERE DNI_TRABAJADOR_FK = @DNI AND FECHA = @FECHA";

						MySqlDataAdapter adapter = new MySqlDataAdapter();
						MySqlCommand comando = new MySqlCommand(consulta, conexion);
						comando.Parameters.AddWithValue("@FECHA", dateTimePicker.Text);
						comando.Parameters.AddWithValue("@DNI", buscarUsuario.dni);
						adapter.SelectCommand = comando;

						DataTable dt = new DataTable();
						adapter.Fill(dt);

						registroAsistenciasDataGridView.DataSource = dt;
					}
				}
				else
				{
					using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
					{
						conexion.Open();
						string consulta = "SELECT DNI_TRABAJADOR_FK AS DNI, FECHA, HORA_ENTRADA AS 'HORA ENTRADA', HORA_SALIDA AS 'HORA SALIDA', DURACION FROM HORARIOS WHERE FECHA = @FECHA";

						MySqlDataAdapter adapter = new MySqlDataAdapter();
						MySqlCommand comando = new MySqlCommand(consulta, conexion);
						comando.Parameters.AddWithValue("@FECHA", dateTimePicker.Text);
						adapter.SelectCommand = comando;

						DataTable dt = new DataTable();
						adapter.Fill(dt);

						registroAsistenciasDataGridView.DataSource = dt;
					}
				}
				
			}
			else
			{
				if (switchBuscador)
				{
					using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
					{
						conexion.Open();
						string consulta = "SELECT DNI_TRABAJADOR_FK AS DNI, FECHA, HORA_ENTRADA AS 'HORA ENTRADA', HORA_SALIDA AS 'HORA SALIDA', DURACION FROM HORARIOS WHERE DNI_TRABAJADOR_FK = @DNI";

						MySqlDataAdapter adapter = new MySqlDataAdapter();
						MySqlCommand comando = new MySqlCommand(consulta, conexion);
						comando.Parameters.AddWithValue("@DNI", buscarUsuario.dni);
						adapter.SelectCommand = comando;

						DataTable dt = new DataTable();
						adapter.Fill(dt);

						registroAsistenciasDataGridView.DataSource = dt;
					}
				}
				else
				{
					metodos.cargarPicks(registroAsistenciasDataGridView);
				}
			}
		}

		private void buscarUsuarioButton_Click(object sender, EventArgs e)
		{
			switchBuscador = true;

			buscarUsuario buscarUsuario = new buscarUsuario();
			DialogResult dr = buscarUsuario.ShowDialog();

			if (dr == DialogResult.Cancel)
			{
				using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
				{
					conexion.Open();
					if (dateTimePicker.Checked)
					{
						string consulta = "SELECT DNI_TRABAJADOR_FK AS DNI, FECHA, HORA_ENTRADA AS 'HORA ENTRADA', HORA_SALIDA AS 'HORA SALIDA', DURACION FROM HORARIOS WHERE DNI_TRABAJADOR_FK = @DNI AND FECHA = @FECHA";
						MySqlDataAdapter adapter = new MySqlDataAdapter();
						MySqlCommand comando = new MySqlCommand(consulta, conexion);
						comando.Parameters.AddWithValue("@DNI", buscarUsuario.dni);
						comando.Parameters.AddWithValue("@FECHA", dateTimePicker.Text);
						adapter.SelectCommand = comando;

						DataTable dt = new DataTable();
						adapter.Fill(dt);
						registroAsistenciasDataGridView.DataSource = dt;

					}
					else
					{
						string consulta = "SELECT DNI_TRABAJADOR_FK AS DNI, FECHA, HORA_ENTRADA AS 'HORA ENTRADA', HORA_SALIDA AS 'HORA SALIDA', DURACION FROM HORARIOS WHERE DNI_TRABAJADOR_FK = @DNI";
						MySqlDataAdapter adapter = new MySqlDataAdapter();
						MySqlCommand comando = new MySqlCommand(consulta, conexion);
						comando.Parameters.AddWithValue("@DNI", buscarUsuario.dni);
						adapter.SelectCommand = comando;

						DataTable dt = new DataTable();
						adapter.Fill(dt);
						registroAsistenciasDataGridView.DataSource = dt;

					}

				}
			}
		}

		private void resetearButton_Click(object sender, EventArgs e)
		{
			switchBuscador = false;
			metodos.cargarPicks(registroAsistenciasDataGridView);
		}
	}
}
