using System;
class Boxing  
{
    static void Main () 
    {
        // Create an empty List of type object
        List<object> objectList = new List<object> ();
        // Add values to the list
        objectList.Add(7);
        objectList.Add(28);
        objectList.Add(-1);
        objectList.Add(true);
        objectList.Add("chair");

        // Print the elements in the list
        Console.WriteLine("Elements in the list : ");
        foreach (var item in objectList)
        {
            Console.WriteLine(item);
        }
        int sum = 0 ; 
        foreach (var item in objectList)
        {
            if (item is int)
            {
                
                sum+= (int) item;
            }
        }
        Console.WriteLine($"int sum : {sum}");

        

    }
}