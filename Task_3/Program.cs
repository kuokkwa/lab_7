namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionCache<string, int> cache = new FunctionCache<string, int>();

            int result1 = cache.GetOrAdd("Key_1", key => 111, TimeSpan.FromMinutes(5));
            int result2 = cache.GetOrAdd("Key_2", key => 222, TimeSpan.FromMinutes(5));

            Console.WriteLine("Returned: " + result1);
            Console.WriteLine("Returned (cache): " + result2);
        }
    }
}