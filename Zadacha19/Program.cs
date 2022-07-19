//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void Zadacha19 ()
{
    Console.WriteLine("Введите ПЯТИЗНАЧНОЕ!!! число");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 9999 && number < 100000)
    {
        int numb1 = number / 10000;
        int numb2 = number / 1000 % 10;
        int numb4 = number / 10 % 10;
        int numb5 = number % 10;
        if (numb1 == numb5 && numb2 == numb4) Console. WriteLine($" ({number}) Это число палиндром!");
        else Console.WriteLine("Число не являяется палиндромом!");
            }
    else Console.WriteLine("Число не пятизначное");
}

Zadacha19 ();