// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// ((num / 10 > 0) && (num / 100 > 0) && (num / 1000 == 0))




int SecondDidgit(int num)
{

    int error = 0;
    if (num >= 100 && num <= 999)
    {

        int secNum = num % 100;

        return secNum / 10;
    }

    else
    {
        Console.WriteLine("Error. Enter a three-digit number!");
    }

return error;
}
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDidgit(number);


Console.WriteLine($"Second Digit -> {result}");