// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Задача 10.");
Console.WriteLine("Введите число: ");

int num1 = Convert.ToInt32(Console.ReadLine());
int b = num1 / 10;
int a = b % 10;

Console.WriteLine($"{num1} -> {a}");
Console.WriteLine("");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Задача 13.");
Console.WriteLine("Введите число");

int num2 = Convert.ToInt32(Console.ReadLine());
string l = Convert.ToString(num2);
int len = l.Length;

if (l.Length >= 3){
    Console.WriteLine($"{num2} -> {l[2]}");
}
else{
    Console.WriteLine("третьей цифры нет");
}
Console.WriteLine("");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Задача 15.");
Console.WriteLine("Введите цифру обозначающую день недели: ");

string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

int num3 = Convert.ToInt32(Console.ReadLine());
if (num3 <= 7 && num3 >= 1){
    if(num3 <= 5 && num3 >= 1){
        Console.WriteLine($"{week[num3 - 1]} - это будни");
    }
    else{
        Console.WriteLine($"{week[num3 - 1]} - это выходной");
    }
}
else{
    Console.WriteLine($"{num3}? Нет столько дней в недели");
}
Console.WriteLine("");