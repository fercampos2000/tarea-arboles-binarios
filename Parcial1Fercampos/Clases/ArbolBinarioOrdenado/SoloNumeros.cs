using CLASE3_ARBOLES.Clases.ArbolBinarioOrdenado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Fercampos.Clases.ArbolBinarioOrdenado
{
    class SoloNumeros : Comparador
    {
        public int numero;
        public string descripcion;
        public bool igualQue(object q)
        {
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero == p2.numero;
            return true;
        }

        public bool mayorigualQue(object q)
        {
            //throw new NotImplementedException();
            SoloNumeros p2 = (SoloNumeros)q;
            return numero >= p2.numero;
        }

        public bool menorigualQue(object q)
        {
            SoloNumeros p2 = (SoloNumeros)q;
            return numero <= p2.numero;
        }

        public bool menorQue(object q)
        {
            SoloNumeros p2 = (SoloNumeros)q;
            return numero < p2.numero;
        }

        public bool mayorQue(object q)
        {
            SoloNumeros p2 = (SoloNumeros)q;
            return numero > p2.numero;
        }

        bool Comparador.mayorQue(object q)
        {
            SoloNumeros p2 = (SoloNumeros)q;
            return numero > p2.numero;
        }



        //public bool menorQue(object q)
        //{

        //}

    }
}
