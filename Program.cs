using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite os dados para o Nokia:");
        string numeroNokia = SolicitarEntrada("Número: ");
        string modeloNokia = SolicitarEntrada("Modelo: ");
        string imeiNokia = SolicitarEntrada("IMEI: ");
        int memoriaNokia = SolicitarInteiro("Memória: ");

        Nokia nokiaPhone = new Nokia(numeroNokia, modeloNokia, imeiNokia, memoriaNokia);
        TestarSmartphone(nokiaPhone, "Snake"); 

        Console.WriteLine("Digite os dados para o iPhone:");
        string numeroIphone = SolicitarEntrada("Número: ");
        string modeloIphone = SolicitarEntrada("Modelo: ");
        string imeiIphone = SolicitarEntrada("IMEI: ");
        int memoriaIphone = SolicitarInteiro("Memória: ");

        Iphone iphone = new Iphone(numeroIphone, modeloIphone, imeiIphone, memoriaIphone);
        TestarSmartphone(iphone, "Instagram");
    }

    static string SolicitarEntrada(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    static int SolicitarInteiro(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Por favor, insira um valor inteiro válido.");
            }
        }
    }

    static void TestarSmartphone(Smartphone smartphone, string aplicativo)
    {
        smartphone.Ligar();
        smartphone.ReceberLigacao();
        smartphone.InstalarAplicativo(aplicativo);
        Console.WriteLine(); 
    }
}