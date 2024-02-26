// Программа, которая принимает значение чиcла N, а на выходе выдает
// все числа в промежутке от -N до N

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int negNum = num * -1;                  // Или можно int negNum = -num;

while(negNum <= num)
{
    Console.Write(negNum);              // Или можно Console.Write(negNum + " ");
    Console.Write(" ");
    negNum = negNum + 1;
}