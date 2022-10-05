Console.WriteLine("Программа принимает трехзначное число и выводит вторую цифру. Введите число:");

string input = Console.ReadLine();
int lengthN = input.Length;
int N = int.Parse(input);
int two = ((N / 10) % 10);

if (lengthN != 3) {System.Console.WriteLine("Введенное число не является трехзначным");} else System.Console.WriteLine($"Вторая цифра числа: {two}");