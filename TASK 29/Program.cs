/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, */

void FillArray(int[] collection)
{
    int length = collection.Length;

    for (int index = 0; index < length; index++)
    {
    collection [index] = new Random().Next(0, 100);
    }
}
int[] mass = new int[8];
FillArray(mass);

void PrintArray(int[] col)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(mass);
