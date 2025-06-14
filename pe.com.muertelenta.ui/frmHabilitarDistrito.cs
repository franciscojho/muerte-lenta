using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmHabilitarDistrito : Form
    {
        private DistritoBAL provider = new DistritoBAL();
        List<DistritoBO> districts = new List<DistritoBO>();
        private int selectedCode;

        public frmHabilitarDistrito()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetDistricts();
            AddDataGridViewRows(districts);
        }

        private void SetDistricts()
        {
            districts = provider.ShowAllDistrito();
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

        private void btnEnable_Click(object sender, EventArgs e)
        {
            DistritoBO district = new DistritoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres habilitar el distrito?",
                "Habilitando distrito",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                district.code = selectedCode;
                response = provider.EnableDistrito(district);
                if (response == true)
                {
                    MessageBox.Show("Se habilitó el distrito");
                    SetDistricts();
                    AddDataGridViewRows(districts);
                }
                else
                {
                    MessageBox.Show("No se habilitó el distrito");
                }
            }
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            DistritoBO district = new DistritoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres deshabilitar el distrito?",
                "Deshabilitando distrito",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                district.code = selectedCode;
                response = provider.DeleteDistrito(district);
                if (response == true)
                {
                    MessageBox.Show("Se deshabilitó el distrito");
                    SetDistricts();
                    AddDataGridViewRows(districts);
                }
                else
                {
                    MessageBox.Show("No se deshabilitó el distrito");
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
