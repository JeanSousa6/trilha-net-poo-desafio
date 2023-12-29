namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
        
            Console.WriteLine($"O aplicativo: {nomeApp} foi instalado no Nokia {Modelo} pela PlayStore" +
                    $" do numero: {Numero} IMEI:{IMEI} e com {Memoria}GB de memoria. "); 

        
        
        }

    }
}