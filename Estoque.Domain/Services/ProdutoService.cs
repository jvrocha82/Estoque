using Estoque.Domain.Contracts.Repositories;
using Estoque.Domain.Contracts.Services;
using Estoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(Produto produto)
        {
            await _repository.CreateAsync(produto);
        }

        public async Task DeleteAsync(Produto produto)
        {
            await _repository.DeleteAsync(produto);
        }

        public async Task<Produto> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
                }

        public async Task<List<Produto>> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task UpdateAsync(Produto produto)
        {
            await _repository.UpdateAsync(produto);
        }
    }
}
