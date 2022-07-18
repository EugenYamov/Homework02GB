//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

 Console.WriteLine("Введите число");
 string inputNumber = Console.ReadLine(); 
 int size = inputNumber.Length;

 if (size < 3)
 {
     Console.WriteLine("В вашем числе нет третьей цифры");
 }
        else
        {   int NumberIndex = 2;
            char thirdDigit = inputNumber[NumberIndex];
            Console.WriteLine($"Третья цифра вашего числа - {thirdDigit}");
        }
