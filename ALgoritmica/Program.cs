using System;

namespace Algoritmica_C_Sharp1
{
    class Program
    {
        //static void Main(string[] args) // ex: 1
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        int volum, a, b, c;

        //        Console.Write("Introduceti prima valoare citit de la tastatura : ");
        //        a = Int32.Parse(Console.ReadLine());
        //        Console.Write("Introduceti a doua valoare citit de la tastatura : ");
        //        b = Int32.Parse(Console.ReadLine());
        //        Console.WriteLine("Introduceti ce-a dea treia valoare citita de la tastatura : ");
        //        c = Int32.Parse(Console.ReadLine());

        //        volum = a * b * c;

        //        Console.WriteLine("Volumul paralepipedului dreptunghic este egala cu : " + volum);

        //    }
        //}


        //static void Main(string[] args) // ex  : 2
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        double medie, a, b, c;

        //        Console.WriteLine("Introduceti prima cifra dorita de la tastatura : ");
        //        a = double.Parse(Console.ReadLine());
        //        Console.WriteLine("Introduceti a doua cifra dorita de la tastatura : ");
        //        b = double.Parse(Console.ReadLine());
        //        Console.WriteLine("Introduceti ultima cifra dorita de la tastatura : ");
        //        c = double.Parse(Console.ReadLine());

        //        medie = a + b + c / 3;

        //        Console.WriteLine("Media arritmetica a trei numere este : " + medie);
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        int n, UltimaCifra;

        //        Console.WriteLine("Introduceti o valoare dorita de la tastatura : ");
        //        n = Int32.Parse(Console.ReadLine());

        //        UltimaCifra = n % 10;

        //        Console.WriteLine("Ultima cifra a unui numar este : " + UltimaCifra);
        //    }
        //} // ex 3



        //static void Main(string[] args)
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        int x, Numar_Semn;

        //        Console.WriteLine("Introduceti o valoare dorita x : ");
        //        x = Int32.Parse(Console.ReadLine());

        //        Numar_Semn = x;

        //        if(Numar_Semn > 0)
        //        {
        //            Console.WriteLine("+");
        //            Console.WriteLine("pozitiv!");
        //        }
        //        else if( Numar_Semn < 0)
        //        {
        //            Console.WriteLine( "-");
        //            Console.WriteLine("negativ!");
        //        }
        //        else
        //        {
        //            Console.WriteLine("0 " + "zero!");
        //        }
        //    }
        //} // ex 4



        //static void Main(string[] args)
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        int n, m, ValoareCrescatoare1, ValoareCrescatoare2;

        //        Console.WriteLine("Introduceti o cifra de la tastatura dupa preferinta : ");
        //        n = Int32.Parse(Console.ReadLine());
        //        Console.WriteLine("Introduceti a doua cifra de la tastatura dupa preferinta : ");
        //        m = Int32.Parse(Console.ReadLine());
        //        ValoareCrescatoare1 = n;
        //        ValoareCrescatoare2 = m;
        //        if(n > m)
        //        {
        //            Console.WriteLine("Se afiseaza cele doua numere crescator!");
        //            Console.WriteLine(ValoareCrescatoare1);
        //            Console.WriteLine(ValoareCrescatoare2);
        //        }
        //        else
        //        {
        //            Console.WriteLine(ValoareCrescatoare1);
        //            Console.WriteLine(ValoareCrescatoare2);
        //        }
        //    }
        //}// 5


        //static void Main(string[] args)
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        int a, b, c, Valoare_Descrascatoare1, Valoare_Descrescatoare2, Valoare_Descrescatoare3;
        //        Console.WriteLine("Tasteaza in consola prima cifra dorita! ");
        //        Console.Write("a= ");
        //        a = Int32.Parse(Console.ReadLine());
        //        Console.WriteLine("Tasteaza a treia cifra dorita! ");
        //        Console.Write("b= ");
        //        b = Int32.Parse(Console.ReadLine());
        //        Console.WriteLine("Tasteaza utmima cifra dorita! ");
        //        Console.Write("c= ");
        //        c = Int32.Parse(Console.ReadLine());

        //        Valoare_Descrascatoare1 = a;
        //        Valoare_Descrescatoare2 = b;
        //        Valoare_Descrescatoare3 = c;

        //        if (a < b && a < c)
        //        {
        //            Console.WriteLine("Se afiseaza cele doua numere descrescatore : ");
        //            Console.WriteLine(Valoare_Descrescatoare3);
        //            Console.WriteLine(Valoare_Descrescatoare2);
        //            Console.WriteLine(Valoare_Descrascatoare1);
        //        }
        //        else
        //        {
        //            Console.WriteLine(Valoare_Descrascatoare1);
        //            Console.WriteLine(Valoare_Descrescatoare2);
        //            Console.WriteLine(Valoare_Descrescatoare3);
        //        }
        //    }
        //}//6



        //static void Main(string[] args)
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        int x, numar;
        //        Console.WriteLine("Introduceti o cifra dorita de la tastatura!");
        //        Console.Write("x= ");
        //        x = Int32.Parse(Console.ReadLine());

        //        numar = x;

        //        if (numar % 2 == 0)
        //        {
        //            Console.WriteLine("par");
        //        }
        //        else
        //        {
        //            Console.WriteLine("impar");
        //        }
        //    }
        //}// 7




        //static void Main(string[] args)
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        int x, y, Valoare_Divizibla1, Valoare_Divizibila2;
        //        Console.WriteLine("Introduceti prima valoare x : ");
        //        Console.Write("x= ");
        //        x = Int32.Parse(Console.ReadLine());
        //        Console.WriteLine("Introduceti ultima valoare y : ");
        //        Console.Write("y= ");
        //        y = Int32.Parse(Console.ReadLine());

        //        Valoare_Divizibla1 = x;
        //        Valoare_Divizibila2 = y;

        //        if(Valoare_Divizibla1 % Valoare_Divizibila2 == 0)
        //        {
        //            Console.WriteLine("divizibil! ");
        //        }
        //        else
        //        {
        //            Console.WriteLine("indivizibil! ");
        //        }
        //    }
        //}// 8


        //static void Main(string[] args)
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        int n, m, auxiliar, Prima_valoare, Ultima_valoare;
        //        Console.WriteLine("Tasteaza prima valoare n : ");
        //        Console.Write("n= ");
        //        n = Int32.Parse(Console.ReadLine());
        //        Console.WriteLine("Tasteaza a doua valoare m : ");
        //        Console.Write("m= ");
        //        m = Int32.Parse(Console.ReadLine());

        //        Prima_valoare = n;
        //        Ultima_valoare = m;

        //        auxiliar = Prima_valoare;
        //        Prima_valoare = Ultima_valoare;
        //        Ultima_valoare = auxiliar;

        //        Console.WriteLine(Prima_valoare);
        //        Console.WriteLine(Ultima_valoare);

        //    }
        //}//9


        // sau


        //static void Main(string[] args)
        //{
        //    bool begin = true;
        //    while (begin)
        //    {
        //        int n, m, auxiliar, Prima_valoare, Ultima_valoare;
        //        Console.WriteLine("Tasteaza prima valoare n : ");
        //        Console.Write("n= ");
        //        n = Int32.Parse(Console.ReadLine());
        //        Console.WriteLine("Tasteaza a doua valoare m : ");
        //        Console.Write("m= ");
        //        m = Int32.Parse(Console.ReadLine());

        //        Prima_valoare = n;
        //        Ultima_valoare = m;

        //        auxiliar = Prima_valoare;


        //        if(auxiliar != Ultima_valoare)
        //        {
        //            Console.WriteLine(Ultima_valoare);
        //            Console.WriteLine(Prima_valoare);
        //        }
        //        else
        //        {
        //            Console.WriteLine(Prima_valoare);
        //            Console.WriteLine(Ultima_valoare);
        //        }
        //    }
        //}



        //static void Main(string[] args)
        // {
        //     bool begin = true;
        //     while (begin)
        //     {
        //         int n, Cifra_Tastata, suma;
        //         Console.WriteLine("Tasteaza o valoare formata din dou cifre la alegere! ");
        //         Console.Write("Tasteaza o Cifra n = ");
        //         n = Int32.Parse(Console.ReadLine());

        //         Cifra_Tastata = n;
        //         suma = 0;

        //         while (Cifra_Tastata != 0)
        //         {
        //             suma += Cifra_Tastata % 10;
        //             Cifra_Tastata /= 10;
        //         }
        //         Console.WriteLine("Suma cifrelor lui n este : ");
        //         Console.WriteLine(suma);
        //     }
        // }// 10
    }
}