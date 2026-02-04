using System;
using System.Collections.Generic;

namespace MyFesta.API.Models
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        public string NomeFantasia { get; set; } = string.Empty;
        public string Documento { get; set; } = string.Empty;
        public string WhatsApp { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public StatusFornecedor Status { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;


        public virtual ICollection<OfertaServico> Ofertas { get; set; } = new List<OfertaServico>();
    }
}