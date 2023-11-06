namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taskScheduler = new TaskScheduler<string, int>();
            var taskPool = new List<string>();

            taskScheduler.RunTaskScheduler(task => Console.WriteLine("Executing task: " + task), taskPool);
        }
    }
}