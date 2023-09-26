namespace DCCEVENTOS.CBusqueda
{
    partial class ConsultadePagoDesc
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
            TBDescripcion = new TextBox();
            label4 = new Label();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // TBDescripcion
            // 
            TBDescripcion.CharacterCasing = CharacterCasing.Upper;
            TBDescripcion.Location = new Point(155, 30);
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(284, 23);
            TBDescripcion.TabIndex = 102;
            TBDescripcion.KeyPress += TBDescripcion_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 30);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 101;
            label4.Text = "Descripcion de Evento";
            // 
            // button5
            // 
            button5.Location = new Point(475, 30);
            button5.Name = "button5";
            button5.Size = new Size(117, 23);
            button5.TabIndex = 103;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(502, 265);
            dataGridView1.TabIndex = 104;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(539, 82);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(502, 265);
            dataGridView2.TabIndex = 105;
            dataGridView2.DoubleClick += dataGridView2_DoubleClick;
            // 
            // ConsultadePagoDesc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 360);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(TBDescripcion);
            Controls.Add(label4);
            Name = "ConsultadePagoDesc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultadePagoDesc";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBDescripcion;
        private Label label4;
        private Button button5;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}