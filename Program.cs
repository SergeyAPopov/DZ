Console.WriteLine("Введите первое число ");
int firstD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int thirdD = Convert.ToInt32(Console.ReadLine());
int Max = firstD;
if (Max < secondD)
{
    Max = secondD;
}
if (Max < thirdD)
{
    Max = thirdD;
}

Console.WriteLine("Максимальное число это " + Max);