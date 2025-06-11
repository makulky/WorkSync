using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Data;
using QRCoder;
using LiteDB;
using MySql.Data.MySqlClient;
using WorkSync.database;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;


namespace WorkSync.usuarios
{
	public partial class gestionUsuarios : Form
	{

		private string dniOriginal;

		private FilterInfoCollection dispositivos;
		private VideoCaptureDevice camara;
		private string qrContenido = "";

		public static string dni = "";
		public static string nombre = "";
		public static string apellido1 = "";
		public static string apellido2 = "";
		public static string email = "";
		public static string telefono = "";
		public static string direccion = "";
		public static string puesto = "";
		public static string estado = "";

		public gestionUsuarios()
		{
			InitializeComponent();
		}

		private void gestionUsuarios_Load(object sender, EventArgs e)
		{
			metodos.cargarDatosEmpleados(empleadosDataGridView);
			metodos.CargarPuestos(filtroPuestoCombo);
			filtroPuestoCombo.Items.Add("TODOS");
			filtroPuestoCombo.SelectedIndex = filtroPuestoCombo.Items.Count - 1;
			filtroEstadoCombo.SelectedIndex = filtroEstadoCombo.Items.Count - 1;
		}

		private void agregarPictureBox_Click(object sender, EventArgs e)
		{
			agregarUsuario agregarUsuario = new agregarUsuario();

			posicionFormularioAgregarUsuario(agregarUsuario);

			if (agregarUsuario.ShowDialog() == DialogResult.Cancel)
			{
				metodos.cargarDatosEmpleados(empleadosDataGridView);
			}
		}

		private void posicionFormularioAgregarUsuario(Form agregarUsuario)
		{
			Point botonPosicion = agregarPictureBox.PointToScreen(Point.Empty);

			// Posicionar el formulario justo debajo del botón inicialmente
			agregarUsuario.StartPosition = FormStartPosition.Manual;
			int x = botonPosicion.X;
			int y = botonPosicion.Y + agregarPictureBox.Height;

			// Obtener el tamaño del formulario que se va a mostrar
			agregarUsuario.Load += (s, ev) =>
			{
				// Aquí puedes ajustar la posición cuando el formulario ya conoce su tamaño
				Rectangle pantalla = Screen.FromControl(this).WorkingArea;

				// Si el formulario se sale del lado derecho de la pantalla, ajusta la posición X
				if (x + agregarUsuario.Width > pantalla.Right)
				{
					x = pantalla.Right - agregarUsuario.Width;
					if (x < pantalla.Left) x = pantalla.Left; // Evitar salir del lado izquierdo
				}

				// Si el formulario se sale del borde inferior de la pantalla, ajustar la posición Y (opcional)
				if (y + agregarUsuario.Height > pantalla.Bottom)
				{
					y = botonPosicion.Y - agregarUsuario.Height; // Mostrar encima del botón en lugar de debajo
					if (y < pantalla.Top) y = pantalla.Top; // Ajuste mínimo
				}

				agregarUsuario.Location = new Point(x, y);
			};
		}

		private void empleadosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				metodos.CargarPuestos(puestoComboBox);
				DataGridViewRow filaSeleccionada = empleadosDataGridView.Rows[e.RowIndex];
				dni = filaSeleccionada.Cells["DNI"].Value.ToString();
				nombre = filaSeleccionada.Cells["NOMBRE"].Value.ToString();
				apellido1 = filaSeleccionada.Cells["1º APELLIDO"].Value.ToString();
				apellido2 = filaSeleccionada.Cells["2º APELLIDO"].Value.ToString();
				email = filaSeleccionada.Cells["EMAIL"].Value.ToString();
				telefono = filaSeleccionada.Cells["TELEFONO"].Value.ToString();
				direccion = filaSeleccionada.Cells["DIRECCION"].Value.ToString();
				puesto = filaSeleccionada.Cells["PUESTO"].Value.ToString();
				estado = filaSeleccionada.Cells["ESTADO"].Value.ToString();
				
				// Supongamos que las columnas son: ID, Nombre, Correo
				nombreTextBox.Text = filaSeleccionada.Cells["NOMBRE"].Value.ToString();
				apellido1TextBox.Text = filaSeleccionada.Cells["1º APELLIDO"].Value.ToString();
				apellido2TextBox.Text = filaSeleccionada.Cells["2º APELLIDO"].Value.ToString();
				emailTextBox.Text = filaSeleccionada.Cells["EMAIL"].Value.ToString();
				dniTextBox.Text = filaSeleccionada.Cells["DNI"].Value.ToString();
				dniOriginal = filaSeleccionada.Cells["DNI"].Value.ToString();
				telefonoTextBox.Text = filaSeleccionada.Cells["TELEFONO"].Value.ToString();
				direccionTextBox.Text = filaSeleccionada.Cells["DIRECCION"].Value.ToString();
				puestoComboBox.SelectedItem = filaSeleccionada.Cells["PUESTO"].Value.ToString();
				estadoComboBox.SelectedItem = filaSeleccionada.Cells["ESTADO"].Value.ToString();
				metodos.CargarQrEnPictureBox(dniTextBox.Text,qrPictureBox);
			}
		}

		

		private void editarPictureBox_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult dialogResult = MessageBox.Show("¿Deseas modificar el empleado?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

				if(dialogResult == DialogResult.OK)
				{
					using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
					{
						conexion.Open();
						string consulta = "UPDATE TRABAJADOR SET NOMBRE = @NOMBRE, APELLIDO1 = @APELLIDO1, APELLIDO2 = @APELLIDO2, DNI = @DNI_NUEVO, TELEFONO = @TELEFONO, EMAIL = @EMAIL, DIRECCION = @DIRECCION, ID_PUESTO = @ID_PUESTO, ESTADO = @ESTADO WHERE DNI = @DNI_ORIGINAL";
						MySqlCommand comando = new MySqlCommand(consulta, conexion);
						comando.Parameters.AddWithValue("@NOMBRE", nombreTextBox.Text);
						comando.Parameters.AddWithValue("@APELLIDO1", apellido1TextBox.Text);
						comando.Parameters.AddWithValue("@APELLIDO2", apellido2TextBox.Text);
						comando.Parameters.AddWithValue("@DNI_NUEVO", dniTextBox.Text);
						comando.Parameters.AddWithValue("@DNI_ORIGINAL", dniOriginal);
						comando.Parameters.AddWithValue("@EMAIL", emailTextBox.Text);
						comando.Parameters.AddWithValue("@TELEFONO", telefonoTextBox.Text);
						comando.Parameters.AddWithValue("@DIRECCION", direccionTextBox.Text);
						comando.Parameters.AddWithValue("@ESTADO", estadoComboBox.SelectedItem);
						comando.Parameters.AddWithValue("@ID_PUESTO", metodos.encontrarIDPuesto(puestoComboBox));
						comando.ExecuteNonQuery();
						MessageBox.Show("Se ha actualizado el empleado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
						metodos.cargarDatosEmpleados(empleadosDataGridView);
					}
				}	
			}
			catch(Exception error)
			{
				MessageBox.Show("No se ha podido modificar el usuario. DNI duplicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void scannerPictureBox_Click(object sender, EventArgs e)
		{
			dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			if (dispositivos.Count > 0)
			{
				camara = new VideoCaptureDevice(dispositivos[0].MonikerString);
				camara.NewFrame += Camara_NewFrame;
				camara.Start();
			}
			else
			{
				MessageBox.Show("No se encontró cámara.");
			}
		}

		private void Camara_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();

			ZXing.BarcodeReader lector = new ZXing.BarcodeReader();
			var resultado = lector.Decode(imagen);

			if (resultado != null)
			{
				qrContenido = resultado.Text; // Guarda el contenido en la variable
				camara.SignalToStop(); // Detiene la cámara

				// Si necesitas hacer algo con el contenido aquí, puedes usar qrContenido
				MessageBox.Show("Se ha registrado de forma satisfactoria: " + qrContenido, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				registrarPick();
			}
		}

		private void registrarPick()
		{
			DateTime ahora = DateTime.Now;
			string fechaHoy = ahora.ToString("yyyy-MM-dd");
			string horaActual = ahora.ToString("yyyy-MM-dd HH:mm:ss");

			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				conexion.Open();

				// Verifica si ya existe un registro con entrada pero sin salida para hoy
				string queryVerificar = "SELECT id FROM horarios WHERE dni_trabajador_fk = @dni AND fecha = @fecha AND hora_salida IS NULL";

				using (MySqlCommand cmd = new MySqlCommand(queryVerificar, conexion))
				{
					cmd.Parameters.AddWithValue("@dni", qrContenido);
					cmd.Parameters.AddWithValue("@fecha", fechaHoy);

					object resultado = cmd.ExecuteScalar();

					if (resultado == null) // No hay entrada hoy → insertar nueva fila
					{
						string insertar = @"INSERT INTO horarios (dni_trabajador_fk, fecha, hora_entrada)
								VALUES (@dni, @fecha, @horaEntrada)";

						using (MySqlCommand insertCmd = new MySqlCommand(insertar, conexion))
						{
							insertCmd.Parameters.AddWithValue("@dni", qrContenido);
							insertCmd.Parameters.AddWithValue("@fecha", fechaHoy);
							insertCmd.Parameters.AddWithValue("@horaEntrada", horaActual);
							insertCmd.ExecuteNonQuery();

							MessageBox.Show("Entrada registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else // Ya hay entrada sin salida → registrar salida
					{
						int idHorario = Convert.ToInt32(resultado);
						string actualizar = @"UPDATE horarios SET hora_salida = @horaSalida WHERE id = @id";

						using (MySqlCommand updateCmd = new MySqlCommand(actualizar, conexion))
						{
							updateCmd.Parameters.AddWithValue("@horaSalida", horaActual);
							updateCmd.Parameters.AddWithValue("@id", idHorario);
							updateCmd.ExecuteNonQuery();

							MessageBox.Show("Salida registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
			}
		}

		private void filtroPuestoCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (filtroPuestoCombo.SelectedItem.Equals("TODOS"))
			{
				metodos.cargarDatosEmpleados(empleadosDataGridView);
			}
			else
			{
				using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
				{
					try
					{
						conexion.Open();
						string consulta = @"SELECT T.DNI, T.NOMBRE, T.APELLIDO1 AS '1º APELLIDO', T.APELLIDO2 AS '2º APELLIDO', T.DIRECCION , T.EMAIL, T.TELEFONO, P.NOMBRE AS 'PUESTO', T.ESTADO FROM TRABAJADOR T JOIN PUESTO P ON T.ID_PUESTO = P.ID WHERE ID_PUESTO = @ID_PUESTO";

						if (!filtroEstadoCombo.SelectedItem.Equals("TODOS"))
						{
							consulta += " AND ESTADO = @ESTADO";
						}

						using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
						{
							// Asignar valor al parámetro @PUESTO
							comando.Parameters.AddWithValue("@ID_PUESTO", metodos.encontrarIDPuesto(filtroPuestoCombo)); // Asegúrate de que 'puestoSeleccionado' tenga el valor correcto

							if (!filtroEstadoCombo.SelectedItem.Equals("TODOS"))
							{
								comando.Parameters.AddWithValue("@ESTADO", filtroEstadoCombo.SelectedItem);
							}
							// Crear el adaptador y llenar el DataTable
							using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
							{
								DataTable dt = new DataTable();
								adapter.Fill(dt);

								// Asignar el DataTable al DataGridView
								empleadosDataGridView.DataSource = dt;
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al cargar datos." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			
		}

		private void filtroEstadoCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (filtroEstadoCombo.SelectedItem.Equals("TODOS"))
			{
				metodos.cargarDatosEmpleados(empleadosDataGridView);
			}
			else
			{
				using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
				{
					try
					{
						conexion.Open();
						string consulta = @"SELECT T.DNI, T.NOMBRE, T.APELLIDO1 AS '1º APELLIDO', T.APELLIDO2 AS '2º APELLIDO', T.DIRECCION , T.EMAIL, T.TELEFONO, P.NOMBRE AS 'PUESTO', T.ESTADO FROM TRABAJADOR T JOIN PUESTO P ON T.ID_PUESTO = P.ID WHERE ESTADO = @ESTADO";

						if (!filtroPuestoCombo.SelectedItem.Equals("TODOS"))
						{
							consulta += " AND ID_PUESTO = @ID_PUESTO";
						}
						

						using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
						{
							// Asignar valor al parámetro @PUESTO
							comando.Parameters.AddWithValue("@ESTADO", filtroEstadoCombo.SelectedItem); // Asegúrate de que 'puestoSeleccionado' tenga el valor correcto

							if (!filtroPuestoCombo.SelectedItem.Equals("TODOS"))
							{
								comando.Parameters.AddWithValue("@ID_PUESTO", metodos.encontrarIDPuesto(filtroPuestoCombo)); // Asegúrate de que 'puestoSeleccionado' tenga el valor correcto
							}
							// Crear el adaptador y llenar el DataTable
							using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
							{
								DataTable dt = new DataTable();
								adapter.Fill(dt);

								// Asignar el DataTable al DataGridView
								empleadosDataGridView.DataSource = dt;
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error al cargar datos." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

			}
		}

		private void buscadorTextBox_TextChanged(object sender, EventArgs e)
		{
			if (empleadosDataGridView.DataSource is DataTable dt)
			{
				string input = buscadorTextBox.Text.Trim().Replace("'", "''").ToLower();

				if (string.IsNullOrEmpty(input))
				{
					dt.DefaultView.RowFilter = ""; // Quita el filtro si está vacío
					return;
				}

				string[] palabras = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				// Crear condiciones: cada palabra debe aparecer en alguna columna
				List<string> condiciones = new List<string>();
				foreach (var palabra in palabras)
				{
					string cond = $@"
				CONVERT(NOMBRE, 'System.String') LIKE '%{palabra}%' OR
				CONVERT([1º APELLIDO], 'System.String') LIKE '%{palabra}%' OR
				CONVERT([2º APELLIDO], 'System.String') LIKE '%{palabra}%' OR
				CONVERT(DNI, 'System.String') LIKE '%{palabra}%'";
					condiciones.Add($"({cond})");
				}

				dt.DefaultView.RowFilter = string.Join(" AND ", condiciones);
			}
		}

		private void carpetaPictureBox_Click(object sender, EventArgs e)
		{
			perfilUsuario perfilUsuario = new perfilUsuario();
			perfilUsuario.ShowDialog();
		}
	}
}
