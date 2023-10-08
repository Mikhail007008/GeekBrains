// Task 41

// Console.Clear();
// Console.WriteLine("Введите числа через пробел ");
// double[] array = Console.ReadLine().Split(", ").Select( x => double.Parse(x)).ToArray();

// void func(double[] arr)
// {
// 	double result = 0;
// 	for (double i = 0; i < arr.Length; i++)
// 		if (arr[i] > 0) result++;
// 	Console.Write(result);
// }

// func(array);

//----------------------------------------------------------------------------------------------------------------------

// Задача 43

Console.Clear();
Console.WriteLine("Введите координаты двух прямых ");
double[] array = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();

void func(double[] arr)
{
	double x = 0,
	y = 0;

	x = (arr[2] - arr[0]) / (arr[1] - arr[3]);
	y = arr[1] * ((arr[2] - arr[0]) / (arr[1] - arr[3])) + arr[0];

	Console.WriteLine($"({x}; {y})");
}

func(array);
