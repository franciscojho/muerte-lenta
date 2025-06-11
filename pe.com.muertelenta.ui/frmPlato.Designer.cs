namespace pe.com.muertelenta.ui
{
    partial class frmPlato
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
            txtCode = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbDishType = new ComboBox();
            btnNew = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnEnable = new Button();
            dgvPlato = new DataGridView();
            chState = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvPlato).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 43);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(180, 43);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(150, 31);
            txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(365, 31);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 91);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(180, 142);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(365, 95);
            txtDescription.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 142);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 4;
            label3.Text = "Descripción:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(180, 261);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 261);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(180, 314);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 31);
            txtQuantity.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 314);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 8;
            label5.Text = "Cantidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 366);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 10;
            label6.Text = "Tipo de Plato:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 420);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 12;
            label7.Text = "Estado:";
            // 
            // cbDishType
            // 
            cbDishType.FormattingEnabled = true;
            cbDishType.Location = new Point(180, 366);
            cbDishType.Name = "cbDishType";
            cbDishType.Size = new Size(365, 33);
            cbDishType.TabIndex = 14;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(635, 43);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 34);
            btnNew.TabIndex = 15;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(772, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Registrar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(909, 43);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(635, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEnable
            // 
            btnEnable.Location = new Point(772, 104);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(112, 34);
            btnEnable.TabIndex = 19;
            btnEnable.Text = "Habilitar";
            btnEnable.UseVisualStyleBackColor = true;
            btnEnable.Click += btnEnable_Click;
            // 
            // dgvPlato
            // 
            dgvPlato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlato.Location = new Point(45, 480);
            dgvPlato.Name = "dgvPlato";
            dgvPlato.RowHeadersWidth = 62;
            dgvPlato.Size = new Size(986, 353);
            dgvPlato.TabIndex = 20;
            // 
            // chState
            // 
            chState.AutoSize = true;
            chState.Location = new Point(181, 423);
            chState.Name = "chState";
            chState.Size = new Size(120, 29);
            chState.TabIndex = 21;
            chState.Text = "Habilitado";
            chState.UseVisualStyleBackColor = true;
            // 
            // frmPlato
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 860);
            Controls.Add(chState);
            Controls.Add(dgvPlato);
            Controls.Add(btnEnable);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Controls.Add(cbDishType);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtQuantity);
            Controls.Add(label5);
            Controls.Add(txtPrice);
            Controls.Add(label4);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Name = "frmPlato";
            Text = "frmPlato";
            ((System.ComponentModel.ISupportInitialize)dgvPlato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCode;
        private TextBox txtName;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtQuantity;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbDishType;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnEnable;
        private DataGridView dgvPlato;
        private CheckBox chState;
    }
}