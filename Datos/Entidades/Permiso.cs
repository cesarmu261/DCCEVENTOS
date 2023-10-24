using System;
using System.Collections.Generic;

namespace Datos.Entidades;

public partial class Permiso
{
    public int IdPermiso { get; set; }

    public int? IdRol { get; set; }

    public int? IdMenu { get; set; }

    public bool? Activo { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }
}
