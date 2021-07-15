using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeCargaDinamico
{
    public partial class PuntoCarga
    {
        private String codigo;
        private String nombre;
        private int capacidadAutos;
        private string tipo;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int CapacidadAutos { get => capacidadAutos; set => capacidadAutos = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
