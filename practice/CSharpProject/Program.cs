/*
// Variable to interpolate
using System.ComponentModel;

string place = "Coding Dojo";
//Interpolated string, note the $
string message = $"Hello {place}";
// Displaying final message
Console.WriteLine(message);
// Another option uses placeholders like so
// Note this does NOT have a $ at the start
Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
*/
/*
int numRings = 5 ;
if (numRings >= 5)
{
    Console.WriteLine("You are welcome to join the party");
}
else if (numRings > 2)
{
    Console.WriteLine($"Decent...but {numRings} rings aren't enough");
}
else
{
    Console.WriteLine("Go win some more rings");
}
*/
/*
int numRings = 5;
string name = "Kobe";
if (numRings >= 5 && name == "Kobe")
{
    Console.WriteLine($"Welcome to the party {name}, congratulations on your {numRings}th championships!");
}
  Console.WriteLine("....................................................");

int numOfAllStarAppearances = 17;
if (numRings >= 5 || numOfAllStarAppearances > 3)
{
  Console.WriteLine("Welcome, you are truly a legend");
}
bool crazy = false;
if (!crazy)
{
    Console.WriteLine("Let's party!");
}
*/
/*
// loop from 1 to 5 including 5
for (int i = 1; i <= 5; i++)

{
    Console.WriteLine(i);
}

// loop from 1 to 5 excluding 5
for (int i = 1; i < 5; i++)
{
    Console.WriteLine(i);
}
int i = 1;
while (i < 6)
{
    Console.WriteLine(i);
    i = i + 1;
}
*/
/*
int i = 1;
while (i < 7)
{
    Console.WriteLine(i);
    i = i + 1;
}
*/
Random rand = new Random();
for(int val = 0; val < 10; val++)
{
    //Prints the next random value between 2 and 8
    Console.WriteLine(rand.Next(2,8));
}


