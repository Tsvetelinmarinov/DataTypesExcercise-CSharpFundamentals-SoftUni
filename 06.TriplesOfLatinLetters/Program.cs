using System.Security.Cryptography;

/**
 * 1.	Triples of Latin Letters
 */

namespace _06.TriplesOfLatinLetters;

internal class Program
{

    static void Main(string[] _)
    {

        int letterCount = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < letterCount; ++i)
        {

            for (int j = 0; j < 3; j++)
            {

                for (int k = 0; k < 3; k++)
                {

                    char firstLetter = (char)('a' + i);
                    char secondLetter = (char)('a' + j);
                    char thirdLetter = (char)('a' + k);
                    Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");

                }

            }

        }

    }

}