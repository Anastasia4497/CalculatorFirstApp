namespace CalculatorFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math ops: \n");
            int a = 255 + 235;
            int b = 1248 * 1248;
            int c = 10 / 5;
            int d = 2022 - 1970;
            int e = 89876 + 4;
            int f = 329 * 67;
            int g = 5 / 5;
            int h = 370000 - 370000;
            int i = 10 / 7;
            int modulus = 10 % 7;
            var divide = 10.0d / 7.0d;
            Console.WriteLine("Результат сложения 255 и 235 = " + a);
            Console.WriteLine("Результат умножения 1248 на 1248 = " +b);
            Console.WriteLine("Результат деления 10 на 5 = " + c);
            Console.WriteLine("Результат вычитания 2022 на 1970 = " + d);
            Console.WriteLine("Результат сложения 89876 и 4 = " + e);
            Console.WriteLine("Результат умножения 329 на 67 = " + f);
            Console.WriteLine("Результат деления 5 на 5 = " + g);
            Console.WriteLine("Результат вычитания 370000 на 370000 = " + h);
            Console.WriteLine("Результат деления 10 на 7 = " + i);
            Console.WriteLine("Результат деления 10 на 7 по модулю = " + modulus);
            Console.WriteLine("Результат деления 10 на 7 = " + divide);
            string userInput = Console.ReadLine();


        }
    }
}

