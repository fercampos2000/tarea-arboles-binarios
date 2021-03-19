using CLASE3_ARBOLES.Clases.ArbolBinario;
using CLASE3_ARBOLES.Clases.ArbolBinarioOrdenado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Fercampos.Clases.ArbolBinarioOrdenado
{
    class ArbolBinarioBusqueda : ArbolBinario
    {
        public ArbolBinarioBusqueda (): base()
        {

        }

        public Nodo buscar (Object buscando)
        {
            Comparador dato;
            dato = (Comparador)buscando;
            if(raiz == null)
            {
                return null;
            }
            else
            {
                return localizar(raizArbol(), dato);
            }
        }
        protected Nodo localizar(Nodo raizSub, Comparador buscando)
        {
            if (raizSub == null)
            {
                return null;
            }
            else if (buscando.igualQue(raizSub.valorNodo()))
            {
                return raiz;
            }else if (buscando.menorQue(raizSub.valorNodo()))
            {
                return localizar(raizSub.subarbolIzquierdo(), buscando);
            }
            else
            {
                return localizar(raizSub.subarbolDerecho(), buscando);
            }
      
        }

        public void insertar(Object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = insertar(raiz, dato);
        }

        protected Nodo insertar (Nodo raizSub, Comparador dato)
        {
            if(raizSub == null)
            {
                raizSub = new Nodo(dato);
            }else if (dato.menorigualQue(raizSub.valorNodo()))
            {
                Nodo iz;
                iz = insertar(raizSub.subarbolIzquierdo(), dato);
                raizSub.ramaIzquierda(iz);
            }else if (dato.mayorQue(raizSub.valorNodo()))
            {
                Nodo dr;
                dr = insertar(raizSub.subarbolDerecho(), dato);
                raizSub.ramaDerecha(dr);
            }
            return raizSub;
        }

        public void eliminar(Object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = eliminar(raiz, dato);
        }
        protected Nodo eliminar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null)
            {
                throw new Exception("No hay nod para eliminar");
            } else if (dato.mayorQue(raizSub.valorNodo()))
            {
                Nodo iz;
                iz = eliminar(raizSub.subarbolIzquierdo(), dato);
                raizSub.ramaIzquierda(iz);
            }else if (dato.mayorQue(raizSub.valorNodo()))
            {
                Nodo dr;
                dr = eliminar(raizSub.subarbolDerecho(), dato);
                raizSub.ramaDerecha(dr);
            }
            else
            {
                Nodo q;
                q = raizSub;
                if (q.subarbolIzquierdo() == null)
                {
                    raizSub = q.subarbolDerecho();
                }

                else if (q.subarbolDerecho() == null)
                {
                    raizSub = q.subarbolIzquierdo();
                }
                else
                {
                    q = reemplazar(q);
                }
                q = null;
            }
            return raizSub;
        }

        private Nodo reemplazar(Nodo act)
        {
            Nodo a, p;
            p = act;
            a = act.subarbolIzquierdo();

            while (a.subarbolDerecho() != null)
            {
                p = a;
                p.subarbolDerecho();
            }
            act.nuevoValor(a.valorNodo());

            if (p == act)
            {
                p.ramaIzquierda(a.subarbolIzquierdo());
            }
            else
            {
                p.ramaDerecha(a.subarbolIzquierdo());
            }
            return a;
        }
    
    }
}
