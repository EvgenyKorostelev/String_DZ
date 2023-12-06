// Задайте произвольную строку. Выясните, является ли она палиндромом.
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
string IsPalindrome(string str)
{
    for(int i = 0; i<str.Length/2; i++)
    {
        int convStart = Convert.ToInt32(str[i]);
        int convEnd = Convert.ToInt32(str[str.Length-i-1]);
        if(convStart != convEnd)
        {
            return("String is not palindrome");
        }
    }
    return("String is palindrome");
}

Console.WriteLine();
Console.Write("Введите строку: ");
string str = Console.ReadLine()!;
Console.WriteLine(str);
Console.WriteLine(IsPalindrome(str));
Console.WriteLine();