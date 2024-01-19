using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setul_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();
            //ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex12();
            //ex13();
        }

        private static void ex13()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());

            bool esteRotita = true;
            int nrAnterior = int.MinValue;
            bool salt = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i+1}: ");
                int nrCurent = int.Parse(Console.ReadLine());

                if (nrCurent < nrAnterior)
                {
                    if (salt)
                    {
                        esteRotita = false;
                        break;
                    }
                    salt = true;
                }
                else if (salt && nrCurent > nrAnterior)
                {
                    esteRotita = false;
                    break;
                }

                nrAnterior = nrCurent;
            }

            if (esteRotita)
                Console.WriteLine("Secventa este o secventa crescatoare rotita ");
            
            else
                Console.WriteLine("Secventa nu este o secventa crescatoare rotita ");
            
        }

        private static void ex12()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele secventei:");

            int nr;
            int grupuriCons = 0;
            bool esteInGrup = false;

            for (int i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());

                if (nr != 0 && !esteInGrup)
                {
                    esteInGrup = true;
                    grupuriCons++;
                }

                if (nr == 0 && esteInGrup)
                    esteInGrup = false;
            }

            Console.WriteLine($"Numarul de grupuri consecutive diferite de zero este: {grupuriCons} ");
        }

        private static void ex11()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele secventei:");

            double sumaInv = 0;

            for (int i = 0; i < n; i++)
            {
                double nr = double.Parse(Console.ReadLine());

                sumaInv += 1 / nr;
            }

            Console.WriteLine($"Suma inverselor numerelor din secventa este: {sumaInv} ");
        }

        private static void ex10()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele secventei: ");

            int nrAnterior = int.Parse(Console.ReadLine());
            int nrCurent;
            int lgMaxCons = 1;
            int lgCurentaCons = 1;

            for (int i = 1; i < n; i++)
            {
                nrCurent = int.Parse(Console.ReadLine());

                if (nrCurent == nrAnterior)
                    lgCurentaCons++;
                else
                    lgCurentaCons = 1;

                if (lgCurentaCons > lgMaxCons)
                    lgMaxCons = lgCurentaCons;

                nrAnterior = nrCurent;
            }

            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este: {lgMaxCons} ");
        }

        private static void ex9()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele secventei: ");

            int nrAnterior = int.Parse(Console.ReadLine());
            bool monotonCresc = true;
            bool monotonDescresc = true;

            for (int i = 1; i < n; i++)
            {
                int nrCurent = int.Parse(Console.ReadLine());

                if (nrCurent < nrAnterior)
                    monotonCresc = false;                

                if (nrCurent > nrAnterior)
                    monotonDescresc = false;

                nrAnterior = nrCurent;
            }

            if (monotonCresc)
                Console.WriteLine("Secventa este monoton crescatoare ");

            else if (monotonDescresc)
                Console.WriteLine("Secventa este monoton descrescatoare ");

            else
                Console.WriteLine("Secventa NU este monotona ");

        }

        private static void ex8()
        {
            Console.Write("Introduceti n pentru a afla al n-lea numar din sirul lui Fibonacci: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
                Console.WriteLine("Cel dintai numar din sirul lui Fibonacci este: 0");
            
            else if (n == 2)
                Console.WriteLine("Al 2-lea numar din sirul lui Fibonacci este: 1");
            
            else
            {
                int f1 = 0;
                int f2 = 1;

                for (int i = 3; i <= n; i++)
                {
                    int fCurrent = f1 + f2;
                    f1 = f2;
                    f2 = fCurrent;
                }

                Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {f2} ");
            }
        }

        private static void ex7()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele secventei: ");

            int numar = int.Parse(Console.ReadLine());

            int min = numar;
            int max = numar;

            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(Console.ReadLine());

                if (numar < min)
                    min = numar;

                if (numar > max)
                    max = numar;
            }

            Console.WriteLine($"Cea mai mica valoare din secventa este: {min} ");
            Console.WriteLine($"Cea mai mare valoare din secventa este: {max} ");
        }

        private static void ex6()
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele secventei:");

            int nrAnterior = int.Parse(Console.ReadLine());
            bool OrdCresc = true;

            for (int i = 1; i < n; i++)
            {
                int nrCurent = int.Parse(Console.ReadLine());

                if (nrCurent < nrAnterior)
                {
                    OrdCresc = false;
                    break;
                }

                nrAnterior = nrCurent;
            }

            if (OrdCresc)
                Console.WriteLine("Secventa este in ordine crescatoare ");
            else
                Console.WriteLine("Secventa NU este in ordine crescatoare ");
        }

        private static void ex5()
        {
            Console.Write("Introduceti secventa de numere, separate prin spatii: ");
            string secventa = Console.ReadLine();
            int pozCurenta = 0;
            int nrCurent = 0;
            int contor = 0;
            for (int i = 0; i < secventa.Length; i++)
            {
                if (secventa[i] == ' ' || i == secventa.Length - 1)
                {
                    if (i == secventa.Length - 1)
                        nrCurent = nrCurent * 10 + (secventa[i] - '0');
                    if (nrCurent == pozCurenta)
                        contor++;
                    pozCurenta++;
                    nrCurent = 0;
                }
                else
                    nrCurent = nrCurent * 10 + (secventa[i] - '0');
            }
            Console.WriteLine($"{contor} numere au aceasi valoare ca pozitia pe care sunt ");
        }

        private static void ex4()
        {
            Console.Write("Introduceti secventa de numere, separate prin spatii: ");
            string secventa = Console.ReadLine();
            Console.WriteLine("Introduceti numarul cautat:");
            int a = int.Parse(Console.ReadLine());
            int poz = PozNumar(secventa, a);
            if (poz != -1)
                Console.WriteLine($"Numarul {a} se afla pe pozitia {poz} in secventa ");
            else
                Console.WriteLine($"Numarul {a} nu se afla in secventa ");
           
        }

        static int PozNumar(string secventa, int a)
        {
            string[] numere = secventa.Split(' ');
            for (int i = 0; i < numere.Length; i++)
            {
                int nrCurent = int.Parse(numere[i]);
                if (nrCurent == a)
                    return i;
            }
            return -1;
        }

        private static void ex3()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n= int.Parse(Console.ReadLine());
            int suma = 0;
            double produs = 1;
            for(int i=1;i<=n;i++)
            {
                suma = suma + i;
                produs = produs * i;
            }
            Console.Write($"Suma numerelor de la 1 la {n} este {suma}, iar produsul de la 1 la {n} este {produs} ");
        }

        private static void ex2()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n= int.Parse(Console.ReadLine());
            int nrNeg = 0, nrNul = 0, nrPoz = 0;
            for(int i=1; i<=n;i++)
            {
                Console.Write($"Introduceti elementul {i}: ");
                int nr= int.Parse(Console.ReadLine());
                if (nr == 0)
                    nrNul++;
                if (nr != 0 && nr > 0)
                    nrPoz++;
                if (nr != 0 && nr < 0)
                    nrNeg++;
            }
            Console.WriteLine($"Din cele {n} elemente {nrNeg} sunt negative, {nrNul} sunt zero si {nrPoz} sunt pozitive ");
        }

        private static void ex1()
        {
            Console.Write("Introduceti numarul de elemente: ");
            int n = int.Parse(Console.ReadLine());
            int nrPare = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i}: ");
                int nr = int.Parse(Console.ReadLine());
                if (nr % 2 == 0)
                    nrPare++;
            }
            Console.WriteLine($"Dintre cele {n} numere, {nrPare} sunt pare ");
        }
    }
}
