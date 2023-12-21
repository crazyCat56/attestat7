// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
using System.Reflection.Metadata.Ecma335;

int [] arr = {1,2,3,4,5,6,7,8};
// int ReadInt(string str)
// {
//     Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }
int[] Printarrey(int[] arr, int n)
{
int[] output = new int[n];
   for (int i = 0; i < n; i++)              // незнаю я 
   {
            Printarrey(arr, n - 1);
            output[i] = arr[n-i-1];
   }
   return output;
}
Console.Write(arr);
Console.Write(Printarrey);