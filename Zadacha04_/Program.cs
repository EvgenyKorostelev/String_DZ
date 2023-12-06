// Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.
char[,] CrateArray(string str)
{
   int countI = 0;
   int countJ = 0;
   int tempJ = 0;
   char space = ' ';
   for (int i = 0; i < str.Length; i++)
   {
        if(str[i] != space) tempJ++;
        else
        {
            if(countJ < tempJ) countJ = tempJ;
            tempJ = 0;
            countI++;
        }
   }
   countI++;
   //Console.WriteLine(countI);
   //Console.WriteLine(countJ);


   char [,] chars = new char[countI,countJ];
   int m = 0;
   for (int i = 0 ; i < countI; i++)
   {
        for (int j = 0; j < countJ; j++)
        {
            if(str[m] != space)
            {
                chars [i,j] = str[m];
                m++;
            }
        }
        m++;
   }
   return chars;
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

void Changeling(char [,] array)
{
    string newStr = "";
    for (int i = array.GetLength(0) - 1; i >= 0; i--)
    {
        int m = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newStr = newStr + array[i,j];
            m = j;
        }
         
        if(i != 0 || m != array.GetLength(1) - 1)
        { 
        newStr = newStr + ' ';
        }
    }
    Console.Write(newStr);
}


Console.WriteLine();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
char [,] arr = CrateArray(str);
//Show2dArray(arr);
Console.Write("Перевернутая строка: ");
Changeling(arr);
Console.WriteLine();
