namespace pe.com.muertelenta.ui
{
    partial class frmCliente
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
            txtCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtFirstLastName = new TextBox();
            label4 = new Label();
            txtSecondLastName = new TextBox();
            label5 = new Label();
            txtDni = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            txtMobile = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            dgvData = new DataGridView();
            btnNew = new Button();
            btnAdd = new Button();
            cbxDocumentType = new ComboBox();
            cbxGender = new ComboBox();
            cbxDistrict = new ComboBox();
            cbState = new CheckBox();
            dpBirthDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(217, 61);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(150, 31);
            txtCode.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 64);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 1;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 107);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(217, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 152);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 5;
            label3.Text = "Apellido Paterno:";
            // 
            // txtFirstLastName
            // 
            txtFirstLastName.Location = new Point(217, 149);
            txtFirstLastName.Name = "txtFirstLastName";
            txtFirstLastName.Size = new Size(150, 31);
            txtFirstLastName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 199);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 7;
            label4.Text = "Apellido Materno:";
            // 
            // txtSecondLastName
            // 
            txtSecondLastName.Location = new Point(217, 196);
            txtSecondLastName.Name = "txtSecondLastName";
            txtSecondLastName.Size = new Size(150, 31);
            txtSecondLastName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 247);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 9;
            label5.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(217, 244);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(150, 31);
            txtDni.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 342);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 11;
            label6.Text = "Fecha de Nac.:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 391);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 13;
            label7.Text = "Telefono:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(217, 386);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 439);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 15;
            label8.Text = "Celular:";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(217, 436);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(150, 31);
            txtMobile.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 293);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 17;
            label9.Text = "Direccion:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(217, 290);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 485);
            label10.Name = "label10";
            label10.Size = new Size(70, 25);
            label10.TabIndex = 19;
            label10.Text = "Correo:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 482);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 532);
            label11.Name = "label11";
            label11.Size = new Size(70, 25);
            label11.TabIndex = 21;
            label11.Text = "Estado:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 579);
            label12.Name = "label12";
            label12.Size = new Size(74, 25);
            label12.TabIndex = 23;
            label12.Text = "Distrito:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 622);
            label13.Name = "label13";
            label13.Size = new Size(73, 25);
            label13.TabIndex = 25;
            label13.Text = "Genero:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 665);
            label14.Name = "label14";
            label14.Size = new Size(175, 25);
            label14.TabIndex = 27;
            label14.Text = "Tipo de Documento:";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(405, 12);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(1055, 678);
            dgvData.TabIndex = 28;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(19, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(175, 34);
            btnNew.TabIndex = 29;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(209, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 34);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbxDocumentType
            // 
            cbxDocumentType.FormattingEnabled = true;
            cbxDocumentType.Location = new Point(217, 662);
            cbxDocumentType.Name = "cbxDocumentType";
            cbxDocumentType.Size = new Size(150, 33);
            cbxDocumentType.TabIndex = 31;
            // 
            // cbxGender
            // 
            cbxGender.FormattingEnabled = true;
            cbxGender.Location = new Point(217, 619);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(150, 33);
            cbxGender.TabIndex = 32;
            // 
            // cbxDistrict
            // 
            cbxDistrict.FormattingEnabled = true;
            cbxDistrict.Location = new Point(217, 574);
            cbxDistrict.Name = "cbxDistrict";
            cbxDistrict.Size = new Size(150, 33);
            cbxDistrict.TabIndex = 33;
            // 
            // cbState
            // 
            cbState.AutoSize = true;
            cbState.Location = new Point(217, 528);
            cbState.Name = "cbState";
            cbState.Size = new Size(120, 29);
            cbState.TabIndex = 34;
            cbState.Text = "Habilitado";
            cbState.UseVisualStyleBackColor = true;
            // 
            // dpBirthDate
            // 
            dpBirthDate.Location = new Point(219, 344);
            dpBirthDate.Name = "dpBirthDate";
            dpBirthDate.Size = new Size(148, 31);
            dpBirthDate.TabIndex = 35;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 711);
            Controls.Add(dpBirthDate);
            Controls.Add(cbState);
            Controls.Add(cbxDistrict);
            Controls.Add(cbxGender);
            Controls.Add(cbxDocumentType);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Controls.Add(dgvData);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            Controls.Add(txtAddress);
            Controls.Add(label8);
            Controls.Add(txtMobile);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtDni);
            Controls.Add(label4);
            Controls.Add(txtSecondLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstLastName);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Name = "frmCliente";
            Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtFirstLastName;
        private Label label4;
        private TextBox txtSecondLastName;
        private Label label5;
        private TextBox txtDni;
        private Label label6;
        private Label label7;
        private TextBox txtPhone;
        private Label label8;
        private TextBox txtMobile;
        private Label label9;
        private TextBox txtAddress;
        private Label label10;
        private TextBox txtEmail;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridView dgvData;
        private Button btnNew;
        private Button btnAdd;
        private ComboBox cbxDocumentType;
        private ComboBox cbxGender;
        private ComboBox cbxDistrict;
        private CheckBox cbState;
        private DateTimePicker dpBirthDate;
    }
}