namespace DCCEVENTOS
{
    partial class CCategoria
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
            button1 = new Button();
            BTNAct = new Button();
            BTNGuardar = new Button();
            CBESTADO = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            CategoriaExistencia = new DataGridView();
            TBDESCAT = new TextLabel.ControlTextoEtiqueta();
            ((System.ComponentModel.ISupportInitialize)CategoriaExistencia).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(265, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 28;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // BTNAct
            // 
            BTNAct.Location = new Point(24, 101);
            BTNAct.Name = "BTNAct";
            BTNAct.Size = new Size(144, 23);
            BTNAct.TabIndex = 27;
            BTNAct.Text = "Actualizar Informacion";
            BTNAct.UseVisualStyleBackColor = true;
            // 
            // BTNGuardar
            // 
            BTNGuardar.Location = new Point(184, 101);
            BTNGuardar.Name = "BTNGuardar";
            BTNGuardar.Size = new Size(75, 23);
            BTNGuardar.TabIndex = 26;
            BTNGuardar.Text = "Guardar";
            BTNGuardar.UseVisualStyleBackColor = true;
            // 
            // CBESTADO
            // 
            CBESTADO.FormattingEnabled = true;
            CBESTADO.Location = new Point(96, 55);
            CBESTADO.Name = "CBESTADO";
            CBESTADO.Size = new Size(121, 23);
            CBESTADO.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 55);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 24;
            label3.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 23;
            label1.Text = "Descripcion";
            // 
            // CategoriaExistencia
            // 
            CategoriaExistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriaExistencia.Location = new Point(12, 145);
            CategoriaExistencia.Name = "CategoriaExistencia";
            CategoriaExistencia.RowTemplate.Height = 25;
            CategoriaExistencia.Size = new Size(496, 236);
            CategoriaExistencia.TabIndex = 29;
            // 
            // TBDESCAT
            // 
            TBDESCAT.AlturaControl = 26;
            TBDESCAT.Location = new Point(100, 20);
            TBDESCAT.MinLength = 0;
            TBDESCAT.Name = "TBDESCAT";
            TBDESCAT.Nombre = null;
            TBDESCAT.Size = new Size(117, 26);
            TBDESCAT.TabIndex = 30;
            TBDESCAT.Tipo = "alfanumerico";
            // 
            // CCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 427);
            Controls.Add(TBDESCAT);
            Controls.Add(CategoriaExistencia);
            Controls.Add(button1);
            Controls.Add(BTNAct);
            Controls.Add(BTNGuardar);
            Controls.Add(CBESTADO);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CCategoria";
            Text = "CCategoria";
            ((System.ComponentModel.ISupportInitialize)CategoriaExistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button BTNAct;
        private Button BTNGuardar;
        private ComboBox CBESTADO;
        private Label label3;
        private Label label1;
        private DataGridView CategoriaExistencia;
        private TextLabel.ControlTextoEtiqueta TBDESCAT;
    }
}