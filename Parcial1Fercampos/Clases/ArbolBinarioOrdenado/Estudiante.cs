using Parcial1Fercampos.Clases.ArbolBinarioOrdenado;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLASE3_ARBOLES.Clases.ArbolBinarioOrdenado
{
    public class Estudiante : Comparador
    {
        public string estudiante;
        public string descripcion;
        public bool igualQue(object q)
        {
            //para la busqueda
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero == p2.numero;
            return true;
        }

        public bool mayorigualQue(object q)
        {
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero >= p2.numero;
            Estudiante p2 = (Estudiante)q;
            return estudiante.CompareTo(p2.estudiante) >= 0;
        }

        public bool mayorQue(object q)
        {
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero > p2.numero;
            Estudiante p2 = (Estudiante)q;
            return estudiante.CompareTo(p2.estudiante) > 0;
        }

        public bool menorigualQue(object q)
        {
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero <= p2.numero;
            Estudiante p2 = (Estudiante)q;
            return estudiante.CompareTo(p2.estudiante) <= 0;
        }

        public bool menorQue(object q)
        {
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero < p2.numero;
            Estudiante p2 = (Estudiante)q;
            return estudiante.CompareTo(p2.estudiante) < 0;
        }
    }
}
