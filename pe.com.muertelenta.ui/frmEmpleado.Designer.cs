namespace pe.com.muertelenta.ui
{
    partial class frmEmpleado
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
            dpBirthDate = new DateTimePicker();
            cbState = new CheckBox();
            cbxDistrict = new ComboBox();
            cbxGender = new ComboBox();
            cbxDocumentType = new ComboBox();
            btnAdd = new Button();
            btnNew = new Button();
            dgvData = new DataGridView();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            txtMobile = new TextBox();
            label7 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtDni = new TextBox();
            label4 = new Label();
            txtSecondLastName = new TextBox();
            label3 = new Label();
            txtFirstLastName = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtCode = new TextBox();
            label15 = new Label();
            txtUserName = new TextBox();
            label16 = new Label();
            txtPassword = new TextBox();
            cbxRole = new ComboBox();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dpBirthDate
            // 
            dpBirthDate.Location = new Point(221, 349);
            dpBirthDate.Name = "dpBirthDate";
            dpBirthDate.Size = new Size(148, 31);
            dpBirthDate.TabIndex = 66;
            // 
            // cbState
            // 
            cbState.AutoSize = true;
            cbState.Location = new Point(219, 533);
            cbState.Name = "cbState";
            cbState.Size = new Size(120, 29);
            cbState.TabIndex = 65;
            cbState.Text = "Habilitado";
            cbState.UseVisualStyleBackColor = true;
            // 
            // cbxDistrict
            // 
            cbxDistrict.FormattingEnabled = true;
            cbxDistrict.Location = new Point(219, 579);
            cbxDistrict.Name = "cbxDistrict";
            cbxDistrict.Size = new Size(150, 33);
            cbxDistrict.TabIndex = 64;
            // 
            // cbxGender
            // 
            cbxGender.FormattingEnabled = true;
            cbxGender.Location = new Point(219, 624);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(150, 33);
            cbxGender.TabIndex = 63;
            // 
            // cbxDocumentType
            // 
            cbxDocumentType.FormattingEnabled = true;
            cbxDocumentType.Location = new Point(219, 667);
            cbxDocumentType.Name = "cbxDocumentType";
            cbxDocumentType.Size = new Size(150, 33);
            cbxDocumentType.TabIndex = 62;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(211, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 34);
            btnAdd.TabIndex = 61;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(21, 17);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(175, 34);
            btnNew.TabIndex = 60;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(407, 17);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(1055, 773);
            dgvData.TabIndex = 59;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 670);
            label14.Name = "label14";
            label14.Size = new Size(175, 25);
            label14.TabIndex = 58;
            label14.Text = "Tipo de Documento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 627);
            label13.Name = "label13";
            label13.Size = new Size(73, 25);
            label13.TabIndex = 57;
            label13.Text = "Genero:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 584);
            label12.Name = "label12";
            label12.Size = new Size(74, 25);
            label12.TabIndex = 56;
            label12.Text = "Distrito:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 537);
            label11.Name = "label11";
            label11.Size = new Size(70, 25);
            label11.TabIndex = 55;
            label11.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 490);
            label10.Name = "label10";
            label10.Size = new Size(70, 25);
            label10.TabIndex = 54;
            label10.Text = "Correo:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(219, 487);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 298);
            label9.Name = "label9";
            label9.Size = new Size(89, 25);
            label9.TabIndex = 52;
            label9.Text = "Direccion:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(219, 295);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 444);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 50;
            label8.Text = "Celular:";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(219, 441);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(150, 31);
            txtMobile.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 396);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 48;
            label7.Text = "Telefono:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(219, 391);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 347);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 46;
            label6.Text = "Fecha de Nac.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 252);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 45;
            label5.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(219, 249);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(150, 31);
            txtDni.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 204);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 43;
            label4.Text = "Apellido Materno:";
            // 
            // txtSecondLastName
            // 
            txtSecondLastName.Location = new Point(219, 201);
            txtSecondLastName.Name = "txtSecondLastName";
            txtSecondLastName.Size = new Size(150, 31);
            txtSecondLastName.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 157);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 41;
            label3.Text = "Apellido Paterno:";
            // 
            // txtFirstLastName
            // 
            txtFirstLastName.Location = new Point(219, 154);
            txtFirstLastName.Name = "txtFirstLastName";
            txtFirstLastName.Size = new Size(150, 31);
            txtFirstLastName.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 112);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 39;
            label2.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(219, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 69);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 37;
            label1.Text = "Codigo:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(219, 66);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(150, 31);
            txtCode.TabIndex = 36;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 763);
            label15.Name = "label15";
            label15.Size = new Size(76, 25);
            label15.TabIndex = 68;
            label15.Text = "Usuario:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(219, 760);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(150, 31);
            txtUserName.TabIndex = 67;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(22, 808);
            label16.Name = "label16";
            label16.Size = new Size(105, 25);
            label16.TabIndex = 70;
            label16.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(220, 805);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 69;
            // 
            // cbxRole
            // 
            cbxRole.FormattingEnabled = true;
            cbxRole.Location = new Point(219, 714);
            cbxRole.Name = "cbxRole";
            cbxRole.Size = new Size(150, 33);
            cbxRole.TabIndex = 72;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 717);
            label17.Name = "label17";
            label17.Size = new Size(41, 25);
            label17.TabIndex = 71;
            label17.Text = "Rol:";
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 848);
            Controls.Add(cbxRole);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(txtPassword);
            Controls.Add(label15);
            Controls.Add(txtUserName);
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
            Name = "frmEmpleado";
            Text = "frmEmpleado";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dpBirthDate;
        private CheckBox cbState;
        private ComboBox cbxDistrict;
        private ComboBox cbxGender;
        private ComboBox cbxDocumentType;
        private Button btnAdd;
        private Button btnNew;
        private DataGridView dgvData;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtAddress;
        private Label label8;
        private TextBox txtMobile;
        private Label label7;
        private TextBox txtPhone;
        private Label label6;
        private Label label5;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtSecondLastName;
        private Label label3;
        private TextBox txtFirstLastName;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtCode;
        private Label label15;
        private TextBox txtUserName;
        private Label label16;
        private TextBox txtPassword;
        private ComboBox cbxRole;
        private Label label17;
    }
}