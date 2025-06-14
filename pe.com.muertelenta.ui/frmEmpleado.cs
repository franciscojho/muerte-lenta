using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmEmpleado : Form
    {
        private EmpleadoBAL employeeProvider = new EmpleadoBAL();
        private SexoBAL genderProvider = new SexoBAL();
        private DistritoBAL districtProvider = new DistritoBAL();
        private TipoDocumentoBAL documentTypeProvider = new TipoDocumentoBAL();
        private RolBAL roleProvider = new RolBAL();

        private List<EmpleadoBO> employees = new List<EmpleadoBO>();
        private List<DistritoBO> districts = new List<DistritoBO>();
        private List<SexoBO> genders = new List<SexoBO>();
        private List<TipoDocumentoBO> documentTypes = new List<TipoDocumentoBO>();
        private List<RolBO> roles = new List<RolBO>();

        public frmEmpleado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            txtCode.ReadOnly = true;
            dpBirthDate.Format = DateTimePickerFormat.Custom;
            dpBirthDate.CustomFormat = "";

            BlockFormControllers();
            SetCustomers();
            SetDistricts();
            SetGenders();
            SetDocumentTypes();
            SetRoles();

            AddDataGridViewRows(employees);
            AddDistrictComboBoxOptions(districts);
            AddGendersComboBoxOptions(genders);
            AddDocumentTypesComboBoxOptions(documentTypes);
            AddRolesComboBoxOptions(roles);
        }

        private void SetCustomers()
        {
            employees = employeeProvider.GetEmployees();
        }

        private void SetDistricts()
        {
            districts = districtProvider.ShowDistrito();
        }

        private void SetGenders()
        {
            genders = genderProvider.ShowSexo();
        }

        private void SetDocumentTypes()
        {
            documentTypes = documentTypeProvider.ShowTipoDocumento();
        }

        private void SetRoles()
        {
            roles = roleProvider.ShowRol();
        }

        private void UnblockFormControllers(bool isEnabled = true)
        {
            txtName.Enabled = isEnabled;
            txtFirstLastName.Enabled = isEnabled;
            txtSecondLastName.Enabled = isEnabled;
            txtDni.Enabled = isEnabled;
            txtAddress.Enabled = isEnabled;
            dpBirthDate.Enabled = isEnabled;
            txtPhone.Enabled = isEnabled;
            txtMobile.Enabled = isEnabled;
            txtEmail.Enabled = isEnabled;
            txtUserName.Enabled = isEnabled;
            txtPassword.Enabled = isEnabled;
            cbState.Enabled = isEnabled;
            cbxDistrict.Enabled = isEnabled;
            cbxGender.Enabled = isEnabled;
            cbxDocumentType.Enabled = isEnabled;
            cbxRole.Enabled = isEnabled;
            btnAdd.Enabled = isEnabled;
        }

        private void BlockFormControllers()
        {
            UnblockFormControllers(false);
        }

        private void ResetFields()
        {
            txtCode.Clear();
            txtName.Clear();
            txtFirstLastName.Clear();
            txtSecondLastName.Clear();
            txtDni.Clear();
            txtAddress.Clear();
            dpBirthDate.ResetText();
            txtPhone.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            cbState.Checked = false;
            cbxDistrict.SelectedIndex = -1;
            cbxGender.SelectedIndex = -1;
            cbxDocumentType.SelectedIndex = -1;
            cbxRole.SelectedIndex = -1;
        }

        private void AddDataGridViewRows(List<EmpleadoBO> employees)
        {
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AutoGenerateColumns = false;
            dgvData.Columns.Clear();
            dgvData.ClearSelection();
            dgvData.ReadOnly = true;

            dgvData.Columns.Add("code", "Codigo");
            dgvData.Columns.Add("name", "Nombre");
            dgvData.Columns.Add("firstLastName", "Ape. Paterno");
            dgvData.Columns.Add("secondLastName", "Ape. Materno");
            dgvData.Columns.Add("dni", "DNI");

            DataGridViewTextBoxColumn stateColumn = new DataGridViewTextBoxColumn
            {
                Name = "state",
                HeaderText = "Estado",
                DataPropertyName = "state"
            };

            dgvData.Columns.Add(stateColumn);

            for (int i = 0; i < employees.Count; i++)
            {
                EmpleadoBO employee = employees[i];
                dgvData.Rows.Add();
                dgvData.Rows[i].Cells["code"].Value = employee.code;
                dgvData.Rows[i].Cells["name"].Value = employee.name;
                dgvData.Rows[i].Cells["firstLastName"].Value = employee.firstLastName;
                dgvData.Rows[i].Cells["secondLastName"].Value = employee.secondLastName;
                dgvData.Rows[i].Cells["dni"].Value = employee.dni;
                dgvData.Rows[i].Cells["state"].Value = employee.state ? "Habilitado" : "Deshabilitado";
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void AddDistrictComboBoxOptions(List<DistritoBO> districts)
        {

            DistritoBO firstOption = new DistritoBO
            {
                code = 0,
                name = "Seleccione una opción",
                state = false
            };

            districts.Insert(0, firstOption);

            cbxDistrict.DataSource = districts;
            cbxDistrict.DisplayMember = "name";
            cbxDistrict.ValueMember = "code";
            cbxDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddGendersComboBoxOptions(List<SexoBO> genders)
        {

            SexoBO firstOption = new SexoBO
            {
                code = 0,
                name = "Seleccione una opción",
                state = false
            };

            genders.Insert(0, firstOption);

            cbxGender.DataSource = genders;
            cbxGender.DisplayMember = "name";
            cbxGender.ValueMember = "code";
            cbxGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddDocumentTypesComboBoxOptions(List<TipoDocumentoBO> documentTypes)
        {

            TipoDocumentoBO firstOption = new TipoDocumentoBO
            {
                code = 0,
                name = "Seleccione una opción",
                state = false
            };

            documentTypes.Insert(0, firstOption);

            cbxDocumentType.DataSource = documentTypes;
            cbxDocumentType.DisplayMember = "name";
            cbxDocumentType.ValueMember = "code";
            cbxDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddRolesComboBoxOptions(List<RolBO> roles)
        {

            RolBO firstOption = new RolBO
            {
                code = 0,
                name = "Seleccione una opción",
                state = false
            };

            roles.Insert(0, firstOption);

            cbxRole.DataSource = roles;
            cbxRole.DisplayMember = "name";
            cbxRole.ValueMember = "code";
            cbxRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private DistritoBO findDistrictBy(int districtCode)
        {
            DistritoBO foundDistrict = new DistritoBO();

            foreach (DistritoBO district in districts)
            {
                if (district.code == districtCode)
                {
                    foundDistrict = district;
                }
            }
            return foundDistrict;
        }

        private SexoBO findGenderBy(int genderCode)
        {
            SexoBO foundGender = new SexoBO();

            foreach (SexoBO gender in genders)
            {
                if (gender.code == genderCode)
                {
                    foundGender = gender;
                }
            }
            return foundGender;
        }

        private TipoDocumentoBO findDocumentTypeBy(int documentTypeCode)
        {
            TipoDocumentoBO foundDocumentType = new TipoDocumentoBO();

            foreach (TipoDocumentoBO documentType in documentTypes)
            {
                if (documentType.code == documentTypeCode)
                {
                    foundDocumentType = documentType;
                }
            }
            return foundDocumentType;
        }

        private RolBO findRoleByType(int roleCode)
        {
            RolBO foundRole = new RolBO();

            foreach (RolBO role in roles)
            {
                if (role.code == roleCode)
                {
                    foundRole = role;
                }
            }
            return foundRole;
        }

        private (EmpleadoBO?, string) GetPayload()
        {
            EmpleadoBO payload = new EmpleadoBO();
            List<string> emptyFields = new List<string>();
            string requiredFieldsMessage = "";

            var keyValueArray = new KeyValuePair<object, Control>[]
            {
                new KeyValuePair<object, Control>(new { name = "name", label = "Nombre" }, txtName),
                new KeyValuePair<object, Control>(new { name = "firstLastName", label = "Apellido Paterno" }, txtFirstLastName),
                new KeyValuePair<object, Control>(new { name = "secondLastName", label = "Apellido MAterno" }, txtSecondLastName),
                new KeyValuePair<object, Control>(new { name = "dni", label = "DNI" }, txtDni),
                new KeyValuePair<object, Control>(new { name = "address", label = "Dirección" }, txtAddress),
                new KeyValuePair<object, Control>(new { name = "birthDate", label = "Fecha de Nacimiento" }, dpBirthDate),
                new KeyValuePair<object, Control>(new { name = "phone", label = "Telefono" }, txtPhone),
                new KeyValuePair<object, Control>(new { name = "mobile", label = "Celular" }, txtMobile),
                new KeyValuePair<object, Control>(new { name = "email", label = "Correo" }, txtEmail),
                new KeyValuePair<object, Control>(new { name = "userName", label = "Usuario" }, txtUserName),
                new KeyValuePair<object, Control>(new { name = "password", label = "Contraseña" }, txtPassword),
                new KeyValuePair<object, Control>(new { name = "state", label = "Estado" }, cbState),
                new KeyValuePair<object, Control>(new { name = "codeDistrict", label = "Distrito" }, cbxDistrict),
                new KeyValuePair<object, Control>(new { name = "codeGender", label = "Genero" }, cbxGender),
                new KeyValuePair<object, Control>(new { name = "codeDocumentType", label = "Tipo de Documento" }, cbxDocumentType),
                new KeyValuePair<object, Control>(new { name = "codeRole", label = "Rol" }, cbxRole),
            };


            foreach (KeyValuePair<object, Control> item in keyValueArray)
            {
                dynamic key = item.Key;
                var field = item.Value;

                if (field is TextBox textbox)
                {
                    string value = textbox.Text.Trim();
                    if (string.IsNullOrEmpty(value))
                    {
                        emptyFields.Add(key.label);
                    }
                    payload.GetType().GetProperty(key.name).SetValue(payload, value);
                }
                if (field is CheckBox checkbox)
                {
                    bool value = checkbox.Checked;
                    payload.GetType().GetProperty(key.name).SetValue(payload, value);
                }
                if (field is ComboBox combobox)
                {
                    int value = combobox.SelectedIndex;
                    if (value == 0)
                    {
                        emptyFields.Add(key.label);
                    }
                    payload.GetType().GetProperty(key.name).SetValue(payload, value);
                }
                if (field is DateTimePicker datepicker)
                {
                    DateTime value = datepicker.Value.Date;
                    payload.GetType().GetProperty(key.name).SetValue(payload, value);
                }
            }

            if (emptyFields.Count > 0)
            {
                requiredFieldsMessage = $"Debe llenar los siguientes campos requeridos: {string.Join(", ", emptyFields)}";
            }

            return (payload, requiredFieldsMessage);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UnblockFormControllers();
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            (EmpleadoBO?, string) payloadAndErrorMessage = GetPayload();
            EmpleadoBO payload = payloadAndErrorMessage.Item1;
            string errorMessage = payloadAndErrorMessage.Item2;

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                bool isAddSuccess = employeeProvider.AddEmployee(payload);

                if (isAddSuccess)
                {
                    MessageBox.Show("Se registró el empleado");
                    SetCustomers();
                    AddDataGridViewRows(employees);
                    ResetFields();
                    BlockFormControllers();
                    btnNew.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se registró el empleado");
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int selectedEmployeeCode = 0;
            EmpleadoBO selectedEmployee = new EmpleadoBO();
            DistritoBO selectedDistrict = new DistritoBO();
            SexoBO selectedGender = new SexoBO();
            TipoDocumentoBO selectedDocumentType = new TipoDocumentoBO();
            RolBO selectedRole = new RolBO();
            DataGridViewRow selectedRow = dgvData.Rows[index];

            selectedEmployeeCode = Convert.ToInt32(selectedRow.Cells["code"].Value.ToString());

            foreach (EmpleadoBO employee in employees)
            {
                if (employee.code == selectedEmployeeCode)
                {
                    selectedEmployee = employee;
                    selectedDistrict = findDistrictBy(Convert.ToInt32(selectedEmployee.codeDistrict));
                    selectedGender = findGenderBy(Convert.ToInt32(selectedEmployee.codeGender));
                    selectedDocumentType = findDocumentTypeBy(Convert.ToInt32(selectedEmployee.codeDocumentType));
                    selectedRole = findRoleByType(Convert.ToInt32(selectedEmployee.codeRole));
                }
            }

            using (frmEmpleadoDetalle frmEmployeeDetail = new frmEmpleadoDetalle(selectedEmployee, selectedDistrict, selectedGender, selectedDocumentType, selectedRole))
            {
                frmEmployeeDetail.ShowDialog();
            }
        }
    }
}
