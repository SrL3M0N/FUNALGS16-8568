using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace veterinaria
{
    public class Servicio
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public Servicio(string descripcion, double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}

