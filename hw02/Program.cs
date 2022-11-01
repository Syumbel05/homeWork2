//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
Console.WriteLine("Введите число");
int x=Convert.ToInt32(Console.ReadLine());
if(x<100)
{
    Console.WriteLine("Третьего числа нет");
    }
else
{
    while (x>1000)
    {
        x/=10;
    }

int result =x%10;

Console.WriteLine("Третья цифра"+result);}


