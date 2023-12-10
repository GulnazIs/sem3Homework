//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int [] array = new int [10];
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,1001);
    Console.Write(array[i]+" ");
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
Console.Write(count);
