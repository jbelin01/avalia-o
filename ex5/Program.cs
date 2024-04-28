public class Program
    {
        public static void  Main(string[] args)
        {
            Filme filme1 = new Filme("Cidadão Kane", "Drama", 119, true);
            Filme filme2 = new Filme("Casablanca", "Romance/Drama", 102, true);
            Filme filme3 = new Filme("E o vento levou", "Romance/Drama", 238, true);
            Filme filme4 = new Filme("O Mágico de OZ", "Aventura/Fantasia", 102, true);
            Filme filme5 = new Filme("Tempos Modernos", "Comédia/Drama", 87, true );

 
            Console.WriteLine(filme1.Gettitulo() +": "+ filme1.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme2.Gettitulo() +": "+ filme2.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme3.Gettitulo() +": "+ filme3.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme4.Gettitulo() +": "+ filme4.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme5.Gettitulo() +": "+ filme5.verificarDisponibilidade());
            Console.WriteLine();
 
 
            filme1.registrarLocacao();
            filme2.registrarLocacao();
            filme3.registrarLocacao();
            filme4.registrarLocacao();
            filme5.registrarLocacao();

            Console.WriteLine(filme1.Gettitulo() +": "+ filme1.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme2.Gettitulo() +": "+ filme2.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme3.Gettitulo() +": "+ filme3.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme4.Gettitulo() +": "+ filme4.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme5.Gettitulo() +": "+ filme5.verificarDisponibilidade());
            Console.WriteLine();

            filme1.registrardevolucao();
            filme2.registrardevolucao();
            filme3.registrardevolucao();
            filme4.registrardevolucao();
            filme5.registrardevolucao();
            

            Console.WriteLine(filme1.Gettitulo() +": "+ filme1.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme2.Gettitulo() +": "+ filme2.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme3.Gettitulo() +": "+ filme3.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme4.Gettitulo() +": "+ filme4.verificarDisponibilidade());
            Console.WriteLine(); 
            Console.WriteLine(filme5.Gettitulo() +": "+ filme5.verificarDisponibilidade());
            Console.WriteLine();

}
}