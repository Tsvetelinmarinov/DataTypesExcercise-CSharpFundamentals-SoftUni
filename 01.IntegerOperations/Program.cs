/**
 * 01. Integer Operations
 */

using System;
using System.Runtime.ExceptionServices;

namespace _01.IntegerOperations;

internal class Program
{

    static void Main(string[] _)
    {

        //You should perform the following operations:
        //•	Add first to the second.
        //•	Divide(integer) the result of the first operation by the third number.
        //•	Multiply the result of the second operation by the fourth number.
        //Print the result after the last operation.

        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int fourth = int.Parse(Console.ReadLine());
        double sum = default;

        sum += first + second;
        sum /= third;

        Console.WriteLine(sum * fourth);


    }

}