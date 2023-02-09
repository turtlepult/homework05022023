// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

    Console.WriteLine("Enter row value : ");
    int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < num; i++)//row
    {
        for (int j = num; j > i; j--)//spaces
        {
            Console.Write(" ");
        }
        int val = 1;
        for (int j = 0; j <= i; j++)
        {
            Console.Write(val + " ");
            val = val * (i - j) / (j + 1);
        }
        Console.WriteLine();
    }
    Console.ReadLine();
