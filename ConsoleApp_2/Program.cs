// Напишите программу, которая принимает на фход два числа и вычисляет, не является ли одно крвадратом другого.

Console.Write("Введите чило №1:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило №2:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine($"True: число А = {numberA} является квадратом Б = {numberB}");
}
else
{
    Console.WriteLine($"False: число А = {numberA} НЕ является квадратом Б = {numberB}");
}