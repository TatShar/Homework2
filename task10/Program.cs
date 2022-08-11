// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Console.Write("Введите трехзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int result = number%100;
//int result1 = result%10;
//int result2 = (result - result1)/10;

//if (number>99 | number <1000)
//{
 //   Console.Write(result2);
//}
//if (number<=99 | number >=1000)
//{
//    Console.Write("uncorrect number");
//}

Console.Write("input three-digit number ");
int number = Convert.ToInt32(Console.ReadLine());
String numberT = Convert.ToString(number);

if (numberT.Length <4 && numberT.Length >2){
    Console.Write("secomd number is " + numberT[1]);
}
else {
    Console.Write("uncorrect number");
}