Garcom garcom = new Garcom();

garcom.nome = "Jerson";
garcom.raca = "pardo";
garcom.idade = 22;
garcom.gorjeta = "R$ 5,00";
garcom.batePonto();

        Console.WriteLine("Garçom:");
        Console.WriteLine("Nome: " + garcom.nome);
        Console.WriteLine("Raça: " + garcom.raca);
        Console.WriteLine("Idade: " + garcom.idade);
        Console.WriteLine("gorjeta: " + garcom.gorjeta);
        Console.WriteLine();

Juiz juiz = new Concursado();

juiz.nome = "Leoncio";
juiz.raca = "Asiático";
juiz.idade = 62;
juiz.numOAB = "777";
garcom.batePonto();

        Console.WriteLine("Juiz:");
        Console.WriteLine("Nome: " + juiz.nome);
        Console.WriteLine("Raça: " + juiz.raca);
        Console.WriteLine("Idade: " + juiz.idade);
        Console.WriteLine("Número da OAB: " + juiz.numOAB);
        Console.WriteLine();





