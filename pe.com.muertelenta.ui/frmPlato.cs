using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;
using System.Data;

namespace pe.com.muertelenta.ui
{

    public partial class frmPlato : Form
    {
        private PlatoBAL platoBAL = new PlatoBAL();
        private TipoPlatoBAL tipoPlatoBAL = new TipoPlatoBAL();

        public frmPlato()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtCode.ReadOnly = true;
            BlockFormControllers();
            AddDataGridViewRows(GetPlatos());
            AddComboBoxOptions(GetTipoPlatos());
        }

        private List<PlatoBO> GetPlatos()
        {
            return platoBAL.ShowPlato();
        }

        private List<TipoPlatoBO> GetTipoPlatos()
        {
            return tipoPlatoBAL.ShowTipoPlato();
        }

        private PlatoBO? GetPayload()
        {
            PlatoBO payload = new PlatoBO();
            TipoPlatoBO tipoPlatoBO = new TipoPlatoBO();

            string name = txtName.Text;
            string description = txtDescription.Text.Trim();
            int dishType = int.TryParse(cbDishType.SelectedValue.ToString(), out dishType) ? dishType : -1;
            int quantity = int.TryParse(txtQuantity.Text, out quantity) ? quantity : 0;
            double price = double.TryParse(txtPrice.Text, out price) ? price : 0;
            bool state = chState.Checked;

            if (
                !string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(description) &&
                dishType > 0 && price > 0 && quantity > 0
            )
            {
                payload.name = name;
                payload.description = description;
                payload.price = price;
                payload.quantity = quantity;
                payload.state = state;

                tipoPlatoBO.code = Convert.ToInt32(cbDishType.SelectedValue.ToString());
                payload.dishType = tipoPlatoBO;
            }
            else
            {
                MessageBox.Show("Los campos Nombre, Descripción, Precio, Cantidad, Tipo de Plato son requeridos");
                payload = null;
            }
            return payload;
        }

        private void UnblockFormControllers(bool isEnabled = true)
        {
            txtName.Enabled = isEnabled;
            txtDescription.Enabled = isEnabled;
            txtPrice.Enabled = isEnabled;
            txtQuantity.Enabled = isEnabled;
            cbDishType.Enabled = isEnabled;
            chState.Enabled = isEnabled;
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
            txtDescription.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cbDishType.SelectedIndex = -1;
            chState.Checked = false;
        }

        private void AddDataGridViewRows(List<PlatoBO> platoBOs)
        {
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AutoGenerateColumns = false;
            dgvData.Columns.Clear();
            dgvData.ClearSelection();
            dgvData.ReadOnly = true;

            dgvData.Columns.Add("code", "Còdigo");
            dgvData.Columns.Add("name", "Nombre");
            dgvData.Columns.Add("description", "Descripción");
            dgvData.Columns.Add("price", "Precio");
            dgvData.Columns.Add("quantity", "Cantidad");
            dgvData.Columns.Add("dishType", "Tipo de Plato");

            DataGridViewTextBoxColumn stateColumn = new DataGridViewTextBoxColumn
            {
                Name = "state",
                HeaderText = "Estado",
                DataPropertyName = "state"
            };

            dgvData.Columns.Add(stateColumn);

            for (int i = 0; i < platoBOs.Count; i++)
            {
                PlatoBO platoBO = platoBOs[i];
                dgvData.Rows.Add();
                dgvData.Rows[i].Cells["code"].Value = platoBO.code;
                dgvData.Rows[i].Cells["name"].Value = platoBO.name;
                dgvData.Rows[i].Cells["description"].Value = platoBO.description;
                dgvData.Rows[i].Cells["price"].Value = platoBO.price;
                dgvData.Rows[i].Cells["quantity"].Value = platoBO.quantity;
                dgvData.Rows[i].Cells["dishType"].Value = platoBO.dishType.name;
                dgvData.Rows[i].Cells["state"].Value = platoBO.state ? "Habilitado" : "Deshabilitado";
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void AddComboBoxOptions(List<TipoPlatoBO> tipoPlataBOs)
        {
            TipoPlatoBO tipoPlatoFirstValue = new TipoPlatoBO
            {
                code = 0,
                name = "Seleccione un tipo de plato",
                state = false
            };

            tipoPlataBOs.Insert(0, tipoPlatoFirstValue);

            cbDishType.DataSource = tipoPlataBOs;
            cbDishType.DisplayMember = "name";
            cbDishType.ValueMember = "code";

            cbDishType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UnblockFormControllers();
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            PlatoBO? payload = GetPayload();
            bool isAddSuccess = platoBAL.AddPlato(payload);

            if (isAddSuccess)
            {
                MessageBox.Show("Se registró el plato");
                AddDataGridViewRows(GetPlatos());
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se resgistró el plato");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PlatoBO? payload = GetPayload();
            bool isUpdateSuccess = platoBAL.AddPlato(payload);

            if (isUpdateSuccess)
            {
                MessageBox.Show("Se actualizó el plato");
                AddDataGridViewRows(GetPlatos());
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se actualizó el plato");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PlatoBO platoBO = new PlatoBO();
            bool response = false;

            platoBO.code = Convert.ToInt32(txtCode.Text);

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres eliminar el plato?",
                "Eliminando plato",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                response = platoBAL.DeletePlato(platoBO);
                if (response == true)
                {
                    MessageBox.Show("Se eliminó plato");
                    AddDataGridViewRows(GetPlatos());
                    ResetFields();
                    BlockFormControllers();    
                    btnNew.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se eliminó el plato");
                }
            }
        }

        private TipoPlatoBO findDishTypeByName(string dishTypeName)
        {
            List<TipoPlatoBO> dishTypes = tipoPlatoBAL.ShowAllTipoPlato();
            TipoPlatoBO foundDishType = new TipoPlatoBO();

            foundDishType = dishTypes.FirstOrDefault(
                item => item.name.Equals(dishTypeName, StringComparison.OrdinalIgnoreCase)
            );

            return foundDishType;
        }

        private void dgvPlato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvData.Rows[index];
            if (selectedRow.Cells["code"].Value != null)
            {
                UnblockFormControllers(); 
                btnAdd.Enabled = false;
                txtCode.Text = selectedRow.Cells["code"].Value.ToString();
                txtName.Text = selectedRow.Cells["name"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["description"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["price"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["quantity"].Value.ToString();
                chState.Checked = selectedRow.Cells["state"].Value.ToString() == "Habilitado" ? true : false;
                string dishTypeName = selectedRow.Cells["dishType"].Value.ToString();
                TipoPlatoBO foundDishType = findDishTypeByName(dishTypeName);
                cbDishType.SelectedValue = foundDishType.code != 0 ? foundDishType.code : -1;
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            frmHabilitarPlato form = new frmHabilitarPlato();
            form.FormClosed += CloseListener;
            form.ShowDialog();
        }
        private void CloseListener(object sender, EventArgs e)
        {
            AddDataGridViewRows(GetPlatos());
        }
    }
}
