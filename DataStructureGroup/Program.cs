using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Console.Write("\nPlease choose an option: \n");
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
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            
            
            bool exit = false;

            int option1 = menu(1);

            while(!exit)
            { //Displays first menu 
            
                int option2 = -1;

                switch (option1) //Displays Menu Two based of the user's input from first menu;
                {
                    case 1: 
                        option2 = menuTwo("Stack");
                        string input;
                        string search;
                        bool found = false;
                        Stack<string> second = new Stack<string>();

                        switch (option2) //Enters into cases specific to the Stack
                        {
                            case 1: //add one time
                                Console.Write("Please enter string for the Stack: ");
                                input = Console.ReadLine();
                                myStack.Push(input);
                                Console.WriteLine(input + " entered.");
                                break;
                            case 2: //add huge list
                                myStack.Clear();
                                for (int i = 1; i <= 2000; i++)
                                {
                                    string number = i.ToString();
                                    myStack.Push("New Entry " + number);
                                }
                                Console.WriteLine("Huge List Added");
                                break;
                            case 3: //display
                                // Handle when the stack is empty!
                                if (myStack.Count == 0)
                                {
                                    Console.WriteLine("The Stack is empty.\n");
                                    break;
                                }

                                // Display the elements of the stack one at a time.
                                Console.WriteLine("\nStack:");
                                foreach (string entry in myStack)
                                {
                                    Console.WriteLine(entry);
                                }
                                break;
                            case 4: //delete from
                                Console.Write("Enter string to delete: ");
                                search = Console.ReadLine();
                                foreach (string entry in myStack)
                                {
                                    if (entry.Equals(search))
                                    {
                                        found = true;
                                        while (myStack.Peek() != search)
                                        {
                                            second.Push(myStack.Pop());
                                        }
                                        myStack.Pop();
                                        while (second.Count() > 0)
                                        {
                                            myStack.Push(second.Pop());
                                        }

                                        Console.WriteLine("String deleted. But please use another structure if you want to delete next time...");
                                        break;
                                    }
                                }
                                if (found)
                                {
                                    break;
                                }
                                Console.WriteLine("String not found.");
                                break;
                            case 5: //clear
                                myStack.Clear();
                                Console.WriteLine("Stack cleared.");
                                break;
                            case 6: //search
                                Console.Write("Enter string to search for: ");
                                sw.Start();
                                search = Console.ReadLine();
                                Console.Write("\n");
                                foreach (string entry in myStack)
                                {
                                    if (entry.Equals(search))
                                    {
                                        found = true;
                                        sw.Stop();
                                        Console.WriteLine("String found.");
                                        TimeSpan ts = sw.Elapsed;
                                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            ts.Hours, ts.Minutes, ts.Seconds,
                                            ts.Milliseconds / 10);
                                        Console.WriteLine("Elapsed time: " + elapsedTime);
                                        sw.Reset();
                                        break;
                                    }
                                }
                                if (found)
                                {
                                    break;
                                }
                                sw.Stop();
                                sw.Reset();
                                Console.WriteLine("String not found.");
                                break;
                            case 7: //return to main menu
                                option1 = menu(1);
                                break;
                        }
                        break;
                    case 2:
                        option2 = menuTwo("Queue");
                        
                        switch (option2) //Enters into cases specific to the Queue
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

        }
    }
}
