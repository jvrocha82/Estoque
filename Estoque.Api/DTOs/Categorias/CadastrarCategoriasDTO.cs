using System.ComponentModel.DataAnnotations;

namespace Estoque.Api.DTOs.Categorias
{
    public class CadastrarCategoriasDTO
    {
        [Required]
        [MaxLength(200,ErrorMessage = "Tamanho maximo de 200 caracteres para Descrição")]
        [MinLength(2, ErrorMessage = "Tamanho minimo de 2 caracteres para Descrição")]
        public string Descricao { get; set; }
    }
}
