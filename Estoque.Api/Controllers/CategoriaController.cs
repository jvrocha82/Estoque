using Estoque.Api.DTOs.Categorias;
using Estoque.Domain.Contracts.Services;
using Estoque.Domain.Entities;
using Estoque.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
        [HttpGet]
        [Route("api/List")]
        public async Task<IActionResult> Get()
        {
            try
            {
               return StatusCode(200, await _categoriaService.ListAsync());

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error : {ex}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(CadastrarCategoriasDTO dto)
        {
            try 
            {
                var categoria = new Categoria();
              categoria.setCategoria(dto.Descricao);
               await _categoriaService.CreateAsync(categoria);
                return StatusCode(200, "Salvo com Sucesso");
            }
            catch(Exception ex)
            {
                return new ContentResult()
                {
                    StatusCode = 500,
                    Content = $"Error: {ex}"
                };
            }
        }
    }
}
