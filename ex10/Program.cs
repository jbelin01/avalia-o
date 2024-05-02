class Program
{
    static void Main(string[] args)
    {
        Economico vooEconomico = new Economico("São Paulo", "Rio de Janeiro", "01/05/2024");
        GrupoGrande vooGrupoGrande = new GrupoGrande("São Paulo", "Miami", "10/06/2024");
        PrimeiraClasse vooPrimeiraClasse = new PrimeiraClasse("Paris", "Tóquio", "15/07/2024");

        
        vooEconomico.Reservar();
        vooGrupoGrande.Reservar();
        vooPrimeiraClasse.Reservar();

        
        vooEconomico.Cancelar();
        vooGrupoGrande.Cancelar();
        vooPrimeiraClasse.Cancelar();

       
        vooEconomico.Status();
        vooGrupoGrande.Status();
        vooPrimeiraClasse.Status();
    }
}