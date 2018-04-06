using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable deklaration
            Double FirstNum;
            Double SecondNum;
            Double Answer;
            string operation;


            Console.WriteLine("This is my first calculater");
 

            Console.Write(" Enter first no ");
            FirstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter Second no ");
            SecondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your operation ( * , / , +, -) ");
            operation = Console.ReadLine();

            if (operation == "*")
            {
                Answer = FirstNum * SecondNum;
                Console.WriteLine(FirstNum + "*" + SecondNum + " = " + Answer);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                Answer = FirstNum / SecondNum;
                Console.WriteLine(FirstNum + "/" + SecondNum + " = " + Answer);
                Console.ReadLine();
            }
            else if (operation == "+")
            {
                Answer = FirstNum + SecondNum;
                Console.WriteLine(FirstNum + " + " + SecondNum + " = " + Answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                Answer = FirstNum - SecondNum;
                Console.WriteLine(FirstNum + " - " + SecondNum + " = " + Answer);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry that is not correct format! Please restart!");     //Catch
                Console.ReadLine();
            }
        }
    }
}
