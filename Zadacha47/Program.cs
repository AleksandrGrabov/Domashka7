Console.WriteLine("Введите количество строк m:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов n:");
        int n = int.Parse(Console.ReadLine());

        double[,] array = new double[m, n];

        Random random = new Random(); 

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = Math.Round(random.NextDouble() * 20 - 10, 2); 
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

    