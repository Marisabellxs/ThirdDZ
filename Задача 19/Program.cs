Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine()!;
int length = number.Length;
if (length==5)
{
    if (number[0]==number[4] && number[1]==number[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Не пятизначное число");
}