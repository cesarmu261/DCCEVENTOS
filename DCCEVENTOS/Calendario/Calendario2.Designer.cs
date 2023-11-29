namespace DCCEVENTOS.Calendario
{
    partial class Calendario2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendario2));
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            Lbfecha = new Label();
            DTGEventos = new DataGridView();
            Contenedordia = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DTGEventos).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(883, 139);
            label7.Name = "label7";
            label7.Size = new Size(88, 30);
            label7.TabIndex = 55;
            label7.Text = "Sabado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(736, 139);
            label6.Name = "label6";
            label6.Size = new Size(88, 30);
            label6.TabIndex = 54;
            label6.Text = "Viernes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(597, 139);
            label5.Name = "label5";
            label5.Size = new Size(80, 30);
            label5.TabIndex = 53;
            label5.Text = "Jueves";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(440, 139);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 52;
            label4.Text = "Miercoles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(303, 139);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 51;
            label3.Text = "Martes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(164, 139);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 50;
            label2.Text = "Lunes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 139);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 49;
            label1.Text = "Domingo";
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(955, 58);
            button2.Name = "button2";
            button2.Size = new Size(33, 40);
            button2.TabIndex = 57;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(994, 58);
            button1.Name = "button1";
            button1.Size = new Size(34, 40);
            button1.TabIndex = 56;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lbfecha
            // 
            Lbfecha.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbfecha.Location = new Point(380, 25);
            Lbfecha.Name = "Lbfecha";
            Lbfecha.Size = new Size(282, 73);
            Lbfecha.TabIndex = 58;
            Lbfecha.Text = "MES       AÑO";
            // 
            // DTGEventos
            // 
            DTGEventos.AllowUserToAddRows = false;
            DTGEventos.AllowUserToDeleteRows = false;
            DTGEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DTGEventos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DTGEventos.Location = new Point(1076, 189);
            DTGEventos.Name = "DTGEventos";
            DTGEventos.ReadOnly = true;
            DTGEventos.RowHeadersWidth = 62;
            DTGEventos.RowTemplate.Height = 25;
            DTGEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTGEventos.Size = new Size(551, 461);
            DTGEventos.TabIndex = 59;
            DTGEventos.TabStop = false;
            DTGEventos.DoubleClick += DTGEventos_DoubleClick;
            // 
            // Contenedordia
            // 
            Contenedordia.Location = new Point(12, 189);
            Contenedordia.Name = "Contenedordia";
            Contenedordia.Size = new Size(1058, 911);
            Contenedordia.TabIndex = 60;
            // 
            // Calendario2
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(1632, 1061);
            Controls.Add(Contenedordia);
            Controls.Add(DTGEventos);
            Controls.Add(Lbfecha);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Calendario2";
            Text = "Calendario2";
            Load += Calendario_Load;
            ((System.ComponentModel.ISupportInitialize)DTGEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label Lbfecha;
        private DataGridView DTGEventos;
        private FlowLayoutPanel Contenedordia;
    }
}