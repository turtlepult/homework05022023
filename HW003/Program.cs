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
int[,] RemoveLineColumns(int[,]matrix, int[]minElements, int lines, int columns)
{
    int[,]ChangeMatrix = new int[lines-1, columns-1];
    for (int i = 0; i < ChangeMatrix.GetLength(0); i++)
    {
        if (i<minElements[0]||i>minElements[0])
        {
            for (int j = 0; j < ChangeMatrix.GetLength(1); j++)
            {
                if (j<minElements[1]||j>minElements[1])
                {
                    ChangeMatrix[i,j] = matrix[i,j];
                    
                }
            }
            
        }
    }
    return ChangeMatrix;
}

int lines = new Random().Next(3,6);
int columns = new Random().Next(3,6);
int[,]Arr=CreateAndFillMatrix(lines, columns);
PrintMatrix(Arr);
Console.WriteLine();
int[] index = FiendMinElement(Arr);
foreach (var item in index)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
int[,]ChangeMatrix = RemoveLineColumns(Arr, index, lines,columns);
PrintMatrix(ChangeMatrix);