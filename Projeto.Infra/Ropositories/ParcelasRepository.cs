using Projeto.infra.Context;
using Projeto.infra.Ropositories.Interface;
using Teste.FullSatck.Domain.Entities;

namespace Projeto.infra.Ropositories
{
    public  class ParcelasRepository : Repository<Parcelas>, IParcelasRepository
    {
        public ParcelasRepository(DefaultContext context) : base(context)
        {
        }
    }
}
