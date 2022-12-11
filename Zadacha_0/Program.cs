Console.Clear();

int DataEntryXY (string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindQuandrant(int x, int y)
{
    if((x>0)&&(y>0)) Console.WriteLine("первый квадрат");
    if((x<0)&&(y>0)) Console.WriteLine("второй квадрат");
    if((x<0)&&(y<0)) Console.WriteLine("третий квадрат");
    if((x>0)&&(y<0)) Console.WriteLine("четвертый квадрат");
}

int x = DataEntryXY("Введите координаты x = ");
//Console.WriteLine(x);
int y = DataEntryXY("Введите координаты y = ");
//Console.WriteLine(y);

FindQuandrant(x, y);