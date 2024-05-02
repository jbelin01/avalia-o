public class GrupoGrande : Voo , IReserva{
    
        public GrupoGrande(string origem, string destino, string data) : base(origem, destino, data)
        {
        }

        public void Reservar()
        {
            Console.WriteLine("Reserva de um grupo grande efetuada com sucesso!");
        }

        public void Cancelar()
        {
            Console.WriteLine("Reserva de um grupo grande com sucesso!");
        }

        public  void status()
        {
            Console.WriteLine("Voo com grupo grande");

        }

}