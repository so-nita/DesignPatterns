using SingletonPattern.GreeterExample;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Singleton - Creational Pattern");
        Console.WriteLine("Initial greetings...");
        Console.WriteLine();
        Greet();

        Console.WriteLine("\nGoodbye greetings...");
        Console.WriteLine();
        Greet();
    }

    private static void Greet()
    {
        SimpleGreeter.Instance?.Greet();

        SimpleThreadSafetyGreeter.Instance?.Greet();

        DoubleCheckGreeter.Instance?.Greet();

        LocklessGreeter.Instance?.Greet();

        LocklessFullyLazyGreeter.Instance?.Greet();

        DotNetLazyGreeter.Instance?.Greet();
    }
}