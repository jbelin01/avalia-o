public class Ingles : Curso{

    private int nivel;

    public int Nivel
    {
        get { return nivel; }
        set { nivel = value; }
    }

    public Ingles(string nomeAluno, string codigoAluno, int duracaoHora, int nivel) : base(codigoAluno, codigoAluno, duracaoHora)
    {
        this.nivel = nivel; 
    }

    public void mostrarNivel(){

        Console.WriteLine("O nivel do aluno" + NomeAluno + "é: " + nivel);

    }

    public override string ToString()
    {
        return base.ToString();
    }

}