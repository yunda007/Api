using System;
using System.Collections.Generic;
using System.Text;

namespace Api
{
    class Productos
    {
        public int id_producto { get; set; }
        public string Nombre { get; set; }

        public Int32? Valor { get; set; }
        public string Codigo { get; set; }

        public string Imagen { get; set; }
    }
}
