namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        // Implementação da instalação de aplicativo específica para iPhone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}