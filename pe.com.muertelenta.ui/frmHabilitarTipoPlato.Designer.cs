namespace pe.com.muertelenta.ui
{
    partial class frmHabilitarTipoPlato
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
            btnEnable = new Button();
            btnDisabled = new Button();
            btnGoBack = new Button();
            dgvTipoPlato = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTipoPlato).BeginInit();
            SuspendLayout();
            // 
            // btnEnable
            // 
            btnEnable.Location = new Point(12, 12);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(112, 34);
            btnEnable.TabIndex = 0;
            btnEnable.Text = "Habilitar";
            btnEnable.UseVisualStyleBackColor = true;
            btnEnable.Click += btnEnable_Click;
            // 
            // btnDisabled
            // 
            btnDisabled.Location = new Point(208, 12);
            btnDisabled.Name = "btnDisabled";
            btnDisabled.Size = new Size(127, 34);
            btnDisabled.TabIndex = 1;
            btnDisabled.Text = "Deshabilitar";
            btnDisabled.UseVisualStyleBackColor = true;
            btnDisabled.Click += btnDisabled_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new Point(432, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(112, 34);
            btnGoBack.TabIndex = 2;
            btnGoBack.Text = "Regresar";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // dgvTipoPlato
            // 
            dgvTipoPlato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoPlato.Location = new Point(12, 61);
            dgvTipoPlato.Name = "dgvTipoPlato";
            dgvTipoPlato.RowHeadersWidth = 62;
            dgvTipoPlato.Size = new Size(532, 495);
            dgvTipoPlato.TabIndex = 3;
            dgvTipoPlato.CellClick += dgvTipoPlato_CellClick;
            // 
            // frmHabilitar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 568);
            Controls.Add(dgvTipoPlato);
            Controls.Add(btnGoBack);
            Controls.Add(btnDisabled);
            Controls.Add(btnEnable);
            Name = "frmHabilitar";
            Text = "frmHabilitar";
            ((System.ComponentModel.ISupportInitialize)dgvTipoPlato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnable;
        private Button btnDisabled;
        private Button btnGoBack;
        private DataGridView dgvTipoPlato;
    }
}