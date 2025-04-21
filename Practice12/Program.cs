namespace Practice12
{
class Program
{
    static double Divide(double a, double b)
    {
        if (b == 0) 
            throw new Exception("розподіл на нуль");
        return a / b;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Лабораторна робота 12. Обробка винятків. Поділ дійсних чисел");

            // Ввід чисельника
            Console.Write("Введіть чисельник: ");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Треба ввести число!!!");
            if (input.Length > 15)
                throw new Exception("введено надто довге число");

            double numerator;
            try
            {
                numerator = Convert.ToDouble(input);
            }
            catch
            {
                throw new Exception("помилка перетворення");
            }

            // Ввід знаменника
            Console.Write("Введіть знаменник: ");
            input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                throw new Exception("Треба ввести число!!!");
            if (input.Length > 15)
                throw new Exception("введено надто довге число");

            double denominator;
            try
            {
                denominator = Convert.ToDouble(input);
            }
            catch
            {
                throw new Exception("помилка перетворення");
            }

            // Виконання ділення
            double result = Divide(numerator, denominator);
            Console.WriteLine($"Результат ділення = {result}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Помилка: {0}", e.Message);
        }
    }
}    
}
