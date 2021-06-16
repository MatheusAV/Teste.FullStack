using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.FullSatck.Domain.Entities;

namespace Projeto.infra.Configuration
{
    public class ParcelasConfig : IEntityTypeConfiguration<Parcelas>
    {

        public void Configure(EntityTypeBuilder<Parcelas> builder)
        {
          

            builder.HasKey(a => a.IdParcela);
            builder.HasMany(x => x.Dividas)
                .WithMany(x => x.Parcelas);


        }

    }
}
