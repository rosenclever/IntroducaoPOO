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
        private Cliente _titular;

        public Conta(long numero, decimal saldo)
        {
            _numero = numero;
            _saldo = saldo;
        }

        // crie um metodo construtor que solicite numero, saldo e titular da conta
        public Conta(long numero, decimal saldo, Cliente titular) : this(numero, saldo)
        {
            _titular = titular;
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

        public Cliente Titular { get => _titular; }
    }
}
