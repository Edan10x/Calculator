using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Declare vriables and we initialize it to zero
        int num1, num2 = 0;

        Console.WriteLine("Welcome to the C# calculator");
        Console.WriteLine("====================================");

        // asking the user to enter first number
        Console.WriteLine("Please enter first number");
        num1 = Convert.ToInt32(Console.ReadLine());

        // asking the user to enter second number
        Console.WriteLine("Please enter first number");
        num2 = Convert.ToInt32(Console.ReadLine());


        // asking the user to choose an operator
        Console.WriteLine("Great, now choose an operator:");
        Console.WriteLine("a -> for add");
        Console.WriteLine("s -> for subtracting ");
        Console.WriteLine("m -> for multiplying");
        Console.WriteLine("d -> for dividing");

        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine(num1 + num2);
                break;
            case "s":
                Console.WriteLine(num1 - num2);
                break;
            case "m":
                Console.WriteLine(num1 * num2);
                break;
            case "d":
                Console.WriteLine(num2 / num2);
                break;
        }

        Console.Read();
    }
}