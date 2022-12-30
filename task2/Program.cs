/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSumNumbers(int m, int n, int summ)
{
    if (m == n)
    {
        summ += n;
        return summ;
    }
    else 
    {
        summ += m;
        return GetSumNumbers(m+1,n,summ);
    }
    //return summ;
}
Console.WriteLine($"Сумма чисел равна {GetSumNumbers(1,15,0)}");
