// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*

int[] CreateArray()
{
    Console.WriteLine("Введите количество чисел: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] newArray = new int[num];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

int[] array = CreateArray();

int Count(int[] anyArray)
{
    int count = 0;
    for (int j = 0; j < anyArray.Length; j++)
    {
        Console.Write(anyArray[j] + " ");
        if (anyArray[j] > 0) count++;
    }
    Console.WriteLine();
    return count;
}
Console.WriteLine($"Вы ввели {Count(array)} чисел больше 0");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*

double calculateY(double x, double k, double b)
{
    return (k * x) + b;
}

double findCrossingX(double k1, double b1, double k2, double b2)
{
    return (b2 - b2) / (k1 - k2);
}

Console.WriteLine("Введите коэффициент наклона первой линии, k1:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите слагаемое первой линии, b1:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэффициент наклона второй линии, k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите слагаемое второй линии, b2:");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2) 
{
    Console.WriteLine("Линии параллельны");
}
else
{
    double crossingX = findCrossingX(k1, b1, k2, b2);
    double crossingY = calculateY(crossingX, k1, b1);

    Console.WriteLine($"Точка пересечения имеет координаты {String.Format("{0:F2}", crossingX)} {String.Format("{0:F2}", crossingY)}");
}
*/ 


