using DesafioPOO.Models;

   static void Main(string[] args)
        {
            // Testando a classe Nokia
            Nokia nokiaPhone = new Nokia("123456789");
            Console.WriteLine($"Número do Nokia: {nokiaPhone.Numero}");
            Console.WriteLine($"Modelo do Nokia: {nokiaPhone.Modelo}");
            Console.WriteLine($"Sistema Operacional do Nokia: {nokiaPhone.SistemaOperacional}");
            nokiaPhone.Ligar();
            nokiaPhone.ReceberLigacao();
            nokiaPhone.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Testando a classe Iphone
            Iphone iphone = new Iphone("987654321");
            Console.WriteLine($"Número do iPhone: {iphone.Numero}");
            Console.WriteLine($"Modelo do iPhone: {iphone.Modelo}");
            Console.WriteLine($"Sistema Operacional do iPhone: {iphone.SistemaOperacional}");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    