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
        public async Task CreateAsync(Produto produto)
        {
            await _repository.CreateAsync(produto);
        }

        public async Task DeleteAsync(Produto produto)
        {
            await _repository.DeleteAsync(produto);
        }

        public Task<Produto> GetByIdAsync(Guid id)
        {
            return _repository.GetByIdAsync(id);
                }

        public Task<List<Produto>> ListAsync()
        {
            return _repository.ListAsync();
        }

        public Task UpdateAsync(Produto produto)
        {
            return _repository.UpdateAsync(produto);
        }
    }
}
