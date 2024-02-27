using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        string text = Console.ReadLine();
        int percentage = int.Parse(text);
        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)  
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}.");
        if (percentage >= 70)
        {
            Console.Write("Congradulations, you passed the class!");
        }
        else 
        {
            Console.Write("Better luck next time, you failed the class :D");
        }


    }
}