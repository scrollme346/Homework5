using System;

class Program
{
    static void Main()
    {
        try
        {
            int start = 0, end = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое число:");
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
                    Console.WriteLine("Введите последнее число:");
                    end = Convert.ToInt32(Console.ReadLine());
                    break; // выход из цикла только при корректном вводе
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите корректное число.");
                }
            }

            //переменные для суммы и количества четных, нечетных и чисел, кратных 9
            int sumEven = 0, sumOdd = 0, sumMultipleOf9 = 0;
            int countEven = 0, countOdd = 0, countMultipleOf9 = 0;

            //цикл для обхода чисел от начального до конечного
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)// Проверка на четность
                {
                    sumEven += i;//если четное, добавляем к сумме четных чисел
                    countEven++;//увеличиваем счетчик четных чисел
                }
                else
                {
                    sumOdd += i;//если нечетное, добавляем к сумме нечетных чисел
                    countOdd++;//увеличиваем счетчик нечетных чисел
                }

                if (i % 9 == 0) //проверка на кратность 9
                {
                    sumMultipleOf9 += i;//eсли кратное 9, добавляем к сумме чисел, кратных 9
                    countMultipleOf9++;//увеличиваем счетчик чисел, кратных 9
                }
            }

            //вычисление средних значений для четных, нечетных и чисел, кратных 9
            double avgEven = 0, avgOdd = 0, avgMultipleOf9 = 0;

            if (countEven != 0)
            {
                avgEven = (double)sumEven / countEven;
            }

            if (countOdd != 0)
            {
                avgOdd = (double)sumOdd / countOdd;
            }

            if (countMultipleOf9 != 0)
            {
                avgMultipleOf9 = (double)sumMultipleOf9 / countMultipleOf9;
            }

            Console.WriteLine($"\nСумма четных чисел: {sumEven} \nСреднее арифметическое четных чисел: {avgEven}\n");
            Console.WriteLine($"Сумма нечетных чисел: {sumOdd}\nСреднее арифметическое нечетных чисел: {avgOdd}\n");
            Console.WriteLine($"Сумма чисел, кратных 9: {sumMultipleOf9}\nСреднее арифметическое чисел, кратных 9: {avgMultipleOf9}");

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

