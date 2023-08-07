namespace DCCEVENTOS.CBusqueda
{
    partial class ConsultaDeEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDeEventos));
            TBClientes = new TextBox();
            BTNBus = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            TBDescripcion = new TextBox();
            DTGEventos = new DataGridView();
            DTGDetalles = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            toolStrip1 = new ToolStrip();
            toolStripNuevo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripBuscar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSalir = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            buscarClientesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            CBSalones = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DTGEventos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTGDetalles).BeginInit();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TBClientes
            // 
            TBClientes.Enabled = false;
            TBClientes.Location = new Point(149, 157);
            TBClientes.Name = "TBClientes";
            TBClientes.Size = new Size(200, 23);
            TBClientes.TabIndex = 1;
            // 
            // BTNBus
            // 
            BTNBus.Location = new Point(12, 270);
            BTNBus.Name = "BTNBus";
            BTNBus.Size = new Size(144, 23);
            BTNBus.TabIndex = 4;
            BTNBus.Text = "Buscar";
            BTNBus.UseVisualStyleBackColor = true;
            BTNBus.Click += BTNBus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 157);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 76);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 76);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "periodo";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(149, 112);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 118);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 0;
            label3.Text = "al";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 189);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 0;
            label4.Text = "Descripcion de Evento";
            // 
            // TBDescripcion
            // 
            TBDescripcion.Location = new Point(149, 189);
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(200, 23);
            TBDescripcion.TabIndex = 2;
            // 
            // DTGEventos
            // 
            DTGEventos.AllowUserToAddRows = false;
            DTGEventos.AllowUserToDeleteRows = false;
            DTGEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGEventos.Location = new Point(368, 76);
            DTGEventos.Name = "DTGEventos";
            DTGEventos.ReadOnly = true;
            DTGEventos.RowTemplate.Height = 25;
            DTGEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTGEventos.Size = new Size(832, 239);
            DTGEventos.TabIndex = 0;
            DTGEventos.DoubleClick += DTGEventos_DoubleClick;
            // 
            // DTGDetalles
            // 
            DTGDetalles.AllowUserToAddRows = false;
            DTGDetalles.AllowUserToDeleteRows = false;
            DTGDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGDetalles.Location = new Point(368, 401);
            DTGDetalles.Name = "DTGDetalles";
            DTGDetalles.ReadOnly = true;
            DTGDetalles.RowTemplate.Height = 25;
            DTGDetalles.Size = new Size(832, 171);
            DTGDetalles.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1056, 581);
            button1.Name = "button1";
            button1.Size = new Size(144, 23);
            button1.TabIndex = 62;
            button1.Text = "Reporte";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1056, 321);
            button2.Name = "button2";
            button2.Size = new Size(144, 23);
            button2.TabIndex = 69;
            button2.Text = "Reporte";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNuevo, toolStripSeparator1, toolStripBuscar, toolStripSeparator2, toolStripSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1212, 31);
            toolStrip1.TabIndex = 76;
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
            // toolStripBuscar
            // 
            toolStripBuscar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBuscar.Image = (Image)resources.GetObject("toolStripBuscar.Image");
            toolStripBuscar.ImageTransparentColor = Color.Magenta;
            toolStripBuscar.Name = "toolStripBuscar";
            toolStripBuscar.Size = new Size(28, 28);
            toolStripBuscar.Text = "toolStripButton4";
            toolStripBuscar.ToolTipText = "Buscar";
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
            menuStrip1.Size = new Size(1212, 24);
            menuStrip1.TabIndex = 75;
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
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // buscarClientesToolStripMenuItem
            // 
            buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            buscarClientesToolStripMenuItem.Size = new Size(154, 22);
            buscarClientesToolStripMenuItem.Text = "Buscar Clientes";
            buscarClientesToolStripMenuItem.Click += buscarClientesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(154, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CBSalones
            // 
            CBSalones.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSalones.FormattingEnabled = true;
            CBSalones.Location = new Point(149, 228);
            CBSalones.Name = "CBSalones";
            CBSalones.Size = new Size(200, 23);
            CBSalones.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 233);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 0;
            label5.Text = "Salon";
            // 
            // ConsultaDeEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 616);
            Controls.Add(label5);
            Controls.Add(CBSalones);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(button2);
            Controls.Add(DTGDetalles);
            Controls.Add(DTGEventos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(TBDescripcion);
            Controls.Add(TBClientes);
            Controls.Add(button1);
            Controls.Add(BTNBus);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "ConsultaDeEventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta De Eventos";
            ((System.ComponentModel.ISupportInitialize)DTGEventos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTGDetalles).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBClientes;
        private Button BTNBus;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private TextBox TBDescripcion;
        private DataGridView DTGEventos;
        private DataGridView DTGDetalles;
        private Button button1;
        private Button button2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripNuevo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripBuscar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripSalir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem buscarClientesToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ComboBox CBSalones;
        private Label label5;
    }
}