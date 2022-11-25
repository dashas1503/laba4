// See https://aka.ms/new-console-template for more information
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
int A = 0;
int B = 0;
switch (input)
{
    case 1:
        Console.WriteLine("Введите А:");
        A = Convert.ToInt16(Console.ReadLine());
        return;
    case 2:
        Console.WriteLine("Введите B:");
        B = Convert.ToInt16(Console.ReadLine());
        return;
    case 3:
        Console.WriteLine(A + B);
        return;
    case 4:
        Console.WriteLine(A-B);
        return;
    case 5:
        Console.WriteLine(A * B);
        return;
    case 6:
        Console.WriteLine(A / B);
        return;
}