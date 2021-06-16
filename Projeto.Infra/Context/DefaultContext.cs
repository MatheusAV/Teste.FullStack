using Microsoft.EntityFrameworkCore;
using Teste.FullSatck.Domain.Entities;

namespace Projeto.infra.Context
{
    public class DefaultContext : DbContext
        {


            public DefaultContext(DbContextOptions options) : base(options)
            {


            }
            public DbSet<Divida> Divida { get; set; }
            public DbSet<Parcelas> Parcelas { get; set; }
            public DbSet<TitulosAtraso> TitulosAtrasos { get; set; }
        }
}
