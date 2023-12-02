using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Celular.Models
{
    public class Nokia : Smartphone
    {
        
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        // Implementação da instalação de aplicativo específica para Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na Nokia...");
        }
    }
}