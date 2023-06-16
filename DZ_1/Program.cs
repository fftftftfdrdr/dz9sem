// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int SummaRec(int num1, int num2)
{
    if (num1 == num2) return num1;
else Console.Write($"{SummaRec(num1, num2 + 1)}, ");
return num2;
}

Console.Clear();
System.Console.WriteLine("Введите целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SummaRec(num1, 1));
