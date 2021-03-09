using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASE3_ARBOLES.Clases.ArbolBinario;
using CLASE3_ARBOLES.Clases.JuegoAnimal;
using System.Collections;
using Parcial1Fercampos.Clases.BaseDatos;

namespace Parcial1Fercampos
{
    class Program
    {
        public static void preorden(Nodo r)
        {
            if (r != null)
            {

                r.visitar();
                preorden(r.subarbolIzquierdo());
                preorden(r.subarbolDerecho());
            }
        }

        public static void inorden(Nodo r)
        {
            if (r != null)
            {


                inorden(r.subarbolIzquierdo());
                r.visitar();
                inorden(r.subarbolDerecho());
            }
        }

        public static void postorden(Nodo r)
        {
            if (r != null)
            {


                postorden(r.subarbolIzquierdo());
                postorden(r.subarbolDerecho());
                r.visitar();
            }
        }



        public static void arbolBásico()
        {
            try
            {

                ArbolBinario arbol;
                Nodo a1, a2, a;
                Stack pila = new Stack();
                a1 = ArbolBinario.nuevoArbol(null, "Maria", null);
                a2 = ArbolBinario.nuevoArbol(null, "Fabrizio", null);
                a = ArbolBinario.nuevoArbol(a1, "Gaby", a2);
                pila.Push(a);//apilar

                a1 = ArbolBinario.nuevoArbol(null, "Andrea", null);
                a2 = ArbolBinario.nuevoArbol(null, "Abel", null);
                a = ArbolBinario.nuevoArbol(a1, "Monica", a2);
                pila.Push(a);//apilar

                a2 = (Nodo)pila.Pop();
                a1 = (Nodo)pila.Pop();

                a = ArbolBinario.nuevoArbol(a2, "Hector", a1);
                arbol = new ArbolBinario(a);
                int pausa;
                pausa = 0;


                Console.WriteLine("Preorden: ");
                preorden(a);

                Console.WriteLine("\nPostorden: ");
                postorden(a);

                Console.WriteLine("\nInorden: ");
                inorden(a);


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
        }

        public static void juegoAnimales()
        {
            Console.WriteLine("Juguemos a Adivinar Animales");
            Boolean otrojuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();

            do
            {

                juego.jugar(); ;
                Console.WriteLine("Desea ver la impresion de los datos en consola?\n1. SI 2. NO");
                int impresion;
                impresion = int.Parse(Console.ReadLine());
                if (impresion == 1)
                {
                    AdivinaAnimal listar = new AdivinaAnimal();
                    listar.cargadbimprimiendo();

                }
                
                    Console.WriteLine("Jugamos otra vez?");
                    otrojuego = juego.respuesta();
                Console.Clear();
                


            } while (otrojuego);
        }


        static void Main(string[] args)
        {
            juegoAnimales(); 
            //AdivinaAnimal listar = new AdivinaAnimal();
            //listar.cargadbimprimiendo();
            //Console.ReadLine();
        }
    }
}
