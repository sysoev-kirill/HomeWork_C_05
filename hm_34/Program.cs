// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArrayInt(int size, int min, int max)
{

   int[] arr = new int[size];
   Random rnd = new Random();

   for (int i = 0; i < arr.Length; i++)
   {
      arr[i] = rnd.Next(min, max + 1);
   }
   return arr;
}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      if (i == 0) Console.Write("[");
      if (i < array.Length - 1) Console.Write(array[i] + ",");
      else Console.Write(array[i] + "]");
   }
   Console.Write(" ");
}


int CountOddNumbers(int[] array)
{
   int count = 0;

   foreach (int v in array)
   {
      if (v % 2 == 0)
      {
         count++;
      }
   }
   return (count);
}

int[] array = CreateArrayInt(5, 1, 999);
PrintArray(array);

int result = CountOddNumbers(array);

Console.Write($"=> {result} ");