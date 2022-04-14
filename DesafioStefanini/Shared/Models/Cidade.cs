using System.ComponentModel.DataAnnotations;

namespace DesafioStefanini.Shared.Models
{
    public sealed class Cidade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string UF { get; set; }

        public void Update(Cidade c)
        {
            Nome = c.Nome;
            UF = c.UF;
        }
    }
}