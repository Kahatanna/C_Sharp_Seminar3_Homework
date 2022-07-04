/*

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Введите корректное число.";

    while(true)
    {
        
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if (result < 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);                
            }

            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

void PrintCubes(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(Math.Pow(i,3));
        if (i < n) Console.Write(", ");
    }
}



int x = GetNumber("Введите число: ");
PrintCubes(x);