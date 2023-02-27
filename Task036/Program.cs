// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
if (!int.TryParse(Console.ReadLine(), out int size))
{
  Console.WriteLine("Не верный ввод. Введено не число");
}

int[] GetArray(int size, int minValue, int maxValue)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
  result[i] = new Random().Next(minValue, maxValue +1);
}
return result;
}
int[] array = GetArray(size, 100, 999);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

int sizeEven = array.Length;
int sumNegativ = 0;
for (int i = 1; i < sizeEven; i++)
{
  if (i%2 == 1)
  sumNegativ = sumNegativ + array[i];
}
Console.WriteLine($"Сумма нечетных позиций: {sumNegativ}");