using System;
using System.Collections.Generic;

namespace web_app.Modelss;

public partial class Produto
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }

    public string? UrlImagem { get; set; }
}
