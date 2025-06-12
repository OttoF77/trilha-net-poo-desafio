namespace DesafioPOO.Models
{
    // Classe Nokia deve herdar de Smartphone
    public class Nokia : Smartphone
    {
        // Construtor
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria){}

        // Sobrescreve o método abstrato da classe base
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}
