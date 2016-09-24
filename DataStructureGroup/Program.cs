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
                    validOption = true;
                }
                catch
                {
                    Console.Write("Invalid input. Try again");
                    Console.Write("->");
                    sInput = Console.ReadLine();
                }
                
            }

            if (option > 0 && option < 5)
                return option;
            else
                return -1;

        }

        /* I had to leave this before I could add comments.  I am pretty sure it works but I am going to test it more. 
         * Essentially it brings up the Second menu and uses "Queue", Dictionary", etc. from menu one.
         * I will add more documentary on it later.
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
                    validOption = true;
                }
                catch
                {
                    Console.Write("Invalid input. Try again");
                    Console.Write("->");
                    sInput = Console.ReadLine();
                }

            }

            if (option > 0 && option < 8)
                return option;
            else
                return -1;
        }


        static void Main(string[] args)
        {
            int option1 = menu(1);
            int option2 = -1;

            switch (option1)
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
                    
                    break;
            }
            Console.ReadKey();

        }
    }
}
