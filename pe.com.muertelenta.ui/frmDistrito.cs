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
        List<DistritoBO> districts = new List<DistritoBO>();

        public frmDistrito()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtCode.ReadOnly = true;
            BlockFormControllers();
            SetDistricts();
            AddDataGridViewRows(districts);
        }

        private void SetDistricts()
        {
            districts = distritoBAL.ShowDistrito();
        }


        private void UnblockFormControllers(bool isEnabled = true)
        {
            txtName.Enabled = isEnabled;
            cbState.Enabled = isEnabled;
            btnAdd.Enabled = isEnabled;
            btnUpdate.Enabled = isEnabled;
            btnDelete.Enabled = isEnabled;
        }

        private void BlockFormControllers()
        {
            UnblockFormControllers(false);
        }


        private void clearFields()
        {
            txtCode.Clear();
            txtName.Clear();
            cbState.Checked = false;
            txtName.Focus();
        }

        private void AddDataGridViewRows(List<DistritoBO> districts)
        {
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AutoGenerateColumns = false;
            dgvData.Columns.Clear();
            dgvData.ClearSelection();
            dgvData.ReadOnly = true;

            dgvData.Columns.Add("code", "Código");
            dgvData.Columns.Add("name", "Nombre");

            DataGridViewTextBoxColumn stateColumn = new DataGridViewTextBoxColumn
            {
                Name = "state",
                HeaderText = "Estado",
                DataPropertyName = "state"
            };

            dgvData.Columns.Add(stateColumn);

            for (int i = 0; i < districts.Count; i++)
            {
                DistritoBO district = districts[i];
                dgvData.Rows.Add();
                dgvData.Rows[i].Cells["code"].Value = district.code;
                dgvData.Rows[i].Cells["name"].Value = district.name;
                dgvData.Rows[i].Cells["state"].Value = district.state ? "Habilitado" : "Deshabilitado";
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UnblockFormControllers();
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
                    SetDistricts();
                    AddDataGridViewRows(districts);
                    clearFields();
                    BlockFormControllers();
                    btnNew.Enabled = true;
                }
            }
        }

        private void dgvDistrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            UnblockFormControllers();
            btnAdd.Enabled = true;
            DataGridViewRow selectedRow = dgvData.Rows[index];
            txtCode.Text = selectedRow.Cells["code"].Value.ToString();
            txtName.Text = selectedRow.Cells["name"].Value.ToString();
            cbState.Checked = selectedRow.Cells["state"].Value.ToString() == "Habilitado" ? true : false;
        }
    }
}
