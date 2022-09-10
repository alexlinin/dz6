/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

Console.Write("Укажите кординату первой точки оп оси X: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Укажите кординату первой точки оп оси Y: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Укажите кординату второй точки оп оси X: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Укажите кординату второй точки оп оси Y: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Координаты точки пересечения: {x} , {y}");
