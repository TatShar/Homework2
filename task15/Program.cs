// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("введите цифру, обозначающую день недели ");
int num = Convert.ToInt32(Console.ReadLine());
int holiday = 6;
int holiday1 = 7;

if (num == holiday || num == holiday1){
    Console.Write (num+" день недели является выходным");
} else {
    Console.Write ("Этот день не является выходным");
}

