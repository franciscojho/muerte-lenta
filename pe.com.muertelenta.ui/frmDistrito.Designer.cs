namespace pe.com.muertelenta.ui
{
    partial class frmDistrito
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
            dgvData = new DataGridView();
            btnEnable = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            cbState = new CheckBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtCode = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(45, 290);
            dgvData.Margin = new Padding(4, 5, 4, 5);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(1060, 515);
            dgvData.TabIndex = 25;
            dgvData.CellClick += dgvDistrito_CellClick;
            // 
            // btnEnable
            // 
            btnEnable.Location = new Point(998, 119);
            btnEnable.Margin = new Padding(4, 5, 4, 5);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(107, 38);
            btnEnable.TabIndex = 24;
            btnEnable.Text = "Habilitar";
            btnEnable.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(858, 175);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(858, 119);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Registrar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(721, 175);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 38);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(721, 119);
            btnNew.Margin = new Padding(4, 5, 4, 5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(107, 38);
            btnNew.TabIndex = 20;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // cbState
            // 
            cbState.AutoSize = true;
            cbState.Location = new Point(179, 220);
            cbState.Margin = new Padding(4, 5, 4, 5);
            cbState.Name = "cbState";
            cbState.Size = new Size(120, 29);
            cbState.TabIndex = 19;
            cbState.Text = "Habilitado";
            cbState.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-130, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 18;
            label4.Text = "Estado:";
            // 
            // txtName
            // 
            txtName.Location = new Point(179, 169);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(311, 31);
            txtName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-130, -8);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 16;
            label3.Text = "Nombre:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(179, 120);
            txtCode.Margin = new Padding(4, 5, 4, 5);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(141, 31);
            txtCode.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-130, -57);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 14;
            label2.Text = "Codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, -173);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(486, 45);
            label1.TabIndex = 13;
            label1.Text = "MANTENIMIENTO TIPO PLATO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(354, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(448, 45);
            label5.TabIndex = 26;
            label5.Text = "MANTENIMIENTO DISTRITO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 216);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 29;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 168);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 28;
            label7.Text = "Nombre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 119);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 27;
            label8.Text = "Codigo:";
            // 
            // frmDistrito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 838);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(dgvData);
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
            Name = "frmDistrito";
            Text = "frmDistrito";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private Button btnEnable;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnNew;
        private CheckBox cbState;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtCode;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}