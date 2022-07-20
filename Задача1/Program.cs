// Напишите цикл, который принимает на вход два числа (A и B) и
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
    Console.WriteLine("Введите число A: ");
    int numberA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число В: ");
    int numberB = int.Parse(Console.ReadLine());

    int exponentiation = Exponentiation(numberA, numberB);
    Console.WriteLine("Ответ:" + exponentiation);