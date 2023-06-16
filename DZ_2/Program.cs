
// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummaRec(int num, int num2)
{
    if (num>num2) return (0);
    return num + SummaRec(num+1, num2);
}

Console.Clear();
System.Console.WriteLine("Введите целое число M ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число N ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма рекурсией всех чисел равна {SummaRec(num, num2)}");