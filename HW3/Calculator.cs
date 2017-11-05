using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        private IStackADT stack = new LinkedStack();
        
        /// This is the main method of the calculator.
        static void Main(string[] args)
        {
            Calculator app = new Calculator();
            bool playAgain = true;
            Console.WriteLine("\nPostfix Calculator. Recognizes these operators: + - * /");
            while (playAgain)
            {
                playAgain.app.DoCalculation();
            }
            Console.WriteLine("Bye/さよなら");

        }

        ///Starts ups the calculator and will continue to run until you quit which is "q".
        ///This returns a boolean and it is true if you continue to still use the program.
        bool DoCalculation()
        {
            Console.WriteLine("Please enter Q or q to exit the program\n");
            string input = "2 2 + ";
            Console.Write(">");

            input = Console.ReadLine();

            ///If the input is q or Q then return false which means to quit the program.
            if(input[0] == "q" || input[0] == "Q")
            {
                return false;
            }

            string output = "4";
            ///This is test program to see if the output is read into the program.
            try
            {
                output = EvaluatePostFixInput(input);
            }
            catch(ArgumentException e)
            {
                output = e.Message;
            }
            Console.WriteLine("\n\t>>>" + input + " = " + output);
            return true;
        
        }

        /// This is to test and make sure that the input is valid for calculator to execute.
        /// Param: input strings (Which are the calculations in which you wish to run/execute)
        /// Returns: A string which is the answer to the input question.
      
        string EvaluatePostFixInput(string input)
        {
            if(input == null || input == "")
            {
                throw new ArgumentException("Null or empty string are not valid postfix expressions.");
            }
            stack.Clear();

            string s;
            double a;
            double b;
            double c;

            double test;

            string[] divided = input.Split(new char[0]);

            for(int i = 0; i < divided.Length; i++)
            {
                if(Double.TryParse(divided[i], out test))
                {
                    stack.Push(Convert.ToDouble(divided[i]));
                }
                else
                {
                    s = divided[i];
                    if (stack.IsEmpty())
                        throw new ArgumentException("Improper input format. Stack became empty when excepting the second operand."); 
                    b = (Convert.ToDouble(stack.Pop()));
                    if (stack.IsEmpty())
                        throw new ArgumentException("Improper input format. Stack became empty when excepting the first operand.");
                    a = (Convert.ToDouble(stack.Pop()));
                    c = DoOperation(a, b, s);
                }
            }
            return stack.Pop().ToString();
        }
        /// This is where all of the calculations are done in the application.
        /// This will also catch errors if you divide by 0 or use a invalid operator.
        /// 
        /// param: double a, double b, string s
        /// This would be the first value, the second value, and the operation that is being applied.  
        ///Retruns: double, which is the result or the answer to the problem given as a double.
        double DoOperation(double a, double b, string s)
        {
            double c = 0.0;
            if (s == "+")
            {
                c = (a + b);
            }else if (s == "-")
            {
                c = (a - b);
            }else if (s == "*")
            {
                c = (a * b);
            }else if (s == "/")
            {
                try
                {
                    c = (a / b);
                    if (c == double.NegativeInfinity || c == double.PositiveInfinity)
                        throw new ArgumentException("Can't divide by zero");
                }
                catch (ArithmeticException e)
                {
                    throw new ArgumentException(e.Message);
                }
            }
            else
            {
                return c;
            }
        }
    }
}

