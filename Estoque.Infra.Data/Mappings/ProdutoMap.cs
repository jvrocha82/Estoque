using Estoque.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Infra.Data.Mappings
{
    internal class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(100)
                .HasColumnType("Varchar")
                .IsRequired();

            builder.Property(x => x.Qtd)
                    .HasColumnName("Qtd")
                    .HasMaxLength(100)
                    .HasColumnType("Int")
                    .IsRequired();
        
        }
}
}
