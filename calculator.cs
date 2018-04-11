using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program

    {
        static void Main(string[] args)
        {
            Class1 operations = new Class1();
            double firstNum;
            double secondNum;                   //Variables for equation
            string operation;
            double sum;


            bool isRunning = true;
            while (isRunning)
            {


                Console.WriteLine("Hello, welcome to Amir's basic calculator!");
                Console.ReadLine();

                Console.Write("Enter the first number in your basic equation: ");

                firstNum = Convert.ToInt32(Console.ReadLine());

                //User input for equation
                Console.Write("Now enter your second number in the basic equation: ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ok now enter your operation ( * , / , +, -) ");
                Console.WriteLine("press q to stop the program");
                operation = Console.ReadLine();


                if (operation == "*")
                {
                    //answer = firstNum * secondNum;

                    //Console.ReadLine();
                    sum = operations.Multiplication(firstNum, secondNum);
                    Console.WriteLine(firstNum + " x " + secondNum + " = " + sum);
                    Console.ReadKey();
                }
                else if (operation == "/")
                {
                    sum = operations.Division(firstNum, secondNum);
                    Console.WriteLine(firstNum + " / " + secondNum + " = " + sum);
                    Console.ReadKey();
                    //answer = firstNum / secondNum;

                    //Console.ReadLine();
                }
                ////Getting answers
                else if (operation == "+")
                {
                    sum = operations.Addition(firstNum, secondNum);
                    Console.WriteLine(firstNum + " + " + secondNum + " = " + sum);
                    Console.ReadKey();
                    //answer = firstNum + secondNum;

                    //Console.ReadLine();
                }
                else if (operation == "-")
                {
                    sum = operations.Subtraction(firstNum, secondNum);
                    Console.WriteLine(firstNum + " - " + secondNum + " = " + sum);
                    Console.ReadKey();
                    //    answer = firstNum - secondNum;

                    //    Console.ReadLine();
                }
                else if (operation == "q")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not correct format! Please restart!");     //Catch
                    Console.ReadLine();
                }

            }




        }
    }
}


