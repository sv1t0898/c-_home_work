// Все массивы от 5-ти элементов

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задача 34");
int[] array1 = GetArray(15, 100, 999);
Console.WriteLine($"[{String.Join(",", array1)}] -> {ParytiCheck(array1)}");

int ParytiCheck(int[] array){
    int index = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            index++;
        }
    }
    return index;
}
Console.WriteLine();


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задача 36");
int[] array2 = GetArray(7, -11, 99); //new int[4] {-4, -6, 89, 6};
Console.WriteLine($"[{String.Join(",", array2)}] -> {SumElements(array2)}");

int SumElements(int[] array){
    int conclusion = 0;
    for (int i = 1; i < array2.Length; i += 2){
        conclusion += array2[i]; 
    }
    return conclusion;
}
Console.WriteLine();


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задача 38");
int[] array3 = GetArray(10, 1, 99); //new int[5] {3, 7, 22, 2, 78};
int[] minmax = SearchMinMax(array3);

//Console.WriteLine($"[{String.Join(",", minmax)}]");
Console.WriteLine($"[{String.Join(",", array3)}] -> {minmax[1] - minmax[0]}");

int[] SearchMinMax(int[] array){
    int[] minmax = new int[2] {array[1], array[1]};
    for (int i = 0; i < array.Length; i++){
        if (minmax[0] > array[i]){
            minmax[0] = array[i];
        }
        else if (minmax[1] < array[i]){
            minmax[1] = array[i];
        }
    }
    return minmax;
}
Console.WriteLine();

int[] GetArray(int size, int minValue, int maxValue){
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}