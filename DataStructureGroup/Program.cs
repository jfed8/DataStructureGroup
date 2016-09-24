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
                }
                
            }

            if (option > 0 && option < 5)
                return option;
            else
                return -1;

        }


        static void Main(string[] args)
        {
            int option = menu(1);

            switch (option)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
            }
            Console.ReadKey();

        }
    }
}
