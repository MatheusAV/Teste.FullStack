using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Teste.FullSatck.Domain.Entities
{
    public class Divida
    {
        [Key]
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
