using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeCargaDinamico.DAL
{
   public class TipoDAL
    {
        private static List<Tipo> tipos = new List<Tipo>
        {
            new Tipo
            {
                Nombre ="Electrico",
                Codigo="E-231"
            },
             new Tipo
            {
                Nombre ="Bencina" ,
                Codigo="B-123"
            },
               new Tipo
            {
                Nombre ="Gasolina" ,
                Codigo="C-321"
            },
                new Tipo
            {
                Nombre ="Petroleo" ,
                Codigo="D-321"
            },

        };
        public List<Tipo> GetAll()
        {
            return tipos;
        }
    }
}
