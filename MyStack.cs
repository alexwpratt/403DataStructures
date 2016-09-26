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

public class MyStack
{
	public MyStack(){}


    //print the menu regarding stacks
    public static void printStackMenu()
    {
        Console.WriteLine("\n\t1. Add One Item to Stack\n\t2. Add Huge List of Items to Stack\n\t3. Display Stack\n\t4. Delete from Stack\n\t5. Clear Stack\n\t6. Search Stack\n\t7. Return to Main Menu\n");
    }

    
    //add one item to the list
    public static Stack<string> addOne(Stack<string> my_stack, string add_me)
    {
        my_stack.Push(add_me);
        return my_stack;
    }

    
    //automatically add 2000 items after clearing the list
    public static Stack<string> addHugeList(Stack<string> my_stack)
    {
        my_stack.Clear();
        for (int i = 0; i < 2000; i++)
        {
            my_stack.Push("New Entry " + (i + 1));
        }

        return my_stack;
    }
    

    //display the list
    public static void display(Stack<string> my_stack)
    {
        foreach (string item in my_stack)
        {
            Console.WriteLine(item);
        }

        //return my_stack;
    }


    //delete one item from the list based on the user entry (name), handle errors (incorrect name entry, name not found)
    public static Stack<string> deleteFrom(Stack<string> my_stack, string name)
    {
        Stack<string> new_stack = new Stack<string>();
        bool bFound = false;

        //copy the stack over to the new stack all the values that don't match the name
        foreach (string item in my_stack)
        {
            if (item != name) //don't add it if it matches
            {
                new_stack.Push(item);
            }
            else
            {
                bFound = true;
            }
        }
        my_stack.Clear();
        //flip stack to correct direction
        foreach (string item in new_stack)
        {
            my_stack.Push(item);
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
        
        return my_stack;
    }


    //clear the list
    public static Stack<string> clear(Stack<string> my_stack)
    {
        my_stack.Clear();
        return my_stack;
    }


    //search for one item and show how long it took to find
    public static Stack<string> search(Stack<string> my_stack, string name)
    {
        System.Diagnostics.Stopwatch Timer = new System.Diagnostics.Stopwatch();
        Timer.Start();

        bool found = my_stack.Contains(name);

        Timer.Stop();

        if (found == true)
        {
            Console.WriteLine("\nIt exists! It was found in " + Timer.Elapsed);
        }
        else
        {
            Console.WriteLine("\nSearch was not successful.");
        }

        return my_stack;
    }


}
