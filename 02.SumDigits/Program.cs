/**
 * 02. Sum Digits
 */

namespace _02.SumDigits;

internal class Program
{

    static void Main(string[] _)
    {

        int number = int.Parse(Console.ReadLine()!);
        string numberString = number.ToString();
        int sum = default;

        for (int i = 0; i < numberString.Length; ++i)
        {

            sum += int.Parse(numberString[i].ToString());

        }

        Console.WriteLine(sum);

    }

}