
// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] CreateAndFillMatrix(int lines, int columns)
{
    Random random = new();
    int[,] matrix = new int[lines, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(1,10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}
int[] FiendMinElement(int[,]matrix)
{
    int minInArr= matrix[0,0];
    int[]indexes = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j]<minInArr)
            {
                minInArr = matrix[i,j];
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
return indexes;
}
int[,] RemoveLineColumns(int[,]matrix, int[]minElements)
{
    int[,] ChangeMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
   for (int i = 0, j=0; i < matrix.GetLength(0); i++)
   {
        if(i==minElements[0])
            continue;

    for (int k = 0, u=0; k < matrix.GetLength(1); k++)
    {
        if(k==minElements[1])
            continue;
        ChangeMatrix[j,u] = matrix[i,k];
        u++;
    }
    j++;
   }
   
     return ChangeMatrix;
}

   


int lines = new Random().Next(3,6);
int columns = new Random().Next(3,6);
int[,]Arr=CreateAndFillMatrix(lines, columns);
PrintMatrix(Arr);
Console.WriteLine();
int[] index = FiendMinElement(Arr);
int[,]ChangeMatrix = RemoveLineColumns(Arr, index);
PrintMatrix(ChangeMatrix);