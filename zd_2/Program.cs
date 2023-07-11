// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0) {
    a = a * -1;
}

if (a >= 100) {
    Console.WriteLine ("Третья цифра {0}", a%10);
}
else {
    Console.WriteLine ("Третьей цифры нет");
}