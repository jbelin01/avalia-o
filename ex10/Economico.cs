public class Economico : Voo, IReserva{

        public Economico(string origem, string destino, string data) : base(origem, destino, data)
        {
        }

        public void Reservar()
        {
            Console.WriteLine("Reserva classe econômica efetuada com sucesso!");
        }

        public void Cancelar()
        {
            Console.WriteLine("Reserva classe econômica cancelada com sucesso!");
        }

        public  void status()
        {
            Console.WriteLine("Voo Economico");

        }

    
    
}