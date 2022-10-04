// Напишите программу, которая на вход принммает число и выдает, является ли число четным 
// (делится ли оно без остатка).

Console.WriteLine("Введите первое число: ");
int number = int.Parse(Console.ReadLine());

if ((number % 2) == 0) {
    Console.WriteLine("Число является четным");
} else {
    Console.WriteLine("Число не является четным");
}