using System;
using System.Collections.Generic;
using System.Text;

namespace CLASE3_ARBOLES.Clases.ArbolBinarioOrdenado
{
    public interface Comparador
    {
        bool igualQue(Object q);
        bool menorQue(Object q);
        bool menorigualQue(Object q);
        bool mayorigualQue(Object q);
        bool mayorQue(object q);

    }
}
