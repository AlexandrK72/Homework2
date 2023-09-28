// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDidgit(int num)
{

    int secNum = num % 100;
    return secNum / 10;
}
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDidgit(number);


Console.WriteLine($"Second Digit -> {result}");