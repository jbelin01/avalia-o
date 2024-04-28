public class Filme
{

    private string titulo {get;set;}
    private string genero {get;set;}
    private int duracao {get;set;}
    public bool disponivel; 

    

    public Filme(){

    }

    public Filme(string titulo, string genero, int duracao, bool disponivel){

        this.titulo = titulo; 
        this.genero = genero; 
        this.duracao = duracao; 
        this.disponivel = disponivel;
    
    }

    public string Gettitulo(){

        return this.titulo;

    }


    public void registrarLocacao(){
        if(disponivel == true){
            Console.WriteLine("filme " + titulo + " locado.");
            disponivel = false; 
        }
        else{
            Console.WriteLine("filme " + titulo + " indisponível.");
        }
    }

    public void registrardevolucao(){
        if(disponivel == false){
            Console.WriteLine("filme " + titulo + " devolvido.");
            disponivel = true;
        }
        else {
            Console.WriteLine("filme " + titulo + " já foi devolvido!");
        }
    }

    public string verificarDisponibilidade(){

         if (disponivel == true){
            return " Disponível";
        }
        else{
            return " Indisponível";
        }

    }
    

}