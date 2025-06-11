using Emgu.CV.Dnn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkSync.database;
using static Mysqlx.Crud.Order.Types;

namespace WorkSync.asistencias
{
	public partial class buscarUsuario : Form
	{

		public static string dni = "";

		public buscarUsuario()
		{
			InitializeComponent();
			metodos.cargarDatosEmpleados(empleadosDataGridView);
		}

		private void empleadosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow filaSeleccionada = empleadosDataGridView.Rows[e.RowIndex];
				dni = filaSeleccionada.Cells["DNI"].Value.ToString();
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

		private void aceptarButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
