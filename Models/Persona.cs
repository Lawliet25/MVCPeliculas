using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPeliculas.Models
{
    public class Persona
    {
        public string DUI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }
}