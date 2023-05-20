namespace TextLabel
{
    public partial class ControlTextoEtiqueta : UserControl
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int MinLength { get; set; }
        public int AlturaControl { get; set; }
        public ControlTextoEtiqueta()
        {
            InitializeComponent();
            AlturaControl = this.Height;
        }

        public TextBox GetTextBox()
        {
            return this.texto;
        }

        private void Validaciones()
        {
            System.Text.RegularExpressions.Regex er = new System.Text.RegularExpressions.Regex("");
            if (Tipo.ToLower().Equals("entero"))
            {
                er = new System.Text.RegularExpressions.Regex("^(?:\\+|-)?\\d+$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser numerico entero positivo o negativo";
            }
            else if (Tipo.ToLower().Equals("enteropositivo"))
            {
                er = new System.Text.RegularExpressions.Regex("^\\+?\\d+$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser numerico entero positivo";
            }
            else if (Tipo.ToLower().Equals("enteronegativo"))
            {
                er = new System.Text.RegularExpressions.Regex("^-\\d+$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser numerico entero negativo";
            }
            else if (Tipo.ToLower().Equals("decimal"))
            {
                er = new System.Text.RegularExpressions.Regex("^(?:\\+|-)?\\d+\\.\\d+$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser numerico decimal positivo o negativo";
            }
            else if (Tipo.ToLower().Equals("decimalpositivo"))
            {
                er = new System.Text.RegularExpressions.Regex("^\\+?\\d+\\.\\d+$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser numerico decimal positivo";
            }
            else if (Tipo.ToLower().Equals("decimalnegativo"))
            {
                er = new System.Text.RegularExpressions.Regex("^-\\d+?\\.\\d+$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser numerico decimal negativo";
            }
            else if (Tipo.ToLower().Equals("alfabetico"))
            {
                er = new System.Text.RegularExpressions.Regex("^[a-zA-Z]+$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser alfabetico";
            }
            else if (Tipo.ToLower().Equals("alfanumerico"))
            {
                er = new System.Text.RegularExpressions.Regex("^(?:\\w|\\s)+$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser alfanumerico";
            }
            else if (Tipo.ToLower().Equals("alfanumericocaracteres"))
            {
                er = new System.Text.RegularExpressions.Regex("^(?:\\p{Pc})+$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser alfanumerico con/sin caracteres especiales";
            }
            else if (Tipo.ToLower().Equals("password"))
            {
                er = new System.Text.RegularExpressions.Regex("[a-z]+");
                if (er.Match(this.texto.Text).Success)
                {
                    er = new System.Text.RegularExpressions.Regex("[A-Z]+");
                    if (er.Match(this.texto.Text).Success)
                    {
                        er = new System.Text.RegularExpressions.Regex("\\p{Pc}+");
                        if (!er.Match(this.texto.Text).Success)
                            this.mensaje.Text = "El campo debe contener al menos un caracter especial";
                    }
                    else
                        this.mensaje.Text = "El campo debe contener al menos una letra minuscula";
                }
                else
                    this.mensaje.Text = "El campo debe contener al menos una letra minuscula";
            }
            else if (Tipo.ToLower().Equals("telefono"))
            {
                er = new System.Text.RegularExpressions.Regex("(?:\\d{10}|(?:\\d{3}(?:-| )\\d{3}(?:-| )\\d{2}(?:-| )\\d{2})");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser algun numero telefonico valido a 10 digitos (los separadores pueden ser - o espacio)";
            }
            else if (Tipo.ToLower().Equals("correo"))
            {
                er = new System.Text.RegularExpressions.Regex("^(?:\\w+[!#&*-_=+^%.]*)+@(?:\\w+[!#&*-_=+^%.]*)+(?:com|es|mx|org)$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser algun correo electronico valido";
            }
            else if (Tipo.ToLower().Equals("rfc"))
            {
                er = new System.Text.RegularExpressions.Regex("^[a-zA-Z]{3,4}[0-9]{2}(?:0[1-9]|1[0-2])[0-9]{2}[a-zA-Z0-9]{3}$");
                if (!er.Match(this.texto.Text).Success)
                    this.mensaje.Text = "El campo debe de ser algun RFC valido";
            }

            if (MinLength > this.texto.TextLength)
            {
                this.mensaje.Text += String.Format("{0}La longitud minima es: {1}", Environment.NewLine, MinLength);
                this.texto.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (er.Match(this.texto.Text).Success)
            {
                this.mensaje.Text = "";
                this.texto.BorderStyle = BorderStyle.None;
            }

            if (er.Match(this.texto.Text).Success)
            {
                this.mensaje.Text = "";
                this.mensaje.Visible = false;
                this.texto.BorderStyle = BorderStyle.None;
            }
            else
            {
                this.mensaje.Visible = true;
                this.texto.BorderStyle = BorderStyle.Fixed3D;
            }
            this.Height = AlturaControl;
            if (this.texto.Width < this.mensaje.Width)
            {
                int pixeles = 5;
                int y = this.mensaje.Text.Length * pixeles;
                int x = (int)Math.Truncate((decimal)(y / this.texto.Width));
                int letrasControl = (int)Math.Truncate((decimal)(this.texto.Width / pixeles)), avanceLetras = 0;
                string texto = "";
                for (int i = 1; i <= x; i++)
                {
                    texto += this.mensaje.Text.Substring(avanceLetras, (this.mensaje.Text.Length > (avanceLetras + letrasControl)) ? letrasControl : (this.mensaje.Text.Length - (avanceLetras + 1))) + Environment.NewLine;
                    avanceLetras += letrasControl;
                    this.Height += 10;
                }
                if ((this.mensaje.Text.Length - avanceLetras) > 0)
                {
                    texto += this.mensaje.Text.Substring(avanceLetras, (this.mensaje.Text.Length - avanceLetras));
                    this.Height += 10;
                }
                this.mensaje.Text = texto;
            }
        }

        private void texto_Enter(object sender, EventArgs e)
        {
            if (this.texto.Text.Equals(Nombre))
            {
                this.texto.Text = "";
            }
        }

        private void texto_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.texto.Text))
            {
                this.texto.Text = Nombre;
            }
        }

        private void ControlTextoEtiqueta_Resize(object sender, EventArgs e)
        {
            this.texto.Width = this.Size.Width - 5;
        }

        private void ControlTextoEtiqueta_Load(object sender, EventArgs e)
        {
            this.texto.Text = this.Nombre;
        }

        private void texto_KeyUp(object sender, KeyEventArgs e)
        {
            Validaciones();
            if (e.KeyValue == (int)Keys.Enter)
            {
                this.OnLeave(new EventArgs());
            }
        }
    }
}