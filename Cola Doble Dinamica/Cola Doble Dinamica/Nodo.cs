using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_Doble_Dinamica
{
    internal class Nodo
    {
        public  int Valor { get; set; }
        public Nodo Next { get; set; }
        public Nodo Prev { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Next = null;
            Prev = null;
        }
    }


}
