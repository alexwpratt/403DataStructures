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

public class MyQueue
{
	public MyQueue()
	{
	}



    //print the menu regarding queues
    public static void printQueueMenu()
    {
        Console.WriteLine("1. Add one time to Queue\n2. Add Huge List of Items to Queue\n3. Display Queue\n4. Delete from Queue\n5. Clear Queue\n6. Search Queue\n7. Return to Main Menu\n");
    }

    //search for one item and show how long it took to find
    public static Queue<string> search(Queue<string> my_queue, string name)
    {
        System.Diagnostics.Stopwatch Timer = new System.Diagnostics.Stopwatch();
        Timer.Start();

        bool found = my_queue.Contains(name);

        Timer.Stop();

        if (found == true)
        {
            Console.WriteLine("\nIt exists! It was found in " + Timer.Elapsed);
        }
        else
        {
            Console.WriteLine("\nSearch was not successful.");
        }

        return my_queue;
    }
}
