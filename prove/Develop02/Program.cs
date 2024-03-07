using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.Write("");
        Console.WriteLine("Welcome to your Journal");

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            // Get the user's choice as an integer
            choice = int.Parse(Console.ReadLine());

            // Handle the user's choice using a switch statement
            switch (choice)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                
                    journal.DisplayJournal();
                    break;
                case 3:
                    journal.SaveJournal();
                    break;
                case 4:
                    journal.LoadJournal();
                    break;
                case 5:
                    Console.WriteLine("Thank you for updating the Journal!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}