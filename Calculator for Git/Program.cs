namespace Calculator_for_Git
{
    using static System.Console;
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int operation;

            WriteLine("Enter your first number");
            num1 = int.Parse(ReadLine());
            WriteLine("Enter your second number");
            num2 = int.Parse(ReadLine());

            WriteLine("Select an operation. Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division.");
            operation = int.Parse(ReadLine());
            double answer;
            if (operation == 1)
            {
                answer = num1 + num2;
                WriteLine("The answer is: " + answer);
            }

            if (operation == 2)
            {
                answer = num1 - num2;
                WriteLine("The answer is: " + answer);
            }

            if (operation ==3)
            {
                answer = num1 * num2;
                WriteLine("The answer is: " + answer);
            }

            else
            {
                double div1 = (double)num1;
                double div2 = (double)num2;
                answer = div1 / div2;
                WriteLine("The answer is: " + answer);
            }
        }
    }
}