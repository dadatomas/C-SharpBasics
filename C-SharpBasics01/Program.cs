using System;
using System.Threading; // Kvůli "Heslo + Omezený počet pokusů (5)"
using System.Numerics; //Kvůli "Fibonacciho posloupnost verze s BigInteger -> Neomezený rozsah"

//ZÁKLADNÍ PŘÍKAZY V C#, Tutorial: https://youtu.be/MSXsCDiEdLI?si=QfmldeyPzZ0DYTRo

//Console.WriteLine("Hello World!");

//Hello, <name>!

//Console.Write("Enter your name: ");
//string username = Console.ReadLine();
//Console.WriteLine("Welcome, " + username + "!");
//Console.WriteLine("Welcome, {0}!", username);
//Console.WriteLine($"Welcome, {username}!");


//Číselný vstup a formát výstupu

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = a + b;
//Console.WriteLine(c);
//Console.WriteLine("{0} + {1} = {2}", a, b, c);
//Console.WriteLine($"{a} + {b} = {c}");
//Console.WriteLine("{0} + {1} = {2}", a, b, a+b);
//Console.WriteLine($"{a} + {b} = {a+b}");


//Operace se dvěma čísly

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
//Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
//Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
//Console.WriteLine("{0} / {1} = {2}", a, b, a / (double)b); // Dělení
//Console.WriteLine("{0} / {1} = {2}", a, b, a / b); // Celočíselné Dělení
//Console.WriteLine("Zbytek po dělení: {0}", a % b); //Zbytek po dělení

//Console.WriteLine("Sin(pi/2) = {0}", Math.Sin(Math.PI / 2.0));


//Větší ze dvou hodnot

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//if (a == b)
//    Console.WriteLine("Čísla jsou stejná, {0}", a);
//else if (a > b)
//    Console.WriteLine("Větší je {0}", a);
//else
//    Console.WriteLine("Větší je {0}", b);


//Největší ze čtyř čísel

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//int d = Convert.ToInt32(Console.ReadLine());
//int max = a;
//if (b > max) max = b;
//if (c > max) max = c;
//if (d > max) max = d;
//Console.WriteLine("Největší je {0}", max);


//Prohození dvou proměnných

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("{0}, {1}", a, b);
//int p = a;
//a = b;
//b = p;
//Console.WriteLine("{0}, {1}", a, b);


//Cyklický posun vpřed

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("{0}, {1}, {2}", a, b, c);
//int p = a;
//a = b;
//b = c;
//c = p;
//Console.WriteLine("{0}, {1}, {2}", a, b, c);


//Cyklický posud vzad

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("{0}, {1}, {2}", a, b, c);
//int p = c;
//c = b;
//b = a;
//a = p;
//Console.WriteLine("{0}, {1}, {2}", a, b, c);


//Cyklus While (Výpis 1-10)

//int i = 1;
//while (i <= 10)
//{
//    Console.WriteLine(i);
//    i++; // "++" -> + 1 ( "--" -> -1 )
//    //i += 1;
//    //i = i + 1;
//}


//Cyklus For (Výpis 1-10)

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}


////Heslo

//Console.Write("Enter password: ");
//string password = Console.ReadLine();
//while (password != "supersecretpassword")
//{
//    Console.Write("Wrong password. Try again: ");
//    password = Console.ReadLine();
//}
//Console.WriteLine("You have unlocked something...");

//Heslo + Omezený počet pokusů (5)

//int t = 10;

//Console.Write("Enter password: ");
//string password = Console.ReadLine();
//int i = 0;
//bool infoShown = false;

//while (infoShown == false)
//{
//    while (password != "supersecretpassword" && i < 5)
//    {
//        Console.WriteLine("Wrong password. ({0})", i);
//        Console.Write("Try again: ");
//        i++;
//        password = Console.ReadLine();
//    }
//    if (password == "supersecretpassword")
//    {
//        Console.WriteLine("You have unlocked something...");
//        infoShown = true;
//    }
//    else
//    {
//        t = 10;
//        while (t > 0)
//        {
//            Console.Clear();
//            Console.WriteLine("You entered the wrong password too many times! You will be able to try again in {0}", t);
//            Thread.Sleep(1000);
//            t--;
//        }
//        i = 0;

//    }
//}


//Fibonacciho posloupnost

//Console.Write("How many numbers(?): ");
//int n = Convert.ToInt32(Console.ReadLine());
//ulong a1 = 0, a2 = 1; //long -> větší rozsah než int, ulong -> long bez záporných čísel (takže ještě víc kladných.)

//Console.WriteLine("{0,2}. = {1,26:N0}", 0, a1); //{0,2}. = {1,26:N0} formátovaní
//Console.WriteLine("{0,2}. = {1,26:N0}", 1, a2);

//for (int i = 2; i <= n; i++)
//{
//    ulong a3 = a1 + a2;
//    Console.WriteLine("{0,2}. = {1,26:N0}", i, a3);
//    a1 = a2;
//    a2 = a3;
//}


//Fibonacciho posloupnost verze s BigInteger -> Neomezený rozsah

Console.Write("How many numbers(?): ");
int n = Convert.ToInt32(Console.ReadLine());
BigInteger a1 = 0, a2 = 1; //BigInteger -> Neomezený rozsah

Console.WriteLine("{0,2}. = {1,26:N0}", 0, a1); //{0,2}. = {1,26:N0} formátovaní
Console.WriteLine("{0,2}. = {1,26:N0}", 1, a2);

for (int i = 2; i <= n; i++)
{
    BigInteger a3 = a1 + a2;
    Console.WriteLine("{0,2}. = {1,26:N0}", i, a3);
    a1 = a2;
    a2 = a3;
}

Console.ReadLine();

//ZÁKLADNÍ PŘÍKAZY V C#, Tutorial: https://youtu.be/MSXsCDiEdLI?si=QfmldeyPzZ0DYTRo
