using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Rol
{
    public int IdRol { get; set; }

    public string? Nombre { get; set; }

    public string? CodEstado { get; set; }

    public virtual SaCodEstado? CodEstadoNavigation { get; set; }

    public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
