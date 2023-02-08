/*                                                              О д н о м е р н ы й      м а с с и в
int[]array = new int[10];
Random random = new();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1,10);
}
foreach (var item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Array.Sort(array);
foreach (var item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
int count = 1;
int temp = 1;

for (int i = 0; i < array.Length; i=i+temp)
{
    temp = 1;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[i]==array[j])
            {
                count++;
                temp = count;
            }
        }
    Console.WriteLine($"{array[i]} встречается {count} раз");
    count = 1;
}
*/
/*                                                                             Т а б л и ц а        
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

int lines = new Random().Next(3,4);
int columns = new Random().Next(3,4);
int[,]Arr=CreateAndFillMatrix(lines, columns);
PrintMatrix(Arr);
Console.WriteLine();
int[] structura = new int[lines*columns];
int ch = 0;
for (int i = 0; i < Arr.GetLength(0); i++) //переводим в простой массив
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            structura[ch] = Arr[i,j];
            ch++;
        }
    }
Array.Sort(structura);
int count = 1;
int temp = 1;

for (int i = 0; i < structura.Length; i=i+temp)
{
    temp = 1;
        for (int j = i+1; j < structura.Length; j++)
        {
            if (structura[i]== structura[j])
            {
                count++;
                temp = count;
            }
        }
    Console.WriteLine($"{structura[i]} встречается {count} раз");
    count = 1;
}
*/
/*                                                                  Ч а с т о т н ы й      А н а л и з*/
