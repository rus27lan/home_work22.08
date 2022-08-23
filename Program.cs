// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

void PrintArray() 
{
    int[,] array = new int[,]{ { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
    int rows = array.GetUpperBound(0) + 1;    // количество строк
    int columns = array.Length / rows;  //количество столбцов
    int count;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int ij = j+1; ij<columns; ij++)
            {
                if (array[i,j]>array[i,ij])
                {
                    count = array[i,j];
                    array[i,j] = array[i,ij];
                    array[i,ij] = count;
                }
            }
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
PrintArray();



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void PrintArray() 
// {
//     int[,] array = new int[,]{ { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } , {5, 2 ,6 ,7 } };
//     int rows = array.GetUpperBound(0) + 1;    // количество строк
//     int columns = array.Length / rows;  //количество столбцов
//     int [] numbers = new int [rows];  // создаем массив для хранения сумм элементов в каждой строке 
//     int count = 0;
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             numbers[count] = numbers[count] + array[i,j];
//             Console.Write($"{array[i, j]} \t");
//         }
//         Console.WriteLine();
//         count ++;
//     }
//     int min = 1; 
//     int MinNumbers = numbers[0];
//     for (int i = 0; i < numbers.Length; i++)  // перебераем суммы элементов и находим наименьшее 
//     {
//         if(MinNumbers>numbers[i])
//         {
//             MinNumbers = numbers[i]; 
//             min ++;
//         }
//     }
//     Console.WriteLine($"{min} строка ");
// }
// PrintArray();


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

// void PrintArray()
// {
//     int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
//     int[,] arrayTwo = new int[,] { { 1, 5, 8, 5 }, { 4, 9, 4, 2 }, { 7, 2, 2, 6 }, { 2, 3, 4, 7 } };
//     int rows = array.GetUpperBound(0) + 1;    // количество строк
//     int columns = array.Length / rows;  //количество столбцов

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(array[i, j] * arrayTwo[i,j]);
//             Console.Write($"\t");
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray();



// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4     1     2
// 12 13 14 5     6     3
// 11 16 15 6     5     4
// 10 9  8  7

// int n = 4;
// int[,] array = new int[n, n];
// int count = 1;
// int i = 0;
// int j = 0;
// while (count <= array.GetLength(0) * array.GetLength(1)) /// создание массива по спирали
// {
//   array[i, j] = count;
//   count++;
//   if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= array.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > array.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// PrintArray(array);

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($" {array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }
// // 0,0
// 0,1
// 0,2
// 0,3
// 1,3
// 2,3
// 3,3
// 3,2
// 3,1
// 3,0
// 2,0
// 1,0

// 1,1
// 1,2
// 2,2
// 2,1