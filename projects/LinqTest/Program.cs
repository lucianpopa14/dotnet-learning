public class Program()
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        for (int i = 1; i <= 99; i++)
        {
            numbers.Add(i);
        }

        var evens = from number in numbers
                    where number % 2 == 0
                    select number;
        foreach (int i in evens)
        {
            Console.Write($"{i} ");
        }
    }
}