public class Garcom : Profissional
{
    public string gorjeta;

    public override void batePonto()
    {
        Console.WriteLine("Início de turno (não bate ponto).");
    }
}