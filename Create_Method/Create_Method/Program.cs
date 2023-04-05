using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max number is {GetInput(3)}");
            Main(args);
            Console.ReadLine();
        }
        public static int GetInput(int a)
        {
            qaytayukla1:
            Console.WriteLine("Enter number");
            string input1 =Console.ReadLine();
            bool chek1 = int.TryParse(input1, out int number1);
            if(!chek1)
            {
                Console.WriteLine($"Error {input1}");
                goto qaytayukla1;
            }

            qaytayukla2:
            Console.WriteLine("Enter number");
            string input2 =Console.ReadLine();
            bool chek2 = int.TryParse(input2, out int number2);
            if(!chek2)
            {
                Console.WriteLine($"Error {input2}");
                goto qaytayukla2;
            }

            int result = MaxNumber(number1, number2);

            return result;
        }
        public static int MaxNumber(int number1, int number2)
        {
            if(number1 < number2)
            {
                return number2;
            }else
            {
                return number1;
            }
        }
    }
}
