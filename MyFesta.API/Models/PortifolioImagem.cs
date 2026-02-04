using System;

namespace MyFesta.API.Models
{
    public class PortifolioImagem
    {
        public Guid Id { get; set; }
        public Guid OfertaServicoId { get; set; }
        public string UrlImagem { get; set; } = string.Empty;


        public virtual OfertaServico? OfertaServico { get; set; }
    }
}