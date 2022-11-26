using System;

namespace lab1ex8
{
    /*Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
    daca x este divizibil cu y.
     In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
    “indivizibil”.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acest program va verifica daca x este divizibil cu y. \n");

            Console.WriteLine("Introduceti valoarea x:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea y:");
            var y = int.Parse(Console.ReadLine());

            if (x % y == 0)
                Console.WriteLine("x divizibil cu y ");
            else
                Console.WriteLine("x indivizibil cu y");
        }
    }
}
