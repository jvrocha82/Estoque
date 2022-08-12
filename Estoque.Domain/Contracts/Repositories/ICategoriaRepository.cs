using Estoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Contracts.Repositories
{
    public interface ICategoriaRepository
    {

        Task CreateAsync(Categoria categoria);
        Task UpdateAsync(Categoria categoria);
        Task DeleteAsync(Categoria categoria);
        Task<List<Categoria>> ListAsync();
        Task<Categoria> GetByIdAsync(Guid id);
    }
}
