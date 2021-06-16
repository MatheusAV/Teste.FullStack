using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Domain.Entities
{
   public class TitulosAtraso
    {
        [Key]
        public int IdAtraso { get; set; }
        public int NrTitulo { get; set; }
        public string NmDevedor { get; set; }
        public int DtdeParc { get; set; }
        public decimal VlParc { get; set; }
        public int DiaAtraso { get; set; }
        public decimal  VlAtrsado { get; set; }
        

    }
}
