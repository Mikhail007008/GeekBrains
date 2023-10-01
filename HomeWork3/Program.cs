//Task 25

// Console.Clear();
// Console.WriteLine("Введите первое число ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int B = Convert.ToInt32(Console.ReadLine());

// bool checkValues(int num1, int num2)
// {
// 	if (num1 != 0 && num2 > 0) return true;
// 	return false;
// }

// int compute(int a, int b)
// {
// 	int i = 1,
// 		result = 1;
// 	while (i <= b)
// 	{
// 		result *= a;
// 		i++;
// 	}
// 	return result;
// }

// if (checkValues(A, B))
// {
// 	Console.WriteLine(compute(A, B));
// }

//Task 27

// Console.Clear();
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// void func (int num)
// {
// 	int result = 0;
// 	while(num != 0)
// 	{
// 		result += num % 10 ;
// 		num /= 10;
// 	}
// 	Console.WriteLine(result);
// }

// func(num);

//Task29

Console.Clear();
Console.WriteLine("Введите число, задающую длину массива ");
int size = Convert.ToInt32(Console.ReadLine());

void func (int num)
{
	int [] array = new int[num];
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine("Введите элемент массива ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	Console.WriteLine($"[{string.Join(", ", array)}]");
}

func(size);
