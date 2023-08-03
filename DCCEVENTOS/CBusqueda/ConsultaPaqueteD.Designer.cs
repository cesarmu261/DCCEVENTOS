namespace DCCEVENTOS.CBusqueda
{
    partial class ConsultaPaqueteD
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
            textBox1 = new TextBox();
            BTNBus = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 71;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // BTNBus
            // 
            BTNBus.Location = new Point(394, 26);
            BTNBus.Name = "BTNBus";
            BTNBus.Size = new Size(144, 23);
            BTNBus.TabIndex = 70;
            BTNBus.Text = "Buscar";
            BTNBus.UseVisualStyleBackColor = true;
            BTNBus.Click += BTNBus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 69;
            label1.Text = "Descripcion";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(746, 271);
            dataGridView1.TabIndex = 72;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // ConsultaPaqueteD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 337);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(BTNBus);
            Controls.Add(label1);
            Name = "ConsultaPaqueteD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Paquete D";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button BTNBus;
        private Label label1;
        private DataGridView dataGridView1;
    }
}