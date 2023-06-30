// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//     a        c
// y = k1 * x + b1, 
//     b        d
// y = k2 * x + b2

// x = b2 - b1 / k1- k2

// y = k1 * b2 - k2*b1 / k1- k2

System.Console.Write("k1= ");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("k2= ");
double k2 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("b1= ");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("b2= ");
double b2 = Convert.ToDouble(Console.ReadLine());


System.Console.WriteLine($"{Math.Round((b2 - b1) /
                            (k1 - k2), 1)} ; {Math.Round((k1 * b2 - k2 * b1) /
                            (k1 - k2), 1)}");
