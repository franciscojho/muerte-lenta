using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmTipoDocumento : Form
    {
        private TipoDocumentoBAL provider = new TipoDocumentoBAL();
        List<TipoDocumentoBO> documentTypes = new List<TipoDocumentoBO>();

        public frmTipoDocumento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtCode.ReadOnly = true;
            BlockFormControllers();
            SetDocumentTypes();
            AddDataGridViewRows(documentTypes);
        }

        private void SetDocumentTypes()
        {
            documentTypes = provider.ShowTipoDocumento();
        }

        private void UnblockFormControllers(bool isEnabled = true)
        {
            txtName.Enabled = isEnabled;
            cbState.Enabled = isEnabled;
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
            cbState.Checked = false;
            txtName.Focus();
        }

        private void AddDataGridViewRows(List<TipoDocumentoBO> documentTypes)
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

            for (int i = 0; i < documentTypes.Count; i++)
            {
                TipoDocumentoBO documentType = documentTypes[i];
                dgvData.Rows.Add();
                dgvData.Rows[i].Cells["code"].Value = documentType.code;
                dgvData.Rows[i].Cells["name"].Value = documentType.name;
                dgvData.Rows[i].Cells["state"].Value = documentType.state ? "Habilitado" : "Deshabilitado";
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private TipoDocumentoBO? GetPayload()
        {
            TipoDocumentoBO payload = new TipoDocumentoBO();
            string name = txtName.Text.Trim();
            int code = int.TryParse(txtCode.Text.Trim(), out code) ? code : 0;
            bool state = cbState.Checked;

            if (code != 0)
            {
                payload.code = code;
            }

            if (!string.IsNullOrEmpty(name))
            {
                payload.name = name;
                payload.state = state;
            }
            else
            {
                MessageBox.Show("El campo Nombre es requerido");
                payload = null;
            }
            return payload;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            UnblockFormControllers();
            btnNew.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TipoDocumentoBO? payload = GetPayload();
            bool isAddSuccess = provider.AddTipoDocumento(payload);

            if (isAddSuccess)
            {
                MessageBox.Show("Se resgistró el Tipo de Documento");
                SetDocumentTypes();
                AddDataGridViewRows(documentTypes);
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se resgistró el Tipo de Documento");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TipoDocumentoBO? payload = GetPayload();
            bool isAddSuccess = provider.UpdateTipoDocumento(payload);

            if (isAddSuccess)
            {
                MessageBox.Show("Se actualizó el Tipo de Documento");
                SetDocumentTypes();
                AddDataGridViewRows(documentTypes);
                ResetFields();
                BlockFormControllers();
                btnNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se actualizó el Tipo de Documento");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TipoDocumentoBO documentType = new TipoDocumentoBO();
            bool response = false;

            documentType.code = Convert.ToInt32(txtCode.Text);

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres eliminar el Tipo de Documento?",
                "Eliminando Tipo de Documento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                response = provider.DeleteTipoDocumento(documentType);
                if (response == true)
                {
                    MessageBox.Show("Se eliminó Tipo de Documento");
                    SetDocumentTypes();
                    AddDataGridViewRows(documentTypes);
                    ResetFields();
                    BlockFormControllers();
                    btnNew.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se eliminó el Tipo de Documento");
                }
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            UnblockFormControllers();
            btnAdd.Enabled = true;
            DataGridViewRow selectedRow = dgvData.Rows[index];
            Console.WriteLine(selectedRow.Cells["code"].Value);
            if (selectedRow.Cells["code"].Value != null)
            {
                txtCode.Text = selectedRow.Cells["code"].Value.ToString();
                txtName.Text = selectedRow.Cells["name"].Value.ToString();
                cbState.Checked = selectedRow.Cells["state"].Value.ToString() == "Habilitado" ? true : false;
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            frmHabilitarTipoDocumento form = new frmHabilitarTipoDocumento();
            form.FormClosed += CloseListener;
            form.ShowDialog();
        }

        private void CloseListener(object sender, EventArgs e)
        {
            SetDocumentTypes();
            AddDataGridViewRows(documentTypes);
        }
    }
}
