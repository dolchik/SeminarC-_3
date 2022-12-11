// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();

int EntryDigit (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double findSquare(int userDigit)
{
    int count = 1;
    double result = 0;
    while (count <= userDigit )
    {
        result = Math.Pow(count, 2);
        Console.Write($"{result}, ");
        count++;
    }
    return result;
}

int userDigit = EntryDigit("Введите число: ");
findSquare(userDigit);