﻿//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
//645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.WriteLine("Введите трехзначное число = ");
int num = Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(num);
    
if (a.Length>2)
{
    Console.Write("Третья цифра нашего числа = " + a[2]);
}
else
{
    Console.Write("Третьей цифры нет");
} 
