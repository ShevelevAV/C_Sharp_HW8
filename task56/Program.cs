/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] SumRows(int[,] SR)
{
    int[] res = new int[SR.GetLength(0)];
    for (int i = 0; i < SR.GetLength(0); i++)
    {
        for (int j = 0; j < SR.GetLength(1); j++)
        {
            res[i]= res[i]+SR[i,j];
        }
    }
    return res;
}
void MinSumRows(int[]ISR)
{
    int i = 0;
    int min = ISR[i];
    while (i<ISR.Length)
    {
        if(min > ISR[i])
        {
            min = ISR[i];
        }
        i++;
    }
    for(i=0; i<ISR.Length;i++)
    {
        if(ISR[i]==min)
        {
         Console.WriteLine($"Наименьшая сумма элементов в строке {i+1}");   
        }
    }
}
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
MinSumRows(SumRows(array));
