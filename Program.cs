Console.Clear();
Console.WriteLine("Введите размер двухмерного массива");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);

int[,] arr = GetArray(m, n, 0, 10);
PrintArray(arr);
Console.WriteLine();
int[,] arr2 = ArrangeLine(arr);
PrintArray(arr2);

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
     int[,] result = new int[m, n];
     for (int i = 0; i < m; i++)      
     {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);  
        }              
     }
     return result;
}

int[,] ArrangeLine(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++)
    {   
        for(int j = 0; j < Array.GetLength(1); j++)
        {   for(int k = 0; k < Array.GetLength(1) - 1; k++)
            {
                if(Array[i, k] < Array[i, k + 1]) 
                {   
                    int min = Array[i, k];
                    Array[i, k] = Array[i, k + 1];
                    Array[i, k + 1] = min;
                }
            }    
        }
    }
    return Array;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}