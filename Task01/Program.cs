/*

Задача 19

Напишите программу, которая принимает на вход               // пятизначное 
число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

*/

string GetNumber(string message)
{
    string errorMessage = "Некорректное значение. ";
    string number = string.Empty;


    while (true)
    {

        Console.WriteLine(message);
        number = Console.ReadLine();
        
        if (int.TryParse(number, out int result))
        {
            if (result <= 0) //|| (number.Length != 5))
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
                break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return number;
}

bool IsPalindrom(string num)
{
    bool result = true;

    for (int i = 0; i < num.Length / 2; i++)
    {
        if (num[i] != num[num.Length - i - 1])
        {
            result = false;
            break;
        }
    }
    return result;
}





string number = GetNumber("Введите число: ");
if (IsPalindrom(number))
{
    Console.WriteLine($"Число {number} является палиндромом!");
}
else
{
    Console.WriteLine($"Число {number} - не палиндром...");
}