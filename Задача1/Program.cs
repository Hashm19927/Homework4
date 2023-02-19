/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int a=0;
int b=0;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);

for(int i=1;i<=b;i++);
    Console.Write($"{Math.Pow(a,b)}");