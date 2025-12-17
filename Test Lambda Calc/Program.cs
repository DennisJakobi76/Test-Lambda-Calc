namespace Test_Lambda_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter  the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Calculator calculator = new Calculator();

            // Addition mit Lambda-Ausdruck
            calculator.calculate(num1, num2, (x, y) => Console.WriteLine($"Addition: {x} + {y} = {x + y}"));

            // Subtraktion mit Lambda-Ausdruck
            calculator.calculate(num1, num2, (x, y) => Console.WriteLine($"Subtraktion: {x} - {y} = {x - y}"));

            // Multiplikation mit Lambda-Ausdruck
            calculator.calculate(num1, num2, (x, y) => Console.WriteLine($"Multiplikation: {x} * {y} = {x * y}"));

            if (num2 == 0)
            {
                Console.WriteLine("Division durch Null ist nicht erlaubt.");
            }
            else
            {
                // Division mit Lambda-Ausdruck
                calculator.calculate(num1, num2, (x, y) => Console.WriteLine($"Division: {x} / {y} = {x / y}"));
            }

            Console.ReadLine();
        }
    }
}
