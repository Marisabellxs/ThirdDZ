﻿Console.WriteLine("Введите координаты Х числа А");
double Xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y числа А");
double Ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z числа A");
double Za = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Х числа B");
double Xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y числа B");
double Yb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z числа B");
double Zb = int.Parse(Console.ReadLine());
double AB = Math.Pow(Xb-Xa, 2)+Math.Pow(Yb-Ya, 2)+Math.Pow(Zb-Za, 2);
AB = Math.Sqrt(AB);
Console.WriteLine(AB);