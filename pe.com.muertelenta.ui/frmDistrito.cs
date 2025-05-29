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
    public partial class frmDistrito : Form
    {
        private DistritoBAL distritoBAL = new DistritoBAL();

        public frmDistrito()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtCode.ReadOnly = true;
            enableFieldsAndButtons(false);
            loadDistritos();
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
            dgvDistrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDistrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDistrito.AutoGenerateColumns = false;
            dgvDistrito.Columns.Clear();
            dgvDistrito.ClearSelection();
            dgvDistrito.ReadOnly = true;

            dgvDistrito.Columns.Add("code", "Código");
            dgvDistrito.Columns["code"].DataPropertyName = "code";

            dgvDistrito.Columns.Add("name", "Nombre");
            dgvDistrito.Columns["name"].DataPropertyName = "name";

            DataGridViewTextBoxColumn stateColumn = new DataGridViewTextBoxColumn
            {
                Name = "state",
                HeaderText = "Estado",
                DataPropertyName = "state"
            };

            dgvDistrito.Columns.Add(stateColumn);
            dgvDistrito.CellFormatting += (s, e) =>
            {
                if (dgvDistrito.Columns[e.ColumnIndex].Name == "state" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            foreach (DataGridViewColumn column in dgvDistrito.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void loadDistritos()
        {
            List<DistritoBO> distritoBOs = distritoBAL.ShowAllDistrito();
            dgvDistrito.DataSource = distritoBOs;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enableFieldsAndButtons(true);
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DistritoBO distritoBO = new DistritoBO();
            bool response = false;

            if (txtName.Text == "")
            {
                MessageBox.Show("Ingresa el nombre");
                txtName.Focus();
            }
            else
            {
                distritoBO.name = txtName.Text;
                distritoBO.state = cbState.Checked;
                response = distritoBAL.AddDistrito(distritoBO);
                if (response == true)
                {
                    MessageBox.Show("Se registró el distrito");
                    loadDistritos();
                    clearFields();
                    enableFieldsAndButtons(false);
                    btnNew.Enabled = true;
                }
            }
        }
    }
}
