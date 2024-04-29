public class ContaPoupanca : ContaBancaria
{

    private double taxaJuros {get; set;}

    public ContaPoupanca(string numeroConta, double saldoConta , double taxaJuros) : base(numeroConta, saldoConta){
          
        this.taxaJuros = taxaJuros;

    }
        public void calcularJuros(){

            SaldoConta *= (1 * taxaJuros);

        }



}