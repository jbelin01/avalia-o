class Program
{
    static void Main(string[] args)
    {
        Garcom garcom = new Garcom();
        garcom.nome = "Jerson";
        garcom.raca = "Pardo";
        garcom.idade = 22;
        garcom.gorjeta = "R$ 5,00";
        garcom.batePonto(); 
        garcom.batePonto("Batendo ponto do garçom."); 

        Console.WriteLine("Garçom:");
        Console.WriteLine("Nome: " + garcom.nome);
        Console.WriteLine("Raça: " + garcom.raca);
        Console.WriteLine("Idade: " + garcom.idade);
        Console.WriteLine("Gorjeta: " + garcom.gorjeta);
        Console.WriteLine();

        Profissional Atendente = new Profissional();
        Atendente.nome = "Leoncio";
        Atendente.raca = "Asiático";
        Atendente.idade = 62;
        Atendente.batePonto("Batendo ponto do Atendente."); 

        Console.WriteLine("Atendente:");
        Console.WriteLine("Nome: " + Atendente.nome);
        Console.WriteLine("Raça: " + Atendente.raca);
        Console.WriteLine("Idade: " + Atendente.idade);
    }
}