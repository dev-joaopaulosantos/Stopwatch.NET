internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Start(6);
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
    }
}