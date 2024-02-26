// Программа, которая выводит день недели по порядковому номеру

Console.WriteLine("Введите номер дня недели:");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Понедельник");
}
else if (num == 2)                                  //else ииспользуется для остановки проверки последующих значений!
{
    Console.WriteLine("Вторник");
}
else if (num == 3)
{
    Console.WriteLine("Среда");
}
else if (num == 4)
{
    Console.WriteLine("Четверг");
}
else if (num == 5)
{
    Console.WriteLine("Пятница");
}
else if (num == 6)
{
    Console.WriteLine("Суббота");
}
else if (num == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Не обнаружено соответствующего дня недели!");
}