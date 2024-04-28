
class Program
{
    static void Main(string[] args)
    {
        Profissional garcom = new Profissional();
        garcom.nome = "Jerson";
        garcom.raca = "Pardo";
        garcom.idade = 22;
        

        Console.WriteLine("Garçom:");
        Console.WriteLine("Nome: " + garcom.nome);
        Console.WriteLine("Raça: " + garcom.raca);
        Console.WriteLine("Idade: " + garcom.idade);
        garcom.batePonto();
        Console.WriteLine();
        

        Profissional juiz = new Concursado();
        juiz.nome = "Leoncio";
        juiz.raca = "Asiático";
        juiz.idade = 62;
        

        Console.WriteLine("Juiz:");
        Console.WriteLine("Nome: " + juiz.nome);
        Console.WriteLine("Raça: " + juiz.raca);
        Console.WriteLine("Idade: " + juiz.idade);
        juiz.batePonto();
        Console.WriteLine();
    }
}