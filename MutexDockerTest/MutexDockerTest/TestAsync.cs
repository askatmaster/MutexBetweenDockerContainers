namespace MutexDockerTest;

public class TestAsync
{
    private async Task<string> GetString()
    {
        await Task.Delay(100);

        return await Task.FromResult("Tasker");
    }

    public void TestMutex(TestAsync obj)
    {
        using var mutex = new Mutex (false, "Global\\mutex"); //Create Global Mutex

        mutex.WaitOne();

        try
        {
            var data1 =  obj.GetString().GetAwaiter().GetResult();
            var data2 =  obj.GetString().GetAwaiter().GetResult();
            var data3 =  obj.GetString().GetAwaiter().GetResult();
            var data4 =  obj.GetString().GetAwaiter().GetResult();
            Console.WriteLine("Hello");
        }
        finally
        {
            Console.WriteLine("ReleaseInit");
            mutex.ReleaseMutex();
            Console.WriteLine("Release");
        }
    }
}