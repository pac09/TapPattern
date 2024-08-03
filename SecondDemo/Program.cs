public class Program() 
{
    public static void Main() 
    {
        var processOne = new Thread(ExecuteProcessOne);
        processOne.Start();

        var processTwo = new Thread(ExecuteProcessTwo);
        processTwo.Start();

        var processThree = new Thread(ExecuteProcessThree);
        processThree.Start();

        //MainThread
        for (var i = 0; i < 2000; i++)
            Console.Write("M");
    }

    private static void ExecuteProcessOne() 
    {
        for (var i = 0; i < 4000; i++)
            Console.Write("1");
    }

    private static void ExecuteProcessTwo()
    {
        for (var i = 0; i < 6000; i++)
            Console.Write("2");
    }

    private static void ExecuteProcessThree()
    {
        for (var i = 0; i < 8000; i++)
            Console.Write("3");
    }
}