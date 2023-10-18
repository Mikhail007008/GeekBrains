// Task 64.

// string func(int n)
// {
// 	if (n == 1)
// 		return "1";
// 	return $"{n}, " + func(n - 1);
// }

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(func(n));

//----------------------------------------------------------

// Task 66.

// int func(int m, int n)
// {
// 	if (m == n)
// 		return n;
// 	return func(m + 1, n) + m;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(func(m, n));

//----------------------------------------------------------

// Task 68.

int func(int m, int n)
{
	if (m == 0)
		return n + 1;
	else if (n == 0)
		return func(m - 1, 1);
	return func(m - 1, func(m, n - 1));
}

Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A(m,n) = {func(m, n)}");