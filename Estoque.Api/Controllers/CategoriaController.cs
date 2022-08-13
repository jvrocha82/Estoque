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
        [Route("List")]
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
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                return StatusCode(200, await _categoriaService.GetByIdAsync(id));

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error : {ex}");
            }
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Delete(Categoria categoria)
        {
            try
            {
                await _categoriaService.DeleteAsync(categoria);
                return StatusCode(200, "Deletado com Sucesso");
            }
            catch (Exception ex)
            {
                return new ContentResult()
                {
                    StatusCode = 500,
                    Content = $"Error: {ex}"
                };
            }
        }
        [HttpPatch]
        [Route("Update")]
        public async Task<IActionResult> Update(Categoria categoria)
        {
            try
            {
                await _categoriaService.UpdateAsync(categoria);
                return StatusCode(200, "Atualizado com Sucesso");
            }
            catch (Exception ex)
            {
                return new ContentResult()
                {
                    StatusCode = 500,
                    Content = $"Error: {ex}"
                };
            }
        }
        [HttpPost]
        [Route("Create")]
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
