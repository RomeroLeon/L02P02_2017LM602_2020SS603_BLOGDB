using System;
using System.Collections.Generic;

namespace L02P02_2017LM602_2020SS603_BLOGDB.Models;

public partial class Comentario
{
    public int CometarioId { get; set; }

    public int? PublicacionId { get; set; }

    public string? Comentario1 { get; set; }

    public int? UsuarioId { get; set; }
}
