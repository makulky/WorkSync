using MySql.Data.MySqlClient;
using QRCoder;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WorkSync.database;


namespace WorkSync.usuarios
{
	public partial class agregarUsuario : Form
	{

		public agregarUsuario()
		{
			InitializeComponent();
			metodos.CargarPuestos(puestoComboBox);
		}

		private void cerrarLabel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void aceptarButton_Click(object sender, System.EventArgs e)
		{
			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				conexion.Open();
				try
				{
					if (ValidarCampos())
					{
						byte[] qrBytes = GenerarQrCode(dniTextBox.Text);
						string insertar = "INSERT INTO TRABAJADOR (DNI, NOMBRE, APELLIDO1, APELLIDO2, EMAIL, ID_PUESTO, ID_ROL, TELEFONO, DIRECCION, ESTADO, QR) VALUES (@DNI, @NOMBRE, @APELLIDO1, @APELLIDO2, @EMAIL, @ID_PUESTO, @ID_ROL, @TELEFONO, @DIRECCION, @ESTADO, @QR)";
						MySqlCommand comando = new MySqlCommand(insertar, conexion);

						comando.Parameters.AddWithValue("@DNI", dniTextBox.Text);
						comando.Parameters.AddWithValue("@NOMBRE", nombreTextBox.Text);
						comando.Parameters.AddWithValue("@APELLIDO1", apellido1TextBox.Text);
						comando.Parameters.AddWithValue("@APELLIDO2", apellido2TextBox.Text);
						comando.Parameters.AddWithValue("@EMAIL", emailTextBox.Text);
						comando.Parameters.AddWithValue("@ID_PUESTO", metodos.encontrarIDPuesto(puestoComboBox));
						comando.Parameters.AddWithValue("@ID_ROL", 2);
						comando.Parameters.AddWithValue("@TELEFONO", telefonoTextBox.Text);
						comando.Parameters.AddWithValue("@DIRECCION", direccionTextBox.Text);
						comando.Parameters.AddWithValue("@ESTADO", estadoComboBox.SelectedItem);
						comando.Parameters.AddWithValue("@QR", qrBytes);

						comando.ExecuteNonQuery();

						enviarEmailQR(qrBytes);

						MessageBox.Show("Empleado agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}

				}
				catch (Exception error)
				{
					MessageBox.Show("Error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			
		}

		

		private byte[] GenerarQrCode(string texto)
		{
			using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
			{
				QRCodeData qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);
				using (QRCode qrCode = new QRCode(qrCodeData))
				{
					using (Bitmap qrBitmap = qrCode.GetGraphic(20))
					{
						using (MemoryStream ms = new MemoryStream())
						{
							qrBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
							return ms.ToArray();
						}
					}
				}
			}
		}

		private void enviarEmailQR(byte[] qrBytes)
		{
			using (MailMessage mail = new MailMessage())
			{
				mail.From = new MailAddress("appfusionsoftware@gmail.com");
				mail.To.Add(emailTextBox.Text);
				mail.Subject = "Código QR Registrado";
				mail.Body = "Adjuntamos su código QR generado con el DNI.";

				using (MemoryStream ms = new MemoryStream(qrBytes))
				{
					Attachment attachment = new Attachment(ms, "codigoQR.png", "image/png");
					mail.Attachments.Add(attachment);

					using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
					{
						smtp.Credentials = new NetworkCredential("appfusionsoftware@gmail.com", "lhfr diqm eqvn emyk");
						smtp.EnableSsl = true;
						smtp.Send(mail);
					}
				}
			}
		}

		private bool ValidarCampos()
		{
			bool valido = true;

			// Validar DNI
			if (string.IsNullOrWhiteSpace(dniTextBox.Text))
			{
				errorProvider.SetError(dniTextBox, "El DNI es obligatorio.");
				valido = false;
			}
			else
			{
				errorProvider.SetError(dniTextBox, "");
			}

			// Validar Nombre
			if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
			{
				errorProvider.SetError(nombreTextBox, "El nombre es obligatorio.");
				valido = false;
			}
			else
			{
				errorProvider.SetError(nombreTextBox, "");
			}

			// Validar Apellido 1
			if (string.IsNullOrWhiteSpace(apellido1TextBox.Text))
			{
				errorProvider.SetError(apellido1TextBox, "El primer apellido es obligatorio.");
				valido = false;
			}
			else
			{
				errorProvider.SetError(apellido1TextBox, "");
			}

			// Validar Apellido 2
			if (string.IsNullOrWhiteSpace(apellido2TextBox.Text))
			{
				errorProvider.SetError(apellido2TextBox, "El segundo apellido es obligatorio.");
				valido = false;
			}
			else
			{
				errorProvider.SetError(apellido2TextBox, "");
			}

			// Validar Email
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !emailTextBox.Text.Contains("@"))
			{
				errorProvider.SetError(emailTextBox, "Ingrese un correo válido.");
				valido = false;
			}
			else
			{
				errorProvider.SetError(emailTextBox, "");
			}

			// Validar Teléfono
			if (string.IsNullOrWhiteSpace(telefonoTextBox.Text))
			{
				errorProvider.SetError(telefonoTextBox, "El teléfono es obligatorio.");
				valido = false;
			}
			else
			{
				errorProvider.SetError(telefonoTextBox, "");
			}

			// Validar Dirección
			if (string.IsNullOrWhiteSpace(direccionTextBox.Text))
			{
				errorProvider.SetError(direccionTextBox, "La dirección es obligatoria.");
				valido = false;
			}
			else
			{
				errorProvider.SetError(direccionTextBox, "");
			}

			// Validar Estado (ComboBox)
			if (estadoComboBox.SelectedItem == null)
			{
				errorProvider.SetError(estadoComboBox, "Seleccione un estado.");
				valido = false;
			}
			else
			{
				errorProvider.SetError(estadoComboBox, "");
			}

			return valido;
		}
	}
}
