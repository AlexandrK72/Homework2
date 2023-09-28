// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


//((num / 10 > 0) && (num / 100 > 0) && (num / 1000 == 0))

int ThirdDidgit(int num)

{

    while (num > 999) ;
    {
        num /= 10;

    }
    return num%10;


    while (num > 100)
    {
        if (num >= 100 && num <= 999)
        {


            int secNum = num % 100;

            return secNum / 10;
        }
        else
        {
            Console.WriteLine("Error.");
        }



    }
}


Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int result = ThirdDidgit(number);


Console.WriteLine($"Second Digit -> {result}");