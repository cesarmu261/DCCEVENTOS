namespace DCCEVENTOS.CReporte
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            TBDescripcion = new TextBox();
            TBClientes = new TextBox();
            label4 = new Label();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripNuevo = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSalir = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            buscarClientesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            TBCod = new TextBox();
            label2 = new Label();
            DTGDetalles = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TBDescripcion
            // 
            TBDescripcion.CharacterCasing = CharacterCasing.Upper;
            TBDescripcion.Location = new Point(169, 124);
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(200, 23);
            TBDescripcion.TabIndex = 3;
            // 
            // TBClientes
            // 
            TBClientes.CharacterCasing = CharacterCasing.Upper;
            TBClientes.Location = new Point(169, 95);
            TBClientes.Name = "TBClientes";
            TBClientes.Size = new Size(200, 23);
            TBClientes.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 126);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 0;
            label4.Text = "Descripcion de Evento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 95);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNuevo, toolStripSeparator2, toolStripSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1007, 31);
            toolStrip1.TabIndex = 111;
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
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1007, 24);
            menuStrip1.TabIndex = 110;
            menuStrip1.Text = "Opciones";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, buscarClientesToolStripMenuItem, salirToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(154, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // buscarClientesToolStripMenuItem
            // 
            buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            buscarClientesToolStripMenuItem.Size = new Size(154, 22);
            buscarClientesToolStripMenuItem.Text = "Buscar Clientes";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(154, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // TBCod
            // 
            TBCod.CharacterCasing = CharacterCasing.Upper;
            TBCod.Location = new Point(169, 63);
            TBCod.Name = "TBCod";
            TBCod.Size = new Size(200, 23);
            TBCod.TabIndex = 1;
            TBCod.KeyPress += TBCod_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 67);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 0;
            label2.Text = "Codigo Evento";
            // 
            // DTGDetalles
            // 
            DTGDetalles.AllowUserToAddRows = false;
            DTGDetalles.AllowUserToDeleteRows = false;
            DTGDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGDetalles.Location = new Point(17, 170);
            DTGDetalles.Name = "DTGDetalles";
            DTGDetalles.ReadOnly = true;
            DTGDetalles.RowTemplate.Height = 25;
            DTGDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTGDetalles.Size = new Size(972, 395);
            DTGDetalles.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(845, 96);
            button2.Name = "button2";
            button2.Size = new Size(144, 23);
            button2.TabIndex = 0;
            button2.TabStop = false;
            button2.Text = "Reporte";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(845, 67);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 67);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 121;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(148, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 122;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(148, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 122;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 584);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(DTGDetalles);
            Controls.Add(TBCod);
            Controls.Add(label2);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(TBDescripcion);
            Controls.Add(TBClientes);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte Por Evento";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBDescripcion;
        private TextBox TBClientes;
        private Label label4;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripNuevo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripSalir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem buscarClientesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private TextBox TBCod;
        private Label label2;
        private DataGridView DTGDetalles;
        private Button button2;
        private Button button1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}