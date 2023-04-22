using System;
using System.Collections.Generic;

namespace L02P02_2017LM602_2020SS603_BLOGDB.Models;

public partial class Publicacione
{
    public int PublicacionId { get; set; }

    public string Titulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? UsuarioId { get; set; }
}
