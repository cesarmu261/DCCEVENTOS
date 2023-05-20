namespace DCCEVENTOS
{
    partial class CPorcentaje
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
            PorcentjesExistencia = new DataGridView();
            BTAgregar = new Button();
            BTNAct = new Button();
            BTNGuardar = new Button();
            CBESTADO = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            TBDesPor = new TextLabel.ControlTextoEtiqueta();
            TBPorciento = new TextLabel.ControlTextoEtiqueta();
            ((System.ComponentModel.ISupportInitialize)PorcentjesExistencia).BeginInit();
            SuspendLayout();
            // 
            // PorcentjesExistencia
            // 
            PorcentjesExistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PorcentjesExistencia.Location = new Point(12, 175);
            PorcentjesExistencia.Name = "PorcentjesExistencia";
            PorcentjesExistencia.RowTemplate.Height = 25;
            PorcentjesExistencia.Size = new Size(496, 236);
            PorcentjesExistencia.TabIndex = 37;
            // 
            // BTAgregar
            // 
            BTAgregar.Location = new Point(265, 131);
            BTAgregar.Name = "BTAgregar";
            BTAgregar.Size = new Size(75, 23);
            BTAgregar.TabIndex = 36;
            BTAgregar.Text = "Agregar";
            BTAgregar.UseVisualStyleBackColor = true;
            BTAgregar.Click += BTAgregar_Click;
            // 
            // BTNAct
            // 
            BTNAct.Location = new Point(24, 131);
            BTNAct.Name = "BTNAct";
            BTNAct.Size = new Size(144, 23);
            BTNAct.TabIndex = 35;
            BTNAct.Text = "Actualizar Informacion";
            BTNAct.UseVisualStyleBackColor = true;
            BTNAct.Click += BTNAct_Click;
            // 
            // BTNGuardar
            // 
            BTNGuardar.Location = new Point(184, 131);
            BTNGuardar.Name = "BTNGuardar";
            BTNGuardar.Size = new Size(75, 23);
            BTNGuardar.TabIndex = 34;
            BTNGuardar.Text = "Guardar";
            BTNGuardar.UseVisualStyleBackColor = true;
            // 
            // CBESTADO
            // 
            CBESTADO.FormattingEnabled = true;
            CBESTADO.Location = new Point(100, 92);
            CBESTADO.Name = "CBESTADO";
            CBESTADO.Size = new Size(117, 23);
            CBESTADO.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 92);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 32;
            label3.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 31;
            label1.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 55);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 39;
            label2.Text = "Porciento";
            // 
            // TBDesPor
            // 
            TBDesPor.AlturaControl = 26;
            TBDesPor.Location = new Point(100, 24);
            TBDesPor.MinLength = 0;
            TBDesPor.Name = "TBDesPor";
            TBDesPor.Nombre = null;
            TBDesPor.Size = new Size(117, 26);
            TBDesPor.TabIndex = 40;
            TBDesPor.Tipo = "alfanumerico";
            // 
            // TBPorciento
            // 
            TBPorciento.AlturaControl = 26;
            TBPorciento.Location = new Point(100, 56);
            TBPorciento.MinLength = 0;
            TBPorciento.Name = "TBPorciento";
            TBPorciento.Nombre = null;
            TBPorciento.Size = new Size(117, 26);
            TBPorciento.TabIndex = 41;
            TBPorciento.Tipo = "decimal";
            // 
            // CPorcentaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 421);
            Controls.Add(TBPorciento);
            Controls.Add(TBDesPor);
            Controls.Add(label2);
            Controls.Add(PorcentjesExistencia);
            Controls.Add(BTAgregar);
            Controls.Add(BTNAct);
            Controls.Add(BTNGuardar);
            Controls.Add(CBESTADO);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CPorcentaje";
            Text = "CPorcentaje";
            ((System.ComponentModel.ISupportInitialize)PorcentjesExistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView PorcentjesExistencia;
        private Button BTAgregar;
        private Button BTNAct;
        private Button BTNGuardar;
        private ComboBox CBESTADO;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextLabel.ControlTextoEtiqueta TBDesPor;
        private TextLabel.ControlTextoEtiqueta TBPorciento;
    }
}