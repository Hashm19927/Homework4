/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


/*Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()!);
int Summ(int N)
{
    int count = Convert.ToString(N).Length;
    int ad = 0;
    int result = 0;

    for(int i=0;i<count;i++)
    {
        ad=N-N%10;
        result = result + (N-ad);
        N =N / 10;
    }
    return result;
}
int sum = Summ(N);
Console.Write($"{N}->{sum}");*/

int N=0;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
int sum=0;

while (N > 0)
{
int number = N % 10;
N = N / 10;
sum = sum + number;
}
Console.Write($"сумма равна->{sum}"); //почему не работает, если ставлю: Console.Write($"{N}->{sum}")? ставит 0 вместо N