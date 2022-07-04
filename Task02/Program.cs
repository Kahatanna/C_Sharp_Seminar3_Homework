/*

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53



*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while(true)
    {
        
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
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

double CalcDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = 0;

    result = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),3);

    return result;
}



int x1 = GetNumber("Введите X1:");
int y1 = GetNumber("Введите Y1:");
int z1 = GetNumber("Введите Z1:");
int x2 = GetNumber("Введите X2:");
int y2 = GetNumber("Введите Y2:");
int z2 = GetNumber("Введите Z2:");

Console.WriteLine($"Расстояние между точками: {CalcDistance(x1, y1, z1, x2, y2, z2)}");

