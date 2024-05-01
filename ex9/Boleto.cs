public class Boleto : IMetodo {

    public string codigoBarras;
    
    public string validade;



    public Boleto(string codigoBarras, string validade) {
        this.codigoBarras = codigoBarras;
        this.validade = validade;
    
    }

    public void pagamento(double valor) {
        Console.WriteLine("Pagamento no Boleto de: R${valor}, foi realizado com sucesso!");
    }

    public void statusPagamento(){

        Console.WriteLine("Seu pagamento será efetuado em até 3 dias úteis!");

    }

}