public class PrimeiraClasse : Voo , IReserva{
    
        public PrimeiraClasse(string origem, string destino, string data) : base(origem, destino, data)
        {
        }

        public void Reservar()
        {
            Console.WriteLine("Reserva na primeira classe efetuada com sucesso!");
        }

        public void Cancelar()
        {
            Console.WriteLine("Reserva na primeira classe com sucesso!");
        }

        public  void status()
        {
            Console.WriteLine("Voo primeira classe");

        }

}