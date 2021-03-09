using CLASE3_ARBOLES.Clases.ArbolBinario;
using CLASE3_ARBOLES.Clases.BaseDatos;
using Parcial1Fercampos.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLASE3_ARBOLES.Clases.JuegoAnimal
{
    class AdivinaAnimal
    {
        private static Nodo raiz;
        public AdivinaAnimal()
        {
            raiz = new Nodo("Elefante");
        }
        public void jugar()
        {
            cargadb();
            Nodo nodo = raiz;

            while( nodo !=null)// pregunta
            {
                if(nodo.izquierda!=null)// pregunta existente
                {
                    Console.WriteLine("tu animal hace el siguiente sonido: "+nodo.valorNodo()+"?");
                    nodo = (respuesta()) ? nodo.izquierda : nodo.derecha;
                }else
                {
                    Console.WriteLine($"Ya se, es un {nodo.valorNodo()}?");
                    if(respuesta())
                    {
                       
                        Console.WriteLine("Gane!!    :)");
                        int pausa = 0;
                    }else
                    {
                        animalNuevo(nodo);
                    }  
                    nodo = null;
                    return;
                }
            }// final del ciclo while
        }// fin del metodo jugar


        public bool respuesta()
        {
            while (true)
            {
                String resp = Console.ReadLine().ToLower().Trim();
                if (resp.Equals("si")) return true;
                if (resp.Equals("no")) return false;
                Console.WriteLine("La respuesta debe ser si o no");

            }
        }// fin de la respuesta al usuario


        public void animalNuevo(Nodo nodo)
        {
            //Listardatos nuevo = new Listardatos();
            ClsConexion establecer = new ClsConexion();
            String animalNodo = (String)nodo.valorNodo();
            Console.WriteLine("Cual es el animal entonces?");
            String nuevoA = Console.ReadLine();
            Console.WriteLine($"Que pregunta con respuesta si / no puedo hacer para poder decir que es un {nuevoA}");
            string pregunta = Console.ReadLine();

            establecer.EjecutaSQLDirecto("INSERT INTO animales (animalnombre, animalsonido) VALUES ('" + nuevoA + "','" + pregunta + "');");
            //nuevo.Nuevodato(nuevoA, pregunta);

            Nodo nodo1 = new Nodo(animalNodo);
            Nodo nodo2 = new Nodo(nuevoA);
            Console.WriteLine($"Para un(a)  {nuevoA} la respuestas es si / no ?");
            
            nodo.nuevoValor(pregunta + "?");
            Console.WriteLine("Nuevo registro aguardado en la base de datos");

            if (respuesta ())
            {
                nodo.izquierda = nodo2;
                nodo.derecha = nodo1;
            }
            else
            {
                nodo.izquierda = nodo1;
                nodo.derecha = nodo2;
            }



        }
        public void cargadb()
        {
            Listardatos lista = new Listardatos();
            lista.CargarAnimalesBaseDatos();
            for (int i = 0; i < lista.animalnombre.Count; i++)
            {
                Nodo datos = new Nodo(lista.animalsonido[i]);
                datos.izquierda = new Nodo(lista.animalnombre[i]);
                datos.derecha = raiz;
                raiz = datos;
            }
        }
        public void cargadbimprimiendo()
        {
            Listardatos lista = new Listardatos();
            lista.CargarAnimalesBaseDatos();
            for (int i = 0; i < lista.animalnombre.Count; i++)
            {
                Console.WriteLine("Izquierda, Raiz");
                Console.WriteLine(lista.animalnombre[i]+","+lista.animalsonido[i]);
                Console.WriteLine("");
            }
        }
    }
}
