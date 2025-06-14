using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmHabilitarTipoPlato : Form
    {
        private TipoPlatoBAL tipoPlatoBAL = new TipoPlatoBAL();
        private int selectedCode;

        public frmHabilitarTipoPlato()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loadTipoPlato();
            customizedDataGridView();
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
            List<TipoPlatoBO> tipoPlatos = tipoPlatoBAL.ShowAllTipoPlato();
            dgvTipoPlato.DataSource = tipoPlatos;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            TipoPlatoBO tipoPlatoBO = new TipoPlatoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres habilitar el tipo de plato?",
                "Habilitando tipo de plato",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                tipoPlatoBO.code = selectedCode;
                response = tipoPlatoBAL.EnableTipoPlato(tipoPlatoBO);
                if (response == true)
                {
                    MessageBox.Show("Se habilitó el tipo de plato");
                    loadTipoPlato();
                }
                else
                {
                    MessageBox.Show("No se habilitó el tipo de plato");
                }
            }
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            TipoPlatoBO tipoPlatoBO = new TipoPlatoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres deshabilitar el tipo de plato?",
                "Deshabilitando tipo de plato",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                tipoPlatoBO.code = selectedCode;
                response = tipoPlatoBAL.DeleteTipoPlato(tipoPlatoBO);
                if (response == true)
                {
                    MessageBox.Show("Se deshabilitó el tipo de plato");
                    loadTipoPlato();
                }
                else
                {
                    MessageBox.Show("No se deshabilitó el tipo de plato");
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTipoPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvTipoPlato.Rows[index];
            selectedCode = Convert.ToInt32(selectedRow.Cells["code"].Value.ToString());
        }
    }
}
