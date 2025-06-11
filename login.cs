using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WorkSync.database;

namespace WorkSync
{
	public partial class login : Form
	{

		public login()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{

			string email = usuarioTextBox.Text;
			string password = contraseñaTextBox.Text;

			if (comprobarLogin(email, password))
			{
				main main = new main();
				main.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private bool comprobarLogin(string email, string password) 
		{
			
			string hashPassword = calcularSHA256.CalcularSHA256(password);

			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				conexion.Open();
				string consulta = "SELECT COUNT(*) FROM USUARIO WHERE EMAIL = @EMAIL AND PASSWORD = @PASSWORD";
				MySqlCommand comando = new MySqlCommand(consulta,conexion);
				comando.Parameters.AddWithValue("EMAIL", email);
				comando.Parameters.AddWithValue("PASSWORD", hashPassword);
				int contador = Convert.ToInt32(comando.ExecuteScalar());
				return contador > 0;
			}

		}

		private void mostrarContraseña_CheckedChanged(object sender, EventArgs e)
		{
			if (mostrarContraseña.Checked)
			{
				contraseñaTextBox.PasswordChar = default;
			}
			else
			{
				contraseñaTextBox.PasswordChar = '*';
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void closeMenu_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void minimizeMenu_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
			// Crear un rectángulo que cubra todo el panel
			Rectangle rect = new Rectangle(0, 0, splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);

			// Crear un degradado con tres colores
			using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Empty, Color.Empty, LinearGradientMode.Vertical))
			{
				// Definir los colores y sus posiciones en el degradado
				ColorBlend blend = new ColorBlend();
				blend.Colors = new Color[] {
					Color.FromArgb(7, 41, 66),   // #072942 (arriba)
                    Color.FromArgb(19, 51, 71),  // #133347 (centro)
                    Color.FromArgb(100, 117, 133) // #647585 (abajo)
                };
				blend.Positions = new float[] { 0.0f, 0.5f, 1.0f }; // Posiciones relativas en el degradado

				// Aplicar los colores al pincel
				brush.InterpolationColors = blend;

				// Dibujar el degradado en el panel
				e.Graphics.FillRectangle(brush, rect);
			}
		}

	}
}
