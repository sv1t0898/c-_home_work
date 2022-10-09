// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 7 -2 -85
// 1 -3 8 -9
// 8 7 -7 9

Console.WriteLine("Задача 47.");

int row1 = new Random().Next(1, 10);
int columns1 = new Random().Next(1, 10);
int minValu1 = new Random().Next(-99, 1);
int maxValu1 = new Random().Next(1, 99);

Console.WriteLine($"m = {row1}, n = {columns1}.");
int[,] array1 = GetArray(row1, columns1, minValu1, maxValu1);
PrintArray(array1); 

Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2

Console.WriteLine("Задача 50.");

Console.Write("Введите номер строки: ");
int posrow = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер колонки: ");
int poscolumn = int.Parse(Console.ReadLine()!);

int rows2 = new Random().Next(3, 11);
int columns2 = new Random().Next(3, 11);
int minVal2 = new Random().Next(-99, 1);
int maxVal2 = new Random().Next(1, 99);


int[,] array2 = GetArray(rows2, columns2, minVal2, maxVal2);
PrintArray(array2); 

if (posrow <= array2.GetLength(0) && poscolumn <= array2.GetLength(1)){
    Console.WriteLine($"i = {posrow}, j = {poscolumn} -> {array2[posrow, poscolumn]}");
}
else{
    Console.WriteLine($"i = {posrow}, j = {poscolumn} -> такого числа в массиве нет");
}

Console.WriteLine();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задача 52.");

int row3 = new Random().Next(3, 10);
int column3 = new Random().Next(3, 10);
int minVal3 = new Random().Next(0, 10);
int maxVal3 = new Random().Next(10, 20);

int[,] array3 = GetArray(row3, column3, minVal3, maxVal3);
double[] arithmetic_mean = GetArithmeticMean(array3);

Console.WriteLine("Задан массив:");
PrintArray(array3);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", arithmetic_mean)}");

Console.WriteLine();

double[] GetArithmeticMean(int[,] array){
    double[] arr = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++){
        int divider = 0;
        for (int j = 0; j < array.GetLength(0); j++){
            arr[i] += array[j, i];
            divider++;
        }
        arr[i] /= divider;
    }
    return arr;
}

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}