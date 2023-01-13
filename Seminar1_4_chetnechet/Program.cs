Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
  if (a%2 == 0){
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" чётное.");
  }
  if (a%2 > 0){
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" нечётное.");
  }
