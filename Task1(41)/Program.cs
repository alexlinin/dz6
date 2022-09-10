/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

Console.Write("Укажите количество чисел. которые хотите ввести: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] numberArray = new int[number];
int count = 0;
for (int i = 0; i < number; i++)
{
    Console.Write($"Введите следующее число:");
    numberArray[i] = Convert.ToInt32(Console.ReadLine());
    if (numberArray[i] > 0) count++;
}

Console.WriteLine($"Количество чисел больше 0: {count}");