// Напишите метод, который принимает на вход два числа (А и В) и возводит число А в целую степень В.

Console.WriteLine("Enter a number: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a power: ");
int B = Convert.ToInt32(Console.ReadLine());

int power = A;
for (int i = 0; i < B; i++)
{
    power = power * A;
}

Console.WriteLine($"The power is: {power}");
