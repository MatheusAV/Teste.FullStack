using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.FullSatck.Domain.Entities;

namespace Projeto.infra.Configuration
{
    public class TituloAtrasoConfig : IEntityTypeConfiguration<TitulosAtraso>
    {
        public void Configure(EntityTypeBuilder<TitulosAtraso> builder)
        {
           

            builder.HasKey(a => a.IdAtraso);

            

        }

    }
}
