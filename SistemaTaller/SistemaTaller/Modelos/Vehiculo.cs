﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTaller.Modelos
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public string Sucursal { get; set; }
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Tipo { get; set; }
        public ICollection<Chequeo> Chequeos { get; set; }
        public ICollection<Reparacion> Reparaciones { get; set; }
    }
}