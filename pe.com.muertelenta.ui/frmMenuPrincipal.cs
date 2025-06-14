using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe.com.muertelenta.ui
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        private void tsmCerrarSesion_Click(object sender, EventArgs e)
        {
            frmIngreso form = new frmIngreso();
            form.Show();
            Hide();
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmTipoPlato_Click(object sender, EventArgs e)
        {
            frmTipoPlato form = new frmTipoPlato();
            form.ShowDialog();
        }

        private void tsmDistrito_Click(object sender, EventArgs e)
        {
            frmDistrito form = new frmDistrito();
            form.ShowDialog();
        }

        private void tsmTipoDeDocumento_Click(object sender, EventArgs e)
        {
            frmTipoDocumento form = new frmTipoDocumento();
            form.ShowDialog();
        }

        private void tsmSexo_Click(object sender, EventArgs e)
        {
            frmSexo form = new frmSexo();
            form.ShowDialog();
        }

        private void tsmRol_Click(object sender, EventArgs e)
        {
            frmRol form = new frmRol();
            form.ShowDialog();
        }

        private void tsmCliente_Click(object sender, EventArgs e)
        {
            frmCliente form = new frmCliente();
            form.ShowDialog();
        }

        private void tsmEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleado form = new frmEmpleado();
            form.ShowDialog();
        }
    }
}
