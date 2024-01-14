namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; } // Propriedade adicionada
        public string SistemaOperacional { get; set; } // Propriedade adicionada

        public Smartphone(string numero, string modelo, string sistemaOperacional)
        {
            Numero = numero;
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
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
    }
}

