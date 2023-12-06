// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку,
// в которой все заглавные буквы заменены на строчные.
Console.Write("Введите строку: ");
string beforeString = Console.ReadLine()!;
string afterString  = beforeString.ToLower();
Console.WriteLine($"Измененная строка: {afterString}");