namespace DCCEVENTOS
{
    partial class CPaqueteDetalle
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
            PaqueteExistencia = new DataGridView();
            button1 = new Button();
            BTNAct = new Button();
            CBPaquete = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            controlTextoEtiqueta1 = new TextLabel.ControlTextoEtiqueta();
            ((System.ComponentModel.ISupportInitialize)PaqueteExistencia).BeginInit();
            SuspendLayout();
            // 
            // PaqueteExistencia
            // 
            PaqueteExistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaqueteExistencia.Location = new Point(22, 128);
            PaqueteExistencia.Name = "PaqueteExistencia";
            PaqueteExistencia.RowTemplate.Height = 25;
            PaqueteExistencia.Size = new Size(538, 251);
            PaqueteExistencia.TabIndex = 45;
            // 
            // button1
            // 
            button1.Location = new Point(310, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 44;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // BTNAct
            // 
            BTNAct.Location = new Point(40, 449);
            BTNAct.Name = "BTNAct";
            BTNAct.Size = new Size(144, 23);
            BTNAct.TabIndex = 43;
            BTNAct.Text = "Actualizar Informacion";
            BTNAct.UseVisualStyleBackColor = true;
            // 
            // CBPaquete
            // 
            CBPaquete.FormattingEnabled = true;
            CBPaquete.Location = new Point(91, 28);
            CBPaquete.Name = "CBPaquete";
            CBPaquete.Size = new Size(193, 23);
            CBPaquete.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 79);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 40;
            label3.Text = "Conceptos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 39;
            label1.Text = "Paquete";
            // 
            // controlTextoEtiqueta1
            // 
            controlTextoEtiqueta1.AlturaControl = 26;
            controlTextoEtiqueta1.Location = new Point(98, 76);
            controlTextoEtiqueta1.MinLength = 0;
            controlTextoEtiqueta1.Name = "controlTextoEtiqueta1";
            controlTextoEtiqueta1.Nombre = null;
            controlTextoEtiqueta1.Size = new Size(186, 26);
            controlTextoEtiqueta1.TabIndex = 46;
            controlTextoEtiqueta1.Tipo = null;
            // 
            // CPaqueteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 531);
            Controls.Add(controlTextoEtiqueta1);
            Controls.Add(PaqueteExistencia);
            Controls.Add(button1);
            Controls.Add(BTNAct);
            Controls.Add(CBPaquete);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CPaqueteDetalle";
            Text = "CPaqueteDetalle";
            Load += CPaqueteDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)PaqueteExistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView PaqueteExistencia;
        private Button button1;
        private Button BTNAct;
        private ComboBox CBPaquete;
        private Label label3;
        private Label label1;
        private TextLabel.ControlTextoEtiqueta controlTextoEtiqueta1;
    }
}