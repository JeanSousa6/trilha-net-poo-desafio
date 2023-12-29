namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
       
       
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo: {nomeApp} foi instalado no Iphone {Modelo} pela AppStore" +
                $" e tem o numero: {Numero} IMEI:{IMEI} com {Memoria}GB de memoria. "); 
        
        }
    }
}