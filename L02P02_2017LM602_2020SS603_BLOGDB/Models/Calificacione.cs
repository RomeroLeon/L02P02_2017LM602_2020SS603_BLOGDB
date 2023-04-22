using System;
using System.Collections.Generic;

namespace L02P02_2017LM602_2020SS603_BLOGDB.Models;

public partial class Calificacione
{
    public int CalificacionId { get; set; }

    public int? PublicacionId { get; set; }

    public int? UsuarioId { get; set; }

    public int? Calificacion { get; set; }
}
