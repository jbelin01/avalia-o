public class CartaoCredito : IMetodo{
    
    private String numero {get; set;}
    private String cvv {get; set;}
    public String validade;

    


    public CartaoCredito(String numero, String cvv, String validade){
        this.numero = numero;
        this.cvv = cvv;
        this.validade = validade;
        
    }

    public void pagamento(double valor) {
        Console.WriteLine("Pagamento no Cartão de crédito de: R${valor}, foi  realizado com sucesso!");
    }

    public void statusPagamento(){

        Console.WriteLine("Seu pagamento foi aprovado!");

    }

    

    
}
