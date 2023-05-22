namespace DCCEVENTOS.CBusqueda
{
    partial class ConsultadeConceptos
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
            label1 = new Label();
            BTNBus = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 56;
            label1.Text = "Descripcion";
            // 
            // BTNBus
            // 
            BTNBus.Location = new Point(380, 26);
            BTNBus.Name = "BTNBus";
            BTNBus.Size = new Size(144, 23);
            BTNBus.TabIndex = 58;
            BTNBus.Text = "Buscar";
            BTNBus.UseVisualStyleBackColor = true;
            BTNBus.Click += BTNBus_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(626, 258);
            dataGridView1.TabIndex = 59;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 60;
            // 
            // ConsultadeConceptos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 342);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(BTNBus);
            Controls.Add(label1);
            Name = "ConsultadeConceptos";
            Text = "ConsultadeConceptos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button BTNBus;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}