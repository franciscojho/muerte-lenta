namespace pe.com.muertelenta.ui
{
    partial class frmOrdenPedido
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtOrderNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDate = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chState = new CheckBox();
            btnNew = new Button();
            btnAdd = new Button();
            btnAddDetail = new Button();
            dgvData = new DataGridView();
            cbCustomer = new ComboBox();
            cbEmployee = new ComboBox();
            label7 = new Label();
            txtSubTotal = new TextBox();
            tDate = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 26);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 0;
            label1.Text = "Registro de Orden de Pedido";
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(148, 81);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(100, 23);
            txtOrderNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Número de Pedido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha:";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(148, 110);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(173, 23);
            txtDate.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 176);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Empleado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 205);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Estado:";
            // 
            // chState
            // 
            chState.AutoSize = true;
            chState.Location = new Point(148, 201);
            chState.Name = "chState";
            chState.Size = new Size(81, 19);
            chState.TabIndex = 11;
            chState.Text = "Habilitado";
            chState.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(480, 80);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 12;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(611, 80);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Registrar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddDetail
            // 
            btnAddDetail.Location = new Point(12, 242);
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.Size = new Size(174, 23);
            btnAddDetail.TabIndex = 14;
            btnAddDetail.Text = "Agregar Detalle";
            btnAddDetail.UseVisualStyleBackColor = true;
            btnAddDetail.Click += btnAddDetail_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 279);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(776, 303);
            dgvData.TabIndex = 15;
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(148, 139);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(232, 23);
            cbCustomer.TabIndex = 16;
            // 
            // cbEmployee
            // 
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(148, 168);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(232, 23);
            cbEmployee.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(572, 637);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 19;
            label7.Text = "Subtotal:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(632, 629);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(156, 23);
            txtSubTotal.TabIndex = 18;
            // 
            // tDate
            // 
            tDate.Enabled = true;
            tDate.Interval = 1000;
            // 
            // frmRegistroPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 664);
            Controls.Add(label7);
            Controls.Add(txtSubTotal);
            Controls.Add(cbEmployee);
            Controls.Add(cbCustomer);
            Controls.Add(dgvData);
            Controls.Add(btnAddDetail);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Controls.Add(chState);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDate);
            Controls.Add(label2);
            Controls.Add(txtOrderNumber);
            Controls.Add(label1);
            Name = "frmRegistroPedido";
            Text = "frmRegistroPedido";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrderNumber;
        private Label label2;
        private Label label3;
        private TextBox txtDate;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chState;
        private Button btnNew;
        private Button btnAdd;
        private Button btnAddDetail;
        private DataGridView dgvData;
        private ComboBox cbCustomer;
        private ComboBox cbEmployee;
        private Label label7;
        private TextBox txtSubTotal;
        private System.Windows.Forms.Timer tDate;
    }
}