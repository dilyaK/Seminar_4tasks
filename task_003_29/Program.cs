// Напишите программу, которая задаёт массив из N элементов и выводит их на экран:
// N = 5, получаем массив[1,2,5,7,19];
// N = 3, получаем массив[6,1,33].



void FillArray(int[] numbers) 
Console.WriteLine($"Enter a number: ");

{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new
        index++;
    }
}

void PrintArray(int[] num) // метод для вывода массива на экран
{
    int length = num.Length;
    int pos = 0;
    while (pos < length)
    {
        Console.Write($"{num[pos]} ");
        pos++;
    }
}

int numberN = new Random().Next(1, 10); // Входные данные
Console.WriteLine($"Ввод числа {numberN}");
Console.WriteLine("Полученный массив:");

int[] array = new int[numberN]; // инициализация массива
FillArray(array);
PrintArray(array);
