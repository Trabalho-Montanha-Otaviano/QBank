using System.ComponentModel.DataAnnotations;

namespace banco
{
    public class ContaBancaria
    {
        public int ContaBancariaId { get; set; }
        [Required]
        public string NumeroConta { get; set; }
        [Required]
        public decimal Saldo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Transacao> Transacoes { get; set; }
    }
}