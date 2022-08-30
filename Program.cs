//написать программу, которая создаст двумерный массив размером m * n, заполненный случайными числами
/*
int[,] RandomArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            result[i, j] = new Random().Next(0, 100);
    return result;
}

int Size(string str)
{
    int result;
    Console.WriteLine($"Input size {str}");
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void ShowArray(int[,] array, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            Console.Write($"array[{i},{j}] = {array[i, j]}; ");
        Console.WriteLine();
    }
}

int m = Size("m");
int n = Size("n");
ShowArray(RandomArray(m, n), m, n);
*/

//задать двумерный массив m*n каждый элемент массива которого находится по формуле a[i,j] = i + j
/*
int[,] CreatArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            result[i, j] = i + j;
    return result;
}

int Size(string str)
{
    int result;
    Console.WriteLine($"Input size {str}");
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void ShowArray(int[,] array, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            Console.Write($"array[{i},{j}] = {array[i, j]}; ");
        Console.WriteLine();
    }
}

int m = Size("m");
int n = Size("n");
ShowArray(CreatArray(m, n), m, n);
*/

//задать двумерный массив, найти элементы, у которых оба индекса четные и заменить эти элементы в квадрат

/*
int[,] RandomArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            if (i % 2 == 0 && j % 2 == 0)
                result[i, j] = Convert.ToInt32(Math.Pow(new Random().Next(0, 100), 2));
            else
                result[i, j] = new Random().Next(0, 100);
    return result;
}

int Size(string str)
{
    int result;
    Console.WriteLine($"Input size {str}");
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void ShowArray(int[,] array, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            Console.Write($"array[{i},{j}] = {array[i, j]}; ");
        Console.WriteLine();
    }
}

int m = Size("m");
int n = Size("n");
ShowArray(RandomArray(m, n), m, n);
*/

//задать двумерный массив, найти сумму элементов, находящихся на главной диагонали (i == j)

int SummElements(int[,] arr, int m, int n)
{
    int result = 0;
    if (m < n)
        for(int i = 0; i < m; i++)
            result += arr[i,i];
    else
        for(int i = 0; i < n; i++)
            result += arr[i,i];
    return result;
}

int[,] RandomArray(int m, int n)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            result[i, j] = new Random().Next(0, 100);
    return result;
}

int Size(string str)
{
    int result;
    Console.WriteLine($"Input size {str}");
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void ShowArray(int[,] array, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            Console.Write($"array[{i},{j}] = {array[i, j]}; ");
        Console.WriteLine();
    }
}

int m = Size("m");
int n = Size("n");
int[,] arr = RandomArray(m, n);
ShowArray(arr, m, n);
Console.WriteLine($"Summ elements is {SummElements(arr, m, n)}");