public class Concursado : Profissional
{
    public string numOAB;

    public Concursado()
    {
    }

    public override void batePonto()
    {
        Console.WriteLine("Início de turno (não bate ponto).");
    }
}
