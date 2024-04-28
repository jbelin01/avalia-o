public class Produto{

    private string nome { get; set;} 

    private double preco { get; set;} 

    private int quantidadeEstoque { get; set;} 

    public Produto()
    {
    }

    public Produto(string nome, double preco, int quantidadeEstoque)
    {
        this.nome = nome;
        this.preco = preco;
        this.quantidadeEstoque = quantidadeEstoque;
    }
    
    public void adicionarProduto(int quantidade){
        quantidadeEstoque += quantidade;
    }
    
    public void removerEstoque(int quantidade){
        if (quantidade > 0 ){
        quantidadeEstoque = quantidadeEstoque - quantidade;
    }

    }

    public double calcularValorEstoque(){
        return preco * quantidadeEstoque;
    }
    
}