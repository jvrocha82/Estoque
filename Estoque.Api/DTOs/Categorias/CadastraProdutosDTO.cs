using System.ComponentModel.DataAnnotations;

namespace Estoque.Api.DTOs.Categorias
{
    public class CadastraProdutosDTO
    {
        [Required]
        [MinLength(2,ErrorMessage = "Tamanho minimo de 2 caracteres")]
        [MaxLength(100, ErrorMessage = "Tamanho maximo de 100 caracteres")]
        public string Nome { get; set; }
        public int Qtd { get; set; }
    }
}
