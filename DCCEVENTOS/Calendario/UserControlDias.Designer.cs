namespace DCCEVENTOS.Calendario
{
    partial class UserControlDias
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Lbdia = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Lbdia
            // 
            Lbdia.AutoSize = true;
            Lbdia.Font = new Font("Segoe UI Variable Text", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Lbdia.Location = new Point(17, 15);
            Lbdia.Name = "Lbdia";
            Lbdia.Size = new Size(38, 31);
            Lbdia.TabIndex = 1;
            Lbdia.Text = "00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(10, 38);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 46);
            listBox1.TabIndex = 2;
            listBox1.Visible = false;
            // 
            // UserControlDias
            // 
            AutoScaleMode = AutoScaleMode.None;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(listBox1);
            Controls.Add(Lbdia);
            Name = "UserControlDias";
            Size = new Size(135, 100);
            Load += UserControlDias_Load;
            Click += UserControlDias_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbdia;
        private System.Windows.Forms.Timer timer1;
        private ListBox listBox1;
    }
}
