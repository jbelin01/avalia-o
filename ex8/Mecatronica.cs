public class Mecatronica : Curso{

    public bool certificadoTecnico;

    public Mecatronica(string nomeAluno, string codigoAluno, int duracaoHora, bool certificadoTecnico) : base(nomeAluno, codigoAluno, duracaoHora){
        this.certificadoTecnico = certificadoTecnico;
    }

    public string  gerarCertificado(){

        if(certificadoTecnico == true){
            return "Certificado de conclusão de curso de técnico de Mecatronica";

        }else{

            return "Não possui certificado de conclusão de curso técnico de Mecatronica";
        }

    }
     public override string ToString()
    {
        return base.ToString();
    }

}