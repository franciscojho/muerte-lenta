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
    public partial class frmTipoDocumento : Form
    {
        private TipoDocumentoBAL tipoDocumentoBAL = new TipoDocumentoBAL();

        public frmTipoDocumento()
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
            dgvTipoDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTipoDocumento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoDocumento.AutoGenerateColumns = false;
            dgvTipoDocumento.Columns.Clear();
            dgvTipoDocumento.ClearSelection();
            dgvTipoDocumento.ReadOnly = true;

            dgvTipoDocumento.Columns.Add("code", "Código");
            dgvTipoDocumento.Columns["code"].DataPropertyName = "code";

            dgvTipoDocumento.Columns.Add("name", "Nombre");
            dgvTipoDocumento.Columns["name"].DataPropertyName = "name";

            DataGridViewTextBoxColumn stateColumn = new DataGridViewTextBoxColumn
            {
                Name = "state",
                HeaderText = "Estado",
                DataPropertyName = "state"
            };

            dgvTipoDocumento.Columns.Add(stateColumn);
            dgvTipoDocumento.CellFormatting += (s, e) =>
            {
                if (dgvTipoDocumento.Columns[e.ColumnIndex].Name == "state" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            foreach (DataGridViewColumn column in dgvTipoDocumento.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void loadTipoPlato()
        {
            List<TipoDocumentoBO> tipoDocumentosBOs = tipoDocumentoBAL.ShowAllTipoDocumento();
            dgvTipoDocumento.DataSource = tipoDocumentosBOs;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enableFieldsAndButtons(true);
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TipoDocumentoBO tipoDocumentoBO = new TipoDocumentoBO();
            bool response = false;

            if (txtName.Text == "")
            {
                MessageBox.Show("Ingresa el nombre");
                txtName.Focus();
            }
            else
            {
                tipoDocumentoBO.name = txtName.Text;
                tipoDocumentoBO.state = cbState.Checked;
                response = tipoDocumentoBAL.AddTipoDocumento(tipoDocumentoBO);
                if (response == true)
                {
                    MessageBox.Show("Se registró el tipo de documento");
                    loadTipoPlato();
                    clearFields();
                    enableFieldsAndButtons(false);
                    btnNew.Enabled = true;
                }
            }
        }
    }
}
