using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class Divida
    {
        public int IdTitulo { get; set; }
        public string NmDevedor { get; set; }
        public int NrDevedor { get; set; }
        public decimal Juros { get; set; }
        public decimal Multa { get; set; }
        public int NrParcelas { get; set; }
        public DateTime Vencimento { get; set; }
        public int VlParcela { get; set; }
        public List<Parcelas> Parcelas{ get; set; }


}
}
