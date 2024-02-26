// Программа, которая принимает трехзначное число
// и выводит крайнюю цифру на входе.    857 -> 7

Console.WriteLine("Ввдите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if ((num > 99) && (num < 1000))
{
    int a = num % 10;
    Console.WriteLine(a);
}
else 
{
    Console.WriteLine("Число не является трехзначным!");
}