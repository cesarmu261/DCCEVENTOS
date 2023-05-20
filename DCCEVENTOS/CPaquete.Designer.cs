namespace DCCEVENTOS
{
    partial class CPaquete
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
            TBDesPaq = new TextLabel.ControlTextoEtiqueta();
            PaqueteExistencia = new DataGridView();
            button1 = new Button();
            BTNAct = new Button();
            BTNGuardar = new Button();
            CBESTADO = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)PaqueteExistencia).BeginInit();
            SuspendLayout();
            // 
            // TBDesPaq
            // 
            TBDesPaq.AlturaControl = 26;
            TBDesPaq.Location = new Point(100, 22);
            TBDesPaq.MinLength = 0;
            TBDesPaq.Name = "TBDesPaq";
            TBDesPaq.Nombre = null;
            TBDesPaq.Size = new Size(117, 26);
            TBDesPaq.TabIndex = 38;
            TBDesPaq.Tipo = "alfanumerico";
            // 
            // PaqueteExistencia
            // 
            PaqueteExistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaqueteExistencia.Location = new Point(12, 147);
            PaqueteExistencia.Name = "PaqueteExistencia";
            PaqueteExistencia.RowTemplate.Height = 25;
            PaqueteExistencia.Size = new Size(496, 236);
            PaqueteExistencia.TabIndex = 37;
            // 
            // button1
            // 
            button1.Location = new Point(265, 103);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 36;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BTNAct
            // 
            BTNAct.Location = new Point(24, 103);
            BTNAct.Name = "BTNAct";
            BTNAct.Size = new Size(144, 23);
            BTNAct.TabIndex = 35;
            BTNAct.Text = "Actualizar Informacion";
            BTNAct.UseVisualStyleBackColor = true;
            // 
            // BTNGuardar
            // 
            BTNGuardar.Location = new Point(184, 103);
            BTNGuardar.Name = "BTNGuardar";
            BTNGuardar.Size = new Size(75, 23);
            BTNGuardar.TabIndex = 34;
            BTNGuardar.Text = "Guardar";
            BTNGuardar.UseVisualStyleBackColor = true;
            // 
            // CBESTADO
            // 
            CBESTADO.FormattingEnabled = true;
            CBESTADO.Location = new Point(96, 57);
            CBESTADO.Name = "CBESTADO";
            CBESTADO.Size = new Size(121, 23);
            CBESTADO.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 57);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 32;
            label3.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 31;
            label1.Text = "Descripcion";
            // 
            // CPaquete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 389);
            Controls.Add(TBDesPaq);
            Controls.Add(PaqueteExistencia);
            Controls.Add(button1);
            Controls.Add(BTNAct);
            Controls.Add(BTNGuardar);
            Controls.Add(CBESTADO);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CPaquete";
            Text = "CPaquete";
            ((System.ComponentModel.ISupportInitialize)PaqueteExistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextLabel.ControlTextoEtiqueta TBDesPaq;
        private DataGridView PaqueteExistencia;
        private Button button1;
        private Button BTNAct;
        private Button BTNGuardar;
        private ComboBox CBESTADO;
        private Label label3;
        private Label label1;
    }
}