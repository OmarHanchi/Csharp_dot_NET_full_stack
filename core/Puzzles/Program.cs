using System;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Random object
            Random rand = new Random();

            // Call MakeRandomArray method and get the result
            int[] randomNumbers = MakeRandomArray(rand);

            // Print the generated array
            Console.WriteLine("Generated Array:");

            foreach (var number in randomNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        public static int[] MakeRandomArray(Random rand)
        {
            int[] randomNumbers = new int[10];

            // Fill the array with random numbers between 5 and 25
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(5, 26);
            }
            return randomNumbers;
        }
    
    static string TossCoin()
    {
        string [] sides = {"Heads" , "Tails" } ;
        Random rand = new Random();

        // random selection 
        int toss = rand.Next (sides.Length);
        string result = sides [toss];

        //display the result 
        Console.WriteLine(result);
        return result;

    }
    
    //Names 
    static List<string> Names()
    {
        // Initialization
        List<string> namesList = new List<string> { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
        List<string> newList = new List<string>();

        // Only keep names that are longer than 5 characters 
        Console.WriteLine("Filtered Names:");
        foreach (string name in namesList)
        {
            if (name.Length > 5)
            {
                newList.Add(name);
                Console.WriteLine(name);
            }
        }

        return newList;
    }

    
    }
}