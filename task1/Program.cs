/* Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, 
какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности до N-го значения, 
желательно использовать рекурсию:
N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5" */

int N = Prompt("Введите число N");
Numbers(N);

void Numbers(int N, int count = 1)
{
    if(count>N) return;
    for(;count<=N; count++)
    for(int i=0; i<count; i++)
    Console.Write(count + " ");
    Numbers(N, count++);
}

int Prompt(string text)
{
    Console.WriteLine(text);
    int value = int.Parse(Console.ReadLine());
    return value;
}

