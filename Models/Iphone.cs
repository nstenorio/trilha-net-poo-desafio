namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string Numero, string Modelo, string Imei, int Memoria) : base(Numero, Modelo, Imei, Memoria)
        {
        }

        

        public override void InstalarAplicativo(string NomeApp)
        {
            Console.WriteLine($"Instalando o Aplicativo {NomeApp} no Iphone. - {Modelo} {Memoria}GB");
        }
    }
}