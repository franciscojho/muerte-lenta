﻿using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmHabilitarTipoPlato : Form
    {
        private TipoPlatoBAL tipoPlatoBAL = new TipoPlatoBAL();
        List<TipoPlatoBO> dishTypes = new List<TipoPlatoBO>();
        private int selectedCode;

        public frmHabilitarTipoPlato()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetDishTypes();
            AddDataGridViewRows(dishTypes);
        }

        private void SetDishTypes()
        {
            dishTypes = tipoPlatoBAL.ShowAllTipoPlato();
        }

        private void AddDataGridViewRows(List<TipoPlatoBO> dishTypes)
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

            for (int i = 0; i < dishTypes.Count; i++)
            {
                TipoPlatoBO dishType = dishTypes[i];
                dgvData.Rows.Add();
                dgvData.Rows[i].Cells["code"].Value = dishType.code;
                dgvData.Rows[i].Cells["name"].Value = dishType.name;
                dgvData.Rows[i].Cells["state"].Value = dishType.state ? "Habilitado" : "Deshabilitado";
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
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
                    SetDishTypes();
                    AddDataGridViewRows(dishTypes);
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
                    SetDishTypes();
                    AddDataGridViewRows(dishTypes);
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
            DataGridViewRow selectedRow = dgvData.Rows[index];
            selectedCode = Convert.ToInt32(selectedRow.Cells["code"].Value.ToString());
        }
    }
}
