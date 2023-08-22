namespace DCCEVENTOS
{
    partial class CConcepto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CConcepto));
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            CBCodPor = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            label1 = new Label();
            CBCodCat = new ComboBox();
            label4 = new Label();
            conceptosexistentes = new DataGridView();
            CBEstado = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            TBCantidad = new TextBox();
            TbDes = new TextBox();
            TbPrecio = new TextBox();
            TbIVA = new TextBox();
            TbTotal = new TextBox();
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
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            textBox2 = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)conceptosexistentes).BeginInit();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(288, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 23);
            textBox1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 301);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 0;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 269);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 0;
            label8.Text = "IVA";
            // 
            // CBCodPor
            // 
            CBCodPor.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCodPor.FormattingEnabled = true;
            CBCodPor.Location = new Point(107, 136);
            CBCodPor.Name = "CBCodPor";
            CBCodPor.Size = new Size(121, 23);
            CBCodPor.TabIndex = 3;
            CBCodPor.SelectedIndexChanged += CBCodPor_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 139);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 0;
            label7.Text = "Aplica IVA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 240);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 0;
            label5.Text = "Precio / SubTotal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 113);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripcion";
            // 
            // CBCodCat
            // 
            CBCodCat.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCodCat.FormattingEnabled = true;
            CBCodCat.Location = new Point(107, 73);
            CBCodCat.Name = "CBCodCat";
            CBCodCat.Size = new Size(264, 23);
            CBCodCat.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 81);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 0;
            label4.Text = "Categoria";
            // 
            // conceptosexistentes
            // 
            conceptosexistentes.AllowUserToAddRows = false;
            conceptosexistentes.AllowUserToDeleteRows = false;
            conceptosexistentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            conceptosexistentes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            conceptosexistentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            conceptosexistentes.Location = new Point(411, 73);
            conceptosexistentes.Name = "conceptosexistentes";
            conceptosexistentes.RowTemplate.Height = 25;
            conceptosexistentes.Size = new Size(723, 281);
            conceptosexistentes.TabIndex = 0;
            // 
            // CBEstado
            // 
            CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEstado.FormattingEnabled = true;
            CBEstado.Location = new Point(107, 331);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(121, 23);
            CBEstado.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 334);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 139);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "% IVA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 173);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 0;
            label10.Text = "Cantidad";
            // 
            // TBCantidad
            // 
            TBCantidad.Location = new Point(107, 170);
            TBCantidad.Name = "TBCantidad";
            TBCantidad.Size = new Size(264, 23);
            TBCantidad.TabIndex = 4;
            TBCantidad.Text = "1";
            // 
            // TbDes
            // 
            TbDes.Location = new Point(107, 107);
            TbDes.Name = "TbDes";
            TbDes.Size = new Size(264, 23);
            TbDes.TabIndex = 2;
            // 
            // TbPrecio
            // 
            TbPrecio.Location = new Point(107, 237);
            TbPrecio.Name = "TbPrecio";
            TbPrecio.Size = new Size(264, 23);
            TbPrecio.TabIndex = 6;
            // 
            // TbIVA
            // 
            TbIVA.Location = new Point(107, 266);
            TbIVA.Name = "TbIVA";
            TbIVA.Size = new Size(264, 23);
            TbIVA.TabIndex = 7;
            // 
            // TbTotal
            // 
            TbTotal.Location = new Point(107, 298);
            TbTotal.Name = "TbTotal";
            TbTotal.Size = new Size(264, 23);
            TbTotal.TabIndex = 8;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNuevo, toolStripGuardar, toolStripButton1, toolStripSeparator1, toolStripBuscar, toolStripSeparator2, toolStripSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1134, 31);
            toolStrip1.TabIndex = 68;
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
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(28, 28);
            toolStripButton1.Text = "Actualizar";
            toolStripButton1.Click += toolStripButton1_Click;
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
            toolStripSalir.Click += toolStripSalir_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1134, 24);
            menuStrip1.TabIndex = 67;
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
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(126, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(126, 22);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += actualizarToolStripMenuItem_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(126, 22);
            buscarToolStripMenuItem.Text = "Buscar";
            buscarToolStripMenuItem.Click += buscarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(126, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 23);
            textBox2.TabIndex = 5;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 208);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 0;
            label11.Text = "Importe";
            // 
            // CConcepto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 384);
            Controls.Add(textBox2);
            Controls.Add(label11);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(TbTotal);
            Controls.Add(TbIVA);
            Controls.Add(TbPrecio);
            Controls.Add(TbDes);
            Controls.Add(TBCantidad);
            Controls.Add(label10);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(CBCodPor);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(CBCodCat);
            Controls.Add(label4);
            Controls.Add(conceptosexistentes);
            Controls.Add(CBEstado);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "CConcepto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Concepto";
            ((System.ComponentModel.ISupportInitialize)conceptosexistentes).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label9;
        private Label label8;
        private ComboBox CBCodPor;
        private Label label7;
        private Label label5;
        private Label label1;
        private ComboBox CBCodCat;
        private Label label4;
        private DataGridView conceptosexistentes;
        private ComboBox CBEstado;
        private Label label3;
        private Label label2;
        private TextLabel.ControlTextoEtiqueta TBDesCon;
        private TextLabel.ControlTextoEtiqueta TBCostosCon;
        private TextLabel.ControlTextoEtiqueta controlTextoEtiqueta3;
        private TextLabel.ControlTextoEtiqueta controlTextoEtiqueta4;
        private TextLabel.ControlTextoEtiqueta TBCostosprecio;
        private Label label10;
        private TextBox TBCantidad;
        private TextBox TbDes;
        private TextBox TbPrecio;
        private TextBox TbIVA;
        private TextBox TbTotal;
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
        private TextBox textBox2;
        private Label label11;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}