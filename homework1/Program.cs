//Задача 1
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.Write("Введите первое число : ");
//int numberA = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число : ");
//int numberB = Convert.ToInt32(Console.ReadLine());
//if (numberA>numberB)
//{
//    Console.WriteLine( numberA + " Это число больше" );
//}
//else
//{
//    Console.WriteLine(numberB + " Это число больше");
//}


//Задача 2
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


//Console.Write("Введите первое число : ");
//int numberA = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число : ");
//int numberB = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите третье число : ");
//int numberC = Convert.ToInt32(Console.ReadLine());
//if (numberA>numberB && numberA>numberC)
//{
//    Console.WriteLine(numberA + " Это число самое большое из трех");
//}
//if (numberB>numberA && numberB>numberC)
//{
//    Console.WriteLine(numberB + " Это число самое большое из трех");
//}
//if (numberC>numberA && numberC>numberB)
//{
//    Console.WriteLine(numberC + " Это число самое большое из трех");
//}

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число : ");
int numberA = Convert.ToInt32(Console.ReadLine());
int div=numberA % 2;
if (div==0)
{
    Console.Write(numberA + " Число четное");
}
else
{
    Console.Write(numberA + " Число не четное");
}