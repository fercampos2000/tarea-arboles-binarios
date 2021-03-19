using CLASE3_ARBOLES.Clases.ArbolBinarioOrdenado;
using Parcial1Fercampos.Clases.ArbolBinarioOrdenado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Fercampos.Clases.clasesmain
{
    class ordenarboles
    {
        public void ordenacarnet()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            string[] carnet = { "0905-19-52517", "0905-19-62517", "0905-19-42517", "0905-19-32517" };
            carnetordena carne = new carnetordena();
            foreach (string d in carnet)
            {
                carne.carnet = d;
                carne.descrip = $"insertar carnet.{d}";
                ArBus.insertar(carne);
                carne = new carnetordena();
            }
            int pausa;
            pausa = 0;
            carne = new carnetordena();

        }
        public void ordenanombre()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            string[] nombres = { "jose", "luis", "adrian", "bartolome" };
            Estudiante es = new Estudiante();
            foreach (string d in nombres)
            {
                es.estudiante = d;
                es.descripcion = $"insertar Nombre.{d}";
                ArBus.insertar(es);
                es = new Estudiante();
            }
            int pausa;
            pausa = 0;
            es = new Estudiante();

        }
    }
}
