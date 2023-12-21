// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
int ReadInt(string str)
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
// void error ( int M, int N)
// { 
//     if (M > N)                                 // не выводится так, не разобрался еще как норм конвертировать       
//     Console.Write("некоректный ввод"); 
//     return;  
// }

void PrintNambers(int M, int N)
{ 
    if(M > N) return;
    PrintNambers ( M + 1, N + 0);
    Console.Write( M + " ");
}
int M = ReadInt("введите число M: ");
int N = ReadInt("введите число N: ");
   if (M > N)
   {                                        
    Console.Write("некоректный ввод"); 
    Convert.ToInt32(Console.ReadLine());
    }
PrintNambers(M,N);
// Console.Write(error);

