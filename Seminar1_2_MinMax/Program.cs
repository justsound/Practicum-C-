Console.WriteLine("Введите целое первое число ");
int number1 = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("Введите второе целое число ");
int number2 = Convert.ToInt32( Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Максимальное число ");
    Console.WriteLine(number1);
    Console.WriteLine("Минимальное число ");
    Console.WriteLine(number2);
}
else
{
     Console.WriteLine("Максимальное число ");
    Console.WriteLine(number2);
    Console.WriteLine("Минимальное число ");
    Console.WriteLine(number1);
};
