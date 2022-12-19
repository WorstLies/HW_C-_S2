// Задача 1: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int num1 = num%100;
// int num2 = num1/10;

// Console.WriteLine(num2);

// Задача 2: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int num = new Random().Next(1, 10000);
// Console.WriteLine(num);

// string aNum = Convert.ToString(num);

// if (aNum.Length>2)
// {
//     Console.WriteLine(aNum[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Задача 3: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int num = new Random().Next(1, 8);
Console.WriteLine(num);

if ((num==6)||(num==7))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}