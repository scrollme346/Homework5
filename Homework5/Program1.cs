;

class Program
{
    static void Main()
    {
        int start = 0, end = 0;

        while (true)
        {
            try
            {
                Console.WriteLine("Введите первое число диапазона:");
                start = Convert.ToInt32(Console.ReadLine());
                break; // выход из цикла только при корректном вводе
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите корректное число.");
            }
        }

        while (true)
        {
            try
            {
                Console.WriteLine("Введите последнее число диапазона:");
                end = Convert.ToInt32(Console.ReadLine());
                break; // выход из цикла только при корректном вводе
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите корректное число.");
            }
        }

        Console.WriteLine($"Все числа в диапазоне:");
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine($"Числа в убывающем порядке:");
        for (int i = end; i >= start; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine($"Числа кратные 7:");
        for (int i = start; i <= end; i++)
        {
            if (i % 7 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine("\n");

        int count5 = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                count5++;
            }
        }
        Console.WriteLine($"Количество чисел кратных 5: {count5}");
    }
}

