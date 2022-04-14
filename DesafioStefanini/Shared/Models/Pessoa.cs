using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioStefanini.Shared.Models
{
    public sealed class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        public Cidade Cidade { get; set; }
        [ForeignKey("Cidade")]
        public int CidadeId { get; set; }
        [Required]
        public int Idade { get; set; }

        public void Update(Pessoa p)
        {
            Nome = p.Nome;
            CPF = p.CPF;
            Cidade = p.Cidade;
            Idade = p.Idade;
            CidadeId = p.CidadeId;
        }
    }
}
