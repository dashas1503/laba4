﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Ввести A");
Console.WriteLine("2. Ввести B");
Console.WriteLine("3. Сложить");
Console.WriteLine("4. Вычесть");
Console.WriteLine("5. Умножить");
Console.WriteLine("6. Поделить");
int input = Convert.ToInt16(Console.ReadLine());
while(input < 1 || input > 6)
{
    Console.WriteLine("Неверный ввод. Попробуйте ещё раз.");
    input = Convert.ToInt16(Console.ReadLine());
}
switch (input)
{
    case 1:
        return;
    case 2:
        return;
    case 3:
        return;
    case 4:
        return;
    case 5:
        return;
    case 6:
        return;
}