// Напишите программу, которая принимает на вход три числа и выдает максимальное из этич чисел
// 2, 3, 7 -> 7
//44, 5, 78 -> 78
// 22, 3, 9 -> 9

Console.WriteLine("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberThree = int.Parse(Console.ReadLine());

if (numberOne > numberTwo && numberOne > numberThree) {
    Console.WriteLine("Первое число больше, чем второе и третье");
} else if (numberTwo > numberOne && numberTwo > numberThree) {
    Console.WriteLine("Второе число больше, чем первое и третье");
} else if (numberThree > numberOne && numberThree > numberTwo) {
    Console.WriteLine("Третье число больше, чем первое и второе");
}  else {
    Console.WriteLine("Все введенные числа одинаковы. Введите другие числа");
}