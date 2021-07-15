using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeCargaDinamico.DAL
{
     public class PuntoCargaDAL
    {
        public static List<PuntoCarga> puntos = new List<PuntoCarga>();
     
        public void Add(PuntoCarga p)
        {
            puntos.Add(p);
        }
        public List<PuntoCarga> GetAll()
        {
            return puntos;
        }
        public void Remove(String codigo)
        {
            PuntoCarga punto = puntos.Find(p => p.Codigo == codigo);
            puntos.Remove(punto);
        }

        public List<PuntoCarga> GetAll(int capacidadAutos)
        {
            return puntos.FindAll(p => p.CapacidadAutos == capacidadAutos);
        }
        
        public void Update(String codigo)
        {
            PuntoCarga punto = puntos.Find(p => p.Codigo == codigo);
           
        }
        
    }
}
