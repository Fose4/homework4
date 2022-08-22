// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.WriteLine("Введите число A: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num2 = int.Parse(Console.ReadLine());
int Degree(int numberA, int numberB)
{
    int result = 1;
    for(int i=1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}
int degree = Degree(num1, num2);
Console.WriteLine($"{num1}, {num2} -> {degree}");