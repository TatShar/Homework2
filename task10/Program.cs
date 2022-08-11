// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number%100;
int result1 = result%10;
int result2 = (result - result1)/10;

if (number>99 | number <1000)
{
    Console.Write(result2);
}
if (number<=99 | number >=1000)
{
    Console.Write("uncorrect number");
}