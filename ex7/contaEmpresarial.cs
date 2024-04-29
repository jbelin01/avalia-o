public class ContaEmpresarial : ContaBancaria
{

    private double saldoMinimo {get; set;}

    public ContaEmpresarial(string numeroConta, double saldoConta, double saldoMinimo) : base( numeroConta, saldoConta) {

            this.saldoMinimo = saldoMinimo;
        
    }

    public bool verificarMinimo(){
         return SaldoConta >= saldoMinimo;
    }
}