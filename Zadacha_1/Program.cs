// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int AddNumbers (string numbers) // Метод ввода числа.
{
    System.Console.Write(numbers);
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;
}

int[] BuildArray (int size) // Метод создания массива.
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Convert.ToInt32(System.Console.ReadLine());
    }
    return res;
}

int MetodMoreZero (int[] BuildArray)
{
  int count = 0;
  for (int i = 0; i < BuildArray.Length; i++)
  {
    if (BuildArray[i] > 0)
    {
        count++;
    }
  }
  return count;
}

int Msize = AddNumbers ("Введите размер массива: ");
System.Console.WriteLine("Введите числа в массиве: ");
int[] numbers = BuildArray ( Msize);
System.Console.Write("Массив: " + (String.Join(" ", numbers)));
System.Console.WriteLine();
System.Console.Write("Результат: " + (String.Join(" ", MetodMoreZero(numbers))));
