Console.WriteLine("Введите первое число ");
int firstD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondD = Convert.ToInt32(Console.ReadLine());

if (firstD > secondD) 
{
    Console.WriteLine("Число " + firstD + " больше числа " + secondD);
}
else 
{
    Console.WriteLine("Число " + secondD + " больше числа " + firstD);
}