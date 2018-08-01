using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("Calculator");

            //In this line I am asking the user to input a number.
            Console.Write("First number: ");

            //Now, I am assigning the number to a variable called firstNumber.
            string firstNumber = Console.ReadLine();

            //In this line I am asking the user to input another number.
            Console.Write("Second number: ");

            //Now, I am assigning the second number to a variable called secondNumber.
            string secondNumber = Console.ReadLine();

            //Here, I am asking the user what they would like to do with their two numbers.
            Console.Write("add, subtract, multiply, or divide: ");

            //Now, I am assigning the mathmatical operation to a variable called operation.
            string operation = Console.ReadLine();

            //A new variable is declared.
            int expression = 0;
         
            //Here, I am changing the two numbers given by the user from strings to integers.
            int first = int.Parse(firstNumber);
            int second = int.Parse(secondNumber);

            //Here, I am telling the console to calculate a specific expression if the user requests that specific operation.
            if (operation == "add")
                expression = first + second;
            else if (operation == "subtract")
                expression = first - second;
            else if (operation == "multiply")
                expression = first * second;
            else if (operation == "divide")
                expression = first / second;

            //Finally, I am printing the expression to the console.
            Console.WriteLine(expression);
            Console.ReadLine();
       
  
                











        }
    }
}
