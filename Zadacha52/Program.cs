int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            double average = (double)sum / rows;
            Console.WriteLine("Среднее арифметическое элементов столбца " + (j + 1) + ": " + Math.Round(average, 2));
        }