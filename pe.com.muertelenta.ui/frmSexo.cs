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
    public partial class frmSexo : Form
    {
        private SexoBAL sexoBAL = new SexoBAL();

        public frmSexo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtCode.ReadOnly = true;
            enableFieldsAndButtons(false);
            loadSexo();
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
            dgvSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSexo.AutoGenerateColumns = false;
            dgvSexo.Columns.Clear();
            dgvSexo.ClearSelection();
            dgvSexo.ReadOnly = true;

            dgvSexo.Columns.Add("code", "Código");
            dgvSexo.Columns["code"].DataPropertyName = "code";

            dgvSexo.Columns.Add("name", "Nombre");
            dgvSexo.Columns["name"].DataPropertyName = "name";

            DataGridViewTextBoxColumn stateColumn = new DataGridViewTextBoxColumn
            {
                Name = "state",
                HeaderText = "Estado",
                DataPropertyName = "state"
            };

            dgvSexo.Columns.Add(stateColumn);
            dgvSexo.CellFormatting += (s, e) =>
            {
                if (dgvSexo.Columns[e.ColumnIndex].Name == "state" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            foreach (DataGridViewColumn column in dgvSexo.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void loadSexo()
        {
            List<SexoBO> sexoBOs = sexoBAL.ShowAllSexo();
            dgvSexo.DataSource = sexoBOs;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enableFieldsAndButtons(true);
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SexoBO sexoBO = new SexoBO();
            bool response = false;

            if (txtName.Text == "")
            {
                MessageBox.Show("Ingresa el nombre");
                txtName.Focus();
            }
            else
            {
                sexoBO.name = txtName.Text;
                sexoBO.state = cbState.Checked;
                response = sexoBAL.addSexo(sexoBO);
                if (response == true)
                {
                    MessageBox.Show("Se registró el sexo");
                    loadSexo();
                    clearFields();
                    enableFieldsAndButtons(false);
                    btnNew.Enabled = true;
                }
            }
        }
    }
}
