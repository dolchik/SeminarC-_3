// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

int EntryQuandrant(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindXY (int numQuandrant)
{
    if (numQuandrant == 1) Console.WriteLine("x > 0, y > 0");
    if (numQuandrant == 2) Console.WriteLine("x < 0, y > 0");
    if (numQuandrant == 3) Console.WriteLine("x < 0, y < 0");
    if (numQuandrant == 4) Console.WriteLine("x > 0, y < 0");
}

int numQuandrant = EntryQuandrant("Введите номер квадрата: ");
//Console.WriteLine(numQuandrant);
FindXY(numQuandrant);
