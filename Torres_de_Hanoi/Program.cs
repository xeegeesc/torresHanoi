using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduce el número de discos");
            int numDiscos = int.Parse(Console.ReadLine());
            Hanoi hanoi = new Hanoi();
            Pila INI = new Pila(numDiscos);
            Pila AUX = new Pila(0);
            Pila FIN = new Pila(0);
            
            int NumMovimientos = hanoi.iterativo(numDiscos, INI, FIN, AUX);
            Console.WriteLine("Movimientos totales: "+NumMovimientos);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
