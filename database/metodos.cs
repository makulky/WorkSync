using LiteDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using Emgu.CV.Dnn;


namespace WorkSync.database
{
	internal class metodos
	{

		public static void CargarQrEnPictureBox(string dni, PictureBox qrPictureBox)
		{
			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				conexion.Open();
				string query = "SELECT QR FROM TRABAJADOR WHERE DNI = @DNI";
				MySqlCommand comando = new MySqlCommand(query, conexion);
				comando.Parameters.AddWithValue("@DNI", dni);

				using (MySqlDataReader reader = comando.ExecuteReader())
				{
					if (reader.Read() && !reader.IsDBNull(0))
					{
						byte[] qrBytes = (byte[])reader["QR"];

						using (MemoryStream ms = new MemoryStream(qrBytes))
						{
							qrPictureBox.Image = Image.FromStream(ms);
						}
					}
					else
					{
						System.Windows.MessageBox.Show("No se encontró un código QR para el DNI proporcionado.");
					}
				}
			}
		}

		public static void CargarPuestos(ComboBox comboBox)
		{
			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				try
				{
					conexion.Open();
					string consulta = "SELECT NOMBRE FROM PUESTO";
					MySqlCommand comando = new MySqlCommand(consulta, conexion);
					MySqlDataReader reader = comando.ExecuteReader();

					comboBox.Items.Clear();

					while (reader.Read())
					{
						comboBox.Items.Add(reader.GetString("NOMBRE").ToUpper());
					}

				}
				catch (Exception ex)
				{
					System.Windows.MessageBox.Show("No se puedo cargar los puestos de trabajo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}

		public static void cargarDatosEmpleados(DataGridView empleadosDataGridView)
		{
			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				try
				{
					conexion.Open();
					string consulta = @"SELECT T.DNI, T.NOMBRE, T.APELLIDO1 AS '1º APELLIDO', T.APELLIDO2 AS '2º APELLIDO', T.DIRECCION , T.EMAIL, T.TELEFONO, P.NOMBRE AS 'PUESTO', T.ESTADO FROM TRABAJADOR T JOIN PUESTO P ON T.ID_PUESTO = P.ID";

					MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
					DataTable dt = new DataTable();
					adapter.Fill(dt);

					empleadosDataGridView.DataSource = dt;
				}
				catch (Exception ex)
				{
					System.Windows.MessageBox.Show("Error al cargar datos." + ex, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				}
			}
		}


		public static int encontrarIDPuesto(ComboBox puestoComboBox)
		{
			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				int idPuesto = 0;

				conexion.Open();

				string consulta = "SELECT ID FROM PUESTO WHERE NOMBRE = @NOMBRE";

				MySqlCommand comando = new MySqlCommand(consulta, conexion);
				comando.Parameters.AddWithValue("@NOMBRE", puestoComboBox.SelectedItem);

				idPuesto = Convert.ToInt32(comando.ExecuteScalar());

				return idPuesto;

			}
		}

		public static void cargarPicks(DataGridView picksDataGridView)
		{
			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				try
				{
					conexion.Open();
					string consulta = "SELECT DNI_TRABAJADOR_FK AS DNI, FECHA, HORA_ENTRADA AS 'HORA ENTRADA', HORA_SALIDA AS 'HORA SALIDA', DURACION FROM HORARIOS";

					MySqlDataAdapter adapter = new MySqlDataAdapter(consulta,conexion);

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
