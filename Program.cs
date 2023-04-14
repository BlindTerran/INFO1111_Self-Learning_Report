using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a number:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a number:");
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine(averageOfThree(num, num2, num3));
    }

    static int averageOfThree(int num1, int num2, int num3)
    {
        int[] numbers = new int[] { num1, num2, num3 };

        int result = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            result += numbers[i];
        }

        return result / 3;
    }
}