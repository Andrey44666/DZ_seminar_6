// Задача 44:выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

System.Console.WriteLine("Введите число N: ");
PrintFibonacci(int.Parse(Console.ReadLine()));

int Fibonacci (int n)  // Метод для вычисления числа Фибоначчи
{
return n > 1 ? Fibonacci(n - 1) + Fibonacci(n - 2) : n;
}

int PrintFibonacci (int n)  //  Вывод последовательности Фибоначчи
{

  for (int i = 0; i < n; i++)
  {
    System.Console.WriteLine(Fibonacci(i));
  }
  return Fibonacci(n);
}