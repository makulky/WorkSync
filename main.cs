using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WorkSync
{
	public partial class main : Form
	{
		// Constantes para mover y redimensionar la ventana
		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HTCAPTION = 0x2;
		private const int HTBOTTOMRIGHT = 17; // Código para la esquina inferior derecha

		// Importar funciones de la API de Windows
		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		public main()
		{
			InitializeComponent();

			this.panelResize.Enabled = false;
			// Establecer los límites maximizados sin cubrir la barra de tareas
			this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
			this.WindowState = FormWindowState.Maximized;

			// Evento para mover la ventana
			panelMenu.MouseDown += PanelBarra_MouseDown;

			// Evento para redimensionar desde la esquina
			panelResize.MouseDown += PanelResize_MouseDown;

			AbrirFormularioEnPanel(new usuarios.gestionUsuarios());
		}

		// Permite mover la ventana al hacer clic en el panel de la barra superior
		private void PanelBarra_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
			}
		}

		// Permite redimensionar la ventana al hacer clic en el panel de la esquina inferior derecha
		private void PanelResize_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTBOTTOMRIGHT, 0);
			}
		}

		private void closeMenu_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void maximizedMenu_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Maximized)
			{
				this.WindowState = FormWindowState.Normal;
				this.panelResize.Enabled = true;
			}
			else
			{
				this.panelResize.Enabled = false;
				this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void minimizeMenu_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void AbrirFormularioEnPanel(object formHijo)
		{
			if (this.panelContenedor.Controls.Count > 0)
				this.panelContenedor.Controls.RemoveAt(0);

			Form fh = formHijo as Form;
			fh.TopLevel = false;
			fh.FormBorderStyle = FormBorderStyle.None;
			fh.Dock = DockStyle.Fill;
			this.panelContenedor.Controls.Add(fh);
			this.panelContenedor.Tag = fh;
			fh.Show();
		}

		private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirFormularioEnPanel(new usuarios.gestionUsuarios());
		}

		private void registroDeAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AbrirFormularioEnPanel(new asistencias.registroAsistencias());
		}

		private void backupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			backup.backupFormulario backupFormulario = new backup.backupFormulario();
			backupFormulario.ShowDialog();
		}

		private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			puestos.puestosFormulario puestosFormulario = new puestos.puestosFormulario();
			puestosFormulario.ShowDialog();
		}
	}
}
