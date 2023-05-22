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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            catalogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porcentajeToolStripMenuItem, categoriaToolStripMenuItem, conceptoToolStripMenuItem, paqueteToolStripMenuItem, paqueteDetalleToolStripMenuItem });
            catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            catalogoToolStripMenuItem.Size = new Size(67, 20);
            catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // porcentajeToolStripMenuItem
            // 
            porcentajeToolStripMenuItem.Name = "porcentajeToolStripMenuItem";
            porcentajeToolStripMenuItem.Size = new Size(180, 22);
            porcentajeToolStripMenuItem.Text = "Porcentaje";
            porcentajeToolStripMenuItem.Click += porcentajeToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(180, 22);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // conceptoToolStripMenuItem
            // 
            conceptoToolStripMenuItem.Name = "conceptoToolStripMenuItem";
            conceptoToolStripMenuItem.Size = new Size(180, 22);
            conceptoToolStripMenuItem.Text = "Concepto";
            conceptoToolStripMenuItem.Click += conceptoToolStripMenuItem_Click;
            // 
            // paqueteToolStripMenuItem
            // 
            paqueteToolStripMenuItem.Name = "paqueteToolStripMenuItem";
            paqueteToolStripMenuItem.Size = new Size(180, 22);
            paqueteToolStripMenuItem.Text = "Paquete";
            paqueteToolStripMenuItem.Click += paqueteToolStripMenuItem_Click;
            // 
            // paqueteDetalleToolStripMenuItem
            // 
            paqueteDetalleToolStripMenuItem.Name = "paqueteDetalleToolStripMenuItem";
            paqueteDetalleToolStripMenuItem.Size = new Size(180, 22);
            paqueteDetalleToolStripMenuItem.Text = "Paquete Detalle";
            paqueteDetalleToolStripMenuItem.Click += paqueteDetalleToolStripMenuItem_Click;
            // 
            // CPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CPrincipal";
            Text = "Form1";
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
    }
}