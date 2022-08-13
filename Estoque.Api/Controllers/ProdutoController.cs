using Estoque.Api.DTOs.Categorias;
using Estoque.Domain.Contracts.Services;
using Estoque.Domain.Entities;
using Estoque.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpGet]
        [Route("List")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return StatusCode(200, await _produtoService.ListAsync());
            }catch(Exception ex)
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
        public async Task<ActionResult> Post(CadastraProdutosDTO dto)
        {
            try
            {
                var produto = new Produto();
                produto.setProduto(dto.Nome, dto.Qtd);
                await _produtoService.CreateAsync(produto);
                return StatusCode(200, "Salvo com Sucesso");
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
        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete(Produto produto)
        {
            try
            {
                await _produtoService.DeleteAsync(produto);
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
        public async Task<IActionResult> Update(Produto produto)
        {
            try
            {
                await _produtoService.UpdateAsync(produto);
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
        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                return StatusCode(200, await _produtoService.GetByIdAsync(id));

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error : {ex}");
            }
        }
    }
}
