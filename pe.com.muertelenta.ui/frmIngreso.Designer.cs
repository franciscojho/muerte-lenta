namespace pe.com.muertelenta.ui
{
    partial class frmIngreso
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            btnIngresar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 24);
            label1.Name = "label1";
            label1.Size = new Size(173, 21);
            label1.TabIndex = 0;
            label1.Text = "INGRESO AL SISTEMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 63);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 103);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Clave:";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(44, 164);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(328, 164);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(455, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 163);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 215);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresar);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            IsMdiContainer = true;
            Name = "frmIngreso";
            Text = "frmIngreso";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button btnIngresar;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}