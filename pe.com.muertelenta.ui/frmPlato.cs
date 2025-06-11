using Azure;
using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;
using pe.com.muertelenta.dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe.com.muertelenta.ui
{

    public partial class frmPlato : Form
    {
        private PlatoBAL platoBAL = new PlatoBAL();
        private List<PlatoBO> platoBOs;

        public frmPlato()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtCode.ReadOnly = true;
            loadPlatos();
            loadComboBoxElements();
        }

        private void loadPlatos()
        {
            dgvPlato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPlato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlato.AutoGenerateColumns = false;
            dgvPlato.Columns.Clear();
            dgvPlato.ClearSelection();
            dgvPlato.ReadOnly = true;

            dgvPlato.Columns.Add("code", "Còdigo");
            dgvPlato.Columns.Add("name", "Nombre");
            dgvPlato.Columns.Add("description", "Descripción");
            dgvPlato.Columns.Add("price", "Precio");
            dgvPlato.Columns.Add("quantity", "Cantidad");
            dgvPlato.Columns.Add("dishType", "Tipo de Plato");

            DataGridViewTextBoxColumn stateColumn = new DataGridViewTextBoxColumn
            {
                Name = "state",
                HeaderText = "Estado",
                DataPropertyName = "state"
            };

            dgvPlato.Columns.Add(stateColumn);

            List<PlatoBO> platoBOs = platoBAL.ShowPlato();

            for (int i = 0; i < platoBOs.Count; i++)
            {
                PlatoBO platoBO = platoBOs[i];
                dgvPlato.Rows.Add();
                dgvPlato.Rows[i].Cells["code"].Value = platoBO.code;
                dgvPlato.Rows[i].Cells["name"].Value = platoBO.name;
                dgvPlato.Rows[i].Cells["description"].Value = platoBO.description;
                dgvPlato.Rows[i].Cells["price"].Value = platoBO.price;
                dgvPlato.Rows[i].Cells["quantity"].Value = platoBO.quantity;
                dgvPlato.Rows[i].Cells["dishType"].Value = platoBO.dishType.name;
                dgvPlato.Rows[i].Cells["state"].Value = platoBO.state ? "Habilitado" : "Deshabilitado";
            }

            foreach (DataGridViewColumn column in dgvPlato.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void loadComboBoxElements()
        {
            TipoPlatoBAL tipoPlatoBAL = new TipoPlatoBAL();
            List<TipoPlatoBO> tipoPlataBOs = tipoPlatoBAL.ShowTipoPlato();

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

        private void enableFieldsAndButtons(bool isEnabled)
        {
            txtCode.Enabled = isEnabled;
            txtName.Enabled = isEnabled;
            btnAdd.Enabled = isEnabled;
            btnUpdate.Enabled = isEnabled;
            btnDelete.Enabled = isEnabled;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enableFieldsAndButtons(false);
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PlatoBO payload = new PlatoBO();
            TipoPlatoBO tipoPlatoBO = new TipoPlatoBO();

            
            
            payload.name = txtName.Text;
            payload.description = txtDescription.Text;
            payload.price = Convert.ToDouble(txtPrice.Text);
            payload.quantity = Convert.ToInt32(txtQuantity.Text);
            payload.state = chState.Checked;

            tipoPlatoBO.code = Convert.ToInt32(cbDishType.SelectedValue.ToString());
            payload.dishType = tipoPlatoBO;

            bool response = platoBAL.AddPlato(payload);

            if (response == true)
            {
                MessageBox.Show("Se registró el tipo de plato");
                loadPlatos();
                //clearFields();
                enableFieldsAndButtons(false);
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se resgistró el tipo de plato");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEnable_Click(object sender, EventArgs e)
        {

        }
    }
}
