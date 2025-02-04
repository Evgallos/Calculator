using System;
using System.ComponentModel.Design;
using static System.Console;


namespace CalcuLatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Scope
            //{
                  //Scope area between {SCOPE}              //< that we call it SCOPE area
            //}







            // Simple Calculator Project bellow:

            double num1, num2, result = 0; //<<<< Always we put result zero in calcualtions otherwise we will have error to our results!

            Write("Select an option + - * /"); //<<< Creation menu for user.

            char op = char.Parse(ReadLine()); //<< op means operator 

            if(op=='+' || op == '-' || op == '*' || op == '/') //<< the menu and wrong option if doesn't choice one of select option
            {
                Write("First Number:        ");     //<<<< User typing the number
                num1 = double.Parse(ReadLine());

                Write("Second Number:       ");
                num2 = double.Parse(ReadLine());   //<<<< User typing the number

                if (op == '+')                     
                    result = num1 + num2;
                else if (op == '-')
                    result = num1 - num2;
                else if (op == '*')
                    result = num1 * num2;
                else
                    result = num1 / num2;



            }
            else
            {
                WriteLine("You selected a wrong option.");
            }
            WriteLine($"The result is:   {result}");  //<< result
            
            
            ReadKey();
        }
    }
}
