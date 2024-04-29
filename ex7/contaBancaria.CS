public class contaBancaria
{

    public string numeroConta;
    private double saldoConta {get; set;}
    public string NumeroConta
    {
        get { return numeroConta; }
    }
    public contaBancaria(){

    }

    public contaBancaria(string numeroConta, double saldoConta){

        this.numeroConta = numeroConta;
        this.saldoConta = saldoConta;

    }

    
    public double depositar( double deposito){

        return saldoConta += deposito;

    }

    public double sacar( double saque){

        return saldoConta -= saque;

    }


}