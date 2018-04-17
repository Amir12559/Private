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

            // First of we declared varibales which we needed for (+,-,*,/) and sum is the result of these vartiables
            Class1 operations = new Class1();// We made a class named Class1 and we have public in that class which can call from everywhere,::::To call that class1 we write this line of code(Class1 operations = new Class1();
            double firstNum;
            double secondNum;                   //Variables for equation
            string operation;
            double sum;


            bool isRunning = true; // This is our while loop which runs untill our statments are true and we apply it on our whole code....But....We need to stop this code to else it will run all the time repeatidly.
            while (isRunning)// It will run untill condition is true
            {
                // Whole program

                Console.WriteLine("Hello, welcome to Amir's basic calculator!");
                Console.ReadLine();

                Console.Write("Enter the first number in your basic equation: ");

                firstNum = Convert.ToInt32(Console.ReadLine());

                //User input for equation
                Console.Write("Now enter your second number in the basic equation: ");
                secondNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ok now enter your operation ( * , / , +, -) ");
                Console.WriteLine("press q to stop the program");// We decided that if we press q then it will stop running that while loop, we can decide any word/digit eg (a,b,2 etc)
                operation = Console.ReadLine();// To see where to go in meny (+,-,*,/)


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
                else if (operation == "q")// If we press q then condition will be false and it will stop running
                {
                    isRunning = false;// It will stop running 
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


