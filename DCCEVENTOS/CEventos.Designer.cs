namespace DCCEVENTOS
{
    partial class CEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CEventos));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            CBEstado = new ComboBox();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblCajas = new Label();
            CBPaquete = new ComboBox();
            ConceptosPaquetes = new DataGridView();
            CCodigo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            CostosC = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripNuevo = new ToolStripButton();
            toolStripGuardar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripBuscar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSalir = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            buscarClientesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            Codigo = new DataGridViewTextBoxColumn();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ConceptosUni = new DataGridView();
            DTCodigo = new DataGridViewTextBoxColumn();
            DTDESCRIPCION = new DataGridViewTextBoxColumn();
            DTCantida = new DataGridViewTextBoxColumn();
            DTCostosC = new DataGridViewTextBoxColumn();
            Paquete = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Codigoc = new DataGridViewTextBoxColumn();
            CBSalones = new ComboBox();
            Salon = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ConceptosPaquetes).BeginInit();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ConceptosUni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 0;
            label2.Text = "Descripcion ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 210);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(102, 204);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 253);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 0;
            label4.Text = "Observaciones";
            // 
            // CBEstado
            // 
            CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEstado.FormattingEnabled = true;
            CBEstado.Location = new Point(102, 291);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(200, 23);
            CBEstado.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 294);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 0;
            label5.Text = "Estado";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblCajas);
            flowLayoutPanel1.Controls.Add(CBPaquete);
            flowLayoutPanel1.Controls.Add(ConceptosPaquetes);
            flowLayoutPanel1.Location = new Point(315, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(686, 231);
            flowLayoutPanel1.TabIndex = 65;
            // 
            // lblCajas
            // 
            lblCajas.AutoSize = true;
            lblCajas.Location = new Point(3, 0);
            lblCajas.Name = "lblCajas";
            lblCajas.Size = new Size(126, 15);
            lblCajas.TabIndex = 4;
            lblCajas.Text = "Seleccione un paquete";
            // 
            // CBPaquete
            // 
            CBPaquete.DropDownStyle = ComboBoxStyle.DropDownList;
            CBPaquete.FormattingEnabled = true;
            CBPaquete.Location = new Point(135, 3);
            CBPaquete.Name = "CBPaquete";
            CBPaquete.Size = new Size(181, 23);
            CBPaquete.TabIndex = 3;
            CBPaquete.DropDown += CBPaquete_DropDown;
            CBPaquete.SelectedIndexChanged += CBPaquete_SelectedIndexChanged;
            // 
            // ConceptosPaquetes
            // 
            ConceptosPaquetes.AllowUserToAddRows = false;
            ConceptosPaquetes.AllowUserToDeleteRows = false;
            ConceptosPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ConceptosPaquetes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ConceptosPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConceptosPaquetes.Columns.AddRange(new DataGridViewColumn[] { CCodigo, Column1, Column2, CostosC });
            ConceptosPaquetes.Location = new Point(3, 32);
            ConceptosPaquetes.Name = "ConceptosPaquetes";
            ConceptosPaquetes.ReadOnly = true;
            ConceptosPaquetes.RowTemplate.Height = 25;
            ConceptosPaquetes.Size = new Size(666, 171);
            ConceptosPaquetes.TabIndex = 2;
            // 
            // CCodigo
            // 
            CCodigo.HeaderText = "Codigo";
            CCodigo.Name = "CCodigo";
            CCodigo.ReadOnly = true;
            CCodigo.Width = 71;
            // 
            // Column1
            // 
            Column1.HeaderText = "Descripcion";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 94;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 80;
            // 
            // CostosC
            // 
            CostosC.HeaderText = "Costos Concepto";
            CostosC.Name = "CostosC";
            CostosC.ReadOnly = true;
            CostosC.Width = 113;
            // 
            // button1
            // 
            button1.Location = new Point(398, 295);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 68;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 299);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 67;
            label6.Text = "Conceptos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(820, 299);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 69;
            label7.Text = "Total Paquete";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(914, 295);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 70;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1130, 665);
            label9.Name = "label9";
            label9.Size = new Size(0, 21);
            label9.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1017, 665);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 71;
            label10.Text = "Total Conceptos";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNuevo, toolStripGuardar, toolStripSeparator1, toolStripBuscar, toolStripSeparator2, toolStripSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1223, 31);
            toolStrip1.TabIndex = 74;
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
            // toolStripGuardar
            // 
            toolStripGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripGuardar.Image = (Image)resources.GetObject("toolStripGuardar.Image");
            toolStripGuardar.ImageTransparentColor = Color.Magenta;
            toolStripGuardar.Name = "toolStripGuardar";
            toolStripGuardar.Size = new Size(28, 28);
            toolStripGuardar.Text = "Guardar";
            toolStripGuardar.Click += toolStripGuardar_Click;
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
            toolStripBuscar.Text = "Buscar Clientes";
            toolStripBuscar.ToolTipText = "Buscar";
            toolStripBuscar.Click += toolStripBuscar_Click;
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
            menuStrip1.Size = new Size(1223, 24);
            menuStrip1.TabIndex = 73;
            menuStrip1.Text = "Opciones";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, guardarToolStripMenuItem, buscarClientesToolStripMenuItem, salirToolStripMenuItem });
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
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(154, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
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
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(ConceptosUni);
            flowLayoutPanel3.Location = new Point(315, 327);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(896, 317);
            flowLayoutPanel3.TabIndex = 75;
            // 
            // ConceptosUni
            // 
            ConceptosUni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ConceptosUni.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ConceptosUni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConceptosUni.Columns.AddRange(new DataGridViewColumn[] { DTCodigo, DTDESCRIPCION, DTCantida, DTCostosC, Paquete, Categoria });
            ConceptosUni.Location = new Point(3, 3);
            ConceptosUni.Name = "ConceptosUni";
            ConceptosUni.RowTemplate.Height = 25;
            ConceptosUni.Size = new Size(882, 314);
            ConceptosUni.TabIndex = 0;
            ConceptosUni.CellValueChanged += ConceptosUni_CellValueChanged;
            // 
            // DTCodigo
            // 
            DTCodigo.HeaderText = "Codigo";
            DTCodigo.Name = "DTCodigo";
            DTCodigo.Width = 71;
            // 
            // DTDESCRIPCION
            // 
            DTDESCRIPCION.HeaderText = "Descripcion";
            DTDESCRIPCION.Name = "DTDESCRIPCION";
            DTDESCRIPCION.Width = 94;
            // 
            // DTCantida
            // 
            DTCantida.HeaderText = "Cantidad";
            DTCantida.Name = "DTCantida";
            DTCantida.Width = 80;
            // 
            // DTCostosC
            // 
            DTCostosC.HeaderText = "Costos";
            DTCostosC.Name = "DTCostosC";
            DTCostosC.Width = 68;
            // 
            // Paquete
            // 
            Paquete.HeaderText = "Paquete";
            Paquete.Name = "Paquete";
            Paquete.Width = 75;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.Width = 83;
            // 
            // Codigoc
            // 
            Codigoc.HeaderText = "Codigo";
            Codigoc.Name = "Codigoc";
            // 
            // CBSalones
            // 
            CBSalones.DropDownStyle = ComboBoxStyle.DropDownList;
            CBSalones.FormattingEnabled = true;
            CBSalones.Location = new Point(102, 166);
            CBSalones.Name = "CBSalones";
            CBSalones.Size = new Size(200, 23);
            CBSalones.TabIndex = 3;
            // 
            // Salon
            // 
            Salon.AutoSize = true;
            Salon.Location = new Point(12, 174);
            Salon.Name = "Salon";
            Salon.Size = new Size(36, 15);
            Salon.TabIndex = 0;
            Salon.Text = "Salon";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(383, 665);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 79;
            label11.Text = "Ingresos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(513, 665);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 80;
            label12.Text = "Egresos";
            // 
            // CEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 708);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(Salon);
            Controls.Add(CBSalones);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(CBEstado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Location = new Point(1310, 130);
            Name = "CEventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CEventos";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ConceptosPaquetes).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ConceptosUni).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox CBEstado;
        private Label label5;
        private TextLabel.ControlTextoEtiqueta codigoBarras;
        private TextLabel.ControlTextoEtiqueta descripcion;
        private TextLabel.ControlTextoEtiqueta codigoCliente;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblCajas;
        private ComboBox CBPaquete;
        private DataGridView ConceptosPaquetes;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripNuevo;
        private ToolStripButton toolStripGuardar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripBuscar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripSalir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem buscarClientesToolStripMenuItem;
        private DataGridViewTextBoxColumn CCodigo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn CostosC;
        private DataGridViewTextBoxColumn Codigo;
        private FlowLayoutPanel flowLayoutPanel3;
        private DataGridViewTextBoxColumn Codigoc;
        private DataGridView ConceptosUni;
        private DataGridViewTextBoxColumn DTCodigo;
        private DataGridViewTextBoxColumn DTDESCRIPCION;
        private DataGridViewTextBoxColumn DTCantida;
        private DataGridViewTextBoxColumn DTCostosC;
        private DataGridViewTextBoxColumn Paquete;
        private ComboBox CBSalones;
        private Label Salon;
        private DataGridViewTextBoxColumn Categoria;
        private PictureBox pictureBox1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label11;
        private Label label12;
    }
}