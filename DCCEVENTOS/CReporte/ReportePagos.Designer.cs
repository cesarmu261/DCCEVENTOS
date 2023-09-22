namespace DCCEVENTOS.CReporte
{
    partial class ReportePagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportePagos));
            toolStrip1 = new ToolStrip();
            toolStripNuevo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSalir = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            buscarClientesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            DTGEventos = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            TBDescripcion = new TextBox();
            TBClientes = new TextBox();
            label4 = new Label();
            label1 = new Label();
            DTGDetalles = new DataGridView();
            pictureBox5 = new PictureBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker5 = new DateTimePicker();
            dateTimePicker6 = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            Cancelaciones = new Label();
            button6 = new Button();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTGEventos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DTGDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNuevo, toolStripSeparator1, toolStripSeparator2, toolStripSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1495, 31);
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
            menuStrip1.Size = new Size(1495, 24);
            menuStrip1.TabIndex = 77;
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
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(368, 221);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(15, 15);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 105;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(368, 178);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 15);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 104;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(368, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 103;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(124, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 102;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(1056, 317);
            button2.Name = "button2";
            button2.Size = new Size(144, 23);
            button2.TabIndex = 94;
            button2.Text = "Reporte";
            button2.UseVisualStyleBackColor = true;
            // 
            // DTGEventos
            // 
            DTGEventos.AllowUserToAddRows = false;
            DTGEventos.AllowUserToDeleteRows = false;
            DTGEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGEventos.Location = new Point(523, 72);
            DTGEventos.Name = "DTGEventos";
            DTGEventos.ReadOnly = true;
            DTGEventos.RowTemplate.Height = 25;
            DTGEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTGEventos.Size = new Size(677, 239);
            DTGEventos.TabIndex = 95;
            DTGEventos.DoubleClick += DTGEventos_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 139);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 96;
            label3.Text = "al";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 97);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 97;
            label2.Text = "Periodo";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(149, 133);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 98;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(149, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 90;
            // 
            // TBDescripcion
            // 
            TBDescripcion.CharacterCasing = CharacterCasing.Upper;
            TBDescripcion.Location = new Point(149, 222);
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(200, 23);
            TBDescripcion.TabIndex = 100;
            TBDescripcion.KeyPress += TBDescripcion_KeyPress;
            // 
            // TBClientes
            // 
            TBClientes.CharacterCasing = CharacterCasing.Upper;
            TBClientes.Enabled = false;
            TBClientes.Location = new Point(149, 178);
            TBClientes.Name = "TBClientes";
            TBClientes.Size = new Size(200, 23);
            TBClientes.TabIndex = 99;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 222);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 93;
            label4.Text = "Descripcion de Evento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 178);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 86;
            label1.Text = "Cliente";
            // 
            // DTGDetalles
            // 
            DTGDetalles.AllowUserToAddRows = false;
            DTGDetalles.AllowUserToDeleteRows = false;
            DTGDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGDetalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGDetalles.Location = new Point(523, 346);
            DTGDetalles.Name = "DTGDetalles";
            DTGDetalles.ReadOnly = true;
            DTGDetalles.RowTemplate.Height = 25;
            DTGDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTGDetalles.Size = new Size(944, 328);
            DTGDetalles.TabIndex = 106;
            DTGDetalles.DoubleClick += DTGDetalles_DoubleClick;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(368, 391);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(15, 15);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 112;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(389, 391);
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
            label5.Location = new Point(19, 433);
            label5.Name = "label5";
            label5.Size = new Size(16, 15);
            label5.TabIndex = 109;
            label5.Text = "al";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 391);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 110;
            label6.Text = "Periodo";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(149, 427);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 111;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(149, 391);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(200, 23);
            dateTimePicker4.TabIndex = 107;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(368, 515);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(15, 15);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 117;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 557);
            label7.Name = "label7";
            label7.Size = new Size(16, 15);
            label7.TabIndex = 114;
            label7.Text = "al";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 515);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 115;
            label8.Text = "Periodo";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Format = DateTimePickerFormat.Short;
            dateTimePicker5.Location = new Point(149, 551);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(200, 23);
            dateTimePicker5.TabIndex = 116;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Format = DateTimePickerFormat.Short;
            dateTimePicker6.Location = new Point(149, 515);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(200, 23);
            dateTimePicker6.TabIndex = 113;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(75, 72);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 118;
            label9.Text = "Evento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(75, 359);
            label10.Name = "label10";
            label10.Size = new Size(91, 15);
            label10.TabIndex = 119;
            label10.Text = "Pagos o abonos";
            // 
            // Cancelaciones
            // 
            Cancelaciones.AutoSize = true;
            Cancelaciones.Location = new Point(75, 480);
            Cancelaciones.Name = "Cancelaciones";
            Cancelaciones.Size = new Size(83, 15);
            Cancelaciones.TabIndex = 120;
            Cancelaciones.Text = "Cancelaciones";
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(389, 511);
            button6.Name = "button6";
            button6.Size = new Size(117, 23);
            button6.TabIndex = 121;
            button6.Text = "Reporte";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ReportePagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1495, 698);
            Controls.Add(button6);
            Controls.Add(Cancelaciones);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dateTimePicker5);
            Controls.Add(dateTimePicker6);
            Controls.Add(pictureBox5);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker4);
            Controls.Add(DTGDetalles);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(DTGEventos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(TBDescripcion);
            Controls.Add(TBClientes);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Name = "ReportePagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportePagos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTGEventos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DTGDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private ToolStripMenuItem buscarClientesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button2;
        private DataGridView DTGEventos;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox TBDescripcion;
        private TextBox TBClientes;
        private Label label4;
        private Label label1;
        private DataGridView DTGDetalles;
        private PictureBox pictureBox5;
        private Button button1;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private PictureBox pictureBox6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker6;
        private Label label9;
        private Label label10;
        private Label Cancelaciones;
        private Button button6;
    }
}