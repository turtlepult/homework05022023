//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
int[, ,] matrix = new int[3,3,3];
int fill = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = fill;
                fill++;
            }
        }
    }

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]} ({i}, {j}, {k}) \t");
            }
           Console.WriteLine();
        }
Console.WriteLine();
    }



