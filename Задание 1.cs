Задача 1 

//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число:");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Введите второе число:");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

if (num1 > num2)
{
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine(num2);
}



Задача 2



//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число:");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Введите второе число:");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

Console.Write("Введите третье число:");
strNum = Console.ReadLine();
int num3 = int.Parse(strNum);

int maxnum = num1;

if (num2 > maxnum)
{
    maxnum = num2;
}
if (num3 > maxnum)
{
    maxnum = num3;
}
System.Console.WriteLine(maxnum);




Задание 3



//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
///-3 -> нет
//7 -> нет

Console.Write("Введите число:");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num % 2 == 0)
{
    Console.WriteLine("Четное");
}
else 
{
    Console.WriteLine("Нечетное");
}




Задание 4




//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число:");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int num0 = 1;

while (num0<=num)
{
    if (num0 % 2 == 0)
{
    Console.WriteLine(num0);
}
num0++;
}
