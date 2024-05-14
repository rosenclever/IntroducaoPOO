using ExemplosAula;

namespace ExemplosAulaTest
{
    [TestClass]
    public class ContaTest
    {
        [TestMethod]
        public void TestDeposito()
        {
            //cenario
            long _numero = 123;
            decimal _saldoInicial = 1000;
            decimal _valorDeposito = 1000;
            decimal _saldoFinal = 2000;
            var conta1 = new Conta(_numero, _saldoInicial);

            //acao
            conta1.Deposito(_valorDeposito);

            //verificação
            Assert.AreEqual(_saldoFinal, conta1.Saldo);
        }

        [TestMethod]
        public void TestSaque()
        {
            long _numero = 123;
            decimal _saldoInicial = 1000;
            decimal _valorSaque = 500;
            decimal _saldoFinal = 500;
            var conta1 = new Conta(_numero, _saldoInicial);

            //acao
            conta1.Saque(_valorSaque);

            //verificação
            Assert.AreEqual(_saldoFinal, conta1.Saldo);
        }
    }
}