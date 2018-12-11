using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendon.Nucleo.Entidades
{
    public class Usuario
    {
        public String Id { get; set; }
        public String Correo { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Sexo { get; set; }
        public String Direccion { get; set; }
    }
}
