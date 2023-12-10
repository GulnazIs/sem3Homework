//Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа.
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

Console.WriteLine("Введите число от 1 до 100 000");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
int n = 1;
int count = 1;

while (num2 >= 10)
    {
        num2 /= 10;
        n *= 10;
        count++;
    }
int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    array[i] = num / n % 10;
    n /= 10;
    Console.Write(array[i]+ " ");
}

