using System;

class Program
{
    static void Main()
    {
        int start, end;
        try
        {
            while (true)//бесконечный цикл для коректного ввода
            {
                
                Console.WriteLine("Введите первое число диапазона:");
                if (int.TryParse(Console.ReadLine(), out start))
                {
                    break; // Прерывание цикла при успешном вводе числа
                }
                else
                {
                    Console.WriteLine("Введите корректное число.");
                }
                
            }

            while (true)
            {
                Console.WriteLine("Введите последнее число диапазона:");
                if (int.TryParse(Console.ReadLine(), out end))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректное число.");
                }
                
            }

            Console.WriteLine($"Все числа в диапазоне от {start} до {end}:");
            for (int i = start; i <= end; i++)//условия при которых цикл завершится
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Числа в убывающем порядке :");
            for (int i = end; i >= start; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Числа кратные 7:");
            for (int i = start; i <= end; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            int count5 = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    count5++;
                }
            }
            Console.WriteLine($"Количество чисел кратных 5 : {count5}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Результат операции слишком большой для данного типа данных");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);
        }


    }
}
