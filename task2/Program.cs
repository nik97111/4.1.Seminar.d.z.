// Напишите программу, которая будет выдавать название дни недели по заданному номеру
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите день недели по номеру: ");
int number = int.Parse(Console.ReadLine());

if (number == 3)
{
    Console.WriteLine("Сегодня среда");
}

if (number == 5)
{
    Console.WriteLine("Сегодня пятница");
}

