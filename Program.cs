using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program executes an array which is of size 25 elements");

            // using the try catch block to validate user input
            try
            {
                Console.WriteLine("Populating the array with 25 integars");
                //Manually Populating the Array
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                Console.WriteLine("Here are the list of elements in the array:");
                Console.WriteLine(" ");
                //for each loop iterates
                foreach (int i in numbers)
                {
                    Console.WriteLine("Element value = " + i + " ");

                }
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to to get completion message");
                Console.ReadKey(true); // this will end the program when the user presses any key
            } //end of try
            catch
            {
                Console.WriteLine("There is an error");
            } //end of catch

            Console.WriteLine("The program worked perfectly, SUCCESS");
            Console.WriteLine("Let's exit the program, press any key");
            Console.ReadKey(true);
        }
    }
}
