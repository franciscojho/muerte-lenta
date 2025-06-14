using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmHabilitarRol : Form
    {
        private RolBAL provider = new RolBAL();
        List<RolBO> roles = new List<RolBO>();
        private int selectedCode;

        public frmHabilitarRol()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetRoles();
            AddDataGridViewRows(roles);
        }

        private void SetRoles()
        {
            roles = provider.ShowAllRol();
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

        private void btnEnable_Click(object sender, EventArgs e)
        {
            RolBO role = new RolBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres habilitar el rol?",
                "Habilitando rol",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                role.code = selectedCode;
                response = provider.EnableRol(role);
                if (response == true)
                {
                    MessageBox.Show("Se habilitó el rol");
                    SetRoles();
                    AddDataGridViewRows(roles);
                }
                else
                {
                    MessageBox.Show("No se habilitó el rol");
                }
            }
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            RolBO role = new RolBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres deshabilitar el rol?",
                "Deshabilitando rol",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                role.code = selectedCode;
                response = provider.DeleteRol(role);
                if (response == true)
                {
                    MessageBox.Show("Se deshabilitó el rol");
                    SetRoles();
                    AddDataGridViewRows(roles);
                }
                else
                {
                    MessageBox.Show("No se deshabilitó el rol");
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvData.Rows[index];
            selectedCode = Convert.ToInt32(selectedRow.Cells["code"].Value.ToString());
        }
    }
}
