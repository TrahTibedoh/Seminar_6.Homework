//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int count = 0;
Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++;
}

Console.WriteLine("Количество чисел больше 0: " + count);

*/

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double k1, b1, k2, b2, x, y;

Console.WriteLine("Input number k1: ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input number b1: ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input number k2: ");
k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input number b2: ");
b2 = Convert.ToDouble(Console.ReadLine());

x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых: {x} ; {y}");
*/