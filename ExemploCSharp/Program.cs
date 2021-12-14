using System;

namespace ExemploCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExemploVariaveis();
            //ExemploConstantes();
            //ExemploOperadoresAritmeticos();
            //ExemploOperadoresRelacionais();
            ExemploOperadoresLogicos();
        }

        static void ExemploVariaveis()
        {
            int numeroUm = 0;
            int numeroDois = 10;
            int numeroTres = 20;

            Console.WriteLine(numeroUm);

            numeroUm = numeroDois;
            Console.WriteLine(numeroUm);

            numeroUm = numeroTres;
            Console.WriteLine(numeroUm);

            Console.ReadKey();
        }

        static void ExemploConstantes()
        {
            const int numeroUm = 0;
            const int numeroDois = 10;
            const int numeroTres = 20;

            Console.WriteLine(numeroUm);
            Console.WriteLine(numeroDois);
            Console.WriteLine(numeroTres);

            Console.ReadKey();

            //essa linha causará um erro de compilação
            //numeroUm = numeroDois;
        }

        static void ExemploOperadoresAritmeticos()
        {
            decimal numeroUm = 10;
            decimal numeroDois = 20;

            Console.WriteLine("Soma: " + (numeroUm + numeroDois));
            Console.WriteLine("Subtração: " + (numeroUm - numeroDois));
            Console.WriteLine("Multiplicação: " + (numeroUm * numeroDois));
            Console.WriteLine("Divisão: " + (numeroUm / numeroDois));            
            Console.WriteLine("Resto: " + (numeroUm % numeroDois));

            Console.ReadKey();
        }

        static void ExemploOperadoresRelacionais()
        {
            Console.WriteLine(100 < 25);
            Console.WriteLine(150 > 100);
            Console.WriteLine(150 <= 140);
            Console.WriteLine(120 >= 120);
            Console.WriteLine(10 == 9);
            Console.WriteLine(9 != 9);

            Console.ReadKey();
        }

        static void ExemploOperadoresLogicos()
        {
            decimal numeroUm = 10;
            decimal numeroDois = 20;

            Console.WriteLine(numeroUm > 0 && numeroDois < 20);
            Console.WriteLine(numeroDois > 0 && numeroUm < 20);
            Console.WriteLine(numeroUm > 0 || numeroDois < 20);
            Console.WriteLine(numeroDois > 0 || numeroUm < 20);
            Console.WriteLine(!(numeroUm > 0 && numeroDois < 20));
            Console.WriteLine(!(numeroDois > 0 && numeroUm < 20));

            Console.ReadKey();
        }
    }
}
