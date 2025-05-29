using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;
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
    public partial class frmRol : Form
    {
        private RolBAL rolBAL = new RolBAL();

        public frmRol()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtCode.ReadOnly = true;
            enableFieldsAndButtons(false);
            loadTipoPlato();
            customizedDataGridView();
        }

        private void enableFieldsAndButtons(bool isEnabled)
        {
            txtCode.Enabled = isEnabled;
            txtName.Enabled = isEnabled;
            cbState.Enabled = isEnabled;
            btnAdd.Enabled = isEnabled;
            btnUpdate.Enabled = isEnabled;
            btnDelete.Enabled = isEnabled;
        }

        private void clearFields()
        {
            txtCode.Clear();
            txtName.Clear();
            cbState.Checked = false;
            txtName.Focus();
        }

        private void customizedDataGridView()
        {
            dgvRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRol.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRol.AutoGenerateColumns = false;
            dgvRol.Columns.Clear();
            dgvRol.ClearSelection();
            dgvRol.ReadOnly = true;

            dgvRol.Columns.Add("code", "Còdigo");
            dgvRol.Columns["code"].DataPropertyName = "code";

            dgvRol.Columns.Add("name", "Nombre");
            dgvRol.Columns["name"].DataPropertyName = "name";

            DataGridViewTextBoxColumn stateColumn = new DataGridViewTextBoxColumn
            {
                Name = "state",
                HeaderText = "Estado",
                DataPropertyName = "state"
            };

            dgvRol.Columns.Add(stateColumn);
            dgvRol.CellFormatting += (s, e) =>
            {
                if (dgvRol.Columns[e.ColumnIndex].Name == "state" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            foreach (DataGridViewColumn column in dgvRol.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void loadTipoPlato()
        {
            List<RolBO> rolBOs = rolBAL.ShowAllRol();
            dgvRol.DataSource = rolBOs;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enableFieldsAndButtons(true);
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RolBO rolBO = new RolBO();
            bool response = false;

            if (txtName.Text == "")
            {
                MessageBox.Show("Ingresa el nombre");
                txtName.Focus();
            }
            else
            {
                rolBO.name = txtName.Text;
                rolBO.state = cbState.Checked;
                response = rolBAL.AddRol(rolBO);
                if (response == true)
                {
                    MessageBox.Show("Se registró el rol");
                    loadTipoPlato();
                    clearFields();
                    enableFieldsAndButtons(false);
                    btnNew.Enabled = true;
                }
            }
        }
    }
}
