using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

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
            EmpleadoBO employeeData = new EmpleadoBO();
            EmpleadoBAL empleadoBAL = new EmpleadoBAL();

            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            bool hasUserName = !String.IsNullOrEmpty(userName);
            bool hasPassword = !String.IsNullOrEmpty(password);

            if (hasUserName)
            {
                employeeData.userName = userName;
            }
            else
            {
                MessageBox.Show("Ingrese el usuario");
            }

            if (hasPassword)
            {
                employeeData.password = password;
            }
            else
            {
                MessageBox.Show("Ingrese la contraseña");
            }

            bool isEmployeeValid = empleadoBAL.ValidateEmployee(employeeData);

            if (hasUserName && hasPassword)
            {
                if (isEmployeeValid)
                {
                    formMenu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos");
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
