using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmDistrito : Form
    {
        private DistritoBAL provider = new DistritoBAL();
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
            districts = provider.ShowDistrito();
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

        private void ResetFields()
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

        private DistritoBO? GetPayload()
        {
            DistritoBO payload = new DistritoBO();
            string name = txtName.Text.Trim();
            int code = int.TryParse(txtCode.Text.Trim(), out code) ? code : 0;
            bool state = cbState.Checked;

            if (code != 0)
            {
                payload.code = code;
            }

            if (!string.IsNullOrEmpty(name))
            {
                payload.name = name;
                payload.state = state;
            }
            else
            {
                MessageBox.Show("El campo Nombre es requerido");
                payload = null;
            }
            return payload;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UnblockFormControllers();
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DistritoBO? payload = GetPayload();
            bool isAddSuccess = provider.AddDistrito(payload);

            if (isAddSuccess)
            {
                MessageBox.Show("Se resgistró el distrito");
                SetDistricts();
                AddDataGridViewRows(districts);
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se resgistró el distrito");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DistritoBO? payload = GetPayload();
            bool isAddSuccess = provider.UpdateDistrito(payload);

            if (isAddSuccess)
            {
                MessageBox.Show("Se actualizó el distrito");
                SetDistricts();
                AddDataGridViewRows(districts);
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se actualizó el distrito");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DistritoBO district = new DistritoBO();
            bool response = false;

            district.code = Convert.ToInt32(txtCode.Text);

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres eliminar el distrito?",
                "Eliminando distrito",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                response = provider.DeleteDistrito(district);
                if (response == true)
                {
                    MessageBox.Show("Se eliminó distrito");
                    SetDistricts();
                    AddDataGridViewRows(districts);
                    ResetFields();
                    BlockFormControllers();
                    btnNew.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se eliminó el distrito");
                }
            }
        }

        private void dgvDistrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            UnblockFormControllers();
            btnAdd.Enabled = true;
            DataGridViewRow selectedRow = dgvData.Rows[index];
            Console.WriteLine(selectedRow.Cells["code"].Value);
            if (selectedRow.Cells["code"].Value != null)
            {
                txtCode.Text = selectedRow.Cells["code"].Value.ToString();
                txtName.Text = selectedRow.Cells["name"].Value.ToString();
                cbState.Checked = selectedRow.Cells["state"].Value.ToString() == "Habilitado" ? true : false;
            }
        }
    }
}
