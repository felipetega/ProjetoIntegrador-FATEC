using System.ComponentModel.DataAnnotations; // anotações para validação acima de cada propriedade

namespace web_app.Models
{
    public class Carro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 3, ErrorMessage ="Mínimo de 3 e máximo de 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Cor", AllowEmptyStrings = false)]
        public string Cor { get; set; }

        [Required]
        [Display(Name = "Data de Fabricação")]
        public DateTime DataFabricacao { get; set; }

        [Required(ErrorMessage = "Valor", AllowEmptyStrings = false)]
        [Range(100, 9999999, ErrorMessage = "Valor entre 100 e 9999999.")]
        public decimal Valor { get; set; }

        public Carro()
        {
            this.Id= 0;
            this.Nome = string.Empty;
            this.Cor = string.Empty;
            this.DataFabricacao = DateTime.Now;
            this.Valor = 0;
        }
    }
}
