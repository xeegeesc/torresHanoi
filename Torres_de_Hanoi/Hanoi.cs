using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            if (a.Top < b.Top)
            {
                if (a.Size > 0)
                {
                    Disco aux = a.pop();
                    b.push(aux);
                }
            }
            else
            {
                if(b.Size > 0)
                {
                    Disco aux = b.pop();
                    a.push(aux);
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            if (n%2==0)
            {
                while (ini.Size != 0 || aux.Size != 0)
                {
                    Console.WriteLine("Muevo disco de INI a AUX");
                    mover_disco(ini, aux);
                    m++;
                    Console.WriteLine("Muevo disco de INI a FIN");
                    mover_disco(ini, fin);
                    m++;
                    Console.WriteLine("Muevo disco de AUX a FIN");
                    mover_disco(aux, fin);
                    m++;
                }
            }
            else
            {
                while (ini.Size != 0 || aux.Size != 0)
                {
                    if (fin.Size == n)
                    {
                        return m;
                    }
                    Console.WriteLine("Muevo disco de INI a FIN");
                    mover_disco(ini, fin);
                    m++;
                    if(fin.Size == n)
                    {
                        return m;
                    }
                    Console.WriteLine("Muevo disco de INI a AUX");
                    mover_disco(ini, aux);
                    m++;
                    if (fin.Size == n)
                    {
                        return m;
                    }
                    Console.WriteLine("Muevo disco de AUX a FIN");
                    mover_disco(aux, fin);
                    m++;
                   
                }
            }
            return m;
        }
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;
            int movAux = 0;
            if (n == 1)
            {
                Console.WriteLine("Movimiento");
                mover_disco(ini, fin);
                m++;
            }
            else
            {
                Console.WriteLine("Recursivo1");
                movAux+=recursivo((n - 1),  ini,  aux,  fin);
                
                Console.WriteLine("Movimiento");
                mover_disco(ini, fin);
                m++;
                Console.WriteLine("Recursivo2");
                movAux+=recursivo((n - 1), aux, fin, ini);
                
            }
            movAux += m;
            return movAux;
        }
    }
}
