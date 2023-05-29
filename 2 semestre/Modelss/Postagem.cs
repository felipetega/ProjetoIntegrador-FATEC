using System;
using System.Collections.Generic;

namespace web_app.Modelss;

public partial class Postagem
{
    public int Id { get; set; }

    public string? Usuario { get; set; }

    public string? Descricao { get; set; }

    public int? Curtidas { get; set; }

    public string? UrlImagem { get; set; }
}
