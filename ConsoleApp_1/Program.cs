﻿// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя).

//Запрос числа от пользователя
Console.Write("Введите чило:");
int number = Convert.ToInt32(Console.ReadLine());

//Вычисление квадрата исходного числа
int sqrNumber = number * number;

//Вывод результата на экран
Console.WriteLine($"Квадрат вашего чила = {sqrNumber}");

