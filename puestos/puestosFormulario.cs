using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkSync.database;

namespace WorkSync.puestos
{
	public partial class puestosFormulario : Form
	{
		public puestosFormulario()
		{
			InitializeComponent();
			metodos.CargarPuestos(puestoComboBox);
		}

		private void añadirRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.Height = 409;
			añadirLabel.Visible = true;
			añadirLabel.Text = "Introduce un nuevo puesto:";
			puestoTextBox.Visible = true;
			puestoButton.Text = "Añadir";
			puestoButton.Location = new System.Drawing.Point(308,278);
		}

		private void modificarRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.Height = 409;
			añadirLabel.Visible = true;
			añadirLabel.Text = "Introduce un nuevo nombre:";
			puestoTextBox.Visible = true;
			puestoButton.Text = "Modificar";
			puestoButton.Location = new System.Drawing.Point(308, 278);
		}

		private void eliminarRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			this.Height = 277;
			añadirLabel.Visible = false;
			puestoTextBox.Visible = false;
			puestoButton.Text = "Eliminar";
			puestoButton.Location = new System.Drawing.Point(308,147);
		}

		private void puestoButton_Click(object sender, EventArgs e)
		{
			if (añadirRadioButton.Checked)
			{
				añadirPuesto();
			}

			if (modificarRadioButton.Checked)
			{
				modificarPuesto();
			}

			if (eliminarRadioButton.Checked)
			{
				eliminarPuesto();
			}
		}

		private void añadirPuesto()
		{
			if (String.IsNullOrEmpty(puestoTextBox.Text))
			{
				MessageBox.Show("Debes introducir un nombre.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (!comprobarPuesto())
			{
				using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
				{
					conexion.Open();
					string consulta = "INSERT INTO PUESTO (NOMBRE) VALUES (@NOMBRE)";
					MySqlCommand comando = new MySqlCommand(consulta, conexion);
					comando.Parameters.AddWithValue("NOMBRE", puestoTextBox.Text);
					comando.ExecuteNonQuery();
					MessageBox.Show("Puesto añadido correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					puestoComboBox.Items.Clear();
					metodos.CargarPuestos(puestoComboBox);
					puestoTextBox.Text = "";
				}
			}
			else
			{
				MessageBox.Show("El puesto ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private bool comprobarPuesto()
		{
			bool rep = false;
			for (int x = 0; x < puestoComboBox.Items.Count; x++)
			{
				if (puestoTextBox.Text.Equals(puestoComboBox.Items[x].ToString()))
				{
					rep = true;
				}
			}
			return rep;
		}

		private void modificarPuesto()
		{
			if (String.IsNullOrEmpty(puestoTextBox.Text) || String.IsNullOrEmpty(puestoComboBox.Text))
			{
				MessageBox.Show("Debes seleccionar un puesto e introducir un nombre para modificarlo.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (!comprobarPuesto())
			{
				using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
				{
					conexion.Open();
					string consulta = "UPDATE PUESTO SET NOMBRE = @NOMBRENUEVO WHERE NOMBRE = @NOMBREANTIGUO";
					MySqlCommand comando = new MySqlCommand(consulta, conexion);
					comando.Parameters.AddWithValue("NOMBRENUEVO", puestoTextBox.Text);
					comando.Parameters.AddWithValue("NOMBREANTIGUO", puestoComboBox.Text);
					comando.ExecuteNonQuery();
					MessageBox.Show("Puesto modificado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					puestoComboBox.Items.Clear();
					metodos.CargarPuestos(puestoComboBox);
					puestoTextBox.Text = "";
				}
			}
			else
			{
				MessageBox.Show("El puesto ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void eliminarPuesto()
		{
			if (String.IsNullOrEmpty(puestoComboBox.Text))
			{
				MessageBox.Show("Debes seleccionar un puesto para eliminarlo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			using (MySqlConnection conexion = new MySqlConnection(credenciales.obtenerCredenciales()))
			{
				conexion.Open();
				string consulta = "DELETE FROM PUESTO WHERE NOMBRE = @NOMBRE";
				MySqlCommand comando = new MySqlCommand(consulta, conexion);
				comando.Parameters.AddWithValue("NOMBRE", puestoComboBox.Text);
				comando.ExecuteNonQuery();
				MessageBox.Show("Puesto eliminado correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
				puestoComboBox.Items.Clear();
				metodos.CargarPuestos(puestoComboBox);
				puestoTextBox.Text = "";
			}

		}
	}
}
