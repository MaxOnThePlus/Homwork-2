
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// void SecondNum (int N)
// {
//   if (N > 99 && N < 1000)
//   {
//     Console.WriteLine(N%100/10);
//   }
//   else 
//   {
//     Console.WriteLine("Число не трехзначное!");
//   }
// }
// Console.WriteLine("Введите трехзначное число:");
// int N = Convert.ToInt32(Console.ReadLine());
// SecondNum(N);

//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }
//Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Укажите, сколько цифр в числе");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// Задача 15: Напишите программу, которая принимает на вход цифру, о
// бозначающую день недели, и проверяет, является ли этот день выходным.

void WeekDay (int num)
{
    
 if (num > 0 && num < 6)
    {
    Console.WriteLine("Это не выходной день");
    }
else 
    if (num>7)
        {
            Console.WriteLine("Такого дня недели не существует");
        }
    else
    Console.WriteLine("Это выходной день");

}
Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());
WeekDay(num);