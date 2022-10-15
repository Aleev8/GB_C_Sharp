/* Напишите программу, которая будет выдавать название дня недели по заданному номеру.
 3 -> Среда
 5 -> Пятница */
Console.WriteLine("Введите число соответствующее дню недели:");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if (numberWeek < 1 | numberWeek > 7)
{
    Console.WriteLine("Дней недели всего 7");
}
else
{
    if (numberWeek == 1) Console.WriteLine("Это понедельник");
    if (numberWeek == 2) Console.WriteLine("Это вторник");
    if (numberWeek == 3) Console.WriteLine("Это среда");
    if (numberWeek == 4) Console.WriteLine("Это четверг");
    if (numberWeek == 5) Console.WriteLine("Это же ПЯТНИЦА!");
    if (numberWeek == 6) Console.WriteLine("Это суббота");
    if (numberWeek == 7) Console.WriteLine("Это уже воскресенье");
}