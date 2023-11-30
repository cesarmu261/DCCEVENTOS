namespace DCCEVENTOS.Calendario
{
    partial class Calendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario));
            button2 = new Button();
            button1 = new Button();
            Lbfecha = new Label();
            Contenedordia = new FlowLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            DTGEventos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DTGEventos).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1000, 73);
            button2.Name = "button2";
            button2.Size = new Size(33, 40);
            button2.TabIndex = 34;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1039, 73);
            button1.Name = "button1";
            button1.Size = new Size(34, 40);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lbfecha
            // 
            Lbfecha.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbfecha.Location = new Point(390, 29);
            Lbfecha.Name = "Lbfecha";
            Lbfecha.Size = new Size(282, 73);
            Lbfecha.TabIndex = 32;
            Lbfecha.Text = "MES       AÑO";
            // 
            // Contenedordia
            // 
            Contenedordia.Location = new Point(42, 189);
            Contenedordia.Name = "Contenedordia";
            Contenedordia.Size = new Size(1031, 911);
            Contenedordia.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(897, 143);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 30;
            label7.Text = "Sabado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(750, 143);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 29;
            label6.Text = "Viernes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(611, 143);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 28;
            label5.Text = "Jueves";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(461, 143);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 27;
            label4.Text = "Miercoles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(323, 143);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 26;
            label3.Text = "Martes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(184, 143);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 25;
            label2.Text = "Lunes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 143);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 24;
            label1.Text = "Domingo";
            // 
            // DTGEventos
            // 
            DTGEventos.AllowUserToAddRows = false;
            DTGEventos.AllowUserToDeleteRows = false;
            DTGEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTGEventos.Location = new Point(1079, 189);
            DTGEventos.Name = "DTGEventos";
            DTGEventos.ReadOnly = true;
            DTGEventos.RowHeadersWidth = 62;
            DTGEventos.RowTemplate.Height = 25;
            DTGEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTGEventos.Size = new Size(494, 461);
            DTGEventos.TabIndex = 35;
            DTGEventos.DoubleClick += DTGEventos_DoubleClick;
            // 
            // Calendario
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1571, 862);
            Controls.Add(DTGEventos);
            Controls.Add(Contenedordia);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Lbfecha);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calendario";
            Text = "Calendario";
            Load += Calendario_Load;
            ((System.ComponentModel.ISupportInitialize)DTGEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label Lbfecha;
        private FlowLayoutPanel Contenedordia;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView DTGEventos;
    }
}