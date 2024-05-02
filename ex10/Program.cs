class Program
{
    static void Main(string[] args)
    {
        Economico economico = new Economico("São Paulo", "Rio de Janeiro", "01/05/2024");
        GrupoGrande grupoGrande = new GrupoGrande("São Paulo", "Miami", "10/06/2024");
        PrimeiraClasse primeiraClasse = new PrimeiraClasse("Paris", "Tóquio", "15/07/2024");

        
        economico.reservar();
        grupoGrande.reservar();
        primeiraClasse.reservar();

        
        economico.cancelar();
        grupoGrande.cancelar();
        primeiraClasse.cancelar();

       
        economico.status();
        grupoGrande.status();
        primeiraClasse.status();
    }
}