//  Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1
int [] GetArray(int length)
{
    int [] result = new int [length];
    for (int i = 0 ; i< length ; i++)
    {
        result[i]= new Random().Next(100);
    }
    return result;
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i=0; i<length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[length-1]);// пишем последний элемент без запятой на конце.
}
PrintArray(GetArray(8));
