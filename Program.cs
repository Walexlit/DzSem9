//Задача 62: Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру).

int dlin = 4;
int[,] matrix = new int[dlin, dlin];
int a = 0;
int b = 0;
for (int i = 1; i <= dlin * dlin; i++)
{
    matrix[a, b] = i;
    if (a <= b + 1 && a + b < dlin-1 )
    {
        b++;
    }
    else if (a < b && a + b >= dlin - 1)
    {
        a++;
    }
    else if (a >= b && a + b > dlin - 1)
    {
        b--;
    }
    else
    {
        a--;
    }
}

void Print(int[,] matr)
{
    for (int c = 0; c < matr.GetLength(0); c++)
    {
        for (int d = 0; d < matr.GetLength(1); d++)
        {
            Console.Write($" {matr[c, d]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Print(matrix);