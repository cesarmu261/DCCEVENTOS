namespace DCCEVENTOS.Configuracion
{
    partial class FCambiarContrasena
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
            BTCancelar = new Button();
            BTAceptar = new Button();
            label2 = new Label();
            label3 = new Label();
            TBConCon = new TextBox();
            label1 = new Label();
            TBConNue = new TextBox();
            TBConAnt = new TextBox();
            SuspendLayout();
            // 
            // BTCancelar
            // 
            BTCancelar.Location = new Point(198, 123);
            BTCancelar.Name = "BTCancelar";
            BTCancelar.Size = new Size(75, 23);
            BTCancelar.TabIndex = 0;
            BTCancelar.Text = "Cancelar";
            BTCancelar.UseVisualStyleBackColor = true;
            BTCancelar.Click += BTCancelar_Click;
            // 
            // BTAceptar
            // 
            BTAceptar.Location = new Point(62, 123);
            BTAceptar.Name = "BTAceptar";
            BTAceptar.Size = new Size(75, 23);
            BTAceptar.TabIndex = 0;
            BTAceptar.Text = "Aceptar";
            BTAceptar.UseVisualStyleBackColor = true;
            BTAceptar.Click += BTAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 56);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 0;
            label2.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 86);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 0;
            label3.Text = "Confirmar Contraseña";
            // 
            // TBConCon
            // 
            TBConCon.CharacterCasing = CharacterCasing.Upper;
            TBConCon.Location = new Point(142, 82);
            TBConCon.MaxLength = 50;
            TBConCon.Name = "TBConCon";
            TBConCon.Size = new Size(186, 23);
            TBConCon.TabIndex = 3;
            TBConCon.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 26);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Contraseña Anterior";
            // 
            // TBConNue
            // 
            TBConNue.CharacterCasing = CharacterCasing.Upper;
            TBConNue.Location = new Point(142, 53);
            TBConNue.MaxLength = 50;
            TBConNue.Name = "TBConNue";
            TBConNue.Size = new Size(186, 23);
            TBConNue.TabIndex = 2;
            TBConNue.UseSystemPasswordChar = true;
            // 
            // TBConAnt
            // 
            TBConAnt.CharacterCasing = CharacterCasing.Upper;
            TBConAnt.Location = new Point(142, 23);
            TBConAnt.MaxLength = 50;
            TBConAnt.Name = "TBConAnt";
            TBConAnt.Size = new Size(186, 23);
            TBConAnt.TabIndex = 1;
            TBConAnt.UseSystemPasswordChar = true;
            // 
            // FCambiarContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 161);
            Controls.Add(TBConAnt);
            Controls.Add(TBConNue);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(TBConCon);
            Controls.Add(BTCancelar);
            Controls.Add(BTAceptar);
            Controls.Add(label2);
            Name = "FCambiarContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTCancelar;
        private Button BTAceptar;
        private Label label2;
        private Label label3;
        public TextBox TBConCon;
        private Label label1;
        public TextBox TBConNue;
        public TextBox TBConAnt;
    }
}