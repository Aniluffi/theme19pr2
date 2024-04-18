using task7;

class Program
{
    public static void Main()
    {
        Player s = new Player();
        Console.WriteLine(s.Play());
        Console.WriteLine(s.Pause());
        Console.WriteLine($"{s.Stop()}\n");

        Console.WriteLine(s.Record());
        Console.WriteLine(s.PauseRecord());
        Console.WriteLine(s.StopRecord());
    }
}
