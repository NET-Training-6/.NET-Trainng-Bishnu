using System;

class Generic
{
    public void Print<T>(T message)
    {
        Console.WriteLine(message);
    }


    void Test()
    {
        Print<string>("Nepal is beautiful.");
        Print<byte>(23);
        Print<double>(4545.56);
        Print<bool>(true);
        Print<DateTime>(DateTime.Now);
        Print<Animal>(new Animal());
    }
}
