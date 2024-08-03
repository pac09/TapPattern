var counter = 0;
var anyObject = new object();
UseSemaphoreTasks();

void UseSemaphoreTasks() 
{
    var semaphoreSlim = new SemaphoreSlim(Environment.ProcessorCount);
    var tasks = new List<Task>();

    for (var i = 0; i < 100; i++) 
    {
        var task = new Task(() =>
        {
            semaphoreSlim.Wait();

            ProcessX();
            lock (anyObject) counter++;

            semaphoreSlim.Release();
        });

        task.Start();
        tasks.Add(task);
    }

    Task.WaitAll(tasks.ToArray());
}

void ProcessX() 
{
    for (var i = 0; i < 10; i++)
        Console.Write($"S{counter}");
}