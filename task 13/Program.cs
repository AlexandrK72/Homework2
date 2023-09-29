// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


//((num / 10 > 0) && (num / 100 > 0) && (num / 1000 == 0))

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}

int ThirdDidgit(int num)
{
    while (num > 999)
    {
        num /= 10;

    }

    return num % 10;
}

bool ExcudeNumber(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цыфры нет");
        return false;
    }

    return true;

}
int number = Prompt("Enter a number ->");

if (ExcudeNumber(number))
{
    Console.WriteLine(ThirdDidgit(number));

}