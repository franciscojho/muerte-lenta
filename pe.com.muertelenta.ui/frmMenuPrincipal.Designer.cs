namespace pe.com.muertelenta.ui
{
    partial class frmMenuPrincipal
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
            menuStrip1 = new MenuStrip();
            tsmArchivo = new ToolStripMenuItem();
            tsmCerrarSesion = new ToolStripMenuItem();
            tsmSalir = new ToolStripMenuItem();
            tsmMantenimientoSimple = new ToolStripMenuItem();
            tsmTipoPlato = new ToolStripMenuItem();
            tsmDistrito = new ToolStripMenuItem();
            tsmSexo = new ToolStripMenuItem();
            tsmTipoDeDocumento = new ToolStripMenuItem();
            tsmMantenimientoDoble = new ToolStripMenuItem();
            tsmProceso = new ToolStripMenuItem();
            registrarPedidoToolStripMenuItem = new ToolStripMenuItem();
            listarPedidosToolStripMenuItem = new ToolStripMenuItem();
            tsmReportes = new ToolStripMenuItem();
            tsmUtilidades = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            blockDeNotasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmArchivo, tsmMantenimientoSimple, tsmMantenimientoDoble, tsmProceso, tsmReportes, tsmUtilidades });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            tsmArchivo.DropDownItems.AddRange(new ToolStripItem[] { tsmCerrarSesion, tsmSalir });
            tsmArchivo.Name = "tsmArchivo";
            tsmArchivo.Size = new Size(88, 29);
            tsmArchivo.Text = "Archivo";
            // 
            // tsmCerrarSesion
            // 
            tsmCerrarSesion.Name = "tsmCerrarSesion";
            tsmCerrarSesion.Size = new Size(218, 34);
            tsmCerrarSesion.Text = "Cerrar Sesion";
            tsmCerrarSesion.Click += tsmCerrarSesion_Click;
            // 
            // tsmSalir
            // 
            tsmSalir.Name = "tsmSalir";
            tsmSalir.Size = new Size(218, 34);
            tsmSalir.Text = "Salir";
            tsmSalir.Click += tsmSalir_Click;
            // 
            // tsmMantenimientoSimple
            // 
            tsmMantenimientoSimple.DropDownItems.AddRange(new ToolStripItem[] { tsmTipoPlato, tsmDistrito, tsmSexo, tsmTipoDeDocumento });
            tsmMantenimientoSimple.Name = "tsmMantenimientoSimple";
            tsmMantenimientoSimple.Size = new Size(207, 29);
            tsmMantenimientoSimple.Text = "Mantenimiento Simple";
            // 
            // tsmTipoPlato
            // 
            tsmTipoPlato.Name = "tsmTipoPlato";
            tsmTipoPlato.Size = new Size(273, 34);
            tsmTipoPlato.Text = "Tipo Plato";
            tsmTipoPlato.Click += tsmTipoPlato_Click;
            // 
            // tsmDistrito
            // 
            tsmDistrito.Name = "tsmDistrito";
            tsmDistrito.Size = new Size(273, 34);
            tsmDistrito.Text = "Distrito";
            tsmDistrito.Click += tsmDistrito_Click;
            // 
            // tsmSexo
            // 
            tsmSexo.Name = "tsmSexo";
            tsmSexo.Size = new Size(273, 34);
            tsmSexo.Text = "Sexo";
            tsmSexo.Click += tsmSexo_Click;
            // 
            // tsmTipoDeDocumento
            // 
            tsmTipoDeDocumento.Name = "tsmTipoDeDocumento";
            tsmTipoDeDocumento.Size = new Size(273, 34);
            tsmTipoDeDocumento.Text = "Tipo de Documento";
            tsmTipoDeDocumento.Click += tsmTipoDeDocumento_Click;
            // 
            // tsmMantenimientoDoble
            // 
            tsmMantenimientoDoble.Name = "tsmMantenimientoDoble";
            tsmMantenimientoDoble.Size = new Size(201, 29);
            tsmMantenimientoDoble.Text = "Mantenimiento Doble";
            // 
            // tsmProceso
            // 
            tsmProceso.DropDownItems.AddRange(new ToolStripItem[] { registrarPedidoToolStripMenuItem, listarPedidosToolStripMenuItem });
            tsmProceso.Name = "tsmProceso";
            tsmProceso.Size = new Size(91, 29);
            tsmProceso.Text = "Proceso";
            // 
            // registrarPedidoToolStripMenuItem
            // 
            registrarPedidoToolStripMenuItem.Name = "registrarPedidoToolStripMenuItem";
            registrarPedidoToolStripMenuItem.Size = new Size(243, 34);
            registrarPedidoToolStripMenuItem.Text = "Registrar Pedido";
            // 
            // listarPedidosToolStripMenuItem
            // 
            listarPedidosToolStripMenuItem.Name = "listarPedidosToolStripMenuItem";
            listarPedidosToolStripMenuItem.Size = new Size(243, 34);
            listarPedidosToolStripMenuItem.Text = "Listar Pedidos";
            // 
            // tsmReportes
            // 
            tsmReportes.Name = "tsmReportes";
            tsmReportes.Size = new Size(98, 29);
            tsmReportes.Text = "Reportes";
            // 
            // tsmUtilidades
            // 
            tsmUtilidades.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, blockDeNotasToolStripMenuItem });
            tsmUtilidades.Name = "tsmUtilidades";
            tsmUtilidades.Size = new Size(106, 29);
            tsmUtilidades.Text = "Utilidades";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(233, 34);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // blockDeNotasToolStripMenuItem
            // 
            blockDeNotasToolStripMenuItem.Name = "blockDeNotasToolStripMenuItem";
            blockDeNotasToolStripMenuItem.Size = new Size(233, 34);
            blockDeNotasToolStripMenuItem.Text = "Block de Notas";
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmArchivo;
        private ToolStripMenuItem tsmMantenimientoSimple;
        private ToolStripMenuItem tsmMantenimientoDoble;
        private ToolStripMenuItem tsmProceso;
        private ToolStripMenuItem tsmReportes;
        private ToolStripMenuItem tsmUtilidades;
        private ToolStripMenuItem tsmCerrarSesion;
        private ToolStripMenuItem tsmSalir;
        private ToolStripMenuItem tsmTipoPlato;
        private ToolStripMenuItem tsmDistrito;
        private ToolStripMenuItem tsmSexo;
        private ToolStripMenuItem tsmTipoDeDocumento;
        private ToolStripMenuItem registrarPedidoToolStripMenuItem;
        private ToolStripMenuItem listarPedidosToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem blockDeNotasToolStripMenuItem;
    }
}