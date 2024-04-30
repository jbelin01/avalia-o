

public class Curso{

    private string nomeAluno;

    private string codigoAluno;

    private int duracaoHora;

    public string NomeAluno{
        get{return nomeAluno;}
        set{nomeAluno = value;}
    }

    public string CodigoAluno{
        get{return codigoAluno;}
        set{codigoAluno = value;}

    }

    public int DuracaoHora 
    { 
        get { return duracaoHora; } 
        set { duracaoHora = value; } 
    }

    public Curso(){

    }
    public Curso(string nomeAluno, string codigoAluno, int duracaoHora){
        this.codigoAluno = codigoAluno;
        this.nomeAluno = nomeAluno;
        this.duracaoHora = duracaoHora;
    }

    public override string ToString(){

    return $"Curso: {NomeAluno}, Código do Aluno: {CodigoAluno}, Duração: {DuracaoHora} horas";
    
    }
}