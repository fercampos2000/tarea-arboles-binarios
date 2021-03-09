using System;
using System.Collections.Generic;
using System.Text;

namespace CLASE3_ARBOLES.Clases.ArbolBinarioOrdenado
{
    interface Comparador
    {
        bool igualQue(Object q);
        bool menorigualQue(Object q);
        bool mayorQue(object q);
        bool mayorigualQue(Object q);

    }
}
