//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt16(Console.ReadLine());

while (number / 100 < 1 || number / 100  > 9)
{
    Console.WriteLine("Введите трёхзначное число");
    number = Convert.ToInt16(Console.ReadLine());
}

int secondDigit = number % 100 / 10;
Console.WriteLine($"Вторая цифра вашего числа - {secondDigit}");
