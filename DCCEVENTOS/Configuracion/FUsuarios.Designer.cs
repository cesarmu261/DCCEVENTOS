namespace DCCEVENTOS.Configuracion
{
    partial class FUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUsuarios));
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
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            CBEstado = new ComboBox();
            CBRol = new ComboBox();
            dataGridView1 = new DataGridView();
            TBCon = new TextBox();
            TBApe = new TextBox();
            TBUau = new TextBox();
            TBNom = new TextBox();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripNuevo, toolStripGuardar, toolStripButton1, toolStripSeparator1, toolStripBuscar, toolStripSeparator2, toolStripSalir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(885, 31);
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
            menuStrip1.Size = new Size(885, 24);
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
            nuevoToolStripMenuItem.Click += toolStripNuevo_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(126, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += toolStripGuardar_Click;
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(126, 22);
            actualizarToolStripMenuItem.Text = "Actualizar";
            actualizarToolStripMenuItem.Click += toolStripButton1_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(126, 22);
            buscarToolStripMenuItem.Text = "Buscar";
            buscarToolStripMenuItem.Click += toolStripBuscar_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(126, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += toolStripSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 108);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 0;
            label5.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(570, 79);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 0;
            label6.Text = "Rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 108);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 79);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 108);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 79);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // CBEstado
            // 
            CBEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CBEstado.FormattingEnabled = true;
            CBEstado.Location = new Point(624, 105);
            CBEstado.Name = "CBEstado";
            CBEstado.Size = new Size(147, 23);
            CBEstado.TabIndex = 0;
            // 
            // CBRol
            // 
            CBRol.DropDownStyle = ComboBoxStyle.DropDownList;
            CBRol.FormattingEnabled = true;
            CBRol.Location = new Point(624, 76);
            CBRol.Name = "CBRol";
            CBRol.Size = new Size(147, 23);
            CBRol.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(866, 187);
            dataGridView1.TabIndex = 0;
            // 
            // TBCon
            // 
            TBCon.CharacterCasing = CharacterCasing.Upper;
            TBCon.Location = new Point(387, 105);
            TBCon.MaxLength = 50;
            TBCon.Name = "TBCon";
            TBCon.Size = new Size(147, 23);
            TBCon.TabIndex = 4;
            TBCon.UseSystemPasswordChar = true;
            // 
            // TBApe
            // 
            TBApe.CharacterCasing = CharacterCasing.Upper;
            TBApe.Location = new Point(387, 76);
            TBApe.MaxLength = 50;
            TBApe.Name = "TBApe";
            TBApe.Size = new Size(147, 23);
            TBApe.TabIndex = 2;
            // 
            // TBUau
            // 
            TBUau.CharacterCasing = CharacterCasing.Upper;
            TBUau.Location = new Point(138, 105);
            TBUau.MaxLength = 50;
            TBUau.Name = "TBUau";
            TBUau.Size = new Size(147, 23);
            TBUau.TabIndex = 3;
            // 
            // TBNom
            // 
            TBNom.CharacterCasing = CharacterCasing.Upper;
            TBNom.Location = new Point(138, 76);
            TBNom.MaxLength = 50;
            TBNom.Name = "TBNom";
            TBNom.Size = new Size(147, 23);
            TBNom.TabIndex = 1;
            // 
            // FUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 355);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CBEstado);
            Controls.Add(CBRol);
            Controls.Add(dataGridView1);
            Controls.Add(TBCon);
            Controls.Add(TBApe);
            Controls.Add(TBUau);
            Controls.Add(TBNom);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Name = "FUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrar Usuarios";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox CBEstado;
        private ComboBox CBRol;
        private DataGridView dataGridView1;
        private TextBox TBCon;
        private TextBox TBApe;
        private TextBox TBUau;
        private TextBox TBNom;
    }
}