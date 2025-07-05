using System.Data;
using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmPedidoDetalle : Form
    {
        private PlatoBAL dishProvider = new PlatoBAL();

        private List<PlatoBO> dishes = new List<PlatoBO>();

        public frmPedidoDetalle()
        {
            InitializeComponent();
            SetDishes();
            AddDataGridViewRows(dishes);
        }

        private void SetDishes()
        {
            dishes = dishProvider.ShowPlato();
        }

        private void AddDataGridViewRows(List<PlatoBO> dishes)
        {
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AutoGenerateColumns = false;
            dgvData.Columns.Clear();
            dgvData.ClearSelection();
            dgvData.ReadOnly = true;

            dgvData.Columns.Add(new DataGridViewTextBoxColumn { Name = "code", HeaderText = "Código", DataPropertyName = "code" });
            dgvData.Columns.Add(new DataGridViewTextBoxColumn { Name = "name", HeaderText = "Nombre", DataPropertyName = "name" });
            dgvData.Columns.Add(new DataGridViewTextBoxColumn { Name = "description", HeaderText = "Descripción", DataPropertyName = "description" });
            dgvData.Columns.Add(new DataGridViewTextBoxColumn { Name = "price", HeaderText = "Precio", DataPropertyName = "price" });
            dgvData.Columns.Add(new DataGridViewTextBoxColumn { Name = "quantity", HeaderText = "Cantidad", DataPropertyName = "quantity" });
            dgvData.Columns.Add(new DataGridViewTextBoxColumn { Name = "dishType", HeaderText = "Tipo de plato", DataPropertyName = "dishTypeName" });
            dgvData.Columns.Add(new DataGridViewTextBoxColumn { Name = "state", HeaderText = "Estado", DataPropertyName = "state" });

            var dishColumns = dishes.Select(dish => new
            {
                dish.code,
                dish.name,
                dish.description,
                dish.price,
                dish.quantity,
                dishTypeName = dish.dishType.name,
                state = dish.state ? "Habilitado" : "Deshabilitado"

            }).ToList();

            dgvData.DataSource = dishColumns;
        }
    }
}
