internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("S = Segundo");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("0 = Sair");
        Console.Write("Quanto tempo deseja conttar? ");

        string data = Console.ReadLine().ToLower();
        int multiplier = 1;

        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));

        if (type == 'm')
        {
            multiplier = 60;
        }
        if (time == 0)
        {
            System.Environment.Exit(0);
        }

        Start(time * multiplier);

    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();

            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Stopwatch finalizado!");
        Thread.Sleep(2500);
        Menu();
    }
}