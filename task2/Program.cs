/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
int answer = AkkermanFunction(m, n);
Console.Write(answer);

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkkermanFunction(m - 1, 1);
    if (n > 0 && m > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return AkkermanFunction(m, n);
}