using pe.com.muertelenta.bo;


namespace pe.com.muertelenta.ui
{
    public partial class frmClienteDetalle : Form
    {
        private ClienteBO _customerData;
        private DistritoBO _districtData;
        private SexoBO _genderData;
        private TipoDocumentoBO _documentTypeData;

        public frmClienteDetalle(ClienteBO customerData, DistritoBO districtData, SexoBO genderData, TipoDocumentoBO documentTypeData)
        {
            InitializeComponent();
            BlockFormControllers();

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            _customerData = customerData;
            _districtData = districtData;
            _genderData = genderData;
            _documentTypeData = documentTypeData;

            setFormData();
            txtCode.ReadOnly = true;
        }

        private void setFormData()
        {
            txtCode.Text = Convert.ToString(_customerData.code);
            txtName.Text = _customerData.name;
            txtFirstLastName.Text = _customerData.firstLastName;
            txtSecondLastName.Text = _customerData.secondLastName;
            txtDni.Text = _customerData.dni;
            txtAddress.Text = _customerData.address;
            txtBirthDate.Text = Convert.ToString(_customerData.birthDate);
            txtPhone.Text = _customerData.phone;
            txtMobile.Text = _customerData.mobile;
            txtEmail.Text = _customerData.email;
            cbState.Checked = _customerData.state;
            txtDistrict.Text = _districtData.name;
            txtGender.Text = _genderData.name;
            txtDocumentType.Text = _documentTypeData.name;
        }

        private void UnblockFormControllers(bool isEnabled = false)
        {
            txtName.Enabled = isEnabled;
            txtFirstLastName.Enabled = isEnabled;
            txtSecondLastName.Enabled = isEnabled;
            txtDni.Enabled = isEnabled;
            txtAddress.Enabled = isEnabled;
            txtBirthDate.Enabled = isEnabled;
            txtPhone.Enabled = isEnabled;
            txtMobile.Enabled = isEnabled;
            txtEmail.Enabled = isEnabled;
            cbState.Enabled = isEnabled;
            txtDistrict.Enabled = isEnabled;
            txtGender.Enabled = isEnabled;
            txtDocumentType.Enabled = isEnabled;
        }

        private void BlockFormControllers()
        {
            UnblockFormControllers(false);
        }
    }
}
