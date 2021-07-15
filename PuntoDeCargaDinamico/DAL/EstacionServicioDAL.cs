using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeCargaDinamico.DAL
{
    public class EstacionServicioDAL
    {
        private static List<EstacionServicio> estaciones = new List<EstacionServicio>();
                   
        public void Add(EstacionServicio et)
        {
            estaciones.Add(et);
        }
        public List<EstacionServicio> GetAll()
        {
            return estaciones;
        }
        public void Remove(String codigo)
        {
            EstacionServicio estacion = estaciones.Find(et => et.Codigo == codigo);
            estaciones.Remove(estacion);
        }
        public List<EstacionServicio> GetAll(int numeroDePuntos)
        {
            return estaciones.FindAll(et => et.NumeroDePuntos == numeroDePuntos);
        }
      

    }
}
