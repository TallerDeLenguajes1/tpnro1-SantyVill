using System;
using System.Collections.Generic;

namespace tp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,id;
            Tareas BTarea = new Tareas();
            Console.WriteLine("Ingrese la cantidad de tareas a cargar.");
            n = Convert.ToInt32(Console.ReadLine());
            List<Tareas> tareas = new List<Tareas>();
            List<Tareas> tareasRealizadas = new List<Tareas>();
            CargarTareas(tareas, n);
            realizarTareas(tareas, tareasRealizadas);
            Console.WriteLine("Tareas Realizadas");
            mostrarTarea(tareasRealizadas);
            Console.WriteLine("Tareas Pendientes");
            mostrarTarea(tareas);
            Console.WriteLine("\nIngrese un id para buscar una tarear: ");
            id= Convert.ToInt32(Console.ReadLine());
            BTarea=Helper.BusquedaPorID(tareas,tareasRealizadas,id);
            Console.WriteLine("Tarea numero: " + BTarea.ID + "\nDescripcion: " + BTarea.descripcion + "\nDuracion: " + BTarea.duracion + "\n");

            Console.WriteLine("\nBuscar tarea por palabra: ");
            string palabra = Console.ReadLine();
            BTarea=Helper.BusquedaPorPalabra(tareas, tareasRealizadas,palabra);
            Console.WriteLine("Tarea numero: " + BTarea.ID + "\nDescripcion: " + BTarea.descripcion + "\nDuracion: " + BTarea.duracion + "\n");
        }

        static void CargarTareas(List<Tareas> tareas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Tareas NTarea = new Tareas();
                NTarea.ID = i + 1;
                Console.WriteLine("Ingrese la descripcion de la tarea "+(i+1)+":");
                NTarea.descripcion = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Ingrese las horas:");
                NTarea.duracion = Convert.ToInt32(Console.ReadLine());
                tareas.Add(NTarea);
            }

        }
        static void realizarTareas(List<Tareas> tareasP, List<Tareas> tareasR)
        {
            List<Tareas> auxTareas = new List<Tareas>();
            int opc;
            Console.WriteLine("\n\n");
            foreach (var item in tareasP)
            {
                Console.WriteLine("Tarea numero: "+item.ID+"\nDescripcion: "+item.descripcion+"\nDuracion: "+item.duracion+"\n");
                Console.WriteLine("Se realizo esta tarea?\nSi --> 1. \tNo-->2");
                opc = Convert.ToInt32(Console.ReadLine());
                while (opc!=1 && opc!=2)
                {
                    Console.WriteLine("Opcion no valida, ingrese otra vez.");
                    opc= Convert.ToInt32(Console.ReadLine());
                }
                if (opc==1)
                {
                    auxTareas.Add(item);
                    tareasR.Add(item);
                }
            }
            foreach (var item in auxTareas)
            {
                tareasP.Remove(item);
            }
        }
        static void mostrarTarea(List<Tareas> tareas)
        {
            foreach (var item in tareas)
            {
                Console.WriteLine("\nTarea numero: " + item.ID + "\nDescripcion: " + item.descripcion + "\nDuracion: " + item.duracion + "\n");
            }
        }
    }
}
