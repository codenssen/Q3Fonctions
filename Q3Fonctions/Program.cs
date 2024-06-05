using System;

class MainClass
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Entrer le premier chiffre : ");
            float number1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Entrer le second chiffre : ");
            float number2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Quelle opération ? (add, substract, multiply, divide, modulo) : ");
            var operation = Console.ReadLine();


            if (operation == "add")
            {
                Console.WriteLine($"{number1} + {number2} = {Add(number1, number1)}");
            } else if(operation == "substract") {
                Console.WriteLine($"{number1} - {number2} = {Substract(number1, number1)}");
            } else if(operation == "multiply") {
                Console.WriteLine($"{number1} * {number2} = {Multiply(number1, number1)}");
            } else if(operation == "divide") {
                if (number2 == 0) {
                    Console.WriteLine("Pas de division par 0...");
                } else
                {
                    Console.WriteLine($"{number1} / {number2} = {Divide(number1, number1)}");
                }
            } else if(operation == "modulo") {
                Console.WriteLine($"{number1} % {number2} = {Modulo(number1, number1)}");
            }
            else
            {
                Console.WriteLine($"{operation} est une opération inconnue !");
            }
        }

    }

    public static float Add(float x, float y)
    {
        return (x + y);
    }
    public static float Substract(float x, float y)
    {
        return (x - y);
    }
    public static float Multiply(float x, float y)
    {
        return (x * y);
    }
    public static float Divide(float x, float y) 
    {
            return (x / y);
    }
    public static float Modulo(float x, float y)
    {
        return (x % y);
    }
}