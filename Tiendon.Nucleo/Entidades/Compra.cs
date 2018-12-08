using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendon.Nucleo.Entidades
{
    class Compra
    {

        public String Id { get; set; }  
        public String NoTarjeta { get; set; }   
        public String FechaExpiracion { get; set; }
        public String NoSeguridad { get; set; }
        public Usuario Usuario { get; set; }
        public String Destinatario { get; set; }
        public String DireccionEnvio { get; set; }
        public IList<Producto> Producto { get; set; }
        public String Fecha { get; set; }
        public double total { get; set; }
        

    }
}
