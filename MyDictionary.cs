/*
 * Add one item to ... - prompts the user to enter a string and then inserts the input into the data structure.

Add Huge List of Items to ... – first clears the data structure and then generate 2,000 items in the data structure with the value of “New Entry” concatenated with the number. For example, New Entry 1, New Entry 2, New Entry 3. For the dictionary, the key will be the generated string ("New Entry 2") and the value will be the current number (2).

Display ... - display the contents of the data structure. You must use the foreach loop when displaying the data. Handle any errors and inform the user.

Delete from ... - prompt for which item to delete from the structure. Handle any errors and inform the user.

Clear ... - wipe out the contents of the data structure

Search ... - Search for an item in the data structure and return if it was found or not found and how long it took to search. You can create a StopWatch object using code like so:

System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
Google how to start and stop the StopWatch and how to get the elapsed time.

Return ... - Return back to the main menu
 * 
 * 
 * */

using System;
using System.Collections.Generic;

public class MyDictionary
{
    public MyDictionary()
	{
	}

    //print the menu regarding dictionary
    public static void printDictionaryMenu()
    {
        Console.WriteLine("1. Add one item to Dictionary\n2. Add Huge List of Items to Dictionary\n3. Display Dictionary\n4. Delete from Dictionary\n5. Clear Dictionary\n6. Search Dictionary\n7. Return to Main Menu\n");
    }

    //add one item to the list
    public static Dictionary<string, int> addOne(Dictionary<string, int> my_dictionary, string add_string, int add_int)
    {
        my_dictionary.Add(add_string, add_int);
        return my_dictionary;
    }

    //display the dictionary
    public static Dictionary<string, int> display(Dictionary<string, int> my_dictionary)
    {
        Console.WriteLine("Dictionary display results:");
        foreach (var item in my_dictionary)
        {
            Console.WriteLine(item.Key + " " + item.Value + "\n\n");
        }

        return my_dictionary;
    }

    //search for one item and show how long it took to find
    public static Dictionary<string, int> search(Dictionary<string, int> my_dictionary, string name)
    {
        System.Diagnostics.Stopwatch Timer = new System.Diagnostics.Stopwatch();
        bool found = false;
        Timer.Start();

        foreach(var item in my_dictionary)
        {
            if(my_dictionary.ContainsKey(name))
            {
                found = true;
            }
        }
        Timer.Stop();

        if(found == true)
        {
            Console.WriteLine("\nIt exists! It was found in " + Timer.Elapsed);
        }
        else
        {
            Console.WriteLine("\nSearch was not successful.");
        }
        
        

        return my_dictionary;
    }
}
