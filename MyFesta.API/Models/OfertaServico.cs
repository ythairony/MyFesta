using System;
using System.Collections.Generic;

namespace MyFesta.API.Models
{
    public class OfertaServico
    {
        public Guid Id { get; set; }
        public Guid FornecedorId { get; set; }
        public int CategoriaId { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public TipoAtendimento Tipo { get; set; }


        public string? Endereco { get; set; }
        public string? CidadeBase { get; set; }
        public int RaioAtendimento { get; set; }


        public virtual Fornecedor? Fornecedor { get; set; }
        public virtual Categoria? Categoria { get; set; }
        public virtual ICollection<PortifolioImagem> Imagens { get; set; } = new List<PortifolioImagem>();
        public virtual ICollection<Pacote> Pacotes { get; set; } = new List<Pacote>();
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();
    }
}