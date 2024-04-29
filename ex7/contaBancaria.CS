public class contaBancaria
{

    private string numeroConta {get; set;}
    private double valorConta {get; set;}

    public contaBancaria(){

    }

    public contaBancaria(string numeroConta, double valorConta){

        this.numeroConta = numeroConta;
        this.valorConta = valorConta;

    }

    public double depositar( double deposito){

        return valorConta += deposito;

    }

    public double sacar( double saque){

        return valorConta -= saque;

    }




}