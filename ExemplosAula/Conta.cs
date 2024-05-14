using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosAula
{
    public class Conta
    {
        private long _numero;
        private decimal _saldo;

        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }

        public long Numero { 
            get => _numero;
            private set {
                _numero = value;
            } 
        }

        public decimal Saldo { get => Saldo; }

        public void Deposito(decimal valor)
        {
            _saldo += valor;
        }

        public void Saque(decimal valor)
        {
            _saldo += valor;
        }
    }
}
