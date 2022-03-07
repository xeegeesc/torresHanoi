using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        /* TO DO: Elegir tipo de Top*/
        public int Top { get; set; }
        /* public String Top { get; set; }        
         */
        /* TO DO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        */
        public List<Disco> Elementos = new List<Disco>();
        

        /* TODO: Implementar métodos */
        public Pila(int numDiscos)
        {
            int aux = numDiscos;
            this.Size = 0;
            for(int i = 0; i < numDiscos; i++)
            {
                Disco discoAux = new Disco(aux);
                Elementos.Add(discoAux);
                aux -= 1;
                this.Size++;
            }
            if (numDiscos > 0)
            {
                this.Top = Elementos.Last<Disco>().Valor;
            }
            else
            {
              this.Top = 100;
            }
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            this.Size += 1;
            this.Top = Elementos.Last<Disco>().Valor;
        }

        public Disco pop()
        {
            if (Elementos.Count > 0)
            {
                Disco aux = Elementos.Last<Disco>();
                Elementos.Remove(Elementos.Last<Disco>());
                this.Size -= 1;
                if (Elementos.Count > 0)
                {
                    this.Top = Elementos.Last<Disco>().Valor;
                }
                else
                {
                    this.Top = 100;
                }
                return aux;
            }
            else
            {
                Console.WriteLine("Error en función pop<Pila>: no hay elementos en la pila");
                return null;
            }
            
        }                
       

        public bool isEmpty()
        {
            if (Elementos.Count == 0) return true;
            else return false;
        }

    }
}
