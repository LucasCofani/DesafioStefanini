using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioStefanini.Shared.Models
{
    public sealed class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int CidadeId { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public PessoaDTO()
        {

        }
        public PessoaDTO(int id,string nome,int idade,int cidadeId,string cidade,string uf)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            CidadeId = cidadeId;
            Cidade = cidade;
            UF = uf;
        }
        public PessoaDTO(Pessoa p)
        {
            Id = p.Id;
            Nome = p.Nome;
            Idade = p.Idade;
            CidadeId = p.CidadeId;
            Cidade = p.Cidade.Nome;
            UF = p.Cidade.UF;
        }
    }
}
