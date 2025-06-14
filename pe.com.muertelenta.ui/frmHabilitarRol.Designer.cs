namespace pe.com.muertelenta.ui
{
    partial class frmHabilitarRol
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
            btnGoBack = new Button();
            btnDisabled = new Button();
            btnEnable = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(24, 72);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(532, 495);
            dgvData.TabIndex = 11;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new Point(444, 23);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(112, 34);
            btnGoBack.TabIndex = 10;
            btnGoBack.Text = "Regresar";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnDisabled
            // 
            btnDisabled.Location = new Point(220, 23);
            btnDisabled.Name = "btnDisabled";
            btnDisabled.Size = new Size(127, 34);
            btnDisabled.TabIndex = 9;
            btnDisabled.Text = "Deshabilitar";
            btnDisabled.UseVisualStyleBackColor = true;
            btnDisabled.Click += btnDisabled_Click;
            // 
            // btnEnable
            // 
            btnEnable.Location = new Point(24, 23);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(112, 34);
            btnEnable.TabIndex = 8;
            btnEnable.Text = "Habilitar";
            btnEnable.UseVisualStyleBackColor = true;
            btnEnable.Click += btnEnable_Click;
            // 
            // frmHabilitarRol
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 594);
            Controls.Add(dgvData);
            Controls.Add(btnGoBack);
            Controls.Add(btnDisabled);
            Controls.Add(btnEnable);
            Name = "frmHabilitarRol";
            Text = "frmHabilitarRol";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private Button btnGoBack;
        private Button btnDisabled;
        private Button btnEnable;
    }
}