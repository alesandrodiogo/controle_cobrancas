using System.ComponentModel.DataAnnotations;

namespace ControleCobrancaADM.Models
{
    public class Clientes
    {
        [Required]
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Pais { get; set; }
        public string Morada { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
    }
}
