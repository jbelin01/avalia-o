public class Ingles : Curso{

    private string nivel;

    public string Nivel
    {
        get { return nivel; }
        set { nivel = value; }
    }

    public Ingles(string nomeAluno, string codigoAluno, int duracaoHora, string nivel) : base(codigoAluno, codigoAluno, duracaoHora)
    {
        this.nivel = nivel; 
    }

    public void mostrarNivel(){

        Console.WriteLine("O nivel do aluno" + NomeAluno + "é: " + nivel);

    }



}