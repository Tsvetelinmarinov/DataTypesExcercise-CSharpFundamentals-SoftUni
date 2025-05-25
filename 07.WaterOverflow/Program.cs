

using System.Diagnostics;

/**
 * 07. Water Overflow
 */
namespace _07.WaterOverflow;

internal class Program
{

    static void Main(string[] _)
    {

        int count = int.Parse(Console.ReadLine()!);
        int total = default;
        for (int i = 0; i < count; i++)
        {

            int liters = int.Parse(Console.ReadLine()!);
            if (total + liters >= 255)
            {
                Console.WriteLine("Insufficient capacity!");
                continue;
            }
            else if (total + liters <= 255)
            {
                total += liters;
            }

        }

        Console.WriteLine(total);

    }

}