using System;
using System.Collections.Generic;

namespace web_app.Modelss;

public partial class TbLogin
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Senha { get; set; }

    public bool? IsAdm { get; set; }
}
