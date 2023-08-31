using System.Text;
using DesafioPOO.Enum;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private Memoria Memoria{ get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, Memoria memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Numero: {Numero}");
            stringBuilder.AppendLine($"Modelo: {Modelo}");
            stringBuilder.AppendLine($"IMEI: {IMEI}");
            stringBuilder.AppendLine($"Memoria: {Memoria} GB");
            return stringBuilder.ToString();
        }
    }
}