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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal formMenu = new frmMenuPrincipal();
            formMenu.Show();
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
