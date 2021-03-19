using CLASE3_ARBOLES.Clases.ArbolBinarioOrdenado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Fercampos.Clases.ArbolBinarioOrdenado
{
    public class carnetordena : Comparador
    {
        public int numero;
        public string carnet;
        public string descrip;
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
            carnetordena p2 = (carnetordena)q;
            return carnet.CompareTo(p2.carnet) >= 0;
        }

        public bool mayorQue(object q)
        {
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero > p2.numero;
            carnetordena p2 = (carnetordena)q;
            return carnet.CompareTo(p2.carnet) > 0;
        }

        public bool menorigualQue(object q)
        {
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero <= p2.numero;
            carnetordena p2 = (carnetordena)q;
            return carnet.CompareTo(p2.carnet) <= 0;
        }

        public bool menorQue(object q)
        {
            //SoloNumeros p2 = (SoloNumeros)q;
            //return numero < p2.numero;
            carnetordena p2 = (carnetordena)q;
            return carnet.CompareTo(p2.carnet) < 0;
        }
    }
}
