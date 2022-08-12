using Estoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Contracts.Repositories
{
    public interface IProdutoRepository
    {
        Task CreateAsync(Produto produto);
        Task UpdateAsync(Produto produto);
        Task DeleteAsync(Produto produto);
        Task<List<Produto>> ListAsync();
        Task<Produto> GetByIdAsync(Guid id);
    }
}
