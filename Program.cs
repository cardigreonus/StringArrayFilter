using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ввод строк с клавиатуры
        Console.WriteLine("Add:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        // Создание списка для выходного массива
        List<string> outputList = new List<string>();

        // Проход по входному массиву и добавление строк длиной <= 3
        foreach (string str in inputArray)
        {
            if (str.Trim().Length <= 3)
            {
                outputList.Add(str.Trim());
            }
        }

        // Вывод выходного массива
        Console.WriteLine("Output Array: " + string.Join(", ", outputList));
    }
}
