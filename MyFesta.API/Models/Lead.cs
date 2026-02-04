using System;

namespace MyFesta.API.Models
{
    public class Lead
    {
        public Guid Id { get; set; }
        public Guid PacoteId { get; set; }
        public string NomeCliente { get; set; } = string.Empty;
        public string ContatoCliente { get; set; } = string.Empty;
        public DateTime DataSolicitacao { get; set; } = DateTime.Now;

        public virtual Pacote? Pacote { get; set; }
    }
}