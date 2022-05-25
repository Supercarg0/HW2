/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Enter the number of the day of the week: ");
sbyte Number = Convert.ToSByte(Console.ReadLine());
if (Number == 6 || Number == 7)
{
    Console.WriteLine($"{Number} -> yes!");
}
else if (Number > 0 && Number < 6)
{
    Console.WriteLine($"{Number} -> no!");
}
else
{
    Console.WriteLine("Input error! There are only 7 days in a week!");
}
