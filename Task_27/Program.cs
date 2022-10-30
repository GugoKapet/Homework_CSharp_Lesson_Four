// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

bool isParsedNumber = int.TryParse(Console.ReadLine(), out int number);
if (!isParsedNumber) 
{
    Console.WriteLine("Неверно введены данные");
    return;
}

int ShowDigitsSum(int n)
{
    int latestDigit = 0;
    int digitsSum = 0;
    while (n > 0)
    {
        latestDigit = n % 10;
        digitsSum += latestDigit;
        n /= 10;
    }
    return digitsSum;
}
int result = ShowDigitsSum(number);
Console.WriteLine(result);