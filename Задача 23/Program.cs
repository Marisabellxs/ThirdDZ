Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
for (int i = 1; i <=number; i++)
{
    int j = i*i*i;
    Console.WriteLine(j);
}