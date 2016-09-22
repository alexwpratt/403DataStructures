/*
 * Brett Adamson
 * Kory Hutchison
 * Nathan Marrs
 * Alex Pratt
 * 
 * IS403
 * Section 2 Group 12
 * 
 * Data Structures Assignment

Write a program in C# using a console application that demonstrates the use of a Stack, Queue, and Dictionary (Map). I want you to start trying to use GitHub for this assignment.

Make sure you document your code. This might seem like a big program but it really isn't since a lot of the code is copied and reused. In fact, it might be a good idea as a group to divide up the work and then try to bring it all together into one project.

When completed, everyone needs to zip the project and upload to Learning Suite and make sure code is committed to GitHub.

As a group, schedule a time with the TAs for grading

Menu Structure

Your application will be based around a simple menu. The functionality of each menu item is described in more detail below. The first menu prompt should be the following:

1. Stack
2. Queue
3. Dictionary
4. Exit
If the user chooses #1, display:

1. Add one time to Stack
2. Add Huge List of Items to Stack
3. Display Stack
4. Delete from Stack
5. Clear Stack
6. Search Stack
7. Return to Main Menu
If the user chooses #2, display:

1. Add one time to Queue
2. Add Huge List of Items to Queue
3. Display Queue
4. Delete from Queue
5. Clear Queue
6. Search Queue
7. Return to Main Menu
If the user chooses #3, display:

1. Add one item to Dictionary
2. Add Huge List of Items to Dictionary
3. Display Dictionary
4. Delete from Dictionary
5. Clear Dictionary
6. Search Dictionary
7. Return to Main Menu
Functionality

Add one item to ... - prompts the user to enter a string and then inserts the input into the data structure.

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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {

        //print the main menu
        public static void printMainMenu()
        {
            Console.WriteLine("1. Stack\n2. Queue\n3. Dictionary\n4. Exit\n");
        }

        //print the menu regarding stacks
        public static void printStackMenu()
        {
            Console.WriteLine("1. Add one time to Stack\n2. Add Huge List of Items to Stack\n3. Display Stack\n4. Delete from Stack\n5. Clear Stack\n6. Search Stack\n7. Return to Main Menu\n");
        }

        //print the menu regarding queues
        public static void printQueueMenu()
        {
            Console.WriteLine("1. Add one time to Queue\n2. Add Huge List of Items to Queue\n3. Display Queue\n4. Delete from Queue\n5. Clear Queue\n6. Search Queue\n7. Return to Main Menu\n");
        }

        //print the menu regarding dictionary
        public static void printDictionaryMenu()
        {
            Console.WriteLine("1. Add one item to Dictionary\n2. Add Huge List of Items to Dictionary\n3. Display Dictionary\n4. Delete from Dictionary\n5. Clear Dictionary\n6. Search Dictionary\n7. Return to Main Menu\n");
        }



        static void Main(string[] args)
        {
            bool bRepeatFullMenu = true, bRepeat = true;
            int iUserInput = 0;

            //full outer menu loop
            while (bRepeatFullMenu)
            {



                //main menu input loop
                bRepeat = true;
                while (bRepeat)
                {
                    //display the main menu
                    Console.WriteLine("Please make a selection: \n");
                    printMainMenu();

                    try
                    {
                        iUserInput = Convert.ToInt32(Console.ReadLine());
                        bRepeat = false;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid integer\n\n");
                        bRepeat = true;
                    }
                }

                switch (iUserInput)
                {
                    case 1: // Stack
                        printStackMenu();
                        break;
                    case 2: // queue
                        printQueueMenu();
                        break;
                    case 3: // dictionary
                        printDictionaryMenu();
                        break;
                    case 4: // exit
                        Console.WriteLine("See you next time!");
                        bRepeatFullMenu = false;
                        break;
                }

                
            }


            Console.Read();
        }
    }
}
