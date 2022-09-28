//ВСЕ ЗАДАЧИ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Задача 25");
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{A} в степени - {B} -> {PowConv(A, B)}");

int PowConv(int a, int b){
    return (int)Math.Pow(a, b);
}
Console.WriteLine();


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача 27");
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{num} -> {SumNum(num)}");

int SumNum(int a){
    int b = a;
    int sum = 0;
    for(int i = 1; b != 0; i++){
        sum = sum + (b%10);
        b = b/10;
    }
    return sum;
}   
Console.WriteLine();


// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Задача 29");
Console.WriteLine($" -> [{String.Join(", ", GenArray())}]");

int[] GenArray(){
    int[] a = new int[8];
    for(int i = 0; i < a.Length; i++){
        //Console.Write($"{i}/{a.Length}.Введите рандомный элемент для добавления в массив:");
        //int num = int.Parse(Console.ReadLine()!);
        int num = new Random().Next(0, 100);
        a[i] = num;
    }
    Console.Write($"{String.Join(", ", a)}");
    return (int[])a;
}
Console.WriteLine();
