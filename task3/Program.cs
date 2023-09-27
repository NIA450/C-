/*Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int number3 = int.Parse(Console.ReadLine());

int maxNumber = 0;
if(number1 > maxNumber) maxNumber = number1;
if(number2 > maxNumber) maxNumber = number2;
if(number3 > maxNumber) maxNumber = number3;

Console.Write(maxNumber);