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
            BtnAgregar = new Button();
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
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripBuscar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSalir = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            buscarClientesToolStripMenuItem = new ToolStripMenuItem();
            Codigo = new DataGridViewTextBoxColumn();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ConceptosUni = new DataGridView();
            DTCodigo = new DataGridViewTextBoxColumn();
            DTDESCRIPCION = new DataGridViewTextBoxColumn();
            DTCantida = new DataGridViewTextBoxColumn();
            DTCostosC = new DataGridViewTextBoxColumn();
            Paquete = new DataGridViewTextBoxColumn();
            Codigoc = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ConceptosPaquetes).BeginInit();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ConceptosUni).BeginInit();
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
            textBox1.Location = new Point(93, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripcion ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(93, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 220);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "Observaciones";
            // 
            // CBEstado
            // 
            CBEstado.FormattingEnabled = true;
            CBEstado.Location = new Point(93, 258);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(200, 23);
            CBEstado.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 266);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 62;
            label5.Text = "Estado";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(12, 315);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 64;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblCajas);
            flowLayoutPanel1.Controls.Add(CBPaquete);
            flowLayoutPanel1.Controls.Add(ConceptosPaquetes);
            flowLayoutPanel1.Location = new Point(315, 54);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(689, 214);
            flowLayoutPanel1.TabIndex = 65;
            // 
            // lblCajas
            // 
            lblCajas.AutoSize = true;
            lblCajas.Location = new Point(3, 0);
            lblCajas.Name = "lblCajas";
            lblCajas.Size = new Size(110, 15);
            lblCajas.TabIndex = 4;
            lblCajas.Text = "Seleccione una caja";
            // 
            // CBPaquete
            // 
            CBPaquete.FormattingEnabled = true;
            CBPaquete.Location = new Point(119, 3);
            CBPaquete.Name = "CBPaquete";
            CBPaquete.Size = new Size(181, 23);
            CBPaquete.TabIndex = 3;
            CBPaquete.SelectedIndexChanged += CBPaquete_SelectedIndexChanged;
            // 
            // ConceptosPaquetes
            // 
            ConceptosPaquetes.AllowUserToAddRows = false;
            ConceptosPaquetes.AllowUserToDeleteRows = false;
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
            // 
            // Column1
            // 
            Column1.HeaderText = "Descripcion";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // CostosC
            // 
            CostosC.HeaderText = "Costos Concepto";
            CostosC.Name = "CostosC";
            CostosC.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(398, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 68;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(318, 288);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 67;
            label6.Text = "Conceptos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(841, 284);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 69;
            label7.Text = "Total Paquete";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(925, 282);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 70;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(861, 653);
            label9.Name = "label9";
            label9.Size = new Size(0, 21);
            label9.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(748, 653);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 71;
            label10.Text = "Total Conceptos";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNuevo, toolStripGuardar, toolStripButton1, toolStripSeparator1, toolStripBuscar, toolStripSeparator2, toolStripSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1055, 31);
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
            // 
            // toolStripGuardar
            // 
            toolStripGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripGuardar.Image = (Image)resources.GetObject("toolStripGuardar.Image");
            toolStripGuardar.ImageTransparentColor = Color.Magenta;
            toolStripGuardar.Name = "toolStripGuardar";
            toolStripGuardar.Size = new Size(28, 28);
            toolStripGuardar.Text = "Guardar";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(28, 28);
            toolStripButton1.Text = "toolStripButton1";
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
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1055, 24);
            menuStrip1.TabIndex = 73;
            menuStrip1.Text = "Opciones";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, guardarToolStripMenuItem, buscarClientesToolStripMenuItem });
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
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(154, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // buscarClientesToolStripMenuItem
            // 
            buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            buscarClientesToolStripMenuItem.Size = new Size(154, 22);
            buscarClientesToolStripMenuItem.Text = "Buscar Clientes";
            buscarClientesToolStripMenuItem.Click += buscarClientesToolStripMenuItem_Click;
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
            flowLayoutPanel3.Size = new Size(686, 317);
            flowLayoutPanel3.TabIndex = 75;
            // 
            // ConceptosUni
            // 
            ConceptosUni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ConceptosUni.Columns.AddRange(new DataGridViewColumn[] { DTCodigo, DTDESCRIPCION, DTCantida, DTCostosC, Paquete });
            ConceptosUni.Location = new Point(3, 3);
            ConceptosUni.Name = "ConceptosUni";
            ConceptosUni.RowTemplate.Height = 25;
            ConceptosUni.Size = new Size(663, 314);
            ConceptosUni.TabIndex = 0;
            ConceptosUni.CellValueChanged += ConceptosUni_CellValueChanged;
            // 
            // DTCodigo
            // 
            DTCodigo.HeaderText = "Codigo";
            DTCodigo.Name = "DTCodigo";
            // 
            // DTDESCRIPCION
            // 
            DTDESCRIPCION.HeaderText = "Descripcion";
            DTDESCRIPCION.Name = "DTDESCRIPCION";
            // 
            // DTCantida
            // 
            DTCantida.HeaderText = "Cantidad";
            DTCantida.Name = "DTCantida";
            // 
            // DTCostosC
            // 
            DTCostosC.HeaderText = "Costos";
            DTCostosC.Name = "DTCostosC";
            // 
            // Paquete
            // 
            Paquete.HeaderText = "Paquete";
            Paquete.Name = "Paquete";
            // 
            // Codigoc
            // 
            Codigoc.HeaderText = "Codigo";
            Codigoc.Name = "Codigoc";
            // 
            // CEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 686);
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
            Controls.Add(BtnAgregar);
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
        private Button BtnAgregar;
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
        private ToolStripButton toolStripButton1;
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
    }
}