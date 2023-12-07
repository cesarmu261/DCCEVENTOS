namespace DCCEVENTOS.CReporte
{
    partial class ReportePagosFechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportePagosFechas));
            toolStrip1 = new ToolStrip();
            toolStripNuevo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSalir = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            DTGDetalles = new DataGridView();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            button2 = new Button();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDetalles).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNuevo, toolStripSeparator1, toolStripSeparator2, toolStripSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(974, 31);
            toolStrip1.TabIndex = 78;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNuevo
            // 
            toolStripNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripNuevo.Image = Properties.Resources.btnNuevo1;
            toolStripNuevo.ImageTransparentColor = Color.Magenta;
            toolStripNuevo.Name = "toolStripNuevo";
            toolStripNuevo.Size = new Size(28, 28);
            toolStripNuevo.Text = "Nuevo";
            toolStripNuevo.Click += toolStripNuevo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // toolStripSalir
            // 
            toolStripSalir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSalir.Image = (Image)resources.GetObject("toolStripSalir.Image");
            toolStripSalir.ImageTransparentColor = Color.Magenta;
            toolStripSalir.Name = "toolStripSalir";
            toolStripSalir.Size = new Size(28, 28);
            toolStripSalir.Text = "toolStripButton5";
            toolStripSalir.ToolTipText = "Salir";
            toolStripSalir.Click += toolStripSalir_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(974, 24);
            menuStrip1.TabIndex = 77;
            menuStrip1.Text = "Opciones";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, salirToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(109, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(109, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // DTGDetalles
            // 
            DTGDetalles.AllowUserToAddRows = false;
            DTGDetalles.AllowUserToDeleteRows = false;
            DTGDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGDetalles.Location = new Point(13, 154);
            DTGDetalles.Name = "DTGDetalles";
            DTGDetalles.ReadOnly = true;
            DTGDetalles.RowTemplate.Height = 25;
            DTGDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTGDetalles.Size = new Size(944, 328);
            DTGDetalles.TabIndex = 106;
            // 
            // button1
            // 
            button1.Location = new Point(840, 98);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 108;
            button1.Text = "Reporte";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 104);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 109;
            label5.Text = "Al";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 72);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 110;
            label6.Text = "Del";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(76, 98);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 111;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(76, 66);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 107;
            // 
            // button2
            // 
            button2.Location = new Point(840, 68);
            button2.Name = "button2";
            button2.Size = new Size(117, 23);
            button2.TabIndex = 122;
            button2.Text = "Consulta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ReportePagosFechas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 502);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker4);
            Controls.Add(DTGDetalles);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Name = "ReportePagosFechas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportePagos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripNuevo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripSalir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView DTGDetalles;
        private Button button1;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Button button2;
    }
}