//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*

int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int SumOfChet(int [] array){
    int count = 0;
    for (int i = 0; i<array.Length; i++){
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

void Showarray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
    }

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size);
Showarray(array);
int sumchet = SumOfChet(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {sumchet}");

*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*

int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

int SumElemNeChet(int [] array){
    int summa = 0;
    for (int i = 1; i<array.Length; i+=2){
        summa += array[i];
    }
    return summa;
}

void Showarray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
    }

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size);
Showarray(array);
int sumnechet = SumElemNeChet(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumnechet}");

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*

int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(-15, 15);
    }
    return array;
}

int findMinMax(int[] array){
    int max = -999999999;
        for (int i=0; i < array.Length; i++) {
            if (array[i] > max) max = array[i];}        
        int min = 999999999;
        for (int i=0; i < array.Length; i++) {
            if (array[i] < min) min = array[i];}
        int result = max - min;
        return result;
        }

void Showarray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
    }

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size);
Showarray(array);
int raznica = findMinMax(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {raznica}");

*/


















































