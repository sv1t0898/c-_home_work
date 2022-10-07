// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Задача 41");
int[] array = GenArray();
int index = 0;

for (int i = 0; i < array.Length; i++){
    if (array[i] > 0){
        index++;
    }
}

Console.WriteLine($"[{String.Join(",", array)}] -> {index}");

int[] GenArray(){
    Console.Write("Введите значене М: ");
    int[] array = new int[int.Parse(Console.ReadLine()!)];
    Console.WriteLine("Введите ряд чисел: ");
    for (int i = 0; i < array.Length; i++){
        array[i] = int.Parse(Console.ReadLine()!);  
    }
    return array; 
}

Console.WriteLine();

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задача 43");
double[] bk1 = GetCoordinates(1);
double[] bk2 = GetCoordinates(2);
Console.Write($"b1 = {bk1[0]}, k1 = {bk1[1]}, b2 = {bk2[0]}, k2 = {bk2[1]} -> ");
Console.WriteLine($"({String.Join("; ", FindCoordinates(bk1, bk2))})");

double[] GetCoordinates(int index_b_k){
    double[] array = new double[2];
    string xy = "bk";
    for (int i = 0; i < array.Length; i++){
        Console.WriteLine($"Задайте значение {xy[i]}{index_b_k}: ");
        array[i] = double.Parse(Console.ReadLine()!);  
    }
    return array; 
}

double[] FindCoordinates(double[] xy1, double[] xy2){
    double x = (xy1[0] - xy2[0])/((-xy1[1]) - (-xy2[1]));
    double y = xy2[1] * x + xy2[0];
    double[] array = new double[2] {x,y};
    return array;
}

Console.WriteLine();