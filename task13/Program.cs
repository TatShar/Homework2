// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
string numberT = Convert.ToString(number);

if (numberT.Length >2 )
{
    Console.WriteLine ("third number is "+ numberT[2]);
}
else {
    Console.Write ("Third number is not");
}
