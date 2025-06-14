using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmEmpleadoDetalle : Form
    {
        private EmpleadoBO _employeeData;
        private DistritoBO _districtData;
        private SexoBO _genderData;
        private TipoDocumentoBO _documentTypeData;
        private RolBO _roleData;

        public frmEmpleadoDetalle(EmpleadoBO employeeData, DistritoBO districtData, SexoBO genderData, TipoDocumentoBO documentTypeData, RolBO roleData)
        {
            InitializeComponent();
            BlockFormControllers();

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            _employeeData = employeeData;
            _districtData = districtData;
            _genderData = genderData;
            _documentTypeData = documentTypeData;
            _roleData = roleData;

            setFormData();
            txtCode.ReadOnly = true;
        }

        private void setFormData()
        {
            txtCode.Text = Convert.ToString(_employeeData.code);
            txtName.Text = _employeeData.name;
            txtFirstLastName.Text = _employeeData.firstLastName;
            txtSecondLastName.Text = _employeeData.secondLastName;
            txtDni.Text = _employeeData.dni;
            txtAddress.Text = _employeeData.address;
            txtBirthDate.Text = Convert.ToString(_employeeData.birthDate);
            txtPhone.Text = _employeeData.phone;
            txtMobile.Text = _employeeData.mobile;
            txtEmail.Text = _employeeData.email;
            txtUserName.Text = _employeeData.userName;
            txtPassword.Text = _employeeData.password;
            cbState.Checked = _employeeData.state;
            txtDistrict.Text = _districtData.name;
            txtGender.Text = _genderData.name;
            txtDocumentType.Text = _documentTypeData.name;
            txtRole.Text = _roleData.name;
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
            txtUserName.Enabled = isEnabled;
            txtPassword.Enabled = isEnabled;
            cbState.Enabled = isEnabled;
            txtDistrict.Enabled = isEnabled;
            txtGender.Enabled = isEnabled;
            txtDocumentType.Enabled = isEnabled;
            txtRole.Enabled = isEnabled;
        }

        private void BlockFormControllers()
        {
            UnblockFormControllers(false);
        }
    }
}
