using System;

namespace MyFesta.API.Models
{
    public class Avaliacao
    {
        public Guid Id { get; set; }
        public Guid OfertaServicoId { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; } = string.Empty;
        public DateTime DataAvaliacao { get; set; } = DateTime.Now;


        public virtual OfertaServico? OfertaServico { get; set; }
    }
}