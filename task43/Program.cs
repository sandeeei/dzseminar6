// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Введение с консоли точек определяющих прямые

Console.Write("Введите координату по оси Х для точки b1: ");
int pointB1x =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси Y для точки b1: ");
int pointB1y =Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координату по оси Х для точки k1: ");
int pointK1x =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси Y для точки k1: ");
int pointK1y =Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координату по оси Х для точки b2: ");
int pointB2x =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси Y для точки b2: ");
int pointB2y =Convert.ToInt32(Console.ReadLine());


Console.Write("Введите координату по оси Х для точки k2: ");
int pointK2x =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси Y для точки k2: ");
int pointK2y =Convert.ToInt32(Console.ReadLine());



// прямая b1, k1

int a1=pointK1y-pointB1y;
int b1=pointB1x-pointK1x;
int c1= (-pointB1x*pointK1y+pointB1y*pointK1x);

// прямая b2,k2
int a2=pointK2y-pointB2y;
int b2=pointB2x-pointK2x;
int c2= (-pointB2x*pointK2y+pointB2y*pointK2x);

int resultX=0;
int resultY=0;
//проверка паралельности 2-х прямых

if ((a1 * b2 - a2 * b1) == 0)
{
    Console.WriteLine("Прямые паралельны друг другу и не имеют точек пересечения");
}
// Проверка на совпадение двух прямых
else if (a1 * b2 == b1 * a2 && a1 * c2 == a2 * c1 && b1 * c2 == c1 * b2)
{
    Console.WriteLine("Прямые совпадают и имеют бесконечное количество точек соприкосновения");
}
// Вычисление точки пересечения 2-х прямых на плоскости
else 
{
    resultX=(b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
    resultY=(a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);
    Console.WriteLine($"\n Координата точки пересечения двух прямых по оси Х: {resultX},  \n Координата точки пересечения двух прямых по оси Y:{resultY}");
}