
void Zadacha23 ()
{
    Console.WriteLine("Введите целое число");
    
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double cube;
    while (i <= N)
    {
        cube = Math.Pow(i,3);
        Console.WriteLine($"{i} *{i} = {cube}");
        i ++;

    }
}

Zadacha23 ();