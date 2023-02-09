// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.WriteLine("Enter row value : ");
int num = int.Parse(Console.ReadLine()??"0");
int[][]mass = new int[num][];

for (int i = 0; i < mass.Length; i++)
{
    int[] result = new int[i+1];
        for (int j = 0; j <= i; j++)
        {
            if (j!=0&&j!=i)
            {
                result[j] = mass[i-1][j-1]+mass[i-1][j];
            }
            else
            {
                result[j] = 1;
            }
        }
    mass[i] = result;
}
Console.Clear();
foreach (var item in mass)
{
    foreach(var item1 in item)
        Console.Write($"{item1} ");
    Console.WriteLine();
}