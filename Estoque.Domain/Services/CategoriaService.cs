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
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(Categoria categoria)
        {
            await _repository.CreateAsync(categoria);
        }

        public async Task DeleteAsync(Categoria categoria)
        {
            await _repository.DeleteAsync(categoria);
        }

        public async Task<Categoria> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<List<Categoria>> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task UpdateAsync(Categoria categoria)
        {
            await _repository.UpdateAsync(categoria);
        }
    }
}
