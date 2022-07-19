//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void Zadacha21 ()
{
    Console.WriteLine("Введите координаты точек");
    Console.WriteLine("Введите координату ПЕРВОЙ точки по оси X");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату ПЕРВОЙ точки по оси Y");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату ПЕРВОЙ точки по оси Z");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату ВТОРОЙ точки по оси X");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату ВТОРОЙ точки по оси Y");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату ВТОРОЙ точки по оси Z");
    int z2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Координаты ПЕРВОЙ точки ({x1}, {y1}, {z1}), Координаты ВТОРОЙ точки ({x2}, {y2}, {z2}) ");

    double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    dist = Math.Round(dist,2);
    Console.WriteLine(dist);


}

Zadacha21 ();
