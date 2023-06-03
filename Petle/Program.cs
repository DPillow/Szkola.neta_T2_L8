using System.Globalization;

namespace Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1. Liczby pierwsze;
            //int sprawdzam = 0;//zmienna służąca do sprawdzenia czy pojawił się dzielnik
            //for (int i = 0; i <= 100; i++) 
            //{
            //    if (i == 0 || i == 1)
            //    {
            //        Console.WriteLine($"{i} nie jest liczbą pierwszą");//0 i 1 nie są pierwszymi dlatego osobny check
            //    }
            //    else
            //    {
            //        for ( int d = 2; d < i; d++)//dzielnik 1 jest domyślny, dlatego 2.
            //        {
            //            if (i % d == 0) 
            //            {
            //                sprawdzam++;//jeżeli dzieli się przez 2 lub więcej leci++
            //            }
            //        }
            //        if (sprawdzam > 0) //jeżeli miał dzielnik inny niż 1 i swój to jest speniony warunek
            //        {
            //            Console.WriteLine($"{i} nie jest liczbą pierwszą");
            //        }
            //        else // jeżeli nie miał dzielnika innego niż 1 i swój to jest speniony warunek
            //        {
            //            Console.WriteLine($"{i} jest liczbą pierwszą");
            //        }
            //        sprawdzam = 0; //Reset zmiennej do śledzenia
            //    }
            //}

            ////2. Parzystość;
            //int i = 0;
            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} jest parzyste");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} nie jest parzyste");
            //    }
            //    i++;
            //}

            ////3. Fibonacci;
            //int F1 = 0;
            //int F2 = 0;
            //int F3 = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i == 0)
            //    { 
            //        Console.WriteLine(F2);
            //    }
            //    else if (i == 1)
            //    {
            //        F2 = 1;
            //        Console.WriteLine(F2);
            //    }
            //    else
            //    {
            //        F3 = F2 + F1;
            //        F1 = F2;
            //        F2 = F3;
            //        Console.WriteLine(F2);
            //    }
            //}

            ////4. Liczby;
            //Console.WriteLine("Podaj liczbę: ");
            //Int32.TryParse(Console.ReadLine(), out int yourNumber);
            //int b = 1;
            //for (int i = 0; i < yourNumber; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        if (b > yourNumber)
            //            break;

            //        Console.Write($"{b} ");
            //        b++;
            //    }
            //    Console.WriteLine();
            //    if (b > yourNumber)
            //        break;
            //}

            ////5. 3 potega;
            //int i = 1;
            //for (i = 1; i <= 20; i++)
            //{
            //    int cubei = i * i * i;
            //    Console.WriteLine(cubei);
            //}

            ////6. Sumy
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i == 0)
            //    {
            //    }
            //    else
            //    {
            //        float sumFractions = 0;
            //        float varA = 0;
            //        float varB = 0;
            //        for (int j = 1; j <= i; j++)
            //        {
            //            varB = 1 / (float)j;
            //            sumFractions = varA + varB;
            //            varA = sumFractions;
            //        }
            //        Console.WriteLine(Math.Round(sumFractions, 3));
            //    }
            //}

            ////7. Diament

        }
    }
}