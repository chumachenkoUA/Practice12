class Program
{
    static void Main()
    {
        Console.WriteLine("Лабораторна робота 12. Обробка виключень. Поділ дійсних чисел");
        double numerator = 0, denominator = 0;
        string input;
        bool validInput = false;
        
        while (!validInput)
        {
            Console.Write("Введіть чисельник: ");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Помилка: не введено число!");
                continue;
            }

            if (input.Length > 15)
            {
                Console.WriteLine("Помилка: введено надто довге число!");
                continue;
            }

            try
            {
                numerator = Convert.ToDouble(input);
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: помилка перетворення (невірний формат числа)!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Помилка: помилка перетворення (значення занадто велике або мале)!");
            }
        }

        validInput = false;
        
        while (!validInput)
        {
            Console.Write("Введіть знаменник: ");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Помилка: не введено число!");
                continue;
            }

            if (input.Length > 15)
            {
                Console.WriteLine("Помилка: введено надто довге число!");
                continue;
            }

            try
            {
                denominator = Convert.ToDouble(input);
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: помилка перетворення (невірний формат числа)!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Помилка: помилка перетворення (значення занадто велике або мале)!");
            }
        }
        
        try
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            double result = numerator / denominator;
            Console.WriteLine($"Результат: {numerator} / {denominator} = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Помилка: розподіл на нуль!");
        }
    }
}