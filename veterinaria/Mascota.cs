using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace veterinaria
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Especie { get; set; }

        public Mascota(string nombre, int edad, string especie)
        {
            Nombre = nombre;
            Edad = edad;
            Especie = especie;
        }
    }
}

