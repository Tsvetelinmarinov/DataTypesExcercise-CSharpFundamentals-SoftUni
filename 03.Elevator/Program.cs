/**
 * 03. Elevator
 */

namespace _03.Elevator;

internal class Program
{

    static void Main(string[] _)
    {

        int peopleCount = int.Parse(Console.ReadLine()!);
        int capacity = int.Parse(Console.ReadLine()!);
        Console.WriteLine((int)Math.Ceiling((float)peopleCount / capacity)); 

    }

}