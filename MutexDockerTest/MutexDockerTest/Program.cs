using MutexDockerTest;
Console.WriteLine("Start");

var obj1 = new TestAsync();
var obj = new TestAsync();

obj.TestMutex(obj1);

Console.WriteLine("End");