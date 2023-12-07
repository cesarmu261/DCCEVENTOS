namespace DCCEVENTOS
{
    partial class CPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPagos));
            toolStrip1 = new ToolStrip();
            toolStripNuevo = new ToolStripButton();
            toolStripGuardar = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripBuscar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSalir = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            fcaturaToolStripMenuItem = new ToolStripMenuItem();
            facturaElectroniToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            TBFolio = new TextBox();
            TBEvento = new TextBox();
            CBTransaccion = new ComboBox();
            label7 = new Label();
            CBEstado = new ComboBox();
            label8 = new Label();
            TBObservacion = new TextBox();
            DTGDetalleEvento = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            CBComprante = new ComboBox();
            CBPago = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            TBReferencia = new TextBox();
            TBRecibo = new TextBox();
            TBDescripcion = new TextBox();
            TBClientes = new TextBox();
            label15 = new Label();
            label16 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            TBObservacionesPago = new TextBox();
            label17 = new Label();
            label11 = new Label();
            label12 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            SaldoPendiente = new TextBox();
            MontoaCobrar = new TextBox();
            SaldoaFavor = new TextBox();
            Penalizacion = new TextBox();
            TBIva = new TextBox();
            SaldoActual = new TextBox();
            label22 = new Label();
            dataGridView1 = new DataGridView();
            CostoEvento = new TextBox();
            label4 = new Label();
            MontoPagado = new TextBox();
            label23 = new Label();
            Calcular = new Button();
            TBSubtotal = new TextBox();
            label24 = new Label();
            panel1 = new Panel();
            label25 = new Label();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            label26 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDetalleEvento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNuevo, toolStripGuardar, toolStripButton1, toolStripButton3, toolStripSeparator1, toolStripBuscar, toolStripSeparator2, toolStripButton2, toolStripSeparator3, toolStripSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(905, 31);
            toolStrip1.TabIndex = 67;
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
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Enabled = false;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(28, 28);
            toolStripButton1.Text = "Cancelar";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Enabled = false;
            toolStripButton3.Image = Properties.Resources.devoluciones_faciles;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(28, 28);
            toolStripButton3.Text = "Devolucion";
            toolStripButton3.Click += toolStripButton3_Click;
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
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Enabled = false;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(28, 28);
            toolStripButton2.Text = "Imprimir";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 31);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, fcaturaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 24);
            menuStrip1.TabIndex = 66;
            menuStrip1.Text = "Opciones";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, guardarToolStripMenuItem, actualizarToolStripMenuItem, buscarToolStripMenuItem, salirToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(126, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(126, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(126, 22);
            actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(126, 22);
            buscarToolStripMenuItem.Text = "Buscar";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(126, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // fcaturaToolStripMenuItem
            // 
            fcaturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { facturaElectroniToolStripMenuItem });
            fcaturaToolStripMenuItem.Name = "fcaturaToolStripMenuItem";
            fcaturaToolStripMenuItem.Size = new Size(81, 20);
            fcaturaToolStripMenuItem.Text = "Facturacion";
            // 
            // facturaElectroniToolStripMenuItem
            // 
            facturaElectroniToolStripMenuItem.Name = "facturaElectroniToolStripMenuItem";
            facturaElectroniToolStripMenuItem.Size = new Size(174, 22);
            facturaElectroniToolStripMenuItem.Text = "Factura Electronica";
            facturaElectroniToolStripMenuItem.Click += facturaElectroniToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 71);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 68;
            label1.Text = "Folio ";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(615, 145);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 0;
            label2.Text = "Tipo de \r\nTransaccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 71);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 0;
            label3.Text = "Evento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 242);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 0;
            label5.Text = "Fecha Pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(253, 242);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 0;
            label6.Text = "Facturacion";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(123, 237);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(349, 237);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(145, 23);
            dateTimePicker2.TabIndex = 0;
            // 
            // TBFolio
            // 
            TBFolio.Location = new Point(370, 68);
            TBFolio.Name = "TBFolio";
            TBFolio.Size = new Size(122, 23);
            TBFolio.TabIndex = 76;
            TBFolio.Visible = false;
            // 
            // TBEvento
            // 
            TBEvento.Location = new Point(122, 68);
            TBEvento.Name = "TBEvento";
            TBEvento.Size = new Size(121, 23);
            TBEvento.TabIndex = 1;
            TBEvento.KeyPress += textBox2_KeyPress;
            // 
            // CBTransaccion
            // 
            CBTransaccion.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTransaccion.Enabled = false;
            CBTransaccion.FormattingEnabled = true;
            CBTransaccion.Location = new Point(704, 150);
            CBTransaccion.Name = "CBTransaccion";
            CBTransaccion.Size = new Size(187, 23);
            CBTransaccion.TabIndex = 8;
            CBTransaccion.SelectionChangeCommitted += CBTransaccion_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 272);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 0;
            label7.Text = "Estado";
            // 
            // CBEstado
            // 
            CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEstado.FormattingEnabled = true;
            CBEstado.Location = new Point(123, 269);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(121, 23);
            CBEstado.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 306);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 0;
            label8.Text = "Observacion";
            // 
            // TBObservacion
            // 
            TBObservacion.CharacterCasing = CharacterCasing.Upper;
            TBObservacion.Location = new Point(124, 303);
            TBObservacion.Multiline = true;
            TBObservacion.Name = "TBObservacion";
            TBObservacion.Size = new Size(370, 60);
            TBObservacion.TabIndex = 5;
            // 
            // DTGDetalleEvento
            // 
            DTGDetalleEvento.AllowUserToAddRows = false;
            DTGDetalleEvento.AllowUserToDeleteRows = false;
            DTGDetalleEvento.AllowUserToResizeColumns = false;
            DTGDetalleEvento.AllowUserToResizeRows = false;
            DTGDetalleEvento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGDetalleEvento.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGDetalleEvento.BorderStyle = BorderStyle.None;
            DTGDetalleEvento.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DTGDetalleEvento.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DTGDetalleEvento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGDetalleEvento.Location = new Point(11, 379);
            DTGDetalleEvento.MultiSelect = false;
            DTGDetalleEvento.Name = "DTGDetalleEvento";
            DTGDetalleEvento.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DTGDetalleEvento.RowTemplate.Height = 25;
            DTGDetalleEvento.Size = new Size(878, 184);
            DTGDetalleEvento.TabIndex = 0;
            DTGDetalleEvento.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(615, 71);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 0;
            label9.Text = "Combrobante";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(615, 111);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 0;
            label10.Text = "Tipo de Pago";
            // 
            // CBComprante
            // 
            CBComprante.DropDownStyle = ComboBoxStyle.DropDownList;
            CBComprante.Enabled = false;
            CBComprante.FormattingEnabled = true;
            CBComprante.Location = new Point(702, 65);
            CBComprante.Name = "CBComprante";
            CBComprante.Size = new Size(187, 23);
            CBComprante.TabIndex = 6;
            CBComprante.SelectionChangeCommitted += CBComprante_SelectionChangeCommitted;
            // 
            // CBPago
            // 
            CBPago.DropDownStyle = ComboBoxStyle.DropDownList;
            CBPago.Enabled = false;
            CBPago.FormattingEnabled = true;
            CBPago.Location = new Point(704, 108);
            CBPago.Name = "CBPago";
            CBPago.Size = new Size(187, 23);
            CBPago.TabIndex = 7;
            CBPago.SelectionChangeCommitted += CBPago_SelectionChangeCommitted;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(616, 242);
            label13.Name = "label13";
            label13.Size = new Size(62, 15);
            label13.TabIndex = 0;
            label13.Text = "Referencia";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(616, 272);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 0;
            label14.Text = "Recibo";
            label14.Visible = false;
            // 
            // TBReferencia
            // 
            TBReferencia.CharacterCasing = CharacterCasing.Upper;
            TBReferencia.Location = new Point(702, 239);
            TBReferencia.Name = "TBReferencia";
            TBReferencia.Size = new Size(187, 23);
            TBReferencia.TabIndex = 9;
            // 
            // TBRecibo
            // 
            TBRecibo.CharacterCasing = CharacterCasing.Upper;
            TBRecibo.Location = new Point(702, 269);
            TBRecibo.Name = "TBRecibo";
            TBRecibo.Size = new Size(187, 23);
            TBRecibo.TabIndex = 0;
            TBRecibo.Visible = false;
            // 
            // TBDescripcion
            // 
            TBDescripcion.CharacterCasing = CharacterCasing.Upper;
            TBDescripcion.Location = new Point(142, 150);
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(350, 23);
            TBDescripcion.TabIndex = 3;
            // 
            // TBClientes
            // 
            TBClientes.CharacterCasing = CharacterCasing.Upper;
            TBClientes.Enabled = false;
            TBClientes.Location = new Point(142, 108);
            TBClientes.Name = "TBClientes";
            TBClientes.Size = new Size(350, 23);
            TBClientes.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 138);
            label15.Name = "label15";
            label15.Size = new Size(69, 30);
            label15.TabIndex = 0;
            label15.Text = "Descripcion\r\nde Evento";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(11, 111);
            label16.Name = "label16";
            label16.Size = new Size(44, 15);
            label16.TabIndex = 0;
            label16.Text = "Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 103;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(121, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 15);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 104;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // TBObservacionesPago
            // 
            TBObservacionesPago.CharacterCasing = CharacterCasing.Upper;
            TBObservacionesPago.Location = new Point(702, 303);
            TBObservacionesPago.Multiline = true;
            TBObservacionesPago.Name = "TBObservacionesPago";
            TBObservacionesPago.Size = new Size(187, 59);
            TBObservacionesPago.TabIndex = 10;
            TBObservacionesPago.Text = "\r\n\r\n\r\n";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(613, 306);
            label17.Name = "label17";
            label17.Size = new Size(87, 30);
            label17.TabIndex = 0;
            label17.Text = "Observaciones \r\nde pago";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 644);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 0;
            label11.Text = "Saldo Pendiente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(14, 676);
            label12.Name = "label12";
            label12.Size = new Size(91, 15);
            label12.TabIndex = 0;
            label12.Text = "Monto a Cobrar";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(278, 579);
            label18.Name = "label18";
            label18.Size = new Size(117, 15);
            label18.TabIndex = 0;
            label18.Text = "Deposito en Garantia";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(278, 612);
            label19.Name = "label19";
            label19.Size = new Size(73, 15);
            label19.TabIndex = 0;
            label19.Text = "Penalizacion";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(46, 41);
            label20.Name = "label20";
            label20.Size = new Size(68, 15);
            label20.TabIndex = 0;
            label20.Text = "IVA(Evento)";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(278, 644);
            label21.Name = "label21";
            label21.Size = new Size(112, 15);
            label21.TabIndex = 0;
            label21.Text = "Saldo Actual Evento";
            // 
            // SaldoPendiente
            // 
            SaldoPendiente.Enabled = false;
            SaldoPendiente.Location = new Point(152, 641);
            SaldoPendiente.Name = "SaldoPendiente";
            SaldoPendiente.RightToLeft = RightToLeft.Yes;
            SaldoPendiente.Size = new Size(100, 23);
            SaldoPendiente.TabIndex = 0;
            SaldoPendiente.Text = "0";
            // 
            // MontoaCobrar
            // 
            MontoaCobrar.Enabled = false;
            MontoaCobrar.Location = new Point(153, 673);
            MontoaCobrar.Name = "MontoaCobrar";
            MontoaCobrar.RightToLeft = RightToLeft.Yes;
            MontoaCobrar.Size = new Size(100, 23);
            MontoaCobrar.TabIndex = 11;
            MontoaCobrar.Text = "0";
            MontoaCobrar.KeyPress += MontoaCobrar_KeyPress;
            // 
            // SaldoaFavor
            // 
            SaldoaFavor.Enabled = false;
            SaldoaFavor.Location = new Point(460, 576);
            SaldoaFavor.Name = "SaldoaFavor";
            SaldoaFavor.RightToLeft = RightToLeft.Yes;
            SaldoaFavor.Size = new Size(100, 23);
            SaldoaFavor.TabIndex = 0;
            // 
            // Penalizacion
            // 
            Penalizacion.Enabled = false;
            Penalizacion.Location = new Point(460, 609);
            Penalizacion.Name = "Penalizacion";
            Penalizacion.RightToLeft = RightToLeft.Yes;
            Penalizacion.Size = new Size(100, 23);
            Penalizacion.TabIndex = 0;
            // 
            // TBIva
            // 
            TBIva.Enabled = false;
            TBIva.Location = new Point(166, 41);
            TBIva.Name = "TBIva";
            TBIva.RightToLeft = RightToLeft.Yes;
            TBIva.Size = new Size(100, 23);
            TBIva.TabIndex = 0;
            // 
            // SaldoActual
            // 
            SaldoActual.Enabled = false;
            SaldoActual.Location = new Point(460, 641);
            SaldoActual.Name = "SaldoActual";
            SaldoActual.RightToLeft = RightToLeft.Yes;
            SaldoActual.Size = new Size(100, 23);
            SaldoActual.TabIndex = 0;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(251, 71);
            label22.Name = "label22";
            label22.Size = new Size(0, 15);
            label22.TabIndex = 121;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 395);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(878, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            // 
            // CostoEvento
            // 
            CostoEvento.Enabled = false;
            CostoEvento.Location = new Point(152, 576);
            CostoEvento.Name = "CostoEvento";
            CostoEvento.RightToLeft = RightToLeft.Yes;
            CostoEvento.Size = new Size(100, 23);
            CostoEvento.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 579);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 0;
            label4.Text = "Costo del Evento";
            // 
            // MontoPagado
            // 
            MontoPagado.Enabled = false;
            MontoPagado.Location = new Point(153, 605);
            MontoPagado.Name = "MontoPagado";
            MontoPagado.RightToLeft = RightToLeft.Yes;
            MontoPagado.Size = new Size(100, 23);
            MontoPagado.TabIndex = 0;
            MontoPagado.Text = "0";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(12, 612);
            label23.Name = "label23";
            label23.Size = new Size(86, 15);
            label23.TabIndex = 0;
            label23.Text = "Monto Pagado";
            // 
            // Calcular
            // 
            Calcular.Location = new Point(774, 692);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 127;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Visible = false;
            Calcular.Click += Calcular_Click;
            // 
            // TBSubtotal
            // 
            TBSubtotal.Enabled = false;
            TBSubtotal.Location = new Point(166, 5);
            TBSubtotal.Name = "TBSubtotal";
            TBSubtotal.RightToLeft = RightToLeft.Yes;
            TBSubtotal.Size = new Size(100, 23);
            TBSubtotal.TabIndex = 0;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(59, 8);
            label24.Name = "label24";
            label24.Size = new Size(55, 15);
            label24.TabIndex = 0;
            label24.Text = "Sub Total";
            // 
            // panel1
            // 
            panel1.Controls.Add(TBSubtotal);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(TBIva);
            panel1.Controls.Add(label24);
            panel1.Location = new Point(583, 571);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 70);
            panel1.TabIndex = 130;
            panel1.Visible = false;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Red;
            label25.Location = new Point(629, 649);
            label25.Name = "label25";
            label25.Size = new Size(85, 15);
            label25.TabIndex = 0;
            label25.Text = "Monto a Pagar";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(749, 646);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(121, 195);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 15);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 135;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(11, 198);
            label26.Name = "label26";
            label26.Size = new Size(93, 15);
            label26.TabIndex = 0;
            label26.Text = "Fecha de Evento";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(142, 192);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(204, 23);
            dateTimePicker3.TabIndex = 0;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(566, 579);
            label27.Name = "label27";
            label27.Size = new Size(0, 15);
            label27.TabIndex = 137;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Enabled = false;
            label28.Location = new Point(259, 676);
            label28.Name = "label28";
            label28.Size = new Size(0, 15);
            label28.TabIndex = 138;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(566, 613);
            label29.Name = "label29";
            label29.Size = new Size(0, 15);
            label29.TabIndex = 139;
            // 
            // CPagos
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(905, 740);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(dateTimePicker3);
            Controls.Add(pictureBox3);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(panel1);
            Controls.Add(Calcular);
            Controls.Add(MontoPagado);
            Controls.Add(MontoaCobrar);
            Controls.Add(label23);
            Controls.Add(CostoEvento);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label22);
            Controls.Add(SaldoActual);
            Controls.Add(Penalizacion);
            Controls.Add(SaldoaFavor);
            Controls.Add(SaldoPendiente);
            Controls.Add(label21);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label11);
            Controls.Add(TBObservacionesPago);
            Controls.Add(label17);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(TBDescripcion);
            Controls.Add(TBClientes);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(TBRecibo);
            Controls.Add(TBReferencia);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(CBPago);
            Controls.Add(CBComprante);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(DTGDetalleEvento);
            Controls.Add(TBObservacion);
            Controls.Add(label8);
            Controls.Add(CBEstado);
            Controls.Add(label7);
            Controls.Add(CBTransaccion);
            Controls.Add(TBEvento);
            Controls.Add(TBFolio);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Name = "CPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagos";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DTGDetalleEvento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox TBFolio;
        private TextBox TBEvento;
        private ComboBox CBTransaccion;
        private Label label7;
        private ComboBox CBEstado;
        private Label label8;
        private TextBox TBObservacion;
        private DataGridView DTGDetalleEvento;
        private Label label9;
        private Label label10;
        private ComboBox CBComprante;
        private ComboBox CBPago;
        private Label label13;
        private Label label14;
        private TextBox TBReferencia;
        private TextBox TBRecibo;
        private TextBox TBDescripcion;
        private TextBox TBClientes;
        private Label label15;
        private Label label16;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox TBObservacionesPago;
        private Label label17;
        private Label label11;
        private Label label12;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox SaldoPendiente;
        private TextBox MontoaCobrar;
        private TextBox SaldoaFavor;
        private TextBox Penalizacion;
        private TextBox TBIva;
        private TextBox SaldoActual;
        private Label label22;
        private DataGridView dataGridView1;
        private TextBox CostoEvento;
        private Label label4;
        private TextBox MontoPagado;
        private Label label23;
        private ToolStripButton toolStripButton1;
        private Button Calcular;
        private ToolStripButton toolStripButton2;
        private TextBox TBSubtotal;
        private Label label24;
        private ToolStripMenuItem fcaturaToolStripMenuItem;
        private ToolStripMenuItem facturaElectroniToolStripMenuItem;
        private Panel panel1;
        private Label label25;
        private TextBox textBox1;
        private ToolStripSeparator toolStripSeparator3;
        private PictureBox pictureBox3;
        private Label label26;
        private DateTimePicker dateTimePicker3;
        private ToolStripButton toolStripButton3;
        private Label label27;
        private Label label28;
        private Label label29;
    }
}