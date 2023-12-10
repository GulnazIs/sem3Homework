//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int count = Convert.ToInt32(Console.ReadLine());
double [] array = new double[count];
Console.WriteLine("Введите минимальное значение диапазона");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение диапазона");
int num2 = Convert.ToInt32(Console.ReadLine());
Random r = new Random();

for (int i = 0; i < array.Length; i++) 
{
    array[i] = r.NextDouble() * (num2 - num1) + num1;   
    Console.Write("{0:0.0000}   ", array[i]);        
}
double max = array [0];
double min = array [0];
for (int i = 0; i < array.Length; i++)
{
    if (array [i] > max)
    {
        max = array [i];
    }
    if (array [i] < min)
    {
        min = array [i];
    }         
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементами массива: "+"{0:0.0000}", max - min);
