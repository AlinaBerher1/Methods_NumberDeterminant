class Task4
{
    /* Задание 4
Напишите метод, который будет определять: 
1) является ли введенное число положительным или отрицательным. 
2) Является ли оно простым (используйте технику перебора значений).
3) Делится ли на 2, 5, 3, 6, 9 без остатка. */

    static void PosNeg(double number1)
    {
        if (number1 < 0)
        {
            Console.WriteLine(number1 + " is negative");
        }
        else if (number1 > 0)
        {
            Console.WriteLine(number1 + " is positive");
        }
        else
        {
            Console.WriteLine(number1 + " neither positive nor negative");
        }
    }
    static void PrimeNum (double number1)
    {
        if (number1 >= -2 && number1 <= 2)
        {
            Console.WriteLine(number1 + " is prime number");
        }
        else
        {
            for (double i = 2; i < number1; i++)
            {
                if (number1 % i == 0)
                {
                    Console.WriteLine(number1 + " is not prime number");
                    break;
                }
                else
                {
                    Console.WriteLine(number1 + " is prime number");
                }
            }
        }
    }
    static void Div (double number1)
    {
        if (number1 % 2 == 0 && number1 % 5 == 0 && number1 % 3 == 0 && number1 % 6 == 0 && number1 % 9 == 0)
        {
            Console.WriteLine(number1 + " is divisible by 2, 5, 3, 6, 9 without a remainder");
        }
        else
        {
            Console.WriteLine(number1 + " is divisible by 2, 5, 3, 6, 9 with a remainder");
        }
    }
    static void Main()
    {
        do
        {
            Console.WriteLine("Please enter the number:");
            double number = Convert.ToDouble(Console.ReadLine());
            PosNeg(number);
            Div(number);
            PrimeNum(number);
        }
        while (true);
    }
}