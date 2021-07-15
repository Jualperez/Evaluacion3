using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeCargaDinamico
{
    public partial class EstacionServicio
    {
        private String codigo;
        private String nombre;
        private int numeroDePuntos;    
        private string region;
        private String direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroDePuntos { get => numeroDePuntos; set => numeroDePuntos = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string  Region { get => region; set => region = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
