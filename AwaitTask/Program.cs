class Program
{
    static async Task Main()
    {
        Console.WriteLine("Before async"); 
        Console.WriteLine("Initial Thread Id:" + Thread.CurrentThread.ManagedThreadId);
        var fooAsync = FooAsync();
        Console.WriteLine("After async"); 
        var fooAsyncWithWait = FooAsyncWithAwait(); 
        Console.WriteLine("Before await"); 
        await fooAsync;
        await fooAsyncWithWait;
        Console.WriteLine("After await"); 
        Console.WriteLine("DONE");
    }

    static async Task FooAsync()
    {
        Task.Delay(1000).Wait();
        Console.WriteLine("Async method that doesn't have await");  
        Console.WriteLine("Thread Id:" + Thread.CurrentThread.ManagedThreadId);
    }

    static async Task FooAsyncWithAwait()
    {
        await Task.Delay(1000);
        Console.WriteLine("Async method that have await"); 
        Console.WriteLine("Thread Id:" + Thread.CurrentThread.ManagedThreadId);
    }

}