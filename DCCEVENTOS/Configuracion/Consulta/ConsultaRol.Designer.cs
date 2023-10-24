namespace DCCEVENTOS.Usuario.Consulta
{
    partial class ConsultaRol
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
            dataGridView1 = new DataGridView();
            BTNBus = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Location = new Point(96, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 9;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 271);
            dataGridView1.TabIndex = 7;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // BTNBus
            // 
            BTNBus.Location = new Point(380, 8);
            BTNBus.Name = "BTNBus";
            BTNBus.Size = new Size(144, 23);
            BTNBus.TabIndex = 10;
            BTNBus.Text = "Buscar";
            BTNBus.UseVisualStyleBackColor = true;
            BTNBus.Click += BTNBus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 8;
            label1.Text = "Descripcion";
            // 
            // ConsultaRol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 321);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(BTNBus);
            Controls.Add(label1);
            Name = "ConsultaRol";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultaRol";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button BTNBus;
        private Label label1;
    }
}