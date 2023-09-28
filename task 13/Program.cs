// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDidgit(int num)
{

    int thirdnum = num * 100;
    return thirdnum % 10;
}

Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int result = ThirdDidgit(number);


Console.WriteLine($"Second Digit -> {result}");