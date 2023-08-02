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
            SuspendLayout();
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(914, 48);
            button2.Name = "button2";
            button2.Size = new Size(33, 40);
            button2.TabIndex = 34;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(953, 48);
            button1.Name = "button1";
            button1.Size = new Size(34, 40);
            button1.TabIndex = 33;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lbfecha
            // 
            Lbfecha.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbfecha.Location = new Point(415, 31);
            Lbfecha.Name = "Lbfecha";
            Lbfecha.Size = new Size(196, 30);
            Lbfecha.TabIndex = 32;
            Lbfecha.Text = "MES       AÑO";
            // 
            // Contenedordia
            // 
            Contenedordia.Location = new Point(28, 147);
            Contenedordia.Name = "Contenedordia";
            Contenedordia.Size = new Size(1018, 673);
            Contenedordia.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(875, 101);
            label7.Name = "label7";
            label7.Size = new Size(88, 30);
            label7.TabIndex = 30;
            label7.Text = "Sabado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(744, 101);
            label6.Name = "label6";
            label6.Size = new Size(88, 30);
            label6.TabIndex = 29;
            label6.Text = "Viernes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(600, 101);
            label5.Name = "label5";
            label5.Size = new Size(80, 30);
            label5.TabIndex = 28;
            label5.Text = "Jueves";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(449, 101);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 27;
            label4.Text = "Miercoles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(323, 101);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 26;
            label3.Text = "Martes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(190, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 25;
            label2.Text = "Lunes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 101);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 24;
            label1.Text = "Domingo";
            // 
            // Calendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 833);
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
    }
}