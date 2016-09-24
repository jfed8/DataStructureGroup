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
                Console.Write("4.  Exit\n");
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
            bool exit = false;

            while(!exit)
            {
                int option1 = menu(1); //Displays first menu 
            
                int option2 = -1;

                switch (option1) //Displays second menu depending on user's selection from menu 1
                {
                    case 1:
                        option2 = menuTwo("Stack");
                        break;
                    case 2:
                        option2 = menuTwo("Queue");
                        break;
                    case 3:
                        option2 = menuTwo("Dictionary");
                        break;
                    case 4:
                        exit = true;
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
