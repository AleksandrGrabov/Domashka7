int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        }; 

        Console.WriteLine("Введите номер строки:");
        int row = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите номер столбца:");
        int column = int.Parse(Console.ReadLine());

        if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        {
            Console.WriteLine($"Значение элемента: {array[row, column]}");
        }
        else
        {
            Console.WriteLine("такого числа в массиве нет");
        }
