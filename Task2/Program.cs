// Программа, принимающая два числа и проверяет является ли первое число квадратом второго

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
    Console.WriteLine("Первое число является квадратом второго числа!");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго числа!");
}