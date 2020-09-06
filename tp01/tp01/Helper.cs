using System;
using System.Collections.Generic;
using System.Text;

namespace tp01
{
    static public class Helper
    {
        public static Tareas BusquedaPorID(List<Tareas> tareasR,List<Tareas> tareasP,int id)
        {
            foreach (var item in tareasR)
            {
                if (item.ID==id)
                {
                    return item;
                }
            }
            foreach (var item in tareasP)
            {
                if (item.ID==id)
                {
                    return item;
                }
            }
            return null;
        }
        public static Tareas BusquedaPorPalabra(List<Tareas> tareasR, List<Tareas> tareasP, string palabra)
        {
            foreach (var item in tareasR)
            {
                if (item.descripcion.Contains(palabra))
                {
                    return item;
                }
            }
            foreach (var item in tareasP)
            {
                if (item.descripcion.Contains(palabra))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
