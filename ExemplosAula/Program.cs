using ExemplosAula;

var cliente1 = new Cliente("Peter", "4321");
var conta1 = new Conta(123, 1000, cliente1);

Console.WriteLine($"Conta {conta1.Numero} pertence ao {conta1.Titular}");