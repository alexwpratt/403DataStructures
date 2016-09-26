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
        Console.WriteLine("\n\t1. Add One Item to Queue\n\t2. Add Huge List of Items to Queue\n\t3. Display Queue\n\t4. Delete from Queue\n\t5. Clear Queue\n\t6. Search Queue\n\t7. Return to Main Menu\n");
    }

    //add one item
    public static Queue<string> addOne(Queue<string> my_queue, string add)
    {
        my_queue.Enqueue(add);
        return my_queue;
    }

    //automatically add 2000 items after clearing the list in their proper format
    public static Queue<string> addHugeList(Queue<string> my_queue)
    {
        my_queue.Clear();
        //loop to add 2000 items in the queue
        for (int iCount = 1; iCount < 2001; iCount++)
        {
            my_queue.Enqueue("New Entry " + iCount);
        }
        return my_queue;
    }


    //display the list
    public static void display(Queue<string> my_queue)
    {
        foreach (string item in my_queue)
        {
            Console.WriteLine(item);
        }

        //return my_stack;
    }

    //delete from the list
    public static Queue<string> deleteFrom(Queue<string> my_queue, string name)
    {
        Queue<string> new_queue = new Queue<string>();
        bool bFound = false;

        //copy the stack over to the new stack all the values that don't match the name
        foreach (string item in my_queue)
        {
            if (item != name) //don't add it if it matches
            {
                new_queue.Enqueue(item);
            }
            else
            {
                bFound = true;
            }
        }

        //if found, give happy message. if not completed, put out error message
        if (bFound == true)
        {
            Console.WriteLine("Item '" + name + "' removed from the list.\n");
        }
        else
        {
            Console.WriteLine("Item '" + name + "' not found.\n");
        }

        return new_queue;
    }


    //clear the list
    public static Queue<string> clear(Queue<string> my_queue)
    {
        my_queue.Clear();
        return my_queue;
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
