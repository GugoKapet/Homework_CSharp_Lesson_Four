// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Задание должно быть выполнено в методах.


int[] EightNumbersMassiv()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] result = EightNumbersMassiv();
PrintArr(result);

void PrintArr(int[] array) 
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
