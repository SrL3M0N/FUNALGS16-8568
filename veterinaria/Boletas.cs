using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using veterinaria;


namespace veterinaria
{
    public class Boleta
    {
        public int Codigo { get; set; }
        public Mascota Mascota { get; set; }
        public Servicio Servicio1 { get; set; }
        public Servicio Servicio2 { get; set; }
        public double Total { get; set; }

        public Boleta(int codigo, Mascota mascota, Servicio servicio1, Servicio servicio2)
        {
            Codigo = codigo;
            Mascota = mascota;
            Servicio1 = servicio1;
            Servicio2 = servicio2;
            Total = (servicio1 != null ? servicio1.Precio : 0) + (servicio2 != null ? servicio2.Precio : 0);
        }
    }
}

