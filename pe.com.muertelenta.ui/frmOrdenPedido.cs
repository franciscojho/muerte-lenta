using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmOrdenPedido : Form
    {
        private EmpleadoBAL employeeProvider = new EmpleadoBAL();
        private ClienteBAL customerProvider = new ClienteBAL();

        private List<EmpleadoBO> employees = new List<EmpleadoBO>();
        private List<ClienteBO> customers = new List<ClienteBO>();
 
        public frmOrdenPedido()
        {
            InitializeComponent();
            BlockFormControllers();
            SetCustomers();
            SetEmployees();

            AddCustomerComboBoxOptions(customers);
            AddEmployeeComboBoxOptions(employees);
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtOrderNumber.Enabled = false;
            txtDate.Enabled = false;
        }

        private void SetCustomers()
        {
            customers = customerProvider.GetCustomers();
        }

        private void SetEmployees()
        {
            employees = employeeProvider.GetEmployees();
        }

        private void AddEmployeeComboBoxOptions(List<EmpleadoBO> employees)
        {

            EmpleadoBO firstOption = new EmpleadoBO
            {
                code = 0,
                name = "Seleccione una opción",
                state = false
            };

            employees.Insert(0, firstOption);

            cbEmployee.DataSource = employees;
            cbEmployee.DisplayMember = "name";
            cbEmployee.ValueMember = "code";
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddCustomerComboBoxOptions(List<ClienteBO> customers)
        {

            ClienteBO firstOption = new ClienteBO
            {
                code = 0,
                name = "Seleccione una opción",
                state = false
            };

            customers.Insert(0, firstOption);

            cbCustomer.DataSource = customers;
            cbCustomer.DisplayMember = "name";
            cbCustomer.ValueMember = "code";
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UnblockFormControllers(bool isEnabled = true)
        {
            cbCustomer.Enabled = isEnabled;
            cbEmployee.Enabled = isEnabled;
            chState.Enabled = isEnabled;
            btnAddDetail.Enabled = isEnabled;
        }

        private void BlockFormControllers()
        {
            UnblockFormControllers(false);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UnblockFormControllers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se añadió la orden");
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            frmPedidoDetalle form = new frmPedidoDetalle();
            form.ShowDialog();
        }
    }
}
