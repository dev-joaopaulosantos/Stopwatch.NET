internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Menu();
    }

    static void Menu(){
        Console.WriteLine("S = Segundo");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja conttar? ");
    }

    static void Start(int time){
        // int time = 10;
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
    }
}