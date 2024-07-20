public class Program 
{
    public static int x = 20;
    public static int y = 0;

    public static async Task Main(string[] args) 
    {
        try
        {
            var magicNumber = await GetMagicNumber();

            await GetMagicMessage();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.ToString());
        }
        
    }

    private static Task<double> GetMagicNumber() 
    {
        try
        {
            var number = Convert.ToDouble(x / y);
            Console.WriteLine("The magic number is: " + number);
            return Task.FromResult(number);
        }
        catch (Exception ex) 
        {
            Console.Write(ex.ToString());
            return null;
        }

    }

    private static async Task GetMagicMessage()
    {
        Thread.Sleep(3000);
        Console.WriteLine("The second Task was executed");
    }



}