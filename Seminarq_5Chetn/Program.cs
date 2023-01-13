Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count < N+1)
{
    Console.WriteLine(count);
    count +=2;
}
