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
                
                Console.Write("\nPlease choose an option: \n");
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
                }
                
            }

            if (option > 0 && option < 7)
                return option;
            else
                return -1;

        }


        static void Main(string[] args)
        {
            Console.Write("Feddock");
            Console.Write("Jess");
            Console.Write("Group 2-3");

            int option = menu(1);

        }
    }
}
