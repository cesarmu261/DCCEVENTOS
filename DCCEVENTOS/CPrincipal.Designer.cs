namespace DCCEVENTOS
{
    partial class CPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            catalogoToolStripMenuItem = new ToolStripMenuItem();
            porcentajeToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            conceptoToolStripMenuItem = new ToolStripMenuItem();
            paqueteToolStripMenuItem = new ToolStripMenuItem();
            paqueteDetalleToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            eventosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel2 = new Panel();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reporteEventoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogoToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1924, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            catalogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porcentajeToolStripMenuItem, categoriaToolStripMenuItem, conceptoToolStripMenuItem, paqueteToolStripMenuItem, paqueteDetalleToolStripMenuItem, clientesToolStripMenuItem, eventosToolStripMenuItem });
            catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            catalogoToolStripMenuItem.Size = new Size(67, 20);
            catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // porcentajeToolStripMenuItem
            // 
            porcentajeToolStripMenuItem.Name = "porcentajeToolStripMenuItem";
            porcentajeToolStripMenuItem.Size = new Size(156, 22);
            porcentajeToolStripMenuItem.Text = "Porcentaje";
            porcentajeToolStripMenuItem.Click += porcentajeToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(156, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // conceptoToolStripMenuItem
            // 
            conceptoToolStripMenuItem.Name = "conceptoToolStripMenuItem";
            conceptoToolStripMenuItem.Size = new Size(156, 22);
            conceptoToolStripMenuItem.Text = "Concepto";
            conceptoToolStripMenuItem.Click += conceptoToolStripMenuItem_Click;
            // 
            // paqueteToolStripMenuItem
            // 
            paqueteToolStripMenuItem.Name = "paqueteToolStripMenuItem";
            paqueteToolStripMenuItem.Size = new Size(156, 22);
            paqueteToolStripMenuItem.Text = "Paquete";
            paqueteToolStripMenuItem.Click += paqueteToolStripMenuItem_Click;
            // 
            // paqueteDetalleToolStripMenuItem
            // 
            paqueteDetalleToolStripMenuItem.Name = "paqueteDetalleToolStripMenuItem";
            paqueteDetalleToolStripMenuItem.Size = new Size(156, 22);
            paqueteDetalleToolStripMenuItem.Text = "Paquete Detalle";
            paqueteDetalleToolStripMenuItem.Click += paqueteDetalleToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(156, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // eventosToolStripMenuItem
            // 
            eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            eventosToolStripMenuItem.Size = new Size(156, 22);
            eventosToolStripMenuItem.Text = "Eventos";
            eventosToolStripMenuItem.Click += eventosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(194, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1246, 792);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(1470, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 516);
            panel2.TabIndex = 2;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteEventoToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteEventoToolStripMenuItem
            // 
            reporteEventoToolStripMenuItem.Name = "reporteEventoToolStripMenuItem";
            reporteEventoToolStripMenuItem.Size = new Size(180, 22);
            reporteEventoToolStripMenuItem.Text = "Reporte Evento";
            reporteEventoToolStripMenuItem.Click += reporteEventoToolStripMenuItem_Click;
            // 
            // CPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 887);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu principal";
            WindowState = FormWindowState.Maximized;
            Load += CPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem catalogoToolStripMenuItem;
        private ToolStripMenuItem porcentajeToolStripMenuItem;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem conceptoToolStripMenuItem;
        private ToolStripMenuItem paqueteToolStripMenuItem;
        private ToolStripMenuItem paqueteDetalleToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem eventosToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem reporteEventoToolStripMenuItem;
    }
}