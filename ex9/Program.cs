public class Program{

    static void  Main(string[] args)
    {
        
    
        IMetodo metodoB = new Boleto("123123", "05/05/2024");
        metodoB.pagamento(250.77);
        metodoB.statusPagamento();

        IMetodo metodoC = new CartaoCredito("987654321", "777", "15/08/2025");
        metodoC.pagamento(1500.77);
        metodoC.statusPagamento();

        IMetodo metodoT = new Transferencia("787878", "0001", "7070");
        metodoT.pagamento(100.77);
        metodoT.statusPagamento();


    }
}