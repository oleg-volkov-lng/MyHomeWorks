//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input first number: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
int max = FirstNumber;
int min = SecondNumber;
if (FirstNumber < SecondNumber)
{
    max = SecondNumber;
    min = FirstNumber;
}
Console.WriteLine($"{max} большее число,"+ $" {min} меньшее число" );
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input first number: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = SecondNumber;
if (max < FirstNumber)
{
    max = FirstNumber;
}
if (max < ThirdNumber)
{
    max = ThirdNumber; 
}
Console.WriteLine($"{max} наибольшее число");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input Number: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else 
{
    Console.WriteLine("Число нечетное");
}