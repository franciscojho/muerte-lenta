using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmSexo : Form
    {
        private SexoBAL provider = new SexoBAL();
        List<SexoBO> genders = new List<SexoBO>();

        public frmSexo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtCode.ReadOnly = true;
            BlockFormControllers();
            SetGenders();
            AddDataGridViewRows(genders);
        }

        private void SetGenders()
        {
            genders = provider.ShowSexo();
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

        private void AddDataGridViewRows(List<SexoBO> genders)
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

            for (int i = 0; i < genders.Count; i++)
            {
                SexoBO gender = genders[i];
                dgvData.Rows.Add();
                dgvData.Rows[i].Cells["code"].Value = gender.code;
                dgvData.Rows[i].Cells["name"].Value = gender.name;
                dgvData.Rows[i].Cells["state"].Value = gender.state ? "Habilitado" : "Deshabilitado";
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private SexoBO? GetPayload()
        {
            SexoBO payload = new SexoBO();
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
            SexoBO? payload = GetPayload();
            bool isAddSuccess = provider.AddSexo(payload);

            if (isAddSuccess)
            {
                MessageBox.Show("Se resgistró el sexo");
                SetGenders();
                AddDataGridViewRows(genders);
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se resgistró el sexo");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SexoBO? payload = GetPayload();
            bool isAddSuccess = provider.UpdateSexo(payload);

            if (isAddSuccess)
            {
                MessageBox.Show("Se actualizó el sexo");
                SetGenders();
                AddDataGridViewRows(genders);
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se actualizó el sexo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SexoBO gender = new SexoBO();
            bool response = false;

            gender.code = Convert.ToInt32(txtCode.Text);

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres eliminar el sexo?",
                "Eliminando sexo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                response = provider.DeleteSexo(gender);
                if (response == true)
                {
                    MessageBox.Show("Se eliminó sexo");
                    SetGenders();
                    AddDataGridViewRows(genders);
                    ResetFields();
                    BlockFormControllers();
                    btnNew.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se eliminó el sexo");
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnEnable_Click(object sender, EventArgs e)
        {
            frmHabilitarSexo form = new frmHabilitarSexo();
            form.FormClosed += CloseListener;
            form.ShowDialog();
        }

        private void CloseListener(object sender, EventArgs e)
        {
            SetGenders();
            AddDataGridViewRows(genders);
        }
    }
}
