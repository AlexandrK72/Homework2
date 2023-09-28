// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// ((num / 10 > 0) && (num / 100 > 0) && (num / 1000 == 0))




int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}

int SecondDidgit(int num)
{

        int secNum = num % 100;

        return secNum / 10;
       
}


int number = Prompt("Введите трехзначне число >");
if (number < 100 || number >= 1000)
{
Console.WriteLine("Ошибка. Введите трехзначное число");
return;
}


// Console.WriteLine("Enter a number");
// int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введенное число  -> {number}");
int res = SecondDidgit(number);
Console.WriteLine($"Second Digit -> {res}");