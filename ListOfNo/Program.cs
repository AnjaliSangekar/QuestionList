using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
 * The list of numbers may include duplicates. Display the unique numbers that the user has entered.
 *
 */
namespace ListOfNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter the number or quit to exit");
                var num = Console.ReadLine();

                if (num == "quit")
                {
                    break;
                }
                else
                {
                    var number = Convert.ToInt32(num);
                    if(list.Contains(number))
                    {
                        continue;
                    }
                    else
                    {
                        list.Add(number);
                    }
                }
            }

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
