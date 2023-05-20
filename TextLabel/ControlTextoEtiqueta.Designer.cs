namespace TextLabel
{
    partial class ControlTextoEtiqueta
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            texto = new TextBox();
            mensaje = new Label();
            SuspendLayout();
            // 
            // texto
            // 
            texto.ForeColor = Color.Gray;
            texto.Location = new Point(1, 1);
            texto.Name = "texto";
            texto.Size = new Size(100, 23);
            texto.TabIndex = 0;
            texto.TextAlign = HorizontalAlignment.Center;
            texto.Enter += texto_Enter;
            texto.KeyUp += texto_KeyUp;
            texto.Leave += texto_Leave;
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.Font = new Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            mensaje.ForeColor = Color.Red;
            mensaje.Location = new Point(116, 6);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(0, 13);
            mensaje.TabIndex = 1;
            mensaje.Visible = false;
            // 
            // ControlTextoEtiqueta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mensaje);
            Controls.Add(texto);
            Name = "ControlTextoEtiqueta";
            Size = new Size(326, 26);
            Load += ControlTextoEtiqueta_Load;
            Resize += ControlTextoEtiqueta_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texto;
        private Label mensaje;
    }
}