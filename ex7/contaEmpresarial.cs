public class contaEmpresarial : contaBancaria
{

    private double saldoMinimo {get; set;}

    public contaEmpresarial(string numeroConta, double saldoConta){
        this.numeroConta = NumeroConta;
        this.saldoConta = saldoConta;
        
    }

    public bool verificarMinimo(){
         if (saldoConta >= saldoMinimo ){
            return "possui o saldo nececssário";
         }
         else {
            return "Não possui o saldo necessário";
         }
    }
}