using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array to hold the roll values
            var random = new Random();
            int[] rollTotals = new int[11];

            // Welcome user to dice throwing simulator
            Console.WriteLine("Welcome to the dice throwing simulator! \n");
            Console.Write("How many dice rolls would you like to simulate? ");

            // Set input to numRolls
            int numRolls = Convert.ToInt32(Console.ReadLine());

            // Dice simulator intro
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls +".\n");

            // Roll dice
            for (int i=0; i<numRolls; i++)
            {
                int dice1 = random.Next(1,7);
                int dice2 = random.Next(1,7);
                int total = dice1 + dice2;
                rollTotals[total-2]++;             
            }

            // print out totals for dice rolls
            for (int i = 0; i < rollTotals.Length; i++)
            {
                // Calculate percentage
                int totalPercent = (int)((rollTotals[i] / (float)numRolls) * 100);

                string starTotal =  "";

                // Create histogram values
                for (int j=0; j<totalPercent; j++)
                {
                starTotal += "*";                
                }

                // Print
                Console.WriteLine((i + 2) + ": " + starTotal);
            }


            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
