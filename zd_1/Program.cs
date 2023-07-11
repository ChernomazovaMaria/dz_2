// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
string? a = Console.ReadLine();
if (a is not null && a.Length >= 3) {
    Console.WriteLine("Вторая цифра числа {0}",a[1]);
} else {
    Console.WriteLine("Введено не трехзначное число");
}
