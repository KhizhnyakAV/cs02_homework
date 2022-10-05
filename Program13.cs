Console.WriteLine("Программа выводит третью цифру. Введите число:");

string input = Console.ReadLine();

if (input.Length < 3) {System.Console.WriteLine("Третьей цифры нет");} else System.Console.WriteLine($"Третья цифра числа: {input[2]}");
