// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задача 64");
Console.WriteLine("Введите число: ");
int n64 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"N = {n64} -> {FindN(n64)}");

string FindN(int n){
    if (n == 0) return String.Empty;
    else return $"{n}"+ ", " + FindN(n-1);
    
}
Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задача 66");
Console.WriteLine("Задайте значение M: ");
int m66 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте значение N: ");
int n66 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"M = {m66}; N = {n66}. -> {Sum(m66, n66)}");

int Sum(int m, int n){
    if (m > n) return 0;
    else return n + Sum(m, n-1);
    
}
Console.WriteLine();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Задача 68");
Console.WriteLine("Задайте значение m: ");
int m68 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте значение n: ");
int n68 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"m = {m68}, n = {n68} -> A(m,n) = {A(m68, n68)}");

int A(int m, int n){

    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return A(m-1, 1);
    
    return A(m - 1, A(m, n -1));
}

Console.WriteLine();