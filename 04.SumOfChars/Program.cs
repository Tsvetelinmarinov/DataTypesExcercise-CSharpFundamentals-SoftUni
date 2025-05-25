/**
 * 04. Sum of Chars
 */

namespace _04.SumOfChars;

internal class Program
{

    static void Main(string[] _)
    {

        int counter = int.Parse(Console.ReadLine()!);
        int sum = default;

        for (int i = 0; i < counter; ++i)
        {

            sum += char.Parse(Console.ReadLine()!);

        }

        Console.WriteLine("The sum equals: {0}", sum);

    }

}