/**
 * 05.PrintPartOfASCIITable
 */

namespace _05.PrintPartOfASCIITable;

internal class Program
{

    static void Main(string[] _)
    {

        int startCode = int.Parse(Console.ReadLine()!);
        int endCode = int.Parse(Console.ReadLine()!);

        while (startCode <= endCode)
        {

            Console.Write((char)startCode++ + " ");

        }

    }

}