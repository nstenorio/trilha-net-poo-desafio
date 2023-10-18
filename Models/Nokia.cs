namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string Modelo, string Imei, int Memoria) : base(numero, Modelo, Imei, Memoria)
        {
        }

        

        public override void InstalarAplicativo(string NomeApp)
        {
            Console.WriteLine($"Instalando o Aplicativo {NomeApp} no Nokia. - {Modelo} {Memoria}GB");
        }
    }
}