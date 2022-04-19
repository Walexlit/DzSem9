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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Print(matrix);