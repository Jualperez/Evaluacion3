using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeCargaDinamico.DAL
{
    public class RegionDAL
    {
        private static List<Region> regiones = new List<Region>()
        {
             new Region
            {
                Nombre="Arica y Parinacota",
                Codigo="R-1"
            },
            new Region
            {
                Nombre="Tarapaca",
                Codigo="R-2"
            },
            new Region
            {
                Nombre="Antofagasta",
                Codigo="R-3"
            },
            new Region
            {
                Nombre="Coquimbo",
                Codigo="R-4"
            },
            new Region
            {
                Nombre="Valparaiso",
                Codigo="R-5"
            },
            new Region
            {
                Nombre="Metropolitana de Santiago",
                Codigo="R-6"
            },
              new Region
            {
                Nombre="Libertador General Bernardo O'Higgins",
                Codigo="R-7"
            },
                new Region
            {
                Nombre="Maule",
                Codigo="R-8"
            },
              new Region
            {
                Nombre="Ñuble",
                Codigo="R-9"
            },
              new Region
            {
                Nombre="BioBio",
                Codigo="R-10"
            },
              new Region
            {
                Nombre="Aracaunia",
                Codigo="R-11"
            },
              new Region
            {
                Nombre="Los Rios",
                Codigo="R-12"
            },
               new Region
            {
                Nombre="Los Lagos",
                Codigo="R-13"
            },
               new Region
            {
                Nombre="Aysen",
                Codigo="F-14"
            },
               new Region
            {
                Nombre="Magallanes",
                Codigo="F-15"
            },
        };

        public List<Region> GetAll()
        {
            return regiones;
        }
    }
}
