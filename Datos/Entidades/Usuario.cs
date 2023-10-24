using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Usuario1 { get; set; }

    public string? Clave { get; set; }

    public int? IdRol { get; set; }

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }
}
