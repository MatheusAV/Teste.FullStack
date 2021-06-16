using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class Parcelas
    {
       [Key]
        public int IdParcela { get; set; }
        public string descricao  { get; set; }
        public int NrParcelas { get; set; }
        public bool Ativos { get; set; }
        public List<Divida> Dividas { get; set; }

    }
}
