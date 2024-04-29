public class ContaBancaria
{

    public string numeroConta;
    private double saldoConta {get; set;}
    public string NumeroConta
    {
        get { return numeroConta; }
    }
    public double SaldoConta{
        get{ return saldoConta;}
        set[ saldoConta = value;]
    }
    public ContaBancaria(){

    }

    public ContaBancaria(string numeroConta, double saldoConta){

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