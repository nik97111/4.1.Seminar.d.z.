// Напишите программу, которая будет выдавать название дни недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите день недели по номеру: ");
int numberDay = int.Parse(Console.ReadLine());

if (numberDay == 3)
{
    Console.WriteLine("Сегодня среда");
}

if (numberDay == 5)
{
    Console.WriteLine("Сегодня пятница");
}

