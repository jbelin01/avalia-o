public class Profissional{

    public string nome; 

    public string raca; 

    public int idade; 

    public Profissional()
    {
       
    }

    public Profissional(string nome, string raça, int idade)
    {
        this.nome = nome;
        this.raca = raca;
        this.idade = idade;
    }
    
    public virtual void batePonto(){

        Console.WriteLine("ponto registrado");
        
    }
    
    
}