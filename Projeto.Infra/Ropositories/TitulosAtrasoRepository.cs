using Projeto.infra.Context;
using Projeto.infra.Ropositories.Interface;
using Teste.FullSatck.Domain.Entities;

namespace Projeto.infra.Ropositories
{
    public class TitulosAtrasoRepository : Repository<TitulosAtraso>, ITituloAtrasoRepository
    {
        public TitulosAtrasoRepository(DefaultContext context) : base(context)
        {
        }
    }
}
