using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureGroup
{
    class Program
    {
        public static int menu(int type)
        {
            bool validOption = false;
            int option = -1;

            if (type == 1)
            {

                Console.Write("Please choose an option: \n");
                Console.Write("1. Stack\n");
                Console.Write("2. Queue\n");
                Console.Write("3. Dictionary\n");
                Console.Write("4. Exit\n");
                Console.Write("->");
            }

            string sInput;
            sInput = Console.ReadLine();
            while (!validOption)
            {
                try
                {
                    option = int.Parse(sInput);

                    if (option > 0 && option < 5) //Tests if int is within the menu bounds
                    {
                        validOption = true;
                    }
                    else
                    {
                        Console.Write("Invalid input. Try again\n");
                        Console.Write("->");
                        sInput = Console.ReadLine();
                    }



                }
                catch
                {
                    Console.Write("Invalid input. Try again\n");
                    Console.Write("->");
                    sInput = Console.ReadLine();
                }

            }

            return option;


        }

        /* Function: menuTwo()
         * Description: Displays the second menu so user can select specific action with the chosen Data Structure
         * Parameters: String StructureType - Chosen by user from main menu
         * Returns: int option
         */
        public static int menuTwo(string StructureType)
        {
            Console.Write("Please choose an option: \n");
            Console.Write("1. Add one time to " + StructureType + "\n");
            Console.Write("2. Add Huge List of Items to " + StructureType + "\n");
            Console.Write("3. Display " + StructureType + "\n");
            Console.Write("4. Delete from " + StructureType + "\n");
            Console.Write("5. Clear " + StructureType + "\n");
            Console.Write("6. Search " + StructureType + "\n");
            Console.Write("7. Return to Main Menu\n");
            Console.Write("->");

            string sInput;
            sInput = Console.ReadLine();
            int option = -1;

            bool validOption = false;
            while (!validOption)
            {
                try
                {
                    option = int.Parse(sInput);
                    if (option > 0 && option < 8)
                    {
                        validOption = true;
                    }
                    else
                    {
                        Console.Write("Invalid input. Try again\n");
                        Console.Write("->");
                        sInput = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.Write("Invalid input. Try again\n");
                    Console.Write("->");
                    sInput = Console.ReadLine();
                }

            }
            return option;
        }





        static void Main(string[] args)
        {
            //Initiate the DataStructures that the program uses
            Stack<string> myStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();



            bool exit = false;
            while (!exit)
            {
                int option1 = menu(1); //Displays first menu 

                int option2 = -1;

                switch (option1) //Displays Menu Two based of the user's input from first menu;
                {
                    case 1:
                        option2 = menuTwo("Stack");

                        switch (option2) //Enters into cases specific to the Stack
                        {
                            case 1: //add one time
                                break;
                            case 2: //add huge list
                                break;
                            case 3: //display
                                break;
                            case 4: //delete from
                                break;
                            case 5: //clear
                                break;
                            case 6: //search
                                break;
                            case 7: //return to main menu
                                //Due to while loop, automatically returns to main menu
                                break;
                        }
                        break;
                    case 2:
                        option2 = -1;
                        while (option2 != 7)
                        {
                            Console.WriteLine("");//for a neater, easier to read appearance
                            option2 = menuTwo("Queue");
                            switch (option2) //Enters into cases specific to the Queue
                            {
                                case 1: //add one time
                                    Console.Write("\nEnter the item you would like to add to the Stack: ");
                                    string singleItem = Console.ReadLine();
                                    myQueue.Enqueue(singleItem);
                                    break;
                                case 2: //add huge list
                                    myQueue.Clear();
                                    for (int i = 1; i < 2001; i++)
                                    {
                                        myQueue.Enqueue("New Entry " + i);
                                    }
                                    break;
                                case 3: //display
                                    if (myQueue.Count != 0)
                                    {
                                        foreach (string item in myQueue)
                                        {
                                            Console.WriteLine(item);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nThe queue is empty. Please fill to display results.");
                                    }
                                    break;
                                case 4: //delete from
                                    string sDeleteItem;
                                    Console.Write("\nEnter the item you would like to delete: ");
                                    sDeleteItem = Console.ReadLine();
                                    if (myQueue.Peek() == sDeleteItem)
                                    {
                                        myQueue.Dequeue();
                                    }
                                    else
                                    {
                                        Console.WriteLine("This item is not at the front of the queue.");
                                    }
                                    break;
                                case 5: //clear
                                    myQueue.Clear();
                                    break;
                                case 6: //search
                                    bool found = false;
                                    string sFindItem;
                                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                                    IEnumerator<string> MyQueueEnumerator = myQueue.GetEnumerator();
                                    Console.Write("\nEnter the item you would like to find: ");
                                    sFindItem = Console.ReadLine();
                                    sw.Start();
                                    while (!found && MyQueueEnumerator.MoveNext())
                                    {
                                        if (sFindItem == MyQueueEnumerator.Current)
                                        {
                                            found = true;
                                        }
                                    }
                                    sw.Stop();
                                    var timeElapsed = sw.ElapsedMilliseconds;
                                    if (found)
                                    {
                                        Console.WriteLine(sFindItem + " was found in the queue!");
                                    }
                                    else
                                    {
                                        Console.WriteLine(sFindItem + " was not found.");
                                    }
                                    Console.WriteLine("Execution time: " + timeElapsed);
                                    break;
                                case 7: //return to main menu
                                    //Due to while loop, automatically returns to main menu
                                    break;
                            }
                        }
                        break;
                    case 3:
                        option2 = menuTwo("Dictionary");

                        switch (option2)  //Enters into cases specific to the Dictionary
                        {
                            case 1: //add one time
                                break;
                            case 2: //add huge list
                                break;
                            case 3: //display
                                break;
                            case 4: //delete from
                                break;
                            case 5: //clear
                                break;
                            case 6: //search
                                break;
                            case 7: //return to main menu
                                //Due to while loop, automatically returns to main menu
                                break;
                        }
                        break;
                    case 4: // Exit
                        exit = true;
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
