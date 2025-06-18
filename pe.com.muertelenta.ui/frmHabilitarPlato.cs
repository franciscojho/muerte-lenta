using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmHabilitarPlato : Form
    {
        private PlatoBAL provider = new PlatoBAL();
        List<PlatoBO> dishes = new List<PlatoBO>();
        private int selectedCode;

        public frmHabilitarPlato()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetDishes();
            AddDataGridViewRows(dishes);
        }

        private void SetDishes()
        {
            dishes = provider.ShowAllPlato();
        }

        private void AddDataGridViewRows(List<PlatoBO> dishes)
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

            for (int i = 0; i < dishes.Count; i++)
            {
                PlatoBO dish = dishes[i];
                dgvData.Rows.Add();
                dgvData.Rows[i].Cells["code"].Value = dish.code;
                dgvData.Rows[i].Cells["name"].Value = dish.name;
                dgvData.Rows[i].Cells["state"].Value = dish.state ? "Habilitado" : "Deshabilitado";
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            PlatoBO dish = new PlatoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres habilitar el plato?",
                "Habilitando plato",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                dish.code = selectedCode;
                response = provider.EnablePlato(dish);
                if (response == true)
                {
                    MessageBox.Show("Se habilitó el plato");
                    SetDishes();
                    AddDataGridViewRows(dishes);
                }
                else
                {
                    MessageBox.Show("No se habilitó el plato");
                }
            }
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            PlatoBO dish = new PlatoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres deshabilitar el plato?",
                "Deshabilitando plato",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                dish.code = selectedCode;
                response = provider.DeletePlato(dish);
                if (response == true)
                {
                    MessageBox.Show("Se deshabilitó el plato");
                    SetDishes();
                    AddDataGridViewRows(dishes);
                }
                else
                {
                    MessageBox.Show("No se deshabilitó el plato");
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
