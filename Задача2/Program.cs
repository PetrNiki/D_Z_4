// Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int n)
  {
    int counter = Convert.ToString(n).Length;
    int adv = 0;
    int sum = 0;
    for (int i = 0; i < counter; i++)
    {
        adv = n - n % 10;
        sum = sum + (n - adv);
        n = n / 10;
    } 
    
    return sum;
  }

int sumNumber = SumNumber(n);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);