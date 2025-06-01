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
    public partial class frmTipoPlato : Form
    {
        private TipoPlatoBAL tipoPlatoBAL = new TipoPlatoBAL();

        public frmTipoPlato()
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
            dgvTipoPlato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTipoPlato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoPlato.AutoGenerateColumns = false;
            dgvTipoPlato.Columns.Clear();
            dgvTipoPlato.ClearSelection();
            dgvTipoPlato.ReadOnly = true;

            dgvTipoPlato.Columns.Add("code", "Còdigo");
            dgvTipoPlato.Columns["code"].DataPropertyName = "code";

            dgvTipoPlato.Columns.Add("name", "Nombre");
            dgvTipoPlato.Columns["name"].DataPropertyName = "name";

            DataGridViewTextBoxColumn stateColumn = new DataGridViewTextBoxColumn
            {
                Name = "state",
                HeaderText = "Estado",
                DataPropertyName = "state"
            };

            dgvTipoPlato.Columns.Add(stateColumn);
            dgvTipoPlato.CellFormatting += (s, e) =>
            {
                if (dgvTipoPlato.Columns[e.ColumnIndex].Name == "state" && e.Value != null)
                {
                    e.Value = (bool)e.Value ? "Habilitado" : "Deshabilitado";
                    e.FormattingApplied = true;
                }
            };

            foreach (DataGridViewColumn column in dgvTipoPlato.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void loadTipoPlato()
        {
            List<TipoPlatoBO> tipoPlatos = tipoPlatoBAL.ShowTipoPlato();
            dgvTipoPlato.DataSource = tipoPlatos;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enableFieldsAndButtons(true);
            btnNew.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TipoPlatoBO tipoPlatoBO = new TipoPlatoBO();
            bool response = false;

            if (txtName.Text == "")
            {
                MessageBox.Show("Ingresa el nombre");
                txtName.Focus();
            }
            else
            {
                tipoPlatoBO.name = txtName.Text;
                tipoPlatoBO.state = cbState.Checked;
                response = tipoPlatoBAL.AddTipoPlato(tipoPlatoBO);
                if (response == true)
                {
                    MessageBox.Show("Se registró el tipo de plato");
                    loadTipoPlato();
                    clearFields();
                    enableFieldsAndButtons(false);
                    btnNew.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se resgistró el tipo de plato");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TipoPlatoBO tipoPlatoBO = new TipoPlatoBO();
            bool response = false;

            tipoPlatoBO.code = Convert.ToInt32(txtCode.Text);
            tipoPlatoBO.name = txtName.Text;
            tipoPlatoBO.state = cbState.Checked;
            response = tipoPlatoBAL.UpdateTipoPlato(tipoPlatoBO);
            if (response == true)
            {
                MessageBox.Show("Se actualizó el tipo de plato");
                loadTipoPlato();
                clearFields();
                enableFieldsAndButtons(false);
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se actualizó el tipo de plato");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TipoPlatoBO tipoPlatoBO = new TipoPlatoBO();
            bool response = false;

            tipoPlatoBO.code = Convert.ToInt32(txtCode.Text);

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres eliminar el tipo de plato?",
                "Eliminando tipo de plato",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                response = tipoPlatoBAL.DeleteTipoPlato(tipoPlatoBO);
                if (response == true)
                {
                    MessageBox.Show("Se eliminó el tipo de plato");
                    loadTipoPlato();
                    clearFields();
                    enableFieldsAndButtons(false);
                    btnNew.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se eliminó el tipo de plato");
                }
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            frmHabilitarTipoPlato form = new frmHabilitarTipoPlato();
            form.ShowDialog();
        }

        private void dgvTipoPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            enableFieldsAndButtons(true);
            btnAdd.Enabled = true;
            DataGridViewRow selectedRow = dgvTipoPlato.Rows[index];
            txtCode.Text = selectedRow.Cells["code"].Value.ToString();
            txtName.Text = selectedRow.Cells["name"].Value.ToString();
            if (Convert.ToBoolean(selectedRow.Cells["state"].Value))
            {
                cbState.Checked = true;
            }
            else
            {
                cbState.Checked = true;
            }
        }
    }
}