using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmCliente : Form
    {
        private ClienteBAL customerProvider = new ClienteBAL();
        private SexoBAL genderProvider = new SexoBAL();
        private DistritoBAL districtProvider = new DistritoBAL();
        private TipoDocumentoBAL documentTypeProvider = new TipoDocumentoBAL();
        
        private List<ClienteBO> customers = new List<ClienteBO>();
        private List<DistritoBO> districts = new List<DistritoBO>();
        private List<SexoBO> genders = new List<SexoBO>();
        private List<TipoDocumentoBO> documentTypes = new List<TipoDocumentoBO>();

        public frmCliente()
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

            AddDataGridViewRows(customers);
            AddDistrictComboBoxOptions(districts);
            AddGendersComboBoxOptions(genders);
            AddDocumentTypesComboBoxOptions(documentTypes);
        }

        private void SetCustomers()
        {
            customers = customerProvider.GetCustomers();
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
            cbState.Enabled = isEnabled;
            cbxDistrict.Enabled = isEnabled;
            cbxGender.Enabled = isEnabled;
            cbxDocumentType.Enabled = isEnabled;
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
            cbState.Checked = false;
            cbxDistrict.SelectedIndex = -1;
            cbxGender.SelectedIndex = -1;
            cbxDocumentType.SelectedIndex = -1;
        }

        private void AddDataGridViewRows(List<ClienteBO> customers)
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

            for (int i = 0; i < customers.Count; i++)
            {
                ClienteBO customer = customers[i];
                dgvData.Rows.Add();
                dgvData.Rows[i].Cells["code"].Value = customer.code;
                dgvData.Rows[i].Cells["name"].Value = customer.name;
                dgvData.Rows[i].Cells["firstLastName"].Value = customer.firstLastName;
                dgvData.Rows[i].Cells["secondLastName"].Value = customer.secondLastName;
                dgvData.Rows[i].Cells["dni"].Value = customer.dni;
                dgvData.Rows[i].Cells["state"].Value = customer.state ? "Habilitado" : "Deshabilitado";
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

        private (ClienteBO?, string) GetPayload()
        {
            ClienteBO payload = new ClienteBO();
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
                new KeyValuePair<object, Control>(new { name = "state", label = "Estado" }, cbState),
                new KeyValuePair<object, Control>(new { name = "codeDistrict", label = "Distrito" }, cbxDistrict),
                new KeyValuePair<object, Control>(new { name = "codeGender", label = "Genero" }, cbxGender),
                new KeyValuePair<object, Control>(new { name = "codeDocumentType", label = "Tipo de Documento" }, cbxDocumentType),
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

            (ClienteBO?, string) payloadAndErrorMessage = GetPayload();
            ClienteBO payload = payloadAndErrorMessage.Item1;
            string errorMessage = payloadAndErrorMessage.Item2;

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                bool isAddSuccess = customerProvider.AddCustomer(payload);

                if (isAddSuccess)
                {
                    MessageBox.Show("Se registró el cliente");
                    SetCustomers();
                    AddDataGridViewRows(customers);
                    ResetFields();
                    BlockFormControllers();
                    btnNew.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se registró el cliente");
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int selectedCustomerCode = 0;
            ClienteBO selectedCustomer = new ClienteBO();
            DistritoBO selectedDistrict = new DistritoBO();
            SexoBO selectedGender = new SexoBO();
            TipoDocumentoBO selectedDocumentType = new TipoDocumentoBO();
            DataGridViewRow selectedRow = dgvData.Rows[index];

            selectedCustomerCode = Convert.ToInt32(selectedRow.Cells["code"].Value.ToString());

            foreach (ClienteBO customer in customers)
            {
                if (customer.code == selectedCustomerCode)
                {
                    selectedCustomer = customer;
                    selectedDistrict = findDistrictBy(Convert.ToInt32(selectedCustomer.codeDistrict));
                    selectedGender = findGenderBy(Convert.ToInt32(selectedCustomer.codeGender));
                    selectedDocumentType = findDocumentTypeBy(Convert.ToInt32(selectedCustomer.codeDocumentType));
                }
            }

            using (frmClienteDetalle formClienteDetalle = new frmClienteDetalle(selectedCustomer, selectedDistrict, selectedGender, selectedDocumentType))
            {
                formClienteDetalle.ShowDialog();
            }   
        }
    }
}
