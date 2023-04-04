// Задача 66: 
// Задайте значения m и n. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от m до n.
// m = 1; n = 15 -> 120
// m = 4; n = 8. -> 30

Console.WriteLine("введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2; 
    else if (n == 0) return (m * (m + 1)) / 2; 
    else if (m == n) return m; 
    else if (m < n) return n + SumOfNumbers(m, n - 1);
    else return n + SumOfNumbers(m, n + 1);
}

Console.WriteLine($"Сумма натуральных чисел в промежутке от m до n = {SumOfNumbers(m, n)}");