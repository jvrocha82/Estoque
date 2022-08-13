using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Entities
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public void setCategoria(string descricao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
        }
    }
}
