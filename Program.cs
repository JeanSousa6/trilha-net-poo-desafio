using DesafioPOO.Models;



public class Program {
    public static void Main(String []args)
    {

        Nokia N = new Nokia("(11)1111-2222", "Nokia G60", "000000-00-000000-0", 128);
        Iphone I = new Iphone("(11)1111-2222", "Iphone 14", "000000-00-000000-0", 256);


        I.Ligar();
        I.InstalarAplicativo("Whatsapp");  
        Console.WriteLine(); 
        N.ReceberLigacao();
        N.InstalarAplicativo("Telegram");   
    
}
}