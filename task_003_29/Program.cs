// Напишите программу, которая задаёт массив из N элементов и выводит их на экран:
// N = 5, получаем массив[1,2,5,7,19];
// N = 3, получаем массив[6,1,33].

Console.WriteLine("Enter a number: ");

int[] NewArray = RandomArray(Convert.ToInt32(Console.ReadLine()));

int[] RandomArray(int N)
{
    int[] array = new int[N];
    Random rand = new Random();
    for (int i = 0; i < N; i++)
    {
        array[i] = rand.Next(0, 100);
        Console.Write(array[i] + " ");
    }
    return array;
}




 