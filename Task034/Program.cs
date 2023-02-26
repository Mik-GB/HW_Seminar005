// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
if (!int.TryParse(Console.ReadLine(), out int size))
{
  Console.WriteLine("Не верный ввод. Введено не число");
}

// Console.WriteLine("Введите нижнюю границу массива");
// if (!int.TryParse(Console.ReadLine(), out int minValue))
// {
//   Console.WriteLine("Не верный ввод. Введено не число");
// }

// Console.WriteLine("Введите верхнюю границу массива");
// if (!int.TryParse(Console.ReadLine(), out int maxValue))
// {
//   Console.WriteLine("Не верный ввод. Введено не число");
// }

int[] GetArray(int size, int minValue, int maxValue)
{
  // if (minValue >= 100 && minValue <= 999 && maxValue >= 100 && maxValue <=999)
  // {
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue +1);
  }
  return result;
  // }
  // else
  // {
  //   Console.WriteLine("Массив состоит не из трехзначных чисел");
  // }
}
int[] array = GetArray(size, 100, 999);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

int sizeEven = array.Length;
int count = 0;
for (int i = 0; i < sizeEven; i++)
{
  if (array[i]%2 == 0)
  count ++;
}
Console.WriteLine($"Количество четных чисел: {count}");