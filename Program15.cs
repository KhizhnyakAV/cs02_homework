// See https://aka.ms/new-console-template for more information
Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным");

string input = Console.ReadLine();
int N = int.Parse(input);

if ((N == 6) || (N == 7)) {System.Console.WriteLine("Да");} else System.Console.WriteLine("Нет");