//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
Console.WriteLine("Введите число");
int x=Convert.ToInt32(Console.ReadLine());
int num=0;
int numA=0;
if (x<=99)Console.WriteLine("нет третьего числа");
else if (x<999) num=x%10 ;Console.WriteLine("третье число"+num);

//else if (x<99999) numA=x/100%10 ;Console.WriteLine("третье число"+numA);