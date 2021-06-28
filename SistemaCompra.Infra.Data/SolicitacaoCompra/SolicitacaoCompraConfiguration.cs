using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using CompraAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;
namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
    public class SolicitacaoCompraConfiguration : IEntityTypeConfiguration<CompraAgg.SolicitacaoCompra>
    {
        public void Configure(EntityTypeBuilder<CompraAgg.SolicitacaoCompra> builder)
        {
            builder.ToTable("SolicitacaoCompra");
        }
    }
}
