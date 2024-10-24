using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public enum TipoTransacao
    {
        Deposito,
        Saque
    }
    public class Transacao
    {
        public int TransacaoId { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public DateTime DataTransacao { get; set; }
        [Required]
        public TipoTransacao TipoTransacao { get; set; }
        public int ContaBancariaId { get; set; }
        public ContaBancaria ContaBancaria { get; set; }
    }
}
