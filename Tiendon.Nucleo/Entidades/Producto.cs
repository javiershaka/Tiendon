using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendon.Nucleo.Entidades
{
    public class Producto
    {
        public String Id { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public double Precio { get; set; }
        public String Talla { get; set; }
        public String Genero { get; set; }
        public String TipoRopa { get; set; }
        public String Marca { get; set; }
        public int stok { get; set; }
    }
}
