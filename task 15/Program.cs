// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System.Reflection;

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;

}

int Deyweek(int num)
{
    if (num == 1) return 0;
    if (num == 2) return 0;
    if (num == 3) return 0;
    if (num == 4) return 0;
    if (num == 5) return 0;
    if (num == 6) return 1;
    if (num == 7) return 1;
    return 0;
}
bool ValidateDey(int num)
{
    if (num > 0 && num < 8)
    {
        return true;
    }

    Console.WriteLine("Ошибка. Не день недели");
    return false;

}

int number = Prompt("Введите номер дня недели->");

int dey = Deyweek(number);

if(ValidateDey(number))
if (dey == 1)
{
    Console.WriteLine($"{number} -> да");


}
else Console.WriteLine($"{number} -> нет");