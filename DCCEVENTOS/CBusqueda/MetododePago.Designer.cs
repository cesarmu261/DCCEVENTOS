namespace DCCEVENTOS.CBusqueda
{
    partial class MetododePago
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
            BTNBus = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // BTNBus
            // 
            BTNBus.Location = new Point(411, 25);
            BTNBus.Name = "BTNBus";
            BTNBus.Size = new Size(144, 23);
            BTNBus.TabIndex = 3;
            BTNBus.Text = "Buscar";
            BTNBus.UseVisualStyleBackColor = true;
            BTNBus.Click += BTNBus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 4;
            label1.Text = "Metodo";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 23);
            comboBox1.TabIndex = 5;
            // 
            // MetododePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 70);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(BTNBus);
            Name = "MetododePago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Metodo de Pago";
            Load += MetododePago_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNBus;
        private Label label1;
        private ComboBox comboBox1;
    }
}