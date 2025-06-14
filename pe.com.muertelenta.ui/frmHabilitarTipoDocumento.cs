using pe.com.muertelenta.bal;
using pe.com.muertelenta.bo;

namespace pe.com.muertelenta.ui
{
    public partial class frmHabilitarTipoDocumento : Form
    {
        private TipoDocumentoBAL provider = new TipoDocumentoBAL();
        List<TipoDocumentoBO> documentTypes = new List<TipoDocumentoBO>();
        private int selectedCode;

        public frmHabilitarTipoDocumento()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetDocumentTypes();
            AddDataGridViewRows(documentTypes);
        }

        private void SetDocumentTypes()
        {
            documentTypes = provider.ShowAllTipoDocumento();
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

        private void btnEnable_Click(object sender, EventArgs e)
        {
            TipoDocumentoBO documentType = new TipoDocumentoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres habilitar el tipo de documento?",
                "Habilitando tipo de documento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                documentType.code = selectedCode;
                response = provider.EnableTipoDocumento(documentType);
                if (response == true)
                {
                    MessageBox.Show("Se habilitó el tipo de documento");
                    SetDocumentTypes();
                    AddDataGridViewRows(documentTypes);
                }
                else
                {
                    MessageBox.Show("No se habilitó el tipo de documento");
                }
            }
        }

        private void btnDisabled_Click(object sender, EventArgs e)
        {
            TipoDocumentoBO documentType = new TipoDocumentoBO();
            bool response = false;

            DialogResult dialogResult = MessageBox.Show(
                "¿Seguro que quieres deshabilitar el tipo de documento?",
                "Deshabilitando tipo de documento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error
             );

            if (dialogResult == DialogResult.Yes)
            {
                documentType.code = selectedCode;
                response = provider.DeleteTipoDocumento(documentType);
                if (response == true)
                {
                    MessageBox.Show("Se deshabilitó el tipo de documento");
                    SetDocumentTypes();
                    AddDataGridViewRows(documentTypes);
                }
                else
                {
                    MessageBox.Show("No se deshabilitó el tipo de documento");
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvData.Rows[index];
            selectedCode = Convert.ToInt32(selectedRow.Cells["code"].Value.ToString());
        }
    }
}
