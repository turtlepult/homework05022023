// Найти произведение двух матриц
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

int lines = 3;
int columns = 3;
int[,]Arr1=CreateAndFillMatrix(lines, columns);
Console.WriteLine("matrix1: ");
PrintMatrix(Arr1);

int[,]Arr2=CreateAndFillMatrix(lines, columns);
Console.WriteLine("matrix 2: ");
PrintMatrix(Arr2);

int[,] arrsum = new int[3,3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        arrsum[i,j] = Arr1[i,j]*Arr2[i,j];
    }
}
Console.WriteLine("result matrix: ");
PrintMatrix(arrsum);