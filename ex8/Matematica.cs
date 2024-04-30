public class Matematica : Curso{

    public double nota1;
    public double nota2;
    public double nota3;
    

    public Matematica(string nomeAluno, string codigoAluno, int cargaHoraria,double nota1, double nota2, double nota3) : base(nomeAluno, codigoAluno, cargaHoraria){

            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;

    }

    public  double calcularMedia()
    {
        return (nota1 + nota2 + nota3) / 3;
    }

   

}