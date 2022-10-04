// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные 
// числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое положительное число: ");
int N = int.Parse(Console.ReadLine());

int count = 0;
while (count <= N) {
    if ((count % 2) == 0) {
    Console.WriteLine(count);
    }
    count++;
}

// int count = 0;
// while (count <= N) {
//     if ((count % 2) == 0) {
//     Console.Write(count + ", ");
//     }
//     count++;
// }

