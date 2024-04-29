public class contaCorrente : contaBancaria
{
    private double saldoConta;
    public double taxaManutencao;

    public contaCorrente(string numeroConta, double saldoConta , double taxaManutencao){
        this.numeroConta = NumeroConta;
        this.saldoConta = saldoConta;
        this.taxaManutencao = taxaManutencao;
    }


    public void novoSaldoConta(){

        saldoConta -= taxaManutencao; 

    }
}