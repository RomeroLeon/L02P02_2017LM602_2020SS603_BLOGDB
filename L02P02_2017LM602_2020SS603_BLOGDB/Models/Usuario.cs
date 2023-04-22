using System;
using System.Collections.Generic;

namespace L02P02_2017LM602_2020SS603_BLOGDB.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public int? RolId { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;
}
