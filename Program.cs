// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Задача 54");

int row54 = new Random().Next(3, 10);
int columns54 = new Random().Next(3, 10);
int minValue54 = new Random().Next(-99, 0);
int maxValue54 = new Random().Next(0, 99);

int[,] array54 = GetArray(row54, columns54, minValue54, maxValue54);
PrintArray(array54);
SortRow(array54);
Console.WriteLine();
PrintArray(array54);

void SortRow(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int n = 0; n < array.GetLength(1) - 1; n++){
                if (array[i, n] < array[i, n + 1]){
                    int min = array[i, n];
                    array[i, n] = array[i, n + 1];
                    array[i, n + 1] = min;
                }
            }
        }
    }
}

Console.WriteLine();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задача 56");

int row56 = new Random().Next(7, 10);
int columns56 = new Random().Next(3, 5);
int minValue56 = new Random().Next(0, 1);
int maxValue56 = new Random().Next(9, 10);

int[,] array56 = GetArray(row56, columns56, minValue56, maxValue56);
PrintArray(array56);
Console.WriteLine();
Console.WriteLine($"{String.Join(",", MinSumInRow(array56))}"); 

int MinSumInRow(int[,] array){
    // Создаем массив "sum" где будут хранится суммы всех строк двумерного массива.
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            sum[i] += array[i, j];
        }
    }
    // Поиск строки с наименьшей суммой элементов.
    int min = 0;
    for (int n = 0; n < sum.Length; n++){
        if (sum[min] > sum[n]){
            min = n;
        }
    }
    return min+1;  //показываем номер строки, а не индекс то есть считаем строки не с "0" а с "1"
}
Console.WriteLine();

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Задача 58");

int row58 = 2;
int columns58 = 2;
int minValue58 = new Random().Next(0, 1);
int maxValue58 = new Random().Next(9, 10);

int[,] array581 = GetArray(row58, columns58, minValue58, maxValue58);
int[,] array582 = GetArray(row58, columns58, minValue58, maxValue58);
PrintMatrix(array581, array582);
int[,] ar58 = MatrixMult(array581, array582);
PrintArray(ar58);

void PrintMatrix(int[,] array1, int[,] array2){
    for (int i = 0; i < array1.GetLength(0); i++){
        for (int j = 0; j < array1.GetLength(1); j++){
            Console.Write($" {array1[i, j]} ");
        }
        Console.Write(" | ");
        
        for (int j = 0; j < array2.GetLength(1); j++){
            Console.Write($" {array2[i, j]} ");
        }
        Console.WriteLine();
        
    }
}

int[,] MatrixMult(int[,] array1, int[,] array2){
    int[,] array = new int[array1.GetLength(1), array2.GetLength(0)];
    if (array1.GetLength(1) == array2.GetLength(0)){
        //for (int n = 0; n < array.GetLength(0); n++){
            for(int i = 0; i < array1.GetLength(0); i++){
                for (int m = 0; m < array.GetLength(1); m++){
                    for(int j = 0; j < array1.GetLength(1); j++){
                        array[i, m] += array1[i, j] * array2[j, m];
                    }
                }
            }
        //} 
              
    }
    else Console.WriteLine("не согласованы");
    return array;
}
Console.WriteLine();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Задача 60");

int x60 = 2;// new Random().Next(3, 10);
int y60 = 2;//new Random().Next(3, 10);
int z60 = 2;//new Random().Next(3, 10);
int minValue60 = new Random().Next(10, 11);
int maxValue60 = new Random().Next(11, 99);

int[,,] array3d = Get3DArray(x60, y60, z60, minValue60, maxValue60);
Print3DArray(array3d);

int[,,] Get3DArray(int x, int y, int z, int minValue, int maxValue){
    int[,,] array3d = new int[x, y, z];
    int index = (x*y*z);
    int countIter = 0;
    int[] array = new int[index];
    for (int i = 0; i < array3d.GetLength(0); i++){
        for (int j = 0; j < array3d.GetLength(1); j++){
            for (int n = 0; n < array3d.GetLength(2); n++){
                int num = new Random().Next(minValue, maxValue);// 10, index+10); - проверка того что числа рандомные и не повторяются
                for (int m = 0; m < array.Length; m++){
                    if (array[m] == num){
                        num = new Random().Next(minValue, maxValue);// 10, index+10); - проверка того что числа рандомные и не повторяются
                        m = -1;
                    }
                }
                array[countIter] = num;
                countIter++; 
                array3d[i, j, n] = num;//new Random().Next(minValue, maxValue);
            }
        }
    }
    return array3d;
}

void Print3DArray(int[,,] array){
    for (int i = 0; i < array3d.GetLength(0); i++){
        for (int j = 0; j < array3d.GetLength(1); j++){
            for (int n = 0; n < array3d.GetLength(2); n++){
                Console.Write($" {array[j, n, i]}({j},{n},{i}) ");
                
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Задача 62");

PrintArray(SpiralArray());
Console.WriteLine();

int[,] SpiralArray(){
    int[,] array = new int[4, 4];
    int ind = 1;
    int minrow = 0;
    int maxrow = array.GetLength(0) - 1;
    int mincolumns = 0;
    int maxcolumns = array.GetLength(1) - 1;
    while(minrow <= maxrow && mincolumns <= maxcolumns){
        for (int i = mincolumns; i <= maxcolumns; i++){
            array[minrow, i] = ind;
            ind++;
        }
        minrow++;
        for (int j = minrow; j <= maxrow; j++){
            array[j, maxcolumns] = ind;
            ind++;
        }
        maxcolumns--;
        for (int n = maxcolumns; n >= mincolumns; n--){
            array[maxrow, n] = ind;
            ind++;
        }
        maxrow--;
        for (int m = maxrow; m >= minrow; m--){
            array[m, mincolumns] = ind;
            ind++;
        }
        mincolumns++;
    }
    return array;
}

// Рекомендовано решить(задача с семинара)
// Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный 
// и массив с отlсортированными нечетными столбцами

Console.WriteLine("Задача c семинара");

int row0 = new Random().Next(3, 10);
int columns0 = new Random().Next(3, 10);
int minValue0 = new Random().Next(0, 1);
int maxValue0 = new Random().Next(0, 99);

int[,] array0 = GetArray(row0, columns0, minValue0, maxValue0);
PrintArray(array0);
SortColumns(array0);
Console.WriteLine();
PrintArray(array0);

void SortColumns(int[,] array){
    for (int i = 0; i < array.GetLength(1); i+=2){  //нечетный столбцs по номеру, не инндексу - считаем с "1"
        for (int j = 0; j < array.GetLength(0); j++){
            for (int n = 0; n < array.GetLength(0) - 1; n++){
                if (array[n, i] > array[n + 1, i]){
                    int max = array[n, i];
                    array[n, i] = array[n + 1, i];
                    array[n + 1, i] = max;
                }
            }
        }
    }
}

Console.WriteLine();





int[,] GetArray(int row, int columns, int minValue, int maxValue){
    int[,] array = new int[row, columns];
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