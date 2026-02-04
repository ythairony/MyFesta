using System;
using System.Collections.Generic;

namespace MyFesta.API.Models
{
    public class Pacote
    {
        public Guid Id { get; set; }
        public Guid OfertaServicoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public bool EhPrivado { get; set; }
        

        public virtual OfertaServico? OfertaServico { get; set; }
        public virtual ICollection<Lead> Leads { get; set; } = new List<Lead>();
    }
}