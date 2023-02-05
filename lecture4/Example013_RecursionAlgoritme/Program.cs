Console.Clear();

string[,] table = new string[2, 5];
// String.Empty
// table [0,0] table [0,1] table [0,2] ... table [0,4]
// table [1,0] table [1,1] table [1,2] ... table [1,4]
for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        System.Console.Write($"-{table[rows, colums]}-|");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
System.Console.WriteLine("-----------------------next example-------------------------");
System.Console.WriteLine();

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);

System.Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

System.Console.WriteLine();
System.Console.WriteLine("-----------------------next example-------------------------");
System.Console.WriteLine();

int[,] pic = new int[,]
{
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0},
    {0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0)
            {
                System.Console.Write(" ");
            }
            else
            {
                System.Console.Write("+");
            }
        }
        System.Console.WriteLine();
    }
}

PrintImage(pic);

System.Console.WriteLine();
System.Console.WriteLine("-----------------------next example-------------------------");
System.Console.WriteLine();

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}

FillImage(5, 5);
PrintImage(pic);

System.Console.WriteLine();
System.Console.WriteLine("-----------------------next example-------------------------");
System.Console.WriteLine();

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}

System.Console.WriteLine();
System.Console.WriteLine("-----------------------next example-------------------------");
System.Console.WriteLine();

double Fibonachi(int n)
{
    if (n == 1 || n==2) return 1;
    else return Fibonachi(n-1)+Fibonachi(n-2);
}

for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"F{i}! = {Fibonachi(i)}");
}