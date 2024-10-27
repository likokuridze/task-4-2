// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        int sum = 0;
        int number;
        string enteredNumbers = "";


        Console.WriteLine("Enter positive numbers (enter a negative number to stop):");

        while (true)
        {
            number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                break;
            }

            sum += number;
            enteredNumbers += number + "; ";

        }
        Console.WriteLine("Enter Numbers: " + enteredNumbers);
        Console.WriteLine("Total: " + sum);

    }
}
