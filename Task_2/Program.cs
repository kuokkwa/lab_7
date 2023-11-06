namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<string> stringRepository = new Repository<string>();

            stringRepository.Add("-1");
            stringRepository.Add("1");
            stringRepository.Add("-2");
            stringRepository.Add("2");
            stringRepository.Add("-3");
            stringRepository.Add("3");

            List<string> result = stringRepository.Find(item => item.StartsWith("Criteria: positive number"));

            Console.WriteLine("Elements satisfying the criterion (even number):");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Repository<int> intRepository = new Repository<int>();

            intRepository.Add(-1);
            intRepository.Add(1);
            intRepository.Add(-2);
            intRepository.Add(2);
            intRepository.Add(-3);
            intRepository.Add(3);

            List<int> intResult = intRepository.Find(item => item > 0);

            foreach (var item in intResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}