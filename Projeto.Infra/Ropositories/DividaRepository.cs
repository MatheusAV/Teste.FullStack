using Projeto.infra.Context;
using Projeto.infra.Ropositories.Interface;
using Teste.FullSatck.Domain.Entities;

namespace Projeto.infra.Ropositories
{
    public class DividaRepository : Repository<Divida>, IDividaRepository
    {
        public DividaRepository(DefaultContext context) : base(context)
        {
        }

    }
}
