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
        Console.WriteLine("\n\t1. Add One Item to Dictionary\n\t2. Add Huge List of Items to Dictionary\n\t3. Display Dictionary\n\t4. Delete from Dictionary\n\t5. Clear Dictionary\n\t6. Search Dictionary\n\t7. Return to Main Menu\n");
    }

    //add one item to the list
    public static Dictionary<string, int> addOne(Dictionary<string, int> my_dictionary, string add_string, int add_int)
    {
        my_dictionary.Add(add_string, add_int);
        Console.WriteLine("\nItem '" + add_string + "' with a value of '" + add_int + "' has been added to the Dictionary.\n");
        return my_dictionary;
    }

    //automatically add 2000 items after clearing the list in their proper format
    public static Dictionary<string, int> addHugeList(Dictionary<string, int> my_dictionary)
    {
        my_dictionary.Clear();
        //loop to add 2000 items in the dictionary
        for (int iCount = 1; iCount < 2001; iCount++)
        {
            my_dictionary.Add("New Entry " + iCount, iCount);
        }

        Console.WriteLine("\n2000 items added to the Dictionary.\n");
        return my_dictionary;
    }
    

    //display the dictionary
    public static void display(Dictionary<string, int> my_dictionary)
    {
        Console.WriteLine("Dictionary display results:");
        foreach (var item in my_dictionary)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }


    //delete from the list
    public static Dictionary<string, int> deleteFrom(Dictionary<string, int> my_dictionary, string name)
    {
        Dictionary<string, int> new_dictionary = new Dictionary<string, int>();
        bool bFound = false;

        //copy the stack over to the new stack all the values that don't match the name
        foreach (KeyValuePair<string, int> item in my_dictionary)
        {
            if (item.Key != name) //don't add it if it matches
            {
                new_dictionary.Add(item.Key, item.Value);
            }
            else
            {
                bFound = true;
            }
        }

        //if found, give happy message. if not completed, put out error message
        if (bFound == true)
        {
            Console.WriteLine("Item '" + name + "' removed from the Dictionary.\n");
        }
        else
        {
            Console.WriteLine("Item '" + name + "' not found.\n");
        }

        return new_dictionary;
    }


    //clear the dictionary
    public static Dictionary<string, int> clear(Dictionary<string, int> my_dictionary)
    {
        my_dictionary.Clear();
        Console.WriteLine("\nDictionary cleared!\n");
        return my_dictionary;
    }


    //search for one item and show how long it took to find
    public static Dictionary<string, int> search(Dictionary<string, int> my_dictionary, string name)
    {
        System.Diagnostics.Stopwatch Timer = new System.Diagnostics.Stopwatch();
        bool found = false;
        Timer.Start();

        foreach (var item in my_dictionary)
        {
            if (my_dictionary.ContainsKey(name))
            {
                found = true;
            }
        }
        Timer.Stop();

        if (found == true)
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
