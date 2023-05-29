using System;
using System.Collections.Generic;

namespace web_app.Modelss;

public partial class Carro
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Cor { get; set; } = null!;

    public DateTime? DataFabricacao { get; set; }

    public decimal? Valor { get; set; }
}
