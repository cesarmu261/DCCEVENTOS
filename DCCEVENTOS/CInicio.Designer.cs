namespace DCCEVENTOS
{
    partial class CInicio
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
            TBUsuario = new TextBox();
            TBCon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BTAceptar = new Button();
            BTCancelar = new Button();
            SuspendLayout();
            // 
            // TBUsuario
            // 
            TBUsuario.CharacterCasing = CharacterCasing.Upper;
            TBUsuario.Location = new Point(111, 26);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(186, 23);
            TBUsuario.TabIndex = 1;
            // 
            // TBCon
            // 
            TBCon.CharacterCasing = CharacterCasing.Upper;
            TBCon.Location = new Point(111, 56);
            TBCon.MaxLength = 50;
            TBCon.Name = "TBCon";
            TBCon.Size = new Size(186, 23);
            TBCon.TabIndex = 2;
            TBCon.UseSystemPasswordChar = true;
            TBCon.KeyPress += TBCon_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 59);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Contraseña";
            // 
            // BTAceptar
            // 
            BTAceptar.Location = new Point(57, 95);
            BTAceptar.Name = "BTAceptar";
            BTAceptar.Size = new Size(75, 23);
            BTAceptar.TabIndex = 3;
            BTAceptar.Text = "Aceptar";
            BTAceptar.UseVisualStyleBackColor = true;
            BTAceptar.Click += BTAceptar_Click;
            // 
            // BTCancelar
            // 
            BTCancelar.Location = new Point(193, 95);
            BTCancelar.Name = "BTCancelar";
            BTCancelar.Size = new Size(75, 23);
            BTCancelar.TabIndex = 4;
            BTCancelar.Text = "Cancelar";
            BTCancelar.UseVisualStyleBackColor = true;
            BTCancelar.Click += BTCancelar_Click;
            // 
            // CInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 129);
            Controls.Add(BTCancelar);
            Controls.Add(BTAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBCon);
            Controls.Add(TBUsuario);
            Name = "CInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button BTAceptar;
        private Button BTCancelar;
        public TextBox TBUsuario;
        public TextBox TBCon;
    }
}