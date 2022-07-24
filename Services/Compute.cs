using System.Diagnostics;

namespace WebApplication1.Services;

public class Compute
{
    public ulong computeAndReturn()
    {
        Task<ulong> task = new Task<ulong>(exec);
        Task<ulong> task2 = new Task<ulong>(exec);
        Task<ulong> task3 = new Task<ulong>(exec);
        Task<ulong> task4 = new Task<ulong>(exec);

        List<Task<ulong>> tasks = new List<Task<ulong>> { task, task2, task3, task4};


        foreach (var task1 in tasks)
        {
            task1.Start();
        }



        return
            tasks
                .ConvertAll(t => t.Result)
                .Aggregate(((task1, task5) => task1 + task5));
    }

    public ulong exec()
    {
        Thread.Sleep(700);
        Console.Out.Write("th ");
        return 400;
    }
}