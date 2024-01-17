using System;
using System.Collections.Generic;
namespace collectionspractice
{
    class Program
    {
        static void Main (string [] args )
        {
                 // Three Basic Arrays
            Console.WriteLine(".......Three Basic Arrays........");
            //Create an array to hold integer values 0 through 9
            int[] numArray1 = {1,2,3,4,5,6,7,8,9};
                //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string [] namesArray = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine("...............");
            bool [] boolArray = new bool[10];
            for (int i=0 ; i<10 ; i++)
            {
                boolArray[i] = i % 2 == 0 ; 
                Console.WriteLine(boolArray [i]);
            }
            Console.WriteLine(".......List of Flavors........");
            List<string> iceCreamFlavors = new List<string>
            {
                "Vanilla",
                "Chocolate",
                "Strawberry",
                "Mint Chocolate Chip",
                "Cookies and Cream",
                "Rocky Road"
            };
            Console.WriteLine(iceCreamFlavors.Count);
            Console.WriteLine(iceCreamFlavors[3]);
            iceCreamFlavors.RemoveAt(3);
            Console.WriteLine(iceCreamFlavors.Count);

            Console.WriteLine(".........User Info Dictionary..........");
             Dictionary<string, string> MyDictio = new Dictionary<string, string>();

            // Loop through the names array and associate each name with a flavor sequentially
            for (int i = 0; i < namesArray.Length; i++)
            {
                // Ensure there are flavors left in the list
                if (i < iceCreamFlavors.Count)
                {
                    MyDictio.Add(namesArray[i], iceCreamFlavors[i]);
                }
                else
                {
                    Console.WriteLine("Not enough flavors for all names.");
                    break;
                }
            }

            // Print the User Info Dictionary
            Console.WriteLine("User Info Dictionary:");
            foreach (var kvp in MyDictio)
            {
                Console.WriteLine($"Name: {kvp.Key}, Flavor: {kvp.Value}");
            }
        }
    }
}