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

        static void Main(string[] args)
        {
            //variables:
            bool bRepeatFullMenu = true, bRepeatInnerMenu = true;
            int iMainMenuInput = 0, iInnerMenuInput = 0;
            Stack<string> my_stack = new Stack<string>();
            Queue<string> my_queue = new Queue<string>();
            Dictionary<string, int> my_dictionary = new Dictionary<string, int>();
            string search_string = "", add_string = "", delete_string = "";


            while (bRepeatFullMenu) //full outer menu loop
            {
                //main menu input loop
                bRepeatFullMenu = true;
                while (bRepeatFullMenu)
                {
                    //display the main menu
                    Console.WriteLine("Please make a selection: ");
                    printMainMenu();

                    try
                    {
                        iMainMenuInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        bRepeatFullMenu = false;

                        //confirm inner menu input
                        if (iMainMenuInput == 1 || iMainMenuInput == 2 || iMainMenuInput == 3)
                        {
                            bRepeatInnerMenu = true;
                        }
                        else if (iMainMenuInput == 4)
                        {
                            Console.WriteLine("See you next time!");
                            bRepeatFullMenu = false;
                            bRepeatInnerMenu = false;
                        }
                        else
                        {
                            bRepeatFullMenu = true;
                            bRepeatInnerMenu = false;
                            Console.WriteLine("Please enter a valid choice\n\n");
                        }


                        while (bRepeatInnerMenu) //inner menus input loop
                        {

                            Console.WriteLine("Please make a selection: ");

                            switch (iMainMenuInput) //print inner menu
                            {
                                case 1:
                                    MyStack.printStackMenu();
                                    break;
                                case 2:
                                    MyQueue.printQueueMenu();
                                    break;
                                case 3:
                                    MyDictionary.printDictionaryMenu();
                                    break;
                            }
                            Console.WriteLine();

                            try
                            {
                                iInnerMenuInput = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                bRepeatInnerMenu = false;

                                //inner loop input handling
                                switch (iInnerMenuInput)
                                {
                                    case 1: // add one item

                                        bRepeatInnerMenu = true;
                                        switch (iMainMenuInput)
                                        {
                                            case 1: // stack
                                                Console.Write("Enter the string: ");
                                                add_string = Convert.ToString(Console.ReadLine());
                                                my_stack = MyStack.addOne(my_stack, add_string);
                                                break;
                                            case 2: // queue
                                                Console.Write("Enter the string: ");
                                                add_string = Convert.ToString(Console.ReadLine());
                                                my_queue = MyQueue.addOne(my_queue, add_string);
                                                break;
                                            case 3: // dictionary
                                                Console.Write("Enter the string key: ");
                                                add_string = Convert.ToString(Console.ReadLine());
                                                Console.Write("\nEnter the integer value: "); // TODO add error handling for the integer conversion
                                                try
                                                {
                                                    int add_int = Convert.ToInt32(Console.ReadLine());
                                                    my_dictionary = MyDictionary.addOne(my_dictionary, add_string, add_int);
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("\nInvalid integer, nothing added to dictionary.\n");
                                                }
                                                break;
                                        }

                                        break;
                                    case 2: // add huge list of items

                                        bRepeatInnerMenu = true;
                                        switch (iMainMenuInput)
                                        {
                                            case 1: // stack
                                                my_stack = MyStack.addHugeList(my_stack);
                                                break;
                                            case 2: // queue
                                                my_queue = MyQueue.addHugeList(my_queue);
                                                break;
                                            case 3: // dictionary
                                                my_dictionary = MyDictionary.addHugeList(my_dictionary);
                                                break;
                                        }

                                        break;
                                    case 3: // display the list

                                        bRepeatInnerMenu = true;
                                        switch (iMainMenuInput)
                                        {
                                            case 1: // stack
                                                MyStack.display(my_stack);
                                                break;
                                            case 2: // queue
                                                MyQueue.display(my_queue);
                                                break;
                                            case 3: // dictionary
                                                MyDictionary.display(my_dictionary);
                                                break;
                                        }

                                        break;
                                    case 4: // delete from the list

                                        bRepeatInnerMenu = true;
                                        switch (iMainMenuInput)
                                        {
                                            case 1: // stack
                                                Console.Write("Enter the string to delete: ");
                                                delete_string = Convert.ToString(Console.ReadLine());
                                                my_stack = MyStack.deleteFrom(my_stack, delete_string);
                                                break;
                                            case 2: // queue
                                                Console.Write("Enter the string to delete: ");
                                                delete_string = Convert.ToString(Console.ReadLine());
                                                my_queue = MyQueue.deleteFrom(my_queue, delete_string);
                                                break;
                                            case 3: // dictionary
                                                Console.Write("Enter the string to delete: ");
                                                delete_string = Convert.ToString(Console.ReadLine());
                                                my_dictionary = MyDictionary.deleteFrom(my_dictionary, delete_string);
                                                break;
                                        }

                                        break;
                                    case 5: // clear the list

                                        bRepeatInnerMenu = true;
                                        switch (iMainMenuInput)
                                        {
                                            case 1: // stack
                                                my_stack = MyStack.clear(my_stack);
                                                break;
                                            case 2: // queue
                                                my_queue = MyQueue.clear(my_queue);
                                                break;
                                            case 3: // dictionary
                                                my_dictionary = MyDictionary.clear(my_dictionary);
                                                break;
                                        }

                                        break;
                                    case 6: // search the list

                                        bRepeatInnerMenu = true;
                                        switch (iMainMenuInput)
                                        {
                                            case 1: // stack
                                                Console.WriteLine("Enter the value you want to search for:");
                                                search_string = Convert.ToString(Console.ReadLine());
                                                my_stack = MyStack.search(my_stack, search_string);
                                                break;
                                            case 2: // queue
                                                Console.WriteLine("Enter the value you want to search for:");
                                                search_string = Convert.ToString(Console.ReadLine());
                                                my_queue = MyQueue.search(my_queue, search_string);
                                                break;
                                            case 3: // dictionary
                                                Console.WriteLine("Enter the value you want to search for:");
                                                search_string = Convert.ToString(Console.ReadLine());
                                                my_dictionary = MyDictionary.search(my_dictionary, search_string);
                                                break;
                                        }

                                        break;
                                    case 7: // return to the main menu
                                        bRepeatInnerMenu = false;
                                        bRepeatFullMenu = true;
                                        break;
                                    default: // entered an integer, but not a valid menu item 1-7
                                        bRepeatInnerMenu = true;
                                        Console.WriteLine("Please enter a valid choice\n\n");
                                        break;
                                }
                            }
                            catch
                            {
                                bRepeatInnerMenu = true;
                                Console.WriteLine("Please enter a valid integer");
                            }

                        } // end of inner menu loop

                    }
                    catch
                    {
                        bRepeatFullMenu = true;
                        Console.WriteLine("Please enter a valid integer");
                    }
                }

            } // end of main menu outer loop

            Console.Read();
        }


        //other functions:------------------------------------------------------------------

        //print the main menu
        public static void printMainMenu()
        {
            Console.WriteLine("\n1. Stack\n2. Queue\n3. Dictionary\n4. Exit\n");
        }



    }
}
