using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.FullSatck.Domain.Entities;

namespace Projeto.infra.Configuration
{
    public class DividaConfig : IEntityTypeConfiguration<Divida>
    {
        public void Configure(EntityTypeBuilder<Divida> builder)
        {           

            builder.HasKey(a => a.IdTitulo);

            builder.HasMany(x => x.Parcelas)
                .WithMany(x => x.Dividas);


        }
    }
}
