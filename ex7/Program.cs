public class Program 
{

    public static void Main(string[] args)
    {
        ContaCorrente contaCorrente = new ContaCorrente("0001", 4.000, 25.00);
        ContaEmpresarial contaEmpresarial = new ContaEmpresarial("0002\0001-2", 10000.00, 5000.00 );
        ContaPoupanca contaPoupanca = new ContaPoupanca("1010", 200.00, 0.5);

        

    }

}