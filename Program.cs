// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Задача 19");
Console.Write("Ведите число для проверки, является ли оно палиндромом: ");
int number = int.Parse(Console.ReadLine());
int num = number;
int lennumber = Convert.ToString(number).Length;
int[] numbers = new int[lennumber];

for (int i = 0; i <= lennumber - 1; i++){
    numbers[i] = num % 10;
    num = num / 10;
}

for (int i = 0; i <= lennumber -1; i++){
    if (numbers[i] != numbers[(lennumber - 1) - i]){
        Console.WriteLine($"{number} -> нет");
        break;
    }
    if (i == lennumber - 1){
        Console.WriteLine($"{number} -> Да");
    }
}
Console.WriteLine();

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21");
Console.WriteLine("Введите координату x точки A:");
int ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y точки A:");
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z точки A:");
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x точки B:");
int bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y точки B:");
int by = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z точки B:");
int bz = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2)
    + Math.Pow(az - bz, 2));
Console.WriteLine($"{distance}");
Console.WriteLine();

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 23");
Console.Write("Введите число N, где N определяет вывод кубов от 1 до N: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"{n} -> ");

for (int i = 1; i <= n; i++){
    Console.Write($"{Math.Pow(i, 3)}, ");
}
Console.WriteLine();
