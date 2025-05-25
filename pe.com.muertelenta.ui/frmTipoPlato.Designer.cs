namespace pe.com.muertelenta.ui
{
    partial class frmTipoPlato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbState = new CheckBox();
            btnNew = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEnable = new Button();
            dgvTipoPlato = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTipoPlato).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 22);
            label1.Name = "label1";
            label1.Size = new Size(319, 30);
            label1.TabIndex = 0;
            label1.Text = "MANTENIMIENTO TIPO PLATO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 92);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(122, 89);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 118);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 23);
            txtName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 121);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 150);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 5;
            label4.Text = "Estado:";
            // 
            // cbState
            // 
            cbState.AutoSize = true;
            cbState.Location = new Point(122, 149);
            cbState.Name = "cbState";
            cbState.Size = new Size(81, 19);
            cbState.TabIndex = 6;
            cbState.Text = "Habilitado";
            cbState.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(501, 88);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 7;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(501, 122);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(597, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Registrar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(597, 122);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEnable
            // 
            btnEnable.Location = new Point(695, 88);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(75, 23);
            btnEnable.TabIndex = 11;
            btnEnable.Text = "Habilitar";
            btnEnable.UseVisualStyleBackColor = true;
            btnEnable.Click += btnEnable_Click;
            // 
            // dgvTipoPlato
            // 
            dgvTipoPlato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoPlato.Location = new Point(28, 191);
            dgvTipoPlato.Name = "dgvTipoPlato";
            dgvTipoPlato.Size = new Size(742, 309);
            dgvTipoPlato.TabIndex = 12;
            // 
            // frmTipoPlato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(dgvTipoPlato);
            Controls.Add(btnEnable);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(cbState);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTipoPlato";
            Text = "frmTipoPlato";
            ((System.ComponentModel.ISupportInitialize)dgvTipoPlato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCode;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private CheckBox cbState;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEnable;
        private DataGridView dgvTipoPlato;
    }
}