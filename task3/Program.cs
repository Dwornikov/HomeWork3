﻿Console.Clear();
System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=a;i++){
    System.Console.Write($"{i*i*i},");
}