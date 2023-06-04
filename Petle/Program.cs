using System.Globalization;

namespace Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Liczby pierwsze");
            int check = 0;//zmienna służąca do sprawdzenia czy pojawił się dzielnik
            for (int i = 0; i <= 100; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.WriteLine($"{i} nie jest liczbą pierwszą");//0 i 1 nie są pierwszymi dlatego osobny check
                }
                else
                {
                    for (int d = 2; d < i; d++)//dzielnik 1 jest domyślny, dlatego 2.
                    {
                        if (i % d == 0)
                        {
                            check++;//jeżeli dzieli się przez 2 lub więcej leci++
                        }
                    }
                    if (check > 0) //jeżeli miał dzielnik inny niż 1 i swój to jest speniony warunek
                    {
                        Console.WriteLine($"{i} nie jest liczbą pierwszą");
                    }
                    else // jeżeli nie miał dzielnika innego niż 1 i swój to jest speniony warunek
                    {
                        Console.WriteLine($"{i} jest liczbą pierwszą");
                    }
                    check = 0; //Reset zmiennej do śledzenia
                }
            }

            Console.WriteLine("");
            Console.WriteLine(".....................................................");
            Console.WriteLine("");

            Console.WriteLine("2. Parzystość");
            int v = 0;
            while (v <= 100)
            {
                if (v % 2 == 0)
                {
                    Console.WriteLine($"{v} jest parzyste");
                }
                else
                {
                    Console.WriteLine($"{v} nie jest parzyste");
                }
                v++;
            }

            Console.WriteLine("");
            Console.WriteLine(".....................................................");
            Console.WriteLine("");

            Console.WriteLine("3.Fibonacci");
            ulong F1 = 0;
            ulong F2 = 0;
            ulong F3 = 0;
            for (int u = 0; u <= 100; u++)
            {
                if (u == 0)
                {
                    Console.WriteLine(F2);
                }
                else if (u == 1)
                {
                    F2 = 1;
                    Console.WriteLine(F2);
                }
                else
                {
                    F3 = F2 + F1;
                    F1 = F2;
                    F2 = F3;
                    Console.WriteLine(F2);
                }
            }

            Console.WriteLine("");
            Console.WriteLine(".....................................................");
            Console.WriteLine("");

            Console.WriteLine("4. Liczby");
            Console.WriteLine("Podaj liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int yourNumber);
            int b = 1;
            for (int i = 0; i < yourNumber; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    if (b > yourNumber)
                        break;

                    Console.Write($"{b} ");
                    b++;
                }
                Console.WriteLine();
                if (b > yourNumber)
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine(".....................................................");
            Console.WriteLine("");

            Console.WriteLine("5. 3 potega");
            int o = 1;
            for (o = 1; o <= 20; o++)
            {
                int cubei = o * o * o;
                Console.WriteLine(cubei);
            }

            Console.WriteLine("");
            Console.WriteLine(".....................................................");
            Console.WriteLine("");

            Console.WriteLine("6. Sumy");
            for (int i = 0; i <= 20; i++)
            {
                if (i == 0)
                {
                }
                else
                {
                    float sumFractions = 0;
                    float varA = 0;
                    float varB = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        varB = 1 / (float)j;
                        sumFractions = varA + varB;
                        varA = sumFractions;
                    }
                    Console.WriteLine(Math.Round(sumFractions, 3));
                }
            }

            Console.WriteLine("");
            Console.WriteLine(".....................................................");
            Console.WriteLine("");

            Console.WriteLine("7. Diament");
            Console.WriteLine("Podaj długość przekątnej: ");
            Int32.TryParse(Console.ReadLine(), out int numberDiamond);
            for (int i = 0; i < numberDiamond; i++)
            {
                int blanks = Math.Abs(numberDiamond / 2 - i); //puste miejsca
                int textDiamond = numberDiamond - blanks * 2; //ilosc gwiazdek
                int n = 0;
                int m = 0;


                while (n < blanks)
                {
                    if (textDiamond != 0)   //Sprawdzenie żeby nie było brzydkiej linii w parzystych
                        Console.Write(" ");
                    n++;

                }
                while (m < textDiamond)
                {
                    Console.Write("x");
                    m++;

                }
                if (textDiamond != 0)   //Sprawdzenie żeby nie było brzydkiej linii w parzystych
                    Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine(".....................................................");
            Console.WriteLine("");

            Console.WriteLine("8. Odwracanie");
            Console.Write("Wpisz string: ");
            string valueToReverse = Console.ReadLine();
            string lowercase = valueToReverse.ToLower(); //wszystko zamieniamy na lowercase
            char[] arr = lowercase.ToCharArray(); //String do array
            Array.Reverse(arr); //odwracamy string
            arr[0] = char.ToUpper(arr[0]); //Wielka litera na początku
            Console.WriteLine(arr);

            Console.WriteLine("");
            Console.WriteLine(".....................................................");
            Console.WriteLine("");

            Console.WriteLine("9. Binarna");
            Console.Write("Wpisz numer do konwersji:");
            Int32.TryParse(Console.ReadLine(), out int num);
            int rest;
            string binary = string.Empty;
            while (num > 0)
            {
                rest = num % 2;
                num = num / 2;
                binary = rest.ToString() + binary;
            }
            Console.WriteLine(binary);

            Console.WriteLine("");
            Console.WriteLine(".....................................................");
            Console.WriteLine("");

            Console.WriteLine("10. Wielokrotność");
            int baseNum1 = 30;
            int baseNum2 = 250;
            int num1 = baseNum1;
            int num2 = baseNum2;
            int divider;
            int rest2;
            do
            {
                if (num1 > num2)
                {
                    num2 = num2 + baseNum2;
                    divider = num1 / num2;
                    rest2 = num1 % num2;
                }
                else if (num1 < num2)
                {
                    num1 = num1 + baseNum1;
                    divider = num1 / num2;
                    rest2 = num1 % num2;
                }
                else
                {
                    break; //Jeżeli liczby są równe
                }   
            }
            while (divider != 1 || rest2 != 0); //Pętla się powtarza do reszty równej 0 i wyniku równego 1
            Console.WriteLine($"NNW({baseNum1},{baseNum2}) = {num2}");
        }
    }
}