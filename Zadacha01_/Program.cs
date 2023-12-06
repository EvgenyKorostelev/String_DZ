// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.
char [,] Create2dArray(int row, int col)
{
    char [,] array = new char[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = Convert.ToChar(new Random().Next('a', 'z' + 1));
        }
    }
    return array;
}

void Show2dArray(char [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
} 

void NewString(char[,] array)
{
    string newString = "";
    foreach(char item in array)
    {
        newString = newString + item;
    }
    Console.WriteLine(newString);
}


Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int cow =Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
char [,] arr = Create2dArray(row, cow);
Show2dArray(arr);
Console.WriteLine();
NewString(arr);
Console.WriteLine();
