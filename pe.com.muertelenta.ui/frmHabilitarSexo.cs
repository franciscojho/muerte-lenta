using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmHabilitarSexo : Form
    {
        private SexoBAL provider = new SexoBAL();
        List<SexoBO> genders = new List<SexoBO>();
        private int selectedCode;

        public frmHabilitarSexo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetGenders();
            AddDataGridViewRows(genders);
        }

        private void SetGenders()
        {
            genders = provider.ShowAllSexo();
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

        private void btnEnable_Click(object sender, EventArgs e)
        {
            SexoBO gender = new SexoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres habilitar el sexo?",
                "Habilitando sexo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                gender.code = selectedCode;
                response = provider.EnableSexo(gender);
                if (response == true)
                {
                    MessageBox.Show("Se habilitó el sexo");
                    SetGenders();
                    AddDataGridViewRows(genders);
                }
                else
                {
                    MessageBox.Show("No se habilitó el sexo");
                }
            }
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            SexoBO gender = new SexoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres deshabilitar el sexo?",
                "Deshabilitando sexo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                gender.code = selectedCode;
                response = provider.DeleteSexo(gender);
                if (response == true)
                {
                    MessageBox.Show("Se deshabilitó el sexo");
                    SetGenders();
                    AddDataGridViewRows(genders);
                }
                else
                {
                    MessageBox.Show("No se deshabilitó el sexo");
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
