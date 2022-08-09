// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayDouble(int size, int min, int max)
{

   double[] arr = new double[size];
   Random rnd = new Random();

   for (int i = 0; i < arr.Length; i++)
   {
      arr[i] = Math.Round((rnd.NextDouble() * (min - max) + max), 1);

   }
   return arr;
}

void PrintArray(double[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      if (i == 0) Console.Write("[");
      if (i < array.Length - 1) Console.Write(array[i] + ", ");
      else Console.Write(array[i] + "]");
   }
   Console.Write(" ");
}

double MaxMinusMin(double[] array)
{
   double max = array[0];
   double min = array[0];

   for (int i = 0; i < array.Length; i++)
   {
      if (max < array[i])
      {
         max = array[i];
      }
      if (min > array[i])
      {
         min = array[i];
      }
   }
   double sum = max - min;
   return Math.Round((sum), 1);
}

double[] array = CreateArrayDouble(10, 1, 100);
PrintArray(array);

double result = MaxMinusMin(array);

Console.Write($"=> {result} ");