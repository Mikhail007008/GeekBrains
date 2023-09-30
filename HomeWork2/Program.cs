// Task 10

// Console.Clear();
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num < 1000) Console.WriteLine($"Вторая цифра числа = {num / 10 % 10}");
// else Console.WriteLine("Ошибка");

// Task 13

// Console.Clear();
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// while (num > 999) num /= 10;
// if (num < 100) Console.Write("Третьей цифры нет");
// else Console.WriteLine(num % 10);

//Task 15

string func(int x)
{
    for (int i = 1; i <= x; i++)
        {
            if (x >= 1 && x <= 5) return "Нет, это не выходной";
            if (x == 6 || x == 7) return "Да, это выходной";
        }
    return "Нет такого дня недели";
}

Console.WriteLine("Введите цифру, обозначающую день недели ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(func(num));