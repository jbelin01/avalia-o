public class Transferencia : IMetodo {
    public String conta;
    public String agencia;
    private String codSeguranca {get; set;}
    


    public Transferencia(String conta, String agencia, String codSeguranca){
        this.conta = conta;
        this.agencia = agencia;
        this.codSeguranca = codSeguranca;
    }

    public void pagamento(double valor) {
        Console.WriteLine("Pagamento no Cartão de crédito de: R${valor}, foi  realizado com sucesso!");
    }

    public void statusPagamento(){

        Console.WriteLine("Seu pagamento foi aprovado!");

    }
}