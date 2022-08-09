// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



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


int SumOddNumbers(int[] array)
{
   int sum = 0;

   for (int i = 0; i < array.Length; i++)
   {
      if (i % 2 != 0)
      {
         sum = sum + array[i];
      }
   }
   return (sum);
}

int[] array = CreateArrayInt(6, 1, 10);
PrintArray(array);

int result = SumOddNumbers(array);

Console.Write($"=> {result} ");