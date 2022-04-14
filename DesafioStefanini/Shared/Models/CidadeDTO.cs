using System.ComponentModel.DataAnnotations;

namespace DesafioStefanini.Shared.Models
{
    public sealed class CidadeDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public CidadeDTO()
        {

        }
        public CidadeDTO(int id, string nome, string uf)
        {
            Id = id;
            Nome = nome;
            UF = uf;
        }
        public CidadeDTO(Cidade c)
        {
            Id = c.Id;
            Nome = c.Nome;
            UF = c.UF;
        }

    }
}