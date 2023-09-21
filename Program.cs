using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Ошибка ввода. Введите положительное целое число.");
            return;
        }

        Console.Write("Четные числа от 1 до {0}: ", n);

        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i);

            // Если это не последнее четное число, добавляем запятую и пробел
            if (i < n - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine(); // Переход на новую строку для читаемос
    }
}
