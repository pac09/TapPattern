var counter = 0;
var anyObject = new Object();
UseParallelForeach();

void UseParallelForeach()
{
    Parallel.ForEach(new int[100], (i) => 
    {
        AnyMethod(counter);
        lock(anyObject) counter++;
    });
}

void AnyMethod(int counter) 
{
    for (var i = 0; i < 10; i++)
        Console.Write($"S{counter}");
}

