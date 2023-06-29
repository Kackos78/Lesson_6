// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] EnterNumToArray(int CountNumbers)
{
    int[] array = new int[CountNumbers];
    int j = 0;
    for (int i = 0; i < CountNumbers; i++)
    {
        System.Console.WriteLine($"Введите число номер {j + 1}");
        array[i] = Convert.ToInt32(Console.ReadLine());
        j++;
    }
    return array;
}

int HowMathPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.WriteLine("Введите количество чисел: ");
int CountNumbers = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Колличество числел > 0 = {(HowMathPositive(EnterNumToArray(CountNumbers)))}");