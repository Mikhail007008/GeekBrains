// Task №2

// Console.Clear();
// Console.Write("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b) Console.Write($"min = {b} max = {a}");
// else Console.Write($"min = {a} max = {b}");

// ------------------------------------------------

// Task №4

// Console.Clear();
// Console.WriteLine("Введите первое число ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число ");
// int num3 = Convert.ToInt32(Console.ReadLine()),
//     max = num1;

// for (int i = 0; i <= 2; i++)
// {
//     if (max < num2) max = num2;
//     else if (max < num3) max = num3;
// }

// Console.WriteLine(max);

// ------------------------------------------------

// Task №6

// Console.Clear();
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 != 0) Console.WriteLine("Нет");
// else Console.WriteLine("Да");

// ------------------------------------------------

// Task №8

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()),
    i = 1;

while (i <= num)
{
    if (i % 2 == 0) Console.Write(i + " ");
    i++;
}