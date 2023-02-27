// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// Используйте NextDouble().


Console.WriteLine("Введите размер массива");
if (!int.TryParse(Console.ReadLine(), out int size))
{
  Console.WriteLine("Не верный ввод. Введено не число");
}

double[] array = new double[size];
for (int i = 0; i < size; i++)
{
  array[i] = Math.Round(new Random().NextDouble()*100, 2);
}

// Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

double maxNumber = array[0];
double minNumber = array[0];
for (int i = 0; i < size; i++)
{
  if (array[i] > maxNumber)
  {
    maxNumber = array[i];
  }
  if (array[i] < minNumber)
  {
    minNumber = array[i];
  }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: [{String.Join("; ", array)}] равна: {Math.Round(maxNumber - minNumber, 2)}");