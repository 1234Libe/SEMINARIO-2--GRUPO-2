using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Universidad Abierta Para Adultos - UAPA.
//Seminario 2, de asignatura: Estructura de Datos y Algoritmos.
//Grupo No. 2.
//Participantes: Ana M Cepeda M, Carlos A. Guzmán H, Ángel Wander Morezux, Roderi D. Peña R, César S. Peña S, Elibeth M. Tapia C.

namespace Seminario2_ArbolBinarios_Nodos
{
    class Nodo
    {
        public Nodo(string pNombre)
        {
            this.Nombre = pNombre;
        }
        public Nodo(string pNombre, Nodo pIzq, Nodo pDer) : this(pNombre)
        {
            this.Izq = pIzq;
            this.Der = pDer;
        }
        public string Nombre { get; set; }
        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }
    }
}

