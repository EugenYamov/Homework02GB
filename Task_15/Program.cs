//Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите порядковый номер дня недели 1-7");
int numberDay = Convert.ToInt16(Console.ReadLine());

while (numberDay < 1 || numberDay > 7)
{    
    Console.WriteLine("Введите порядковый номер дня недели 1-7");
    numberDay = Convert.ToInt16(Console.ReadLine());
}

if (numberDay == 6 || numberDay == 7)
{
    Console.WriteLine("Это выходной");
}

else
{
    Console.WriteLine("К сожалению, это рабочий день");
}


