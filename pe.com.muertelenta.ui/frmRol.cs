using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmRol : Form
    {
        private RolBAL provider = new RolBAL();
        List<RolBO> roles = new List<RolBO>();

        public frmRol()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtCode.ReadOnly = true;
            BlockFormControllers();
            SetRoles();
            AddDataGridViewRows(roles);
        }

        private void SetRoles()
        {
            roles = provider.ShowRol();
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

        private void AddDataGridViewRows(List<RolBO> roles)
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

            for (int i = 0; i < roles.Count; i++)
            {
                RolBO role = roles[i];
                dgvData.Rows.Add();
                dgvData.Rows[i].Cells["code"].Value = role.code;
                dgvData.Rows[i].Cells["name"].Value = role.name;
                dgvData.Rows[i].Cells["state"].Value = role.state ? "Habilitado" : "Deshabilitado";
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private RolBO? GetPayload()
        {
            RolBO payload = new RolBO();
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
            RolBO? payload = GetPayload();
            bool isAddSuccess = provider.AddRol(payload);

            if (isAddSuccess)
            {
                MessageBox.Show("Se resgistró el rol");
                SetRoles();
                AddDataGridViewRows(roles);
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se resgistró el rol");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RolBO? payload = GetPayload();
            bool isAddSuccess = provider.UpdateRol(payload);

            if (isAddSuccess)
            {
                MessageBox.Show("Se actualizó el rol");
                SetRoles();
                AddDataGridViewRows(roles);
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se actualizó el rol");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RolBO role = new RolBO();
            bool response = false;

            role.code = Convert.ToInt32(txtCode.Text);

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres eliminar el rol?",
                "Eliminando rol",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                response = provider.DeleteRol(role);
                if (response == true)
                {
                    MessageBox.Show("Se eliminó rol");
                    SetRoles();
                    AddDataGridViewRows(roles);
                    ResetFields();
                    BlockFormControllers();
                    btnNew.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se eliminó el rol");
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
            if (selectedRow .Cells["code"].Value != null)
            {
                txtCode.Text = selectedRow.Cells["code"].Value.ToString();
                txtName.Text = selectedRow.Cells["name"].Value.ToString();
                cbState.Checked = selectedRow.Cells["state"].Value.ToString() == "Habilitado" ? true : false;
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            frmHabilitarRol form = new frmHabilitarRol();
            form.FormClosed += CloseListener;
            form.ShowDialog();
        }

        private void CloseListener(object sender, EventArgs e)
        {
            SetRoles();
            AddDataGridViewRows(roles);
        }
    }
}
