public class ContaCorrente : ContaBancaria
{
    private double saldoConta;
    public double taxaManutencao;

    public ContaCorrente(string numeroConta, double saldoConta , double taxaManutencao){
        this.numeroConta = NumeroConta;
        this.saldoConta = saldoConta;
        this.taxaManutencao = taxaManutencao;
    }


    public void novoSaldoConta(){

        saldoConta -= taxaManutencao; 

    }
}