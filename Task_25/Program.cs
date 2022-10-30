// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.

bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
if (!isParsedA || !isParsedB) 
{
    Console.WriteLine("Неверно введены данные");
    return;
}

int Powed(int firstNumber, int secondNumber)
{
    int result = 1;
    for (int i = 0; i < secondNumber; i++)
    {
        result *= firstNumber;
    }
    return result;
}

int result = Powed(a,b);
Console.WriteLine(result);