using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Równanie_Pitagorasa
{
    public static class Calculations
    {
        public static void compareArguments()
        {


            int a, b, c;

            Console.WriteLine("Podaj wartość a");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Podaj wartość b");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Podaj wartość c");
            int.TryParse(Console.ReadLine(), out c);
            var result = (a * a + b * b) == c * c;
            if (result == true)
            {
                Console.WriteLine(result);
                Console.WriteLine("Podane liczby tworzą trójkę pitagorejską");
            }
            else
            {
                Console.WriteLine("Podane liczby nie tworzą trójki pitagorejskiej");
            }

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }


        public static void calculateC()
        {
            Console.WriteLine("Wyliczmy równanie z niewiadomą c");
            int a, b, c;

            Console.WriteLine("Podaj wartość a");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Podaj wartość b");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Wynik niewiadomej c wynosi:");
            Console.WriteLine(Math.Sqrt(a * a + b * b));

            Console.ReadKey();          
        }

        public static void calculateA()
        {
            Console.WriteLine("Wyliczmy równanie z niewiadomą a");
            int a, b, c;

            Console.WriteLine("Podaj wartość b");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Podaj wartość c (wynik)");
            int.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Wynik niewiadomej a wynosi:");
            Console.WriteLine(Math.Sqrt(c* c - b* b));

            Console.ReadKey();
        }
 }
}
