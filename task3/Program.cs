/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int GetNumber (string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >=0)
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число или некорректное число");
        }
    }
    return result;
}

int FunctionAkkerman(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else 
    { 
        if (n == 0) 
        {
            return FunctionAkkerman(m - 1, 1);
        }
        else 
        {
            return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
        }  
    }  
}

int mNumber = GetNumber("Введите число m: ");
int nNumber = GetNumber("Введите число n: ");
Console.Write($"Результат вычисления функции Аккермана: {FunctionAkkerman(mNumber,nNumber)} ");


