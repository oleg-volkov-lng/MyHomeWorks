//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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