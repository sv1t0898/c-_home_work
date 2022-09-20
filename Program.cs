//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Задача 2.");
Console.WriteLine("Ведите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine($"число А({numA}) больше чем число B({numB})");
}
else if (numB > numA)
{
    Console.WriteLine($"число B({numB}) больше чем число A({numA})");
}
else
{
    Console.WriteLine($"Числа A и В равны({numB} = {numA})");
}

Console.WriteLine($"");

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача 4.");

//int z = new int[3];
Console.WriteLine("Введите число 1: ");
int max = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (max < b){
    max = b;
}
if (max < c){
    max = c;
}

Console.WriteLine($"Максимальное число - {max}");

Console.WriteLine($"");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Задача 6.");
Console.WriteLine("Ведите число, для проверки четности: ");
int number = Convert.ToInt32(Console.ReadLine());

if (numA % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("нечетное");
}
Console.WriteLine($"");


// Задача 8: Напишите программу, которая на вход принимает число (N), а 
//на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Задача 8.");
Console.WriteLine("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());
int index = 0;

Console.Write($"{N} -> ");

while(index < N - 1){
    Console.Write($"{index = index + 2}, ");    
}
Console.WriteLine($"");