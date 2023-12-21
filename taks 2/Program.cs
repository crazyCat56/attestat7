//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int ReadInt(string str)
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int PrintNambers(int M, int N)
{ 
    if(M == 0)
    {
    return  N + 1;
    }
    
    if(M > 0 && N == 0)
    {
    return PrintNambers ( M - 1,1);
    }
    
    if (M > 0 && N > 0)
    {
    return PrintNambers ( M - 1,PrintNambers(M,N-1));
    }
    else 
    {
    Console.Write("error"); 
    return Convert.ToInt32(Console.ReadLine());
    }
}
int M = ReadInt("введите число M: ");
int N = ReadInt("введите число N: ");

Console.Write($"функция Акермана равна: "+ PrintNambers(M,N));
