﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру обожначающую день недели");
 int a = Convert.ToInt32(Console.ReadLine());
 if (a >=1 && a <=5) {
    Console.WriteLine ("{0} день недели является рабочим", a);
 }
 else if (a == 6 || a == 7) {
    Console.WriteLine ("{0} день недели является выходным", a);
 }
 else {
    Console.WriteLine ("цифра не обозначает день недели");
 }

 