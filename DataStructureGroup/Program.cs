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


            if (type == 1)
            {
                int option = -1;
                Console.Write("\nPlease choose an option: \n");
                Console.Write("1. Add a car to the station\n");
                Console.Write("2. Remove a car from the station\n");
                Console.Write("3. Add a car from the station to a storage facility\n");
                Console.Write("4. Remove a car from a storage facility (bring it to the station)\n");
                Console.Write("5. Display the currently accessible cars in all locations\n");
                Console.Write("6. Quit\n");
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
