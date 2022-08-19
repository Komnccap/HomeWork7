void task47()
{
    {
        Random random = new Random();
        int rows = random.Next(4, 8);
        int colums = random.Next(4, 8);
        double[,] array = new double[rows, colums];

        FillArray(array);
        PrintArray(array);
    }
    void FillArray(double[,] array)
    {
        int rows = array.GetLength(0);
        int colums = array.GetLength(1);
        Random random = new Random();
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colums; j++)
            {
                array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 2);
            }
        }
    }
    void PrintArray(double[,] array)
    {
        Random random = new Random();
        int rows = array.GetLength(0);
        int colums = array.GetLength(1);

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colums; j++)
            {
                Console.Write(array[i, j]  + "\t");
            }
            Console.WriteLine();
        }
    }
}
//task47();

void task50()
{
    {
        Random random = new Random();
        int rows = random.Next(4, 8);
        int columns = random.Next(4, 8);
        int[,] array = new int[rows, columns];
        FillArray(array);
        PrintArray(array);

        Console.WriteLine("Введите номер строки");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер столбца");
        int column = Convert.ToInt32(Console.ReadLine());

        if (row <= rows && row > 0 && column <= columns && column > 0)
        {
            Console.WriteLine($"Искомые элементы {array[row - 1, column -1]}");
        }
        else
        {
            Console.WriteLine("запрашиваемого элемента не существует");
        }

    }
    void FillArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int colums = array.GetLength(1);
        Random random = new Random();
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colums; j++)
            {
                array[i, j] = random.Next(0,10);
            }
        }
    }
    void PrintArray(int[,] array)
    {
        Random random = new Random();
        int rows = array.GetLength(0);
        int colums = array.GetLength(1);

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colums; j++)
            {
                Console.Write(array[i, j]  + "\t");
            }
            Console.WriteLine();
        }
    }
}
//task50();

void task52()
{
    {
        Random random = new Random();
        int rows = 3;
        int columns = 5;
        int[,] array = new int[rows, columns];
        FillArray(array);
        PrintArray(array);
         
    }
    void FillArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int colums = array.GetLength(1);
        Random random = new Random();
        for(int j = 0; j < colums; j++)
        {
            double sum = 0;
            for(int i = 0; i < rows; i++)
            {
                sum += array [i, j];
            }
            Console.Write(Math.Round(sum/rows, 2));
        }
    }
    void PrintArray(int[,] array)
    {
        Random random = new Random();
        int rows = array.GetLength(0);
        int colums = array.GetLength(1);

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < colums; j++)
            {
                Console.Write(array[i, j]  + "\t");
            }
            Console.WriteLine();
        }
    }
}
task52();
